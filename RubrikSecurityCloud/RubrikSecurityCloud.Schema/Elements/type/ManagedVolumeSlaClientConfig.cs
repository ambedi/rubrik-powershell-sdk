// ManagedVolumeSlaClientConfig.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ManagedVolumeSlaClientConfig
    public class ManagedVolumeSlaClientConfig: BaseType
    {
        #region members

        //      C# -> List<System.String>? ChannelHostMountPaths
        // GraphQL -> channelHostMountPaths: [String!]! (scalar)
        [JsonProperty("channelHostMountPaths")]
        public List<System.String>? ChannelHostMountPaths { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean! (scalar)
        [JsonProperty("shouldCancelBackupOnPreBackupScriptFailure")]
        public System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> ManagedVolumeSlaScriptConfig? BackupScript
        // GraphQL -> backupScript: ManagedVolumeSlaScriptConfig! (type)
        [JsonProperty("backupScript")]
        public ManagedVolumeSlaScriptConfig? BackupScript { get; set; }

        //      C# -> ManagedVolumeSlaScriptConfig? FailedPostBackupScript
        // GraphQL -> failedPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        [JsonProperty("failedPostBackupScript")]
        public ManagedVolumeSlaScriptConfig? FailedPostBackupScript { get; set; }

        //      C# -> ManagedVolumeSlaScriptConfig? PreBackupScript
        // GraphQL -> preBackupScript: ManagedVolumeSlaScriptConfig (type)
        [JsonProperty("preBackupScript")]
        public ManagedVolumeSlaScriptConfig? PreBackupScript { get; set; }

        //      C# -> ManagedVolumeSlaScriptConfig? SuccessfulPostBackupScript
        // GraphQL -> successfulPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        [JsonProperty("successfulPostBackupScript")]
        public ManagedVolumeSlaScriptConfig? SuccessfulPostBackupScript { get; set; }


        #endregion

    #region methods

    public ManagedVolumeSlaClientConfig Set(
        List<System.String>? ChannelHostMountPaths = null,
        System.String? HostId = null,
        System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure = null,
        System.String? Username = null,
        ManagedVolumeSlaScriptConfig? BackupScript = null,
        ManagedVolumeSlaScriptConfig? FailedPostBackupScript = null,
        ManagedVolumeSlaScriptConfig? PreBackupScript = null,
        ManagedVolumeSlaScriptConfig? SuccessfulPostBackupScript = null
    ) 
    {
        if ( ChannelHostMountPaths != null ) {
            this.ChannelHostMountPaths = ChannelHostMountPaths;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( ShouldCancelBackupOnPreBackupScriptFailure != null ) {
            this.ShouldCancelBackupOnPreBackupScriptFailure = ShouldCancelBackupOnPreBackupScriptFailure;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( BackupScript != null ) {
            this.BackupScript = BackupScript;
        }
        if ( FailedPostBackupScript != null ) {
            this.FailedPostBackupScript = FailedPostBackupScript;
        }
        if ( PreBackupScript != null ) {
            this.PreBackupScript = PreBackupScript;
        }
        if ( SuccessfulPostBackupScript != null ) {
            this.SuccessfulPostBackupScript = SuccessfulPostBackupScript;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.String>? ChannelHostMountPaths
        // GraphQL -> channelHostMountPaths: [String!]! (scalar)
        if (this.ChannelHostMountPaths != null) {
            s += ind + "channelHostMountPaths\n" ;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            s += ind + "hostId\n" ;
        }
        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean! (scalar)
        if (this.ShouldCancelBackupOnPreBackupScriptFailure != null) {
            s += ind + "shouldCancelBackupOnPreBackupScriptFailure\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        //      C# -> ManagedVolumeSlaScriptConfig? BackupScript
        // GraphQL -> backupScript: ManagedVolumeSlaScriptConfig! (type)
        if (this.BackupScript != null) {
            s += ind + "backupScript {\n" + this.BackupScript.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumeSlaScriptConfig? FailedPostBackupScript
        // GraphQL -> failedPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.FailedPostBackupScript != null) {
            s += ind + "failedPostBackupScript {\n" + this.FailedPostBackupScript.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumeSlaScriptConfig? PreBackupScript
        // GraphQL -> preBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.PreBackupScript != null) {
            s += ind + "preBackupScript {\n" + this.PreBackupScript.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumeSlaScriptConfig? SuccessfulPostBackupScript
        // GraphQL -> successfulPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.SuccessfulPostBackupScript != null) {
            s += ind + "successfulPostBackupScript {\n" + this.SuccessfulPostBackupScript.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? ChannelHostMountPaths
        // GraphQL -> channelHostMountPaths: [String!]! (scalar)
        if (this.ChannelHostMountPaths == null && Exploration.Includes(parent + ".channelHostMountPaths", true))
        {
            this.ChannelHostMountPaths = new List<System.String>();
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId == null && Exploration.Includes(parent + ".hostId", true))
        {
            this.HostId = new System.String("FETCH");
        }
        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean! (scalar)
        if (this.ShouldCancelBackupOnPreBackupScriptFailure == null && Exploration.Includes(parent + ".shouldCancelBackupOnPreBackupScriptFailure", true))
        {
            this.ShouldCancelBackupOnPreBackupScriptFailure = true;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && Exploration.Includes(parent + ".username", true))
        {
            this.Username = new System.String("FETCH");
        }
        //      C# -> ManagedVolumeSlaScriptConfig? BackupScript
        // GraphQL -> backupScript: ManagedVolumeSlaScriptConfig! (type)
        if (this.BackupScript == null && Exploration.Includes(parent + ".backupScript"))
        {
            this.BackupScript = new ManagedVolumeSlaScriptConfig();
            this.BackupScript.ApplyExploratoryFieldSpec(parent + ".backupScript");
        }
        //      C# -> ManagedVolumeSlaScriptConfig? FailedPostBackupScript
        // GraphQL -> failedPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.FailedPostBackupScript == null && Exploration.Includes(parent + ".failedPostBackupScript"))
        {
            this.FailedPostBackupScript = new ManagedVolumeSlaScriptConfig();
            this.FailedPostBackupScript.ApplyExploratoryFieldSpec(parent + ".failedPostBackupScript");
        }
        //      C# -> ManagedVolumeSlaScriptConfig? PreBackupScript
        // GraphQL -> preBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.PreBackupScript == null && Exploration.Includes(parent + ".preBackupScript"))
        {
            this.PreBackupScript = new ManagedVolumeSlaScriptConfig();
            this.PreBackupScript.ApplyExploratoryFieldSpec(parent + ".preBackupScript");
        }
        //      C# -> ManagedVolumeSlaScriptConfig? SuccessfulPostBackupScript
        // GraphQL -> successfulPostBackupScript: ManagedVolumeSlaScriptConfig (type)
        if (this.SuccessfulPostBackupScript == null && Exploration.Includes(parent + ".successfulPostBackupScript"))
        {
            this.SuccessfulPostBackupScript = new ManagedVolumeSlaScriptConfig();
            this.SuccessfulPostBackupScript.ApplyExploratoryFieldSpec(parent + ".successfulPostBackupScript");
        }
    }


    #endregion

    } // class ManagedVolumeSlaClientConfig
    
    #endregion

    public static class ListManagedVolumeSlaClientConfigExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<ManagedVolumeSlaClientConfig> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeSlaClientConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeSlaClientConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types