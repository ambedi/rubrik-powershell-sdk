// SapHanaAppMetadata.cs
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
    #region SapHanaAppMetadata
    public class SapHanaAppMetadata: BaseType
    {
        #region members

        //      C# -> System.Int64? BackupId
        // GraphQL -> backupId: Long (scalar)
        [JsonProperty("backupId")]
        public System.Int64? BackupId { get; set; }

        //      C# -> System.String? BackupPrefix
        // GraphQL -> backupPrefix: String (scalar)
        [JsonProperty("backupPrefix")]
        public System.String? BackupPrefix { get; set; }

        //      C# -> System.Int64? BaseBackupId
        // GraphQL -> baseBackupId: Long (scalar)
        [JsonProperty("baseBackupId")]
        public System.Int64? BaseBackupId { get; set; }

        //      C# -> System.String? BaseFullSnapshotId
        // GraphQL -> baseFullSnapshotId: String (scalar)
        [JsonProperty("baseFullSnapshotId")]
        public System.String? BaseFullSnapshotId { get; set; }

        //      C# -> System.Boolean? IsExternalBackup
        // GraphQL -> isExternalBackup: Boolean (scalar)
        [JsonProperty("isExternalBackup")]
        public System.Boolean? IsExternalBackup { get; set; }

        //      C# -> System.Boolean? IsRubrikTriggeredOnDemandBackup
        // GraphQL -> isRubrikTriggeredOnDemandBackup: Boolean (scalar)
        [JsonProperty("isRubrikTriggeredOnDemandBackup")]
        public System.Boolean? IsRubrikTriggeredOnDemandBackup { get; set; }

        //      C# -> DateTime? RubrikSnapshotEndTime
        // GraphQL -> rubrikSnapshotEndTime: DateTime (scalar)
        [JsonProperty("rubrikSnapshotEndTime")]
        public DateTime? RubrikSnapshotEndTime { get; set; }

        //      C# -> DateTime? RubrikSnapshotStartTime
        // GraphQL -> rubrikSnapshotStartTime: DateTime (scalar)
        [JsonProperty("rubrikSnapshotStartTime")]
        public DateTime? RubrikSnapshotStartTime { get; set; }

        //      C# -> DateTime? SapHanaEndTime
        // GraphQL -> sapHanaEndTime: DateTime (scalar)
        [JsonProperty("sapHanaEndTime")]
        public DateTime? SapHanaEndTime { get; set; }

        //      C# -> DateTime? SapHanaStartTime
        // GraphQL -> sapHanaStartTime: DateTime (scalar)
        [JsonProperty("sapHanaStartTime")]
        public DateTime? SapHanaStartTime { get; set; }

        //      C# -> System.String? SnapshotType
        // GraphQL -> snapshotType: String (scalar)
        [JsonProperty("snapshotType")]
        public System.String? SnapshotType { get; set; }

        //      C# -> List<SapHanaDataBackupFile>? Files
        // GraphQL -> files: [SapHanaDataBackupFile!] (type)
        [JsonProperty("files")]
        public List<SapHanaDataBackupFile>? Files { get; set; }


        #endregion

    #region methods

    public SapHanaAppMetadata Set(
        System.Int64? BackupId = null,
        System.String? BackupPrefix = null,
        System.Int64? BaseBackupId = null,
        System.String? BaseFullSnapshotId = null,
        System.Boolean? IsExternalBackup = null,
        System.Boolean? IsRubrikTriggeredOnDemandBackup = null,
        DateTime? RubrikSnapshotEndTime = null,
        DateTime? RubrikSnapshotStartTime = null,
        DateTime? SapHanaEndTime = null,
        DateTime? SapHanaStartTime = null,
        System.String? SnapshotType = null,
        List<SapHanaDataBackupFile>? Files = null
    ) 
    {
        if ( BackupId != null ) {
            this.BackupId = BackupId;
        }
        if ( BackupPrefix != null ) {
            this.BackupPrefix = BackupPrefix;
        }
        if ( BaseBackupId != null ) {
            this.BaseBackupId = BaseBackupId;
        }
        if ( BaseFullSnapshotId != null ) {
            this.BaseFullSnapshotId = BaseFullSnapshotId;
        }
        if ( IsExternalBackup != null ) {
            this.IsExternalBackup = IsExternalBackup;
        }
        if ( IsRubrikTriggeredOnDemandBackup != null ) {
            this.IsRubrikTriggeredOnDemandBackup = IsRubrikTriggeredOnDemandBackup;
        }
        if ( RubrikSnapshotEndTime != null ) {
            this.RubrikSnapshotEndTime = RubrikSnapshotEndTime;
        }
        if ( RubrikSnapshotStartTime != null ) {
            this.RubrikSnapshotStartTime = RubrikSnapshotStartTime;
        }
        if ( SapHanaEndTime != null ) {
            this.SapHanaEndTime = SapHanaEndTime;
        }
        if ( SapHanaStartTime != null ) {
            this.SapHanaStartTime = SapHanaStartTime;
        }
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
        }
        if ( Files != null ) {
            this.Files = Files;
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
        //      C# -> System.Int64? BackupId
        // GraphQL -> backupId: Long (scalar)
        if (this.BackupId != null) {
            s += ind + "backupId\n" ;
        }
        //      C# -> System.String? BackupPrefix
        // GraphQL -> backupPrefix: String (scalar)
        if (this.BackupPrefix != null) {
            s += ind + "backupPrefix\n" ;
        }
        //      C# -> System.Int64? BaseBackupId
        // GraphQL -> baseBackupId: Long (scalar)
        if (this.BaseBackupId != null) {
            s += ind + "baseBackupId\n" ;
        }
        //      C# -> System.String? BaseFullSnapshotId
        // GraphQL -> baseFullSnapshotId: String (scalar)
        if (this.BaseFullSnapshotId != null) {
            s += ind + "baseFullSnapshotId\n" ;
        }
        //      C# -> System.Boolean? IsExternalBackup
        // GraphQL -> isExternalBackup: Boolean (scalar)
        if (this.IsExternalBackup != null) {
            s += ind + "isExternalBackup\n" ;
        }
        //      C# -> System.Boolean? IsRubrikTriggeredOnDemandBackup
        // GraphQL -> isRubrikTriggeredOnDemandBackup: Boolean (scalar)
        if (this.IsRubrikTriggeredOnDemandBackup != null) {
            s += ind + "isRubrikTriggeredOnDemandBackup\n" ;
        }
        //      C# -> DateTime? RubrikSnapshotEndTime
        // GraphQL -> rubrikSnapshotEndTime: DateTime (scalar)
        if (this.RubrikSnapshotEndTime != null) {
            s += ind + "rubrikSnapshotEndTime\n" ;
        }
        //      C# -> DateTime? RubrikSnapshotStartTime
        // GraphQL -> rubrikSnapshotStartTime: DateTime (scalar)
        if (this.RubrikSnapshotStartTime != null) {
            s += ind + "rubrikSnapshotStartTime\n" ;
        }
        //      C# -> DateTime? SapHanaEndTime
        // GraphQL -> sapHanaEndTime: DateTime (scalar)
        if (this.SapHanaEndTime != null) {
            s += ind + "sapHanaEndTime\n" ;
        }
        //      C# -> DateTime? SapHanaStartTime
        // GraphQL -> sapHanaStartTime: DateTime (scalar)
        if (this.SapHanaStartTime != null) {
            s += ind + "sapHanaStartTime\n" ;
        }
        //      C# -> System.String? SnapshotType
        // GraphQL -> snapshotType: String (scalar)
        if (this.SnapshotType != null) {
            s += ind + "snapshotType\n" ;
        }
        //      C# -> List<SapHanaDataBackupFile>? Files
        // GraphQL -> files: [SapHanaDataBackupFile!] (type)
        if (this.Files != null) {
            s += ind + "files {\n" + this.Files.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? BackupId
        // GraphQL -> backupId: Long (scalar)
        if (this.BackupId == null && Exploration.Includes(parent + ".backupId", true))
        {
            this.BackupId = new System.Int64();
        }
        //      C# -> System.String? BackupPrefix
        // GraphQL -> backupPrefix: String (scalar)
        if (this.BackupPrefix == null && Exploration.Includes(parent + ".backupPrefix", true))
        {
            this.BackupPrefix = new System.String("FETCH");
        }
        //      C# -> System.Int64? BaseBackupId
        // GraphQL -> baseBackupId: Long (scalar)
        if (this.BaseBackupId == null && Exploration.Includes(parent + ".baseBackupId", true))
        {
            this.BaseBackupId = new System.Int64();
        }
        //      C# -> System.String? BaseFullSnapshotId
        // GraphQL -> baseFullSnapshotId: String (scalar)
        if (this.BaseFullSnapshotId == null && Exploration.Includes(parent + ".baseFullSnapshotId", true))
        {
            this.BaseFullSnapshotId = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsExternalBackup
        // GraphQL -> isExternalBackup: Boolean (scalar)
        if (this.IsExternalBackup == null && Exploration.Includes(parent + ".isExternalBackup", true))
        {
            this.IsExternalBackup = true;
        }
        //      C# -> System.Boolean? IsRubrikTriggeredOnDemandBackup
        // GraphQL -> isRubrikTriggeredOnDemandBackup: Boolean (scalar)
        if (this.IsRubrikTriggeredOnDemandBackup == null && Exploration.Includes(parent + ".isRubrikTriggeredOnDemandBackup", true))
        {
            this.IsRubrikTriggeredOnDemandBackup = true;
        }
        //      C# -> DateTime? RubrikSnapshotEndTime
        // GraphQL -> rubrikSnapshotEndTime: DateTime (scalar)
        if (this.RubrikSnapshotEndTime == null && Exploration.Includes(parent + ".rubrikSnapshotEndTime", true))
        {
            this.RubrikSnapshotEndTime = new DateTime();
        }
        //      C# -> DateTime? RubrikSnapshotStartTime
        // GraphQL -> rubrikSnapshotStartTime: DateTime (scalar)
        if (this.RubrikSnapshotStartTime == null && Exploration.Includes(parent + ".rubrikSnapshotStartTime", true))
        {
            this.RubrikSnapshotStartTime = new DateTime();
        }
        //      C# -> DateTime? SapHanaEndTime
        // GraphQL -> sapHanaEndTime: DateTime (scalar)
        if (this.SapHanaEndTime == null && Exploration.Includes(parent + ".sapHanaEndTime", true))
        {
            this.SapHanaEndTime = new DateTime();
        }
        //      C# -> DateTime? SapHanaStartTime
        // GraphQL -> sapHanaStartTime: DateTime (scalar)
        if (this.SapHanaStartTime == null && Exploration.Includes(parent + ".sapHanaStartTime", true))
        {
            this.SapHanaStartTime = new DateTime();
        }
        //      C# -> System.String? SnapshotType
        // GraphQL -> snapshotType: String (scalar)
        if (this.SnapshotType == null && Exploration.Includes(parent + ".snapshotType", true))
        {
            this.SnapshotType = new System.String("FETCH");
        }
        //      C# -> List<SapHanaDataBackupFile>? Files
        // GraphQL -> files: [SapHanaDataBackupFile!] (type)
        if (this.Files == null && Exploration.Includes(parent + ".files"))
        {
            this.Files = new List<SapHanaDataBackupFile>();
            this.Files.ApplyExploratoryFieldSpec(parent + ".files");
        }
    }


    #endregion

    } // class SapHanaAppMetadata
    
    #endregion

    public static class ListSapHanaAppMetadataExtensions
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
            this List<SapHanaAppMetadata> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaAppMetadata> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaAppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types