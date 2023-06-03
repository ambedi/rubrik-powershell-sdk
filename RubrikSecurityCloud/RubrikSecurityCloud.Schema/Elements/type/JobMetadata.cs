// JobMetadata.cs
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
    #region JobMetadata
    public class JobMetadata: BaseType
    {
        #region members

        //      C# -> LogLevel? LogLevel
        // GraphQL -> logLevel: LogLevel! (enum)
        [JsonProperty("logLevel")]
        public LogLevel? LogLevel { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.Int32? CurrentInstance
        // GraphQL -> currentInstance: Int! (scalar)
        [JsonProperty("currentInstance")]
        public System.Int32? CurrentInstance { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        [JsonProperty("info")]
        public System.String? Info { get; set; }

        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        [JsonProperty("jobType")]
        public System.String? JobType { get; set; }

        //      C# -> DateTime? LastFailure
        // GraphQL -> lastFailure: DateTime (scalar)
        [JsonProperty("lastFailure")]
        public DateTime? LastFailure { get; set; }

        //      C# -> System.String? LastOwner
        // GraphQL -> lastOwner: String! (scalar)
        [JsonProperty("lastOwner")]
        public System.String? LastOwner { get; set; }

        //      C# -> DateTime? LastSkipped
        // GraphQL -> lastSkipped: DateTime (scalar)
        [JsonProperty("lastSkipped")]
        public DateTime? LastSkipped { get; set; }

        //      C# -> DateTime? LastSuccess
        // GraphQL -> lastSuccess: DateTime (scalar)
        [JsonProperty("lastSuccess")]
        public DateTime? LastSuccess { get; set; }

        //      C# -> System.Int32? NumScheduledRuns
        // GraphQL -> numScheduledRuns: Int! (scalar)
        [JsonProperty("numScheduledRuns")]
        public System.Int32? NumScheduledRuns { get; set; }

        //      C# -> System.Int32? NumSuccessfulRuns
        // GraphQL -> numSuccessfulRuns: Int! (scalar)
        [JsonProperty("numSuccessfulRuns")]
        public System.Int32? NumSuccessfulRuns { get; set; }

        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        [JsonProperty("owner")]
        public System.String? Owner { get; set; }

        //      C# -> System.String? Progress
        // GraphQL -> progress: String! (scalar)
        [JsonProperty("progress")]
        public System.String? Progress { get; set; }

        //      C# -> DateTime? ProgressedAt
        // GraphQL -> progressedAt: DateTime (scalar)
        [JsonProperty("progressedAt")]
        public DateTime? ProgressedAt { get; set; }

        //      C# -> System.Int32? RetryAttempts
        // GraphQL -> retryAttempts: Int! (scalar)
        [JsonProperty("retryAttempts")]
        public System.Int32? RetryAttempts { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> DateTime? StartedAt
        // GraphQL -> startedAt: DateTime (scalar)
        [JsonProperty("startedAt")]
        public DateTime? StartedAt { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }


        #endregion

    #region methods

    public JobMetadata Set(
        LogLevel? LogLevel = null,
        DateTime? CreatedAt = null,
        System.Int32? CurrentInstance = null,
        System.Int64? Id = null,
        System.String? Info = null,
        System.String? JobType = null,
        DateTime? LastFailure = null,
        System.String? LastOwner = null,
        DateTime? LastSkipped = null,
        DateTime? LastSuccess = null,
        System.Int32? NumScheduledRuns = null,
        System.Int32? NumSuccessfulRuns = null,
        System.String? Owner = null,
        System.String? Progress = null,
        DateTime? ProgressedAt = null,
        System.Int32? RetryAttempts = null,
        DateTime? StartTime = null,
        DateTime? StartedAt = null,
        System.String? State = null,
        DateTime? UpdatedAt = null
    ) 
    {
        if ( LogLevel != null ) {
            this.LogLevel = LogLevel;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( CurrentInstance != null ) {
            this.CurrentInstance = CurrentInstance;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Info != null ) {
            this.Info = Info;
        }
        if ( JobType != null ) {
            this.JobType = JobType;
        }
        if ( LastFailure != null ) {
            this.LastFailure = LastFailure;
        }
        if ( LastOwner != null ) {
            this.LastOwner = LastOwner;
        }
        if ( LastSkipped != null ) {
            this.LastSkipped = LastSkipped;
        }
        if ( LastSuccess != null ) {
            this.LastSuccess = LastSuccess;
        }
        if ( NumScheduledRuns != null ) {
            this.NumScheduledRuns = NumScheduledRuns;
        }
        if ( NumSuccessfulRuns != null ) {
            this.NumSuccessfulRuns = NumSuccessfulRuns;
        }
        if ( Owner != null ) {
            this.Owner = Owner;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( ProgressedAt != null ) {
            this.ProgressedAt = ProgressedAt;
        }
        if ( RetryAttempts != null ) {
            this.RetryAttempts = RetryAttempts;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( StartedAt != null ) {
            this.StartedAt = StartedAt;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
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
        //      C# -> LogLevel? LogLevel
        // GraphQL -> logLevel: LogLevel! (enum)
        if (this.LogLevel != null) {
            s += ind + "logLevel\n" ;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            s += ind + "createdAt\n" ;
        }
        //      C# -> System.Int32? CurrentInstance
        // GraphQL -> currentInstance: Int! (scalar)
        if (this.CurrentInstance != null) {
            s += ind + "currentInstance\n" ;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        if (this.Info != null) {
            s += ind + "info\n" ;
        }
        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        if (this.JobType != null) {
            s += ind + "jobType\n" ;
        }
        //      C# -> DateTime? LastFailure
        // GraphQL -> lastFailure: DateTime (scalar)
        if (this.LastFailure != null) {
            s += ind + "lastFailure\n" ;
        }
        //      C# -> System.String? LastOwner
        // GraphQL -> lastOwner: String! (scalar)
        if (this.LastOwner != null) {
            s += ind + "lastOwner\n" ;
        }
        //      C# -> DateTime? LastSkipped
        // GraphQL -> lastSkipped: DateTime (scalar)
        if (this.LastSkipped != null) {
            s += ind + "lastSkipped\n" ;
        }
        //      C# -> DateTime? LastSuccess
        // GraphQL -> lastSuccess: DateTime (scalar)
        if (this.LastSuccess != null) {
            s += ind + "lastSuccess\n" ;
        }
        //      C# -> System.Int32? NumScheduledRuns
        // GraphQL -> numScheduledRuns: Int! (scalar)
        if (this.NumScheduledRuns != null) {
            s += ind + "numScheduledRuns\n" ;
        }
        //      C# -> System.Int32? NumSuccessfulRuns
        // GraphQL -> numSuccessfulRuns: Int! (scalar)
        if (this.NumSuccessfulRuns != null) {
            s += ind + "numSuccessfulRuns\n" ;
        }
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        if (this.Owner != null) {
            s += ind + "owner\n" ;
        }
        //      C# -> System.String? Progress
        // GraphQL -> progress: String! (scalar)
        if (this.Progress != null) {
            s += ind + "progress\n" ;
        }
        //      C# -> DateTime? ProgressedAt
        // GraphQL -> progressedAt: DateTime (scalar)
        if (this.ProgressedAt != null) {
            s += ind + "progressedAt\n" ;
        }
        //      C# -> System.Int32? RetryAttempts
        // GraphQL -> retryAttempts: Int! (scalar)
        if (this.RetryAttempts != null) {
            s += ind + "retryAttempts\n" ;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> DateTime? StartedAt
        // GraphQL -> startedAt: DateTime (scalar)
        if (this.StartedAt != null) {
            s += ind + "startedAt\n" ;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            s += ind + "updatedAt\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> LogLevel? LogLevel
        // GraphQL -> logLevel: LogLevel! (enum)
        if (this.LogLevel == null && Exploration.Includes(parent + ".logLevel", true))
        {
            this.LogLevel = new LogLevel();
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt", true))
        {
            this.CreatedAt = new DateTime();
        }
        //      C# -> System.Int32? CurrentInstance
        // GraphQL -> currentInstance: Int! (scalar)
        if (this.CurrentInstance == null && Exploration.Includes(parent + ".currentInstance", true))
        {
            this.CurrentInstance = new System.Int32();
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.Int64();
        }
        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        if (this.Info == null && Exploration.Includes(parent + ".info", true))
        {
            this.Info = new System.String("FETCH");
        }
        //      C# -> System.String? JobType
        // GraphQL -> jobType: String! (scalar)
        if (this.JobType == null && Exploration.Includes(parent + ".jobType", true))
        {
            this.JobType = new System.String("FETCH");
        }
        //      C# -> DateTime? LastFailure
        // GraphQL -> lastFailure: DateTime (scalar)
        if (this.LastFailure == null && Exploration.Includes(parent + ".lastFailure", true))
        {
            this.LastFailure = new DateTime();
        }
        //      C# -> System.String? LastOwner
        // GraphQL -> lastOwner: String! (scalar)
        if (this.LastOwner == null && Exploration.Includes(parent + ".lastOwner", true))
        {
            this.LastOwner = new System.String("FETCH");
        }
        //      C# -> DateTime? LastSkipped
        // GraphQL -> lastSkipped: DateTime (scalar)
        if (this.LastSkipped == null && Exploration.Includes(parent + ".lastSkipped", true))
        {
            this.LastSkipped = new DateTime();
        }
        //      C# -> DateTime? LastSuccess
        // GraphQL -> lastSuccess: DateTime (scalar)
        if (this.LastSuccess == null && Exploration.Includes(parent + ".lastSuccess", true))
        {
            this.LastSuccess = new DateTime();
        }
        //      C# -> System.Int32? NumScheduledRuns
        // GraphQL -> numScheduledRuns: Int! (scalar)
        if (this.NumScheduledRuns == null && Exploration.Includes(parent + ".numScheduledRuns", true))
        {
            this.NumScheduledRuns = new System.Int32();
        }
        //      C# -> System.Int32? NumSuccessfulRuns
        // GraphQL -> numSuccessfulRuns: Int! (scalar)
        if (this.NumSuccessfulRuns == null && Exploration.Includes(parent + ".numSuccessfulRuns", true))
        {
            this.NumSuccessfulRuns = new System.Int32();
        }
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        if (this.Owner == null && Exploration.Includes(parent + ".owner", true))
        {
            this.Owner = new System.String("FETCH");
        }
        //      C# -> System.String? Progress
        // GraphQL -> progress: String! (scalar)
        if (this.Progress == null && Exploration.Includes(parent + ".progress", true))
        {
            this.Progress = new System.String("FETCH");
        }
        //      C# -> DateTime? ProgressedAt
        // GraphQL -> progressedAt: DateTime (scalar)
        if (this.ProgressedAt == null && Exploration.Includes(parent + ".progressedAt", true))
        {
            this.ProgressedAt = new DateTime();
        }
        //      C# -> System.Int32? RetryAttempts
        // GraphQL -> retryAttempts: Int! (scalar)
        if (this.RetryAttempts == null && Exploration.Includes(parent + ".retryAttempts", true))
        {
            this.RetryAttempts = new System.Int32();
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = new DateTime();
        }
        //      C# -> DateTime? StartedAt
        // GraphQL -> startedAt: DateTime (scalar)
        if (this.StartedAt == null && Exploration.Includes(parent + ".startedAt", true))
        {
            this.StartedAt = new DateTime();
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State == null && Exploration.Includes(parent + ".state", true))
        {
            this.State = new System.String("FETCH");
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt == null && Exploration.Includes(parent + ".updatedAt", true))
        {
            this.UpdatedAt = new DateTime();
        }
    }


    #endregion

    } // class JobMetadata
    
    #endregion

    public static class ListJobMetadataExtensions
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
            this List<JobMetadata> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<JobMetadata> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new JobMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types