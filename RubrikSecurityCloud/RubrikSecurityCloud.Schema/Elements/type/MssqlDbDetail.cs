// MssqlDbDetail.cs
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
    #region MssqlDbDetail
    public class MssqlDbDetail: BaseType
    {
        #region members

        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        [JsonProperty("archiveStorage")]
        public System.Int64? ArchiveStorage { get; set; }

        //      C# -> System.Boolean? IsLocal
        // GraphQL -> isLocal: Boolean (scalar)
        [JsonProperty("isLocal")]
        public System.Boolean? IsLocal { get; set; }

        //      C# -> System.Boolean? IsStandby
        // GraphQL -> isStandby: Boolean (scalar)
        [JsonProperty("isStandby")]
        public System.Boolean? IsStandby { get; set; }

        //      C# -> System.String? LatestRecoveryPointV50
        // GraphQL -> latestRecoveryPointV50: String (scalar)
        [JsonProperty("latestRecoveryPointV50")]
        public System.String? LatestRecoveryPointV50 { get; set; }

        //      C# -> System.String? LatestRecoveryPointV51
        // GraphQL -> latestRecoveryPointV51: String (scalar)
        [JsonProperty("latestRecoveryPointV51")]
        public System.String? LatestRecoveryPointV51 { get; set; }

        //      C# -> System.String? LatestRecoveryPointV52
        // GraphQL -> latestRecoveryPointV52: String (scalar)
        [JsonProperty("latestRecoveryPointV52")]
        public System.String? LatestRecoveryPointV52 { get; set; }

        //      C# -> System.String? LatestRecoveryPointV53
        // GraphQL -> latestRecoveryPointV53: String (scalar)
        [JsonProperty("latestRecoveryPointV53")]
        public System.String? LatestRecoveryPointV53 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV60
        // GraphQL -> latestRecoveryPointV60: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV60")]
        public DateTime? LatestRecoveryPointV60 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV70
        // GraphQL -> latestRecoveryPointV70: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV70")]
        public DateTime? LatestRecoveryPointV70 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV80
        // GraphQL -> latestRecoveryPointV80: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV80")]
        public DateTime? LatestRecoveryPointV80 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV81
        // GraphQL -> latestRecoveryPointV81: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV81")]
        public DateTime? LatestRecoveryPointV81 { get; set; }

        //      C# -> DateTime? LatestRecoveryPointV90
        // GraphQL -> latestRecoveryPointV90: DateTime (scalar)
        [JsonProperty("latestRecoveryPointV90")]
        public DateTime? LatestRecoveryPointV90 { get; set; }

        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        [JsonProperty("localStorage")]
        public System.Int64? LocalStorage { get; set; }

        //      C# -> System.Int32? MaxDataStreams
        // GraphQL -> maxDataStreams: Int (scalar)
        [JsonProperty("maxDataStreams")]
        public System.Int32? MaxDataStreams { get; set; }

        //      C# -> System.String? OldestRecoveryPointV50
        // GraphQL -> oldestRecoveryPointV50: String (scalar)
        [JsonProperty("oldestRecoveryPointV50")]
        public System.String? OldestRecoveryPointV50 { get; set; }

        //      C# -> System.String? OldestRecoveryPointV51
        // GraphQL -> oldestRecoveryPointV51: String (scalar)
        [JsonProperty("oldestRecoveryPointV51")]
        public System.String? OldestRecoveryPointV51 { get; set; }

        //      C# -> System.String? OldestRecoveryPointV52
        // GraphQL -> oldestRecoveryPointV52: String (scalar)
        [JsonProperty("oldestRecoveryPointV52")]
        public System.String? OldestRecoveryPointV52 { get; set; }

        //      C# -> System.String? OldestRecoveryPointV53
        // GraphQL -> oldestRecoveryPointV53: String (scalar)
        [JsonProperty("oldestRecoveryPointV53")]
        public System.String? OldestRecoveryPointV53 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV60
        // GraphQL -> oldestRecoveryPointV60: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV60")]
        public DateTime? OldestRecoveryPointV60 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV70
        // GraphQL -> oldestRecoveryPointV70: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV70")]
        public DateTime? OldestRecoveryPointV70 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV80
        // GraphQL -> oldestRecoveryPointV80: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV80")]
        public DateTime? OldestRecoveryPointV80 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV81
        // GraphQL -> oldestRecoveryPointV81: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV81")]
        public DateTime? OldestRecoveryPointV81 { get; set; }

        //      C# -> DateTime? OldestRecoveryPointV90
        // GraphQL -> oldestRecoveryPointV90: DateTime (scalar)
        [JsonProperty("oldestRecoveryPointV90")]
        public DateTime? OldestRecoveryPointV90 { get; set; }

        //      C# -> System.String? ProtectionDateV50
        // GraphQL -> protectionDateV50: String (scalar)
        [JsonProperty("protectionDateV50")]
        public System.String? ProtectionDateV50 { get; set; }

        //      C# -> System.String? ProtectionDateV51
        // GraphQL -> protectionDateV51: String (scalar)
        [JsonProperty("protectionDateV51")]
        public System.String? ProtectionDateV51 { get; set; }

        //      C# -> System.String? ProtectionDateV52
        // GraphQL -> protectionDateV52: String (scalar)
        [JsonProperty("protectionDateV52")]
        public System.String? ProtectionDateV52 { get; set; }

        //      C# -> System.String? ProtectionDateV53
        // GraphQL -> protectionDateV53: String (scalar)
        [JsonProperty("protectionDateV53")]
        public System.String? ProtectionDateV53 { get; set; }

        //      C# -> DateTime? ProtectionDateV60
        // GraphQL -> protectionDateV60: DateTime (scalar)
        [JsonProperty("protectionDateV60")]
        public DateTime? ProtectionDateV60 { get; set; }

        //      C# -> DateTime? ProtectionDateV70
        // GraphQL -> protectionDateV70: DateTime (scalar)
        [JsonProperty("protectionDateV70")]
        public DateTime? ProtectionDateV70 { get; set; }

        //      C# -> DateTime? ProtectionDateV80
        // GraphQL -> protectionDateV80: DateTime (scalar)
        [JsonProperty("protectionDateV80")]
        public DateTime? ProtectionDateV80 { get; set; }

        //      C# -> DateTime? ProtectionDateV81
        // GraphQL -> protectionDateV81: DateTime (scalar)
        [JsonProperty("protectionDateV81")]
        public DateTime? ProtectionDateV81 { get; set; }

        //      C# -> DateTime? ProtectionDateV90
        // GraphQL -> protectionDateV90: DateTime (scalar)
        [JsonProperty("protectionDateV90")]
        public DateTime? ProtectionDateV90 { get; set; }

        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String (scalar)
        [JsonProperty("recoveryForkGuid")]
        public System.String? RecoveryForkGuid { get; set; }

        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        [JsonProperty("snapshotCount")]
        public System.Int32? SnapshotCount { get; set; }

        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        [JsonProperty("blackoutWindowResponseInfo")]
        public BlackoutWindowResponseInfo? BlackoutWindowResponseInfo { get; set; }

        //      C# -> MssqlDbSummary? MssqlDbSummary
        // GraphQL -> mssqlDbSummary: MssqlDbSummary (type)
        [JsonProperty("mssqlDbSummary")]
        public MssqlDbSummary? MssqlDbSummary { get; set; }

        //      C# -> MssqlScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: MssqlScriptDetail (type)
        [JsonProperty("postBackupScript")]
        public MssqlScriptDetail? PostBackupScript { get; set; }

        //      C# -> MssqlScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: MssqlScriptDetail (type)
        [JsonProperty("preBackupScript")]
        public MssqlScriptDetail? PreBackupScript { get; set; }


        #endregion

    #region methods

    public MssqlDbDetail Set(
        System.Int64? ArchiveStorage = null,
        System.Boolean? IsLocal = null,
        System.Boolean? IsStandby = null,
        System.String? LatestRecoveryPointV50 = null,
        System.String? LatestRecoveryPointV51 = null,
        System.String? LatestRecoveryPointV52 = null,
        System.String? LatestRecoveryPointV53 = null,
        DateTime? LatestRecoveryPointV60 = null,
        DateTime? LatestRecoveryPointV70 = null,
        DateTime? LatestRecoveryPointV80 = null,
        DateTime? LatestRecoveryPointV81 = null,
        DateTime? LatestRecoveryPointV90 = null,
        System.Int64? LocalStorage = null,
        System.Int32? MaxDataStreams = null,
        System.String? OldestRecoveryPointV50 = null,
        System.String? OldestRecoveryPointV51 = null,
        System.String? OldestRecoveryPointV52 = null,
        System.String? OldestRecoveryPointV53 = null,
        DateTime? OldestRecoveryPointV60 = null,
        DateTime? OldestRecoveryPointV70 = null,
        DateTime? OldestRecoveryPointV80 = null,
        DateTime? OldestRecoveryPointV81 = null,
        DateTime? OldestRecoveryPointV90 = null,
        System.String? ProtectionDateV50 = null,
        System.String? ProtectionDateV51 = null,
        System.String? ProtectionDateV52 = null,
        System.String? ProtectionDateV53 = null,
        DateTime? ProtectionDateV60 = null,
        DateTime? ProtectionDateV70 = null,
        DateTime? ProtectionDateV80 = null,
        DateTime? ProtectionDateV81 = null,
        DateTime? ProtectionDateV90 = null,
        System.String? RecoveryForkGuid = null,
        System.Int32? SnapshotCount = null,
        BlackoutWindowResponseInfo? BlackoutWindowResponseInfo = null,
        MssqlDbSummary? MssqlDbSummary = null,
        MssqlScriptDetail? PostBackupScript = null,
        MssqlScriptDetail? PreBackupScript = null
    ) 
    {
        if ( ArchiveStorage != null ) {
            this.ArchiveStorage = ArchiveStorage;
        }
        if ( IsLocal != null ) {
            this.IsLocal = IsLocal;
        }
        if ( IsStandby != null ) {
            this.IsStandby = IsStandby;
        }
        if ( LatestRecoveryPointV50 != null ) {
            this.LatestRecoveryPointV50 = LatestRecoveryPointV50;
        }
        if ( LatestRecoveryPointV51 != null ) {
            this.LatestRecoveryPointV51 = LatestRecoveryPointV51;
        }
        if ( LatestRecoveryPointV52 != null ) {
            this.LatestRecoveryPointV52 = LatestRecoveryPointV52;
        }
        if ( LatestRecoveryPointV53 != null ) {
            this.LatestRecoveryPointV53 = LatestRecoveryPointV53;
        }
        if ( LatestRecoveryPointV60 != null ) {
            this.LatestRecoveryPointV60 = LatestRecoveryPointV60;
        }
        if ( LatestRecoveryPointV70 != null ) {
            this.LatestRecoveryPointV70 = LatestRecoveryPointV70;
        }
        if ( LatestRecoveryPointV80 != null ) {
            this.LatestRecoveryPointV80 = LatestRecoveryPointV80;
        }
        if ( LatestRecoveryPointV81 != null ) {
            this.LatestRecoveryPointV81 = LatestRecoveryPointV81;
        }
        if ( LatestRecoveryPointV90 != null ) {
            this.LatestRecoveryPointV90 = LatestRecoveryPointV90;
        }
        if ( LocalStorage != null ) {
            this.LocalStorage = LocalStorage;
        }
        if ( MaxDataStreams != null ) {
            this.MaxDataStreams = MaxDataStreams;
        }
        if ( OldestRecoveryPointV50 != null ) {
            this.OldestRecoveryPointV50 = OldestRecoveryPointV50;
        }
        if ( OldestRecoveryPointV51 != null ) {
            this.OldestRecoveryPointV51 = OldestRecoveryPointV51;
        }
        if ( OldestRecoveryPointV52 != null ) {
            this.OldestRecoveryPointV52 = OldestRecoveryPointV52;
        }
        if ( OldestRecoveryPointV53 != null ) {
            this.OldestRecoveryPointV53 = OldestRecoveryPointV53;
        }
        if ( OldestRecoveryPointV60 != null ) {
            this.OldestRecoveryPointV60 = OldestRecoveryPointV60;
        }
        if ( OldestRecoveryPointV70 != null ) {
            this.OldestRecoveryPointV70 = OldestRecoveryPointV70;
        }
        if ( OldestRecoveryPointV80 != null ) {
            this.OldestRecoveryPointV80 = OldestRecoveryPointV80;
        }
        if ( OldestRecoveryPointV81 != null ) {
            this.OldestRecoveryPointV81 = OldestRecoveryPointV81;
        }
        if ( OldestRecoveryPointV90 != null ) {
            this.OldestRecoveryPointV90 = OldestRecoveryPointV90;
        }
        if ( ProtectionDateV50 != null ) {
            this.ProtectionDateV50 = ProtectionDateV50;
        }
        if ( ProtectionDateV51 != null ) {
            this.ProtectionDateV51 = ProtectionDateV51;
        }
        if ( ProtectionDateV52 != null ) {
            this.ProtectionDateV52 = ProtectionDateV52;
        }
        if ( ProtectionDateV53 != null ) {
            this.ProtectionDateV53 = ProtectionDateV53;
        }
        if ( ProtectionDateV60 != null ) {
            this.ProtectionDateV60 = ProtectionDateV60;
        }
        if ( ProtectionDateV70 != null ) {
            this.ProtectionDateV70 = ProtectionDateV70;
        }
        if ( ProtectionDateV80 != null ) {
            this.ProtectionDateV80 = ProtectionDateV80;
        }
        if ( ProtectionDateV81 != null ) {
            this.ProtectionDateV81 = ProtectionDateV81;
        }
        if ( ProtectionDateV90 != null ) {
            this.ProtectionDateV90 = ProtectionDateV90;
        }
        if ( RecoveryForkGuid != null ) {
            this.RecoveryForkGuid = RecoveryForkGuid;
        }
        if ( SnapshotCount != null ) {
            this.SnapshotCount = SnapshotCount;
        }
        if ( BlackoutWindowResponseInfo != null ) {
            this.BlackoutWindowResponseInfo = BlackoutWindowResponseInfo;
        }
        if ( MssqlDbSummary != null ) {
            this.MssqlDbSummary = MssqlDbSummary;
        }
        if ( PostBackupScript != null ) {
            this.PostBackupScript = PostBackupScript;
        }
        if ( PreBackupScript != null ) {
            this.PreBackupScript = PreBackupScript;
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
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        if (this.ArchiveStorage != null) {
            s += ind + "archiveStorage\n" ;
        }
        //      C# -> System.Boolean? IsLocal
        // GraphQL -> isLocal: Boolean (scalar)
        if (this.IsLocal != null) {
            s += ind + "isLocal\n" ;
        }
        //      C# -> System.Boolean? IsStandby
        // GraphQL -> isStandby: Boolean (scalar)
        if (this.IsStandby != null) {
            s += ind + "isStandby\n" ;
        }
        //      C# -> System.String? LatestRecoveryPointV50
        // GraphQL -> latestRecoveryPointV50: String (scalar)
        if (this.LatestRecoveryPointV50 != null) {
            s += ind + "latestRecoveryPointV50\n" ;
        }
        //      C# -> System.String? LatestRecoveryPointV51
        // GraphQL -> latestRecoveryPointV51: String (scalar)
        if (this.LatestRecoveryPointV51 != null) {
            s += ind + "latestRecoveryPointV51\n" ;
        }
        //      C# -> System.String? LatestRecoveryPointV52
        // GraphQL -> latestRecoveryPointV52: String (scalar)
        if (this.LatestRecoveryPointV52 != null) {
            s += ind + "latestRecoveryPointV52\n" ;
        }
        //      C# -> System.String? LatestRecoveryPointV53
        // GraphQL -> latestRecoveryPointV53: String (scalar)
        if (this.LatestRecoveryPointV53 != null) {
            s += ind + "latestRecoveryPointV53\n" ;
        }
        //      C# -> DateTime? LatestRecoveryPointV60
        // GraphQL -> latestRecoveryPointV60: DateTime (scalar)
        if (this.LatestRecoveryPointV60 != null) {
            s += ind + "latestRecoveryPointV60\n" ;
        }
        //      C# -> DateTime? LatestRecoveryPointV70
        // GraphQL -> latestRecoveryPointV70: DateTime (scalar)
        if (this.LatestRecoveryPointV70 != null) {
            s += ind + "latestRecoveryPointV70\n" ;
        }
        //      C# -> DateTime? LatestRecoveryPointV80
        // GraphQL -> latestRecoveryPointV80: DateTime (scalar)
        if (this.LatestRecoveryPointV80 != null) {
            s += ind + "latestRecoveryPointV80\n" ;
        }
        //      C# -> DateTime? LatestRecoveryPointV81
        // GraphQL -> latestRecoveryPointV81: DateTime (scalar)
        if (this.LatestRecoveryPointV81 != null) {
            s += ind + "latestRecoveryPointV81\n" ;
        }
        //      C# -> DateTime? LatestRecoveryPointV90
        // GraphQL -> latestRecoveryPointV90: DateTime (scalar)
        if (this.LatestRecoveryPointV90 != null) {
            s += ind + "latestRecoveryPointV90\n" ;
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        if (this.LocalStorage != null) {
            s += ind + "localStorage\n" ;
        }
        //      C# -> System.Int32? MaxDataStreams
        // GraphQL -> maxDataStreams: Int (scalar)
        if (this.MaxDataStreams != null) {
            s += ind + "maxDataStreams\n" ;
        }
        //      C# -> System.String? OldestRecoveryPointV50
        // GraphQL -> oldestRecoveryPointV50: String (scalar)
        if (this.OldestRecoveryPointV50 != null) {
            s += ind + "oldestRecoveryPointV50\n" ;
        }
        //      C# -> System.String? OldestRecoveryPointV51
        // GraphQL -> oldestRecoveryPointV51: String (scalar)
        if (this.OldestRecoveryPointV51 != null) {
            s += ind + "oldestRecoveryPointV51\n" ;
        }
        //      C# -> System.String? OldestRecoveryPointV52
        // GraphQL -> oldestRecoveryPointV52: String (scalar)
        if (this.OldestRecoveryPointV52 != null) {
            s += ind + "oldestRecoveryPointV52\n" ;
        }
        //      C# -> System.String? OldestRecoveryPointV53
        // GraphQL -> oldestRecoveryPointV53: String (scalar)
        if (this.OldestRecoveryPointV53 != null) {
            s += ind + "oldestRecoveryPointV53\n" ;
        }
        //      C# -> DateTime? OldestRecoveryPointV60
        // GraphQL -> oldestRecoveryPointV60: DateTime (scalar)
        if (this.OldestRecoveryPointV60 != null) {
            s += ind + "oldestRecoveryPointV60\n" ;
        }
        //      C# -> DateTime? OldestRecoveryPointV70
        // GraphQL -> oldestRecoveryPointV70: DateTime (scalar)
        if (this.OldestRecoveryPointV70 != null) {
            s += ind + "oldestRecoveryPointV70\n" ;
        }
        //      C# -> DateTime? OldestRecoveryPointV80
        // GraphQL -> oldestRecoveryPointV80: DateTime (scalar)
        if (this.OldestRecoveryPointV80 != null) {
            s += ind + "oldestRecoveryPointV80\n" ;
        }
        //      C# -> DateTime? OldestRecoveryPointV81
        // GraphQL -> oldestRecoveryPointV81: DateTime (scalar)
        if (this.OldestRecoveryPointV81 != null) {
            s += ind + "oldestRecoveryPointV81\n" ;
        }
        //      C# -> DateTime? OldestRecoveryPointV90
        // GraphQL -> oldestRecoveryPointV90: DateTime (scalar)
        if (this.OldestRecoveryPointV90 != null) {
            s += ind + "oldestRecoveryPointV90\n" ;
        }
        //      C# -> System.String? ProtectionDateV50
        // GraphQL -> protectionDateV50: String (scalar)
        if (this.ProtectionDateV50 != null) {
            s += ind + "protectionDateV50\n" ;
        }
        //      C# -> System.String? ProtectionDateV51
        // GraphQL -> protectionDateV51: String (scalar)
        if (this.ProtectionDateV51 != null) {
            s += ind + "protectionDateV51\n" ;
        }
        //      C# -> System.String? ProtectionDateV52
        // GraphQL -> protectionDateV52: String (scalar)
        if (this.ProtectionDateV52 != null) {
            s += ind + "protectionDateV52\n" ;
        }
        //      C# -> System.String? ProtectionDateV53
        // GraphQL -> protectionDateV53: String (scalar)
        if (this.ProtectionDateV53 != null) {
            s += ind + "protectionDateV53\n" ;
        }
        //      C# -> DateTime? ProtectionDateV60
        // GraphQL -> protectionDateV60: DateTime (scalar)
        if (this.ProtectionDateV60 != null) {
            s += ind + "protectionDateV60\n" ;
        }
        //      C# -> DateTime? ProtectionDateV70
        // GraphQL -> protectionDateV70: DateTime (scalar)
        if (this.ProtectionDateV70 != null) {
            s += ind + "protectionDateV70\n" ;
        }
        //      C# -> DateTime? ProtectionDateV80
        // GraphQL -> protectionDateV80: DateTime (scalar)
        if (this.ProtectionDateV80 != null) {
            s += ind + "protectionDateV80\n" ;
        }
        //      C# -> DateTime? ProtectionDateV81
        // GraphQL -> protectionDateV81: DateTime (scalar)
        if (this.ProtectionDateV81 != null) {
            s += ind + "protectionDateV81\n" ;
        }
        //      C# -> DateTime? ProtectionDateV90
        // GraphQL -> protectionDateV90: DateTime (scalar)
        if (this.ProtectionDateV90 != null) {
            s += ind + "protectionDateV90\n" ;
        }
        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String (scalar)
        if (this.RecoveryForkGuid != null) {
            s += ind + "recoveryForkGuid\n" ;
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (this.SnapshotCount != null) {
            s += ind + "snapshotCount\n" ;
        }
        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        if (this.BlackoutWindowResponseInfo != null) {
            s += ind + "blackoutWindowResponseInfo {\n" + this.BlackoutWindowResponseInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> MssqlDbSummary? MssqlDbSummary
        // GraphQL -> mssqlDbSummary: MssqlDbSummary (type)
        if (this.MssqlDbSummary != null) {
            s += ind + "mssqlDbSummary {\n" + this.MssqlDbSummary.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> MssqlScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: MssqlScriptDetail (type)
        if (this.PostBackupScript != null) {
            s += ind + "postBackupScript {\n" + this.PostBackupScript.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> MssqlScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: MssqlScriptDetail (type)
        if (this.PreBackupScript != null) {
            s += ind + "preBackupScript {\n" + this.PreBackupScript.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        if (this.ArchiveStorage == null && Exploration.Includes(parent + ".archiveStorage", true))
        {
            this.ArchiveStorage = new System.Int64();
        }
        //      C# -> System.Boolean? IsLocal
        // GraphQL -> isLocal: Boolean (scalar)
        if (this.IsLocal == null && Exploration.Includes(parent + ".isLocal", true))
        {
            this.IsLocal = true;
        }
        //      C# -> System.Boolean? IsStandby
        // GraphQL -> isStandby: Boolean (scalar)
        if (this.IsStandby == null && Exploration.Includes(parent + ".isStandby", true))
        {
            this.IsStandby = true;
        }
        //      C# -> System.String? LatestRecoveryPointV50
        // GraphQL -> latestRecoveryPointV50: String (scalar)
        if (this.LatestRecoveryPointV50 == null && Exploration.Includes(parent + ".latestRecoveryPointV50", true))
        {
            this.LatestRecoveryPointV50 = new System.String("FETCH");
        }
        //      C# -> System.String? LatestRecoveryPointV51
        // GraphQL -> latestRecoveryPointV51: String (scalar)
        if (this.LatestRecoveryPointV51 == null && Exploration.Includes(parent + ".latestRecoveryPointV51", true))
        {
            this.LatestRecoveryPointV51 = new System.String("FETCH");
        }
        //      C# -> System.String? LatestRecoveryPointV52
        // GraphQL -> latestRecoveryPointV52: String (scalar)
        if (this.LatestRecoveryPointV52 == null && Exploration.Includes(parent + ".latestRecoveryPointV52", true))
        {
            this.LatestRecoveryPointV52 = new System.String("FETCH");
        }
        //      C# -> System.String? LatestRecoveryPointV53
        // GraphQL -> latestRecoveryPointV53: String (scalar)
        if (this.LatestRecoveryPointV53 == null && Exploration.Includes(parent + ".latestRecoveryPointV53", true))
        {
            this.LatestRecoveryPointV53 = new System.String("FETCH");
        }
        //      C# -> DateTime? LatestRecoveryPointV60
        // GraphQL -> latestRecoveryPointV60: DateTime (scalar)
        if (this.LatestRecoveryPointV60 == null && Exploration.Includes(parent + ".latestRecoveryPointV60", true))
        {
            this.LatestRecoveryPointV60 = new DateTime();
        }
        //      C# -> DateTime? LatestRecoveryPointV70
        // GraphQL -> latestRecoveryPointV70: DateTime (scalar)
        if (this.LatestRecoveryPointV70 == null && Exploration.Includes(parent + ".latestRecoveryPointV70", true))
        {
            this.LatestRecoveryPointV70 = new DateTime();
        }
        //      C# -> DateTime? LatestRecoveryPointV80
        // GraphQL -> latestRecoveryPointV80: DateTime (scalar)
        if (this.LatestRecoveryPointV80 == null && Exploration.Includes(parent + ".latestRecoveryPointV80", true))
        {
            this.LatestRecoveryPointV80 = new DateTime();
        }
        //      C# -> DateTime? LatestRecoveryPointV81
        // GraphQL -> latestRecoveryPointV81: DateTime (scalar)
        if (this.LatestRecoveryPointV81 == null && Exploration.Includes(parent + ".latestRecoveryPointV81", true))
        {
            this.LatestRecoveryPointV81 = new DateTime();
        }
        //      C# -> DateTime? LatestRecoveryPointV90
        // GraphQL -> latestRecoveryPointV90: DateTime (scalar)
        if (this.LatestRecoveryPointV90 == null && Exploration.Includes(parent + ".latestRecoveryPointV90", true))
        {
            this.LatestRecoveryPointV90 = new DateTime();
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        if (this.LocalStorage == null && Exploration.Includes(parent + ".localStorage", true))
        {
            this.LocalStorage = new System.Int64();
        }
        //      C# -> System.Int32? MaxDataStreams
        // GraphQL -> maxDataStreams: Int (scalar)
        if (this.MaxDataStreams == null && Exploration.Includes(parent + ".maxDataStreams", true))
        {
            this.MaxDataStreams = new System.Int32();
        }
        //      C# -> System.String? OldestRecoveryPointV50
        // GraphQL -> oldestRecoveryPointV50: String (scalar)
        if (this.OldestRecoveryPointV50 == null && Exploration.Includes(parent + ".oldestRecoveryPointV50", true))
        {
            this.OldestRecoveryPointV50 = new System.String("FETCH");
        }
        //      C# -> System.String? OldestRecoveryPointV51
        // GraphQL -> oldestRecoveryPointV51: String (scalar)
        if (this.OldestRecoveryPointV51 == null && Exploration.Includes(parent + ".oldestRecoveryPointV51", true))
        {
            this.OldestRecoveryPointV51 = new System.String("FETCH");
        }
        //      C# -> System.String? OldestRecoveryPointV52
        // GraphQL -> oldestRecoveryPointV52: String (scalar)
        if (this.OldestRecoveryPointV52 == null && Exploration.Includes(parent + ".oldestRecoveryPointV52", true))
        {
            this.OldestRecoveryPointV52 = new System.String("FETCH");
        }
        //      C# -> System.String? OldestRecoveryPointV53
        // GraphQL -> oldestRecoveryPointV53: String (scalar)
        if (this.OldestRecoveryPointV53 == null && Exploration.Includes(parent + ".oldestRecoveryPointV53", true))
        {
            this.OldestRecoveryPointV53 = new System.String("FETCH");
        }
        //      C# -> DateTime? OldestRecoveryPointV60
        // GraphQL -> oldestRecoveryPointV60: DateTime (scalar)
        if (this.OldestRecoveryPointV60 == null && Exploration.Includes(parent + ".oldestRecoveryPointV60", true))
        {
            this.OldestRecoveryPointV60 = new DateTime();
        }
        //      C# -> DateTime? OldestRecoveryPointV70
        // GraphQL -> oldestRecoveryPointV70: DateTime (scalar)
        if (this.OldestRecoveryPointV70 == null && Exploration.Includes(parent + ".oldestRecoveryPointV70", true))
        {
            this.OldestRecoveryPointV70 = new DateTime();
        }
        //      C# -> DateTime? OldestRecoveryPointV80
        // GraphQL -> oldestRecoveryPointV80: DateTime (scalar)
        if (this.OldestRecoveryPointV80 == null && Exploration.Includes(parent + ".oldestRecoveryPointV80", true))
        {
            this.OldestRecoveryPointV80 = new DateTime();
        }
        //      C# -> DateTime? OldestRecoveryPointV81
        // GraphQL -> oldestRecoveryPointV81: DateTime (scalar)
        if (this.OldestRecoveryPointV81 == null && Exploration.Includes(parent + ".oldestRecoveryPointV81", true))
        {
            this.OldestRecoveryPointV81 = new DateTime();
        }
        //      C# -> DateTime? OldestRecoveryPointV90
        // GraphQL -> oldestRecoveryPointV90: DateTime (scalar)
        if (this.OldestRecoveryPointV90 == null && Exploration.Includes(parent + ".oldestRecoveryPointV90", true))
        {
            this.OldestRecoveryPointV90 = new DateTime();
        }
        //      C# -> System.String? ProtectionDateV50
        // GraphQL -> protectionDateV50: String (scalar)
        if (this.ProtectionDateV50 == null && Exploration.Includes(parent + ".protectionDateV50", true))
        {
            this.ProtectionDateV50 = new System.String("FETCH");
        }
        //      C# -> System.String? ProtectionDateV51
        // GraphQL -> protectionDateV51: String (scalar)
        if (this.ProtectionDateV51 == null && Exploration.Includes(parent + ".protectionDateV51", true))
        {
            this.ProtectionDateV51 = new System.String("FETCH");
        }
        //      C# -> System.String? ProtectionDateV52
        // GraphQL -> protectionDateV52: String (scalar)
        if (this.ProtectionDateV52 == null && Exploration.Includes(parent + ".protectionDateV52", true))
        {
            this.ProtectionDateV52 = new System.String("FETCH");
        }
        //      C# -> System.String? ProtectionDateV53
        // GraphQL -> protectionDateV53: String (scalar)
        if (this.ProtectionDateV53 == null && Exploration.Includes(parent + ".protectionDateV53", true))
        {
            this.ProtectionDateV53 = new System.String("FETCH");
        }
        //      C# -> DateTime? ProtectionDateV60
        // GraphQL -> protectionDateV60: DateTime (scalar)
        if (this.ProtectionDateV60 == null && Exploration.Includes(parent + ".protectionDateV60", true))
        {
            this.ProtectionDateV60 = new DateTime();
        }
        //      C# -> DateTime? ProtectionDateV70
        // GraphQL -> protectionDateV70: DateTime (scalar)
        if (this.ProtectionDateV70 == null && Exploration.Includes(parent + ".protectionDateV70", true))
        {
            this.ProtectionDateV70 = new DateTime();
        }
        //      C# -> DateTime? ProtectionDateV80
        // GraphQL -> protectionDateV80: DateTime (scalar)
        if (this.ProtectionDateV80 == null && Exploration.Includes(parent + ".protectionDateV80", true))
        {
            this.ProtectionDateV80 = new DateTime();
        }
        //      C# -> DateTime? ProtectionDateV81
        // GraphQL -> protectionDateV81: DateTime (scalar)
        if (this.ProtectionDateV81 == null && Exploration.Includes(parent + ".protectionDateV81", true))
        {
            this.ProtectionDateV81 = new DateTime();
        }
        //      C# -> DateTime? ProtectionDateV90
        // GraphQL -> protectionDateV90: DateTime (scalar)
        if (this.ProtectionDateV90 == null && Exploration.Includes(parent + ".protectionDateV90", true))
        {
            this.ProtectionDateV90 = new DateTime();
        }
        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String (scalar)
        if (this.RecoveryForkGuid == null && Exploration.Includes(parent + ".recoveryForkGuid", true))
        {
            this.RecoveryForkGuid = new System.String("FETCH");
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (this.SnapshotCount == null && Exploration.Includes(parent + ".snapshotCount", true))
        {
            this.SnapshotCount = new System.Int32();
        }
        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        if (this.BlackoutWindowResponseInfo == null && Exploration.Includes(parent + ".blackoutWindowResponseInfo"))
        {
            this.BlackoutWindowResponseInfo = new BlackoutWindowResponseInfo();
            this.BlackoutWindowResponseInfo.ApplyExploratoryFieldSpec(parent + ".blackoutWindowResponseInfo");
        }
        //      C# -> MssqlDbSummary? MssqlDbSummary
        // GraphQL -> mssqlDbSummary: MssqlDbSummary (type)
        if (this.MssqlDbSummary == null && Exploration.Includes(parent + ".mssqlDbSummary"))
        {
            this.MssqlDbSummary = new MssqlDbSummary();
            this.MssqlDbSummary.ApplyExploratoryFieldSpec(parent + ".mssqlDbSummary");
        }
        //      C# -> MssqlScriptDetail? PostBackupScript
        // GraphQL -> postBackupScript: MssqlScriptDetail (type)
        if (this.PostBackupScript == null && Exploration.Includes(parent + ".postBackupScript"))
        {
            this.PostBackupScript = new MssqlScriptDetail();
            this.PostBackupScript.ApplyExploratoryFieldSpec(parent + ".postBackupScript");
        }
        //      C# -> MssqlScriptDetail? PreBackupScript
        // GraphQL -> preBackupScript: MssqlScriptDetail (type)
        if (this.PreBackupScript == null && Exploration.Includes(parent + ".preBackupScript"))
        {
            this.PreBackupScript = new MssqlScriptDetail();
            this.PreBackupScript.ApplyExploratoryFieldSpec(parent + ".preBackupScript");
        }
    }


    #endregion

    } // class MssqlDbDetail
    
    #endregion

    public static class ListMssqlDbDetailExtensions
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
            this List<MssqlDbDetail> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlDbDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlDbDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types