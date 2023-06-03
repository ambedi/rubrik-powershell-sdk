// Invoke-RscMutateVsphere.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using RubrikSecurityCloud.Schema.Utils;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateVsphere",
        DefaultParameterSetName = "deleteLiveMount")
    ]
    public class Invoke_RscMutateVsphere : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // OnDemandSnapshot parameter set
        //
        // GraphQL operation: vsphereOnDemandSnapshot(input: VsphereOnDemandSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "OnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vsphereOnDemandSnapshot(input: VsphereOnDemandSnapshotInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter OnDemandSnapshot { get; set; }

        [Parameter(
            ParameterSetName = "OnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Input for V1CreateOnDemandBackup.
                GraphQL argument input: VsphereOnDemandSnapshotInput!
                "
        )]
        public VsphereOnDemandSnapshotInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // BulkOnDemandSnapshot parameter set
        //
        // GraphQL operation: vsphereBulkOnDemandSnapshot(input: VsphereBulkOnDemandSnapshotInput!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "BulkOnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Trigger a bulk on demand snapshot.
                GraphQL operation: vsphereBulkOnDemandSnapshot(input: VsphereBulkOnDemandSnapshotInput!):BatchAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter BulkOnDemandSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // deleteLiveMount parameter set
        //
        // GraphQL operation: deleteVsphereLiveMount(input: DeleteVsphereLiveMountInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "deleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Delete a Live Mount VM

Supported in v5.0+
Create a request to delete a Live Mount virtual machine.
                GraphQL operation: deleteVsphereLiveMount(input: DeleteVsphereLiveMountInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter deleteLiveMount { get; set; }

        
        // -------------------------------------------------------------------
        // ExportSnapshotToStandaloneHostV2 parameter set
        //
        // GraphQL operation: vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHostV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Export snapshot of a virtual machine to standalone ESXi server.
                GraphQL operation: vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotToStandaloneHostV2 { get; set; }

        
        // -------------------------------------------------------------------
        // ExportSnapshotToStandaloneHost parameter set
        //
        // GraphQL operation: vsphereExportSnapshotToStandaloneHost(,   snapshotFid: UUID!,   vmName: String,   disableNetwork: Boolean,   removeNetworkDevices: Boolean,   powerOn: Boolean,   keepMacAddresses: Boolean,   hostIpAddress: String!,   datastoreName: String!,   hostUsername: String!,   hostPassword: String!, ):VsphereAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vsphereExportSnapshotToStandaloneHost(,   snapshotFid: UUID!,   vmName: String,   disableNetwork: Boolean,   removeNetworkDevices: Boolean,   powerOn: Boolean,   keepMacAddresses: Boolean,   hostIpAddress: String!,   datastoreName: String!,   hostUsername: String!,   hostPassword: String!, ):VsphereAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotToStandaloneHost { get; set; }

        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Snapshot forever UUID in Rubrik Security Cloud.
                GraphQL argument snapshotFid: UUID!
                "
        )]
        public System.String? SnapshotFid { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument vmName: String
                "
        )]
        public System.String? VmName { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument disableNetwork: Boolean
                "
        )]
        public System.Boolean? DisableNetwork { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument removeNetworkDevices: Boolean
                "
        )]
        public System.Boolean? RemoveNetworkDevices { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument powerOn: Boolean
                "
        )]
        public System.Boolean? PowerOn { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument keepMacAddresses: Boolean
                "
        )]
        public System.Boolean? KeepMacAddresses { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument hostIpAddress: String!
                "
        )]
        public System.String? HostIpAddress { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument datastoreName: String!
                "
        )]
        public System.String? DatastoreName { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument hostUsername: String!
                "
        )]
        public System.String? HostUsername { get; set; }
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument hostPassword: String!
                "
        )]
        public System.String? HostPassword { get; set; }
        
        // -------------------------------------------------------------------
        // downloadVirtualMachineFile parameter set
        //
        // GraphQL operation: downloadVsphereVirtualMachineFiles(input: DownloadVsphereVirtualMachineFilesInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "downloadVirtualMachineFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Download Virtual Machine files from a snapshot

Supported in v9.0
Start an asynchronous job to download multiple Virtual Machine files, such as .vmdk, .vmx, and .nvram files, from the specified Virtual Machine snapshot.
                GraphQL operation: downloadVsphereVirtualMachineFiles(input: DownloadVsphereVirtualMachineFilesInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter downloadVirtualMachineFile { get; set; }

        
        // -------------------------------------------------------------------
        // createAdvancedTag parameter set
        //
        // GraphQL operation: createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!):CreateVsphereAdvancedTagReply!
        //
        [Parameter(
            ParameterSetName = "createAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Create a multi-tag filter for vSphere tags

Supported in v7.0+
Create a filter consisting of vSphere tags joined with logical operators.
                GraphQL operation: createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!):CreateVsphereAdvancedTagReply!
                ",
            Position = 0
        )]
        public SwitchParameter createAdvancedTag { get; set; }

        
        // -------------------------------------------------------------------
        // deleteAdvancedTag parameter set
        //
        // GraphQL operation: deleteVsphereAdvancedTag(input: DeleteVsphereAdvancedTagInput!):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "deleteAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Remove the multi-tag filter

Supported in v7.0+
Remove the multi-tag filter.
                GraphQL operation: deleteVsphereAdvancedTag(input: DeleteVsphereAdvancedTagInput!):RequestSuccess!
                ",
            Position = 0
        )]
        public SwitchParameter deleteAdvancedTag { get; set; }

        
        // -------------------------------------------------------------------
        // updateAdvancedTag parameter set
        //
        // GraphQL operation: updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!):UpdateVsphereAdvancedTagReply!
        //
        [Parameter(
            ParameterSetName = "updateAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Update the multi-tag filter

Supported in v7.0+
Updates the name, condition, and description of the specified multi-tag filter.
                GraphQL operation: updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!):UpdateVsphereAdvancedTagReply!
                ",
            Position = 0
        )]
        public SwitchParameter updateAdvancedTag { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "OnDemandSnapshot":
                        this.ProcessRecord_OnDemandSnapshot();
                        break;
                    case "BulkOnDemandSnapshot":
                        this.ProcessRecord_BulkOnDemandSnapshot();
                        break;
                    case "deleteLiveMount":
                        this.ProcessRecord_deleteLiveMount();
                        break;
                    case "ExportSnapshotToStandaloneHostV2":
                        this.ProcessRecord_ExportSnapshotToStandaloneHostV2();
                        break;
                    case "ExportSnapshotToStandaloneHost":
                        this.ProcessRecord_ExportSnapshotToStandaloneHost();
                        break;
                    case "downloadVirtualMachineFile":
                        this.ProcessRecord_downloadVirtualMachineFile();
                        break;
                    case "createAdvancedTag":
                        this.ProcessRecord_createAdvancedTag();
                        break;
                    case "deleteAdvancedTag":
                        this.ProcessRecord_deleteAdvancedTag();
                        break;
                    case "updateAdvancedTag":
                        this.ProcessRecord_updateAdvancedTag();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscMutateVsphere",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // vsphereOnDemandSnapshot.
        protected void ProcessRecord_OnDemandSnapshot()
        {
            this._logger.name += " -OnDemandSnapshot";
            // Invoke graphql operation vsphereOnDemandSnapshot
            InvokeMutationVsphereOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereBulkOnDemandSnapshot.
        protected void ProcessRecord_BulkOnDemandSnapshot()
        {
            this._logger.name += " -BulkOnDemandSnapshot";
            // Invoke graphql operation vsphereBulkOnDemandSnapshot
            InvokeMutationVsphereBulkOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVsphereLiveMount.
        protected void ProcessRecord_deleteLiveMount()
        {
            this._logger.name += " -deleteLiveMount";
            // Invoke graphql operation deleteVsphereLiveMount
            InvokeMutationDeleteVsphereLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereExportSnapshotToStandaloneHostV2.
        protected void ProcessRecord_ExportSnapshotToStandaloneHostV2()
        {
            this._logger.name += " -ExportSnapshotToStandaloneHostV2";
            // Invoke graphql operation vsphereExportSnapshotToStandaloneHostV2
            InvokeMutationVsphereExportSnapshotToStandaloneHostV2();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereExportSnapshotToStandaloneHost.
        protected void ProcessRecord_ExportSnapshotToStandaloneHost()
        {
            this._logger.name += " -ExportSnapshotToStandaloneHost";
            // Invoke graphql operation vsphereExportSnapshotToStandaloneHost
            InvokeMutationVsphereExportSnapshotToStandaloneHost();
        }

        // This parameter set invokes a single graphql operation:
        // downloadVsphereVirtualMachineFiles.
        protected void ProcessRecord_downloadVirtualMachineFile()
        {
            this._logger.name += " -downloadVirtualMachineFile";
            // Invoke graphql operation downloadVsphereVirtualMachineFiles
            InvokeMutationDownloadVsphereVirtualMachineFiles();
        }

        // This parameter set invokes a single graphql operation:
        // createVsphereAdvancedTag.
        protected void ProcessRecord_createAdvancedTag()
        {
            this._logger.name += " -createAdvancedTag";
            // Invoke graphql operation createVsphereAdvancedTag
            InvokeMutationCreateVsphereAdvancedTag();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVsphereAdvancedTag.
        protected void ProcessRecord_deleteAdvancedTag()
        {
            this._logger.name += " -deleteAdvancedTag";
            // Invoke graphql operation deleteVsphereAdvancedTag
            InvokeMutationDeleteVsphereAdvancedTag();
        }

        // This parameter set invokes a single graphql operation:
        // updateVsphereAdvancedTag.
        protected void ProcessRecord_updateAdvancedTag()
        {
            this._logger.name += " -updateAdvancedTag";
            // Invoke graphql operation updateVsphereAdvancedTag
            InvokeMutationUpdateVsphereAdvancedTag();
        }


        // Invoke GraphQL Mutation:
        // vsphereOnDemandSnapshot(input: VsphereOnDemandSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationVsphereOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereOnDemandSnapshotInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereOnDemandSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereOnDemandSnapshot");
            var parameters = "($input: VsphereOnDemandSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereOnDemandSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereOnDemandSnapshot",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereBulkOnDemandSnapshot(input: VsphereBulkOnDemandSnapshotInput!): BatchAsyncRequestStatus!
        protected void InvokeMutationVsphereBulkOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereBulkOnDemandSnapshotInput!"),
            };
            BatchAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereBulkOnDemandSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereBulkOnDemandSnapshot");
            var parameters = "($input: VsphereBulkOnDemandSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereBulkOnDemandSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereBulkOnDemandSnapshot",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteVsphereLiveMount(input: DeleteVsphereLiveMountInput!): AsyncRequestStatus!
        protected void InvokeMutationDeleteVsphereLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteVsphereLiveMountInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteVsphereLiveMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteVsphereLiveMount");
            var parameters = "($input: DeleteVsphereLiveMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteVsphereLiveMount" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteVsphereLiveMount",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!): AsyncRequestStatus!
        protected void InvokeMutationVsphereExportSnapshotToStandaloneHostV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereExportSnapshotToStandaloneHostV2Input!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereExportSnapshotToStandaloneHostV2(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereExportSnapshotToStandaloneHostV2");
            var parameters = "($input: VsphereExportSnapshotToStandaloneHostV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereExportSnapshotToStandaloneHostV2" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereExportSnapshotToStandaloneHostV2",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereExportSnapshotToStandaloneHost(
        //     snapshotFid: UUID!
        //     vmName: String
        //     disableNetwork: Boolean
        //     removeNetworkDevices: Boolean
        //     powerOn: Boolean
        //     keepMacAddresses: Boolean
        //     hostIpAddress: String!
        //     datastoreName: String!
        //     hostUsername: String!
        //     hostPassword: String!
        //   ): VsphereAsyncRequestStatus!
        protected void InvokeMutationVsphereExportSnapshotToStandaloneHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("vmName", "String"),
                Tuple.Create("disableNetwork", "Boolean"),
                Tuple.Create("removeNetworkDevices", "Boolean"),
                Tuple.Create("powerOn", "Boolean"),
                Tuple.Create("keepMacAddresses", "Boolean"),
                Tuple.Create("hostIpAddress", "String!"),
                Tuple.Create("datastoreName", "String!"),
                Tuple.Create("hostUsername", "String!"),
                Tuple.Create("hostPassword", "String!"),
            };
            VsphereAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereExportSnapshotToStandaloneHost(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereExportSnapshotToStandaloneHost");
            var parameters = "($snapshotFid: UUID!,$vmName: String,$disableNetwork: Boolean,$removeNetworkDevices: Boolean,$powerOn: Boolean,$keepMacAddresses: Boolean,$hostIpAddress: String!,$datastoreName: String!,$hostUsername: String!,$hostPassword: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereExportSnapshotToStandaloneHost" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereExportSnapshotToStandaloneHost",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereAsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // downloadVsphereVirtualMachineFiles(input: DownloadVsphereVirtualMachineFilesInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadVsphereVirtualMachineFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadVsphereVirtualMachineFilesInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DownloadVsphereVirtualMachineFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadVsphereVirtualMachineFiles");
            var parameters = "($input: DownloadVsphereVirtualMachineFilesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadVsphereVirtualMachineFiles" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadVsphereVirtualMachineFiles",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!): CreateVsphereAdvancedTagReply!
        protected void InvokeMutationCreateVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateVsphereAdvancedTagInput!"),
            };
            CreateVsphereAdvancedTagReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CreateVsphereAdvancedTagReply)psObject.BaseObject;
                } else {
                    fields = (CreateVsphereAdvancedTagReply)this.Field;
                }
            }
            string document = Mutation.CreateVsphereAdvancedTag(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateVsphereAdvancedTag");
            var parameters = "($input: CreateVsphereAdvancedTagInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateVsphereAdvancedTag" + parameters + "{" + document + "}",
                OperationName = "MutationCreateVsphereAdvancedTag",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CreateVsphereAdvancedTagReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteVsphereAdvancedTag(input: DeleteVsphereAdvancedTagInput!): RequestSuccess!
        protected void InvokeMutationDeleteVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteVsphereAdvancedTagInput!"),
            };
            RequestSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.DeleteVsphereAdvancedTag(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteVsphereAdvancedTag");
            var parameters = "($input: DeleteVsphereAdvancedTagInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteVsphereAdvancedTag" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteVsphereAdvancedTag",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestSuccess", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!): UpdateVsphereAdvancedTagReply!
        protected void InvokeMutationUpdateVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVsphereAdvancedTagInput!"),
            };
            UpdateVsphereAdvancedTagReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateVsphereAdvancedTagReply)psObject.BaseObject;
                } else {
                    fields = (UpdateVsphereAdvancedTagReply)this.Field;
                }
            }
            string document = Mutation.UpdateVsphereAdvancedTag(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateVsphereAdvancedTag");
            var parameters = "($input: UpdateVsphereAdvancedTagInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateVsphereAdvancedTag" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateVsphereAdvancedTag",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateVsphereAdvancedTagReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscMutateVsphere
}