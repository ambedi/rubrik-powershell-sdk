﻿using System;
using System.Linq;
using System.IO;
using System.Management.Automation;
using System.Security;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.NetSDK.Client.Models.Authentication;
using Rubrik.SecurityCloud.PowerShell.Models;
using RubrikSecurityCloud.PowerShell.Models;
using RubrikSecurityCloud.PowerShell.Private;
using Rubrik.SecurityCloud.PowerShell.Private;
using System.Xml.Linq;
using System.Management.Automation.Runspaces;
using System.Collections;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    ///  <summary>
    ///  Establishes a user session with Rubrik Security Cloud
    ///  </summary>
    ///  <description>
    ///  The Connect-Rsc Cmdlet is used to connect to the Rubrik Security Cloud (RSC) API.
    ///  RSC then returns a unique token to represent the user's credentials for subsequent calls.
    ///  The token is stored securly in a .NET object within this PowerShell session.
    ///  The recommended authentication method is a Rsc Service Account.
    ///  Service Account credentials may be provided as parameters, or stored
    ///  in an encrypted credential file, using Set-RscServiceAccountFile.
    ///  Service Account .json files (unencryped) are not supported.
    ///  </description>
    ///  <example>
    ///  Connect to Rubrik Security Cloud, using the URL, Client Id and Client Secret
    ///  <code>Connect-Rsc -Server mycompany.my.rubrik.com -ClientId xxxxxxxxx -ClientSecret xxxxxxxxx</code>
    ///  </example>
    ///  <example>
    ///  Connect to Rubrik Security Cloud, using a service account file,
    ///  stored in the default RSC credential store in the user profile
    ///  The service account file can be downloaded from the Rsc Web UI.
    ///  <code>
    ///  Set-RscServiceAccountFile -InputFilePath rubrik_service_account.json
    ///  Connect-Rsc
    ///  </code>
    ///  </example>
    ///  <example>
    ///  Connect to Rubrik Security Cloud, using a service account file,
    ///  stored in a location other than the default RSC credential store.
    ///  The service account file can be downloaded from the Rsc Web UI.
    ///  <code>
    ///  Set-RscServiceAccountFile -InputFilePath rubrik_service_account.json -OutputFilePath rubrik_service_account.xml
    ///  Connect-Rsc -ServiceAccountFile rubrik_service_account.xml
    ///  </code>
    ///  </example>
    ///  <example>
    ///  Connect to Rubrik Security Cloud, using a service account file,
    ///  stored in a location held in the OS environment variable RSC_SERVICE_ACCOUNT_FILE
    ///  The service account file can be downloaded from the Rsc Web UI.
    ///  <code>
    ///  Set-RscServiceAccountFile -InputFilePath rubrik_service_account.json -OutputFilePath $ENV:RSC_SERVICE_ACCOUNT_FILE
    ///  Connect-Rsc -FromEnv
    ///  </code>
    ///  </example>
    [Cmdlet(
        VerbsCommunications.Connect,
        "Rsc",
        DefaultParameterSetName = "IfNeeded")]
    public class Connect_Rsc : PSCmdlet
    {
        [Parameter(
            ParameterSetName = "IfNeeded",
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = false)]
        public SwitchParameter IfNeeded { get; set; }
        // ----------------------------------------------------------
        // Parameter Set "ServiceAccountFileFromEnv"
        /// <summary>
        /// Use a service account, which path is stored in an environment variable
        /// </summary>
        [Parameter(
            ParameterSetName = "ServiceAccountFileFromEnv",
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = false)]
        public SwitchParameter FromEnv { get; set; }

        // ----------------------------------------------------------
        // Parameter Set "ServiceAccountFile"
        /// <summary>
        /// Used to specify the service account file downloaded from Rubrik Security Cloud
        /// </summary>
        [Parameter(
            ParameterSetName = "ServiceAccountFile",
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = false)]
        public string ServiceAccountFile { get; set; }

        // ----------------------------------------------------------
        // Parameter Set "ServiceAccountDetails"
        /// <summary>
        /// FQDN or the Rubrik Security Cloud Instance. I.e. mycompany.my.rubrik.com
        /// This can also be found in the JSON file downloaded from RSC when creating the Service Account
        /// </summary>
        [Parameter(
            ParameterSetName = "ServiceAccountDetails",
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = false)]
        public string Server { get; set; }

        /// <summary>
        /// The Service Account ClientId.
        /// This can be found as "client_id" in the JSON file downloaded from RSC when creating the Service Account
        /// </summary>
        [Parameter(
            ParameterSetName = "ServiceAccountDetails",
            Mandatory = true,
            Position = 1,
            ValueFromPipeline = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// The Service Account ClientSecret in SecureString format.
        /// The ClientSecret can be found as "client_secret" in the JSON file downloaded from RSC when creating the Service Account
        /// Convert the JSON plain text field into a secure string with:
        /// $secret = $(Get-Content service_account_file.json | ConvertFrom-Json).client_secret | ConvertTo-SecureString -AsPlainText
        /// </summary>
        [Parameter(
            ParameterSetName = "ServiceAccountDetails",
            Mandatory = true,
            Position = 2,
            ValueFromPipeline = false)]
        public SecureString ClientSecret { get; set; }

        // ----------------------------------------------------------
        private string _server;
        private string _clientId;
        private string _clientSecret;
        private RscGraphQLClient _rbkClient;
        private bool _doConnect = true;

        protected override void BeginProcessing()
        {
            switch (this.ParameterSetName)
            {
                case "IfNeeded":
                    {
                        var psVar = SessionState.PSVariable.GetValue("RscConnectionClient");
                        var sessionClient = (RscGraphQLClient)psVar;
                        if (sessionClient == null ||
                            sessionClient.AuthenticationState != AuthenticationState.AUTHORIZED)
                        {
                            goto case "ServiceAccountFile";
                        }
                        this._rbkClient = sessionClient;
                        this._doConnect = false;
                        this.WriteVerbose("Already connected.");
                        return;
                    }
                case "ServiceAccountFileFromEnv":
                    {
                        ServiceAccountFile = Environment.GetEnvironmentVariable("RSC_SERVICE_ACCOUNT_FILE");
                        this.WriteVerbose(
                            "Retrieving service account file name from " +
                            "environment variable RSC_SERVICE_ACCOUNT_FILE=" +
                            ServiceAccountFile);
                        if (ServiceAccountFile == null)
                        {
                            var error = new ErrorRecord(
                                new ArgumentNullException("Environment variable RSC_SERVICE_ACCOUNT_FILE is not set"),
                                "ServiceAccountFileFromEnv",
                                ErrorCategory.InvalidData,
                                ServiceAccountFile);
                            ThrowTerminatingError(error);
                        }
                        goto case "ServiceAccountFile";
                    }

                case "ServiceAccountFile":
                    {
                        try
                        {
                            if (String.IsNullOrEmpty(ServiceAccountFile))
                            {
                                //ServiceAccountFile option specified, but no file given
                                //Set the default service account file now

                                string psProfilePath = this.SessionState.PSVariable.Get("PROFILE").Value.ToString();
                                string psProfileDir = Path.GetDirectoryName(psProfilePath);
                                ServiceAccountFile = Path.Combine(psProfileDir,
                                                                  "rubrik-powershell-sdk",
                                                                  "rsc_service_account_default.xml");

                            }

                            using (Runspace runspace = RunspaceFactory.CreateRunspace())
                            {
                                runspace.Open();

                                using (System.Management.Automation.PowerShell powerShell = System.Management.Automation.PowerShell.Create())
                                {
                                    powerShell.Runspace = runspace;

                                    powerShell.AddCommand("Import-CliXml").AddParameter("Path", ServiceAccountFile);
                                    var saContent = powerShell.Invoke();

                                    foreach(DictionaryEntry entry in saContent[0].BaseObject as Hashtable)
                                    {
                                        switch (entry.Key)
                                        {
                                            case "client_id":
                                                PSCredential clientIdCred = new PSCredential("clientId", (SecureString)entry.Value);
                                                this._clientId = clientIdCred.GetNetworkCredential().Password;
                                                break;

                                            case "client_secret":
                                                PSCredential clientSecretCred = new PSCredential("clientSecret", (SecureString)entry.Value);
                                                this._clientSecret = clientSecretCred.GetNetworkCredential().Password;
                                                break;

                                            case "access_token_uri":
                                                this._server = entry.Value.ToString();
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            if (ex.HResult == -2146233087)
                            {
                                var error = new ErrorRecord(ex,
                                    "InvalidServiceAccountFileFormat",
                                    ErrorCategory.InvalidData,
                                    ServiceAccountFile);
                                Console.WriteLine("Connect-Rsc does not support unencrypted JSON files " +
                                    "for service accounts. " +
                                    "Please use the \'Set-RscServiceAccountFile\' cmdlet " +
                                    "to create a valid credential file.");
                                ThrowTerminatingError(error);
                            }
                            else
                            {
                                var error = new ErrorRecord(
                                        ex,
                                        "CannotOpenOrParseServiceAccountFile",
                                        ErrorCategory.InvalidData,
                                        ServiceAccountFile);
                                ThrowTerminatingError(error);
                            }

                        }
                        break;
                    }
                case "ServiceAccountDetails":
                    {
                        Console.WriteLine("ServiceAccountDetails");
                        PSCredential clientSecret = new(ClientId, ClientSecret);
                        this._server = Server;
                        this._clientId = ClientId;
                        this._clientSecret =
                            clientSecret.GetNetworkCredential().Password;
                        break;
                    }
            }

            this._rbkClient = new RscGraphQLClient(
                this._clientId,
                this._clientSecret,
                this._server);
        }

        protected override void ProcessRecord()
        {
            if (this._doConnect)
            {
                this._Connect();
            }
        }

        protected void _Connect()
        {
            try
            {
                var authStateBefore = this._rbkClient.AuthenticationState;
                var psVarBefore = SessionState.PSVariable.Get("RscConnectionClient");
                this.WriteDebug($"Before Auth: AuthState={authStateBefore}, PSVar={psVarBefore}");
                Task authTask = this._rbkClient.AuthAsync();
                authTask.Wait();

                if (this._rbkClient.AuthenticationState ==
                AuthenticationState.AUTHORIZED)
                {
                    SessionState.PSVariable.Set(
                        new PSVariable(
                            "RscConnectionClient",
                            this._rbkClient,
                            ScopedItemOptions.AllScope));

                    RscSessionInfo sessionInfo = new RscSessionInfo(
                        this._rbkClient, new RscLogger(this));

                    WriteObject(sessionInfo.GetSessionInfo());
                }

                this.WriteVerbose($"Authentication Status: " +
                        $"{ this._rbkClient.AuthenticationState.ToString()}");
            }
            catch (Exception ex)
            {
                var error = new ErrorRecord(
                    ex,
                    "UnableToAuthenticateToRubrikSecurityCloud",
                    ErrorCategory.AuthenticationError,
                    null);
                ThrowTerminatingError(error);
            }
        }
    }
}