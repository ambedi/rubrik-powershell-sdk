// ActivitySeries.cs
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
    #region ActivitySeries
    public class ActivitySeries: BaseType
    {
        #region members

        //      C# -> ActivityStatusEnum? LastActivityStatus
        // GraphQL -> lastActivityStatus: ActivityStatusEnum! (enum)
        [JsonProperty("lastActivityStatus")]
        public ActivityStatusEnum? LastActivityStatus { get; set; }

        //      C# -> ActivityTypeEnum? LastActivityType
        // GraphQL -> lastActivityType: ActivityTypeEnum! (enum)
        [JsonProperty("lastActivityType")]
        public ActivityTypeEnum? LastActivityType { get; set; }

        //      C# -> ActivityObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ActivityObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public ActivityObjectTypeEnum? ObjectType { get; set; }

        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        [JsonProperty("severity")]
        public ActivitySeverityEnum? Severity { get; set; }

        //      C# -> System.String? ActivitySeriesId
        // GraphQL -> activitySeriesId: UUID! (scalar)
        [JsonProperty("activitySeriesId")]
        public System.String? ActivitySeriesId { get; set; }

        //      C# -> System.String? CauseErrorCode
        // GraphQL -> causeErrorCode: String (scalar)
        [JsonProperty("causeErrorCode")]
        public System.String? CauseErrorCode { get; set; }

        //      C# -> System.String? CauseErrorMessage
        // GraphQL -> causeErrorMessage: String (scalar)
        [JsonProperty("causeErrorMessage")]
        public System.String? CauseErrorMessage { get; set; }

        //      C# -> System.String? CauseErrorReason
        // GraphQL -> causeErrorReason: String (scalar)
        [JsonProperty("causeErrorReason")]
        public System.String? CauseErrorReason { get; set; }

        //      C# -> System.String? CauseErrorRemedy
        // GraphQL -> causeErrorRemedy: String (scalar)
        [JsonProperty("causeErrorRemedy")]
        public System.String? CauseErrorRemedy { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Int64? DataTransferred
        // GraphQL -> dataTransferred: Long (scalar)
        [JsonProperty("dataTransferred")]
        public System.Int64? DataTransferred { get; set; }

        //      C# -> System.Int64? EffectiveThroughput
        // GraphQL -> effectiveThroughput: Long (scalar)
        [JsonProperty("effectiveThroughput")]
        public System.Int64? EffectiveThroughput { get; set; }

        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        [JsonProperty("failureReason")]
        public System.String? FailureReason { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> System.Boolean? IsCancelable
        // GraphQL -> isCancelable: Boolean (scalar)
        [JsonProperty("isCancelable")]
        public System.Boolean? IsCancelable { get; set; }

        //      C# -> System.Boolean? IsPolarisEventSeries
        // GraphQL -> isPolarisEventSeries: Boolean! (scalar)
        [JsonProperty("isPolarisEventSeries")]
        public System.Boolean? IsPolarisEventSeries { get; set; }

        //      C# -> DateTime? LastEventAddedAt
        // GraphQL -> lastEventAddedAt: DateTime (scalar)
        [JsonProperty("lastEventAddedAt")]
        public DateTime? LastEventAddedAt { get; set; }

        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime! (scalar)
        [JsonProperty("lastUpdated")]
        public DateTime? LastUpdated { get; set; }

        //      C# -> DateTime? LastVerifiedAt
        // GraphQL -> lastVerifiedAt: DateTime (scalar)
        [JsonProperty("lastVerifiedAt")]
        public DateTime? LastVerifiedAt { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.Int64? LogicalSize
        // GraphQL -> logicalSize: Long (scalar)
        [JsonProperty("logicalSize")]
        public System.Int64? LogicalSize { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> System.String? Progress
        // GraphQL -> progress: String (scalar)
        [JsonProperty("progress")]
        public System.String? Progress { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> ActivityConnection? ActivityConnection
        // GraphQL -> activityConnection: ActivityConnection! (type)
        [JsonProperty("activityConnection")]
        public ActivityConnection? ActivityConnection { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> List<Org>? Organizations
        // GraphQL -> organizations: [Org!]! (type)
        [JsonProperty("organizations")]
        public List<Org>? Organizations { get; set; }


        #endregion

    #region methods

    public ActivitySeries Set(
        ActivityStatusEnum? LastActivityStatus = null,
        ActivityTypeEnum? LastActivityType = null,
        ActivityObjectTypeEnum? ObjectType = null,
        ActivitySeverityEnum? Severity = null,
        System.String? ActivitySeriesId = null,
        System.String? CauseErrorCode = null,
        System.String? CauseErrorMessage = null,
        System.String? CauseErrorReason = null,
        System.String? CauseErrorRemedy = null,
        System.String? ClusterName = null,
        System.String? ClusterUuid = null,
        System.Int64? DataTransferred = null,
        System.Int64? EffectiveThroughput = null,
        System.String? FailureReason = null,
        System.String? Fid = null,
        System.Int64? Id = null,
        System.Boolean? IsCancelable = null,
        System.Boolean? IsPolarisEventSeries = null,
        DateTime? LastEventAddedAt = null,
        DateTime? LastUpdated = null,
        DateTime? LastVerifiedAt = null,
        System.String? Location = null,
        System.Int64? LogicalSize = null,
        System.String? ObjectId = null,
        System.String? ObjectName = null,
        System.String? OrgId = null,
        System.String? OrgName = null,
        System.String? Progress = null,
        DateTime? StartTime = null,
        ActivityConnection? ActivityConnection = null,
        Cluster? Cluster = null,
        List<Org>? Organizations = null
    ) 
    {
        if ( LastActivityStatus != null ) {
            this.LastActivityStatus = LastActivityStatus;
        }
        if ( LastActivityType != null ) {
            this.LastActivityType = LastActivityType;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( ActivitySeriesId != null ) {
            this.ActivitySeriesId = ActivitySeriesId;
        }
        if ( CauseErrorCode != null ) {
            this.CauseErrorCode = CauseErrorCode;
        }
        if ( CauseErrorMessage != null ) {
            this.CauseErrorMessage = CauseErrorMessage;
        }
        if ( CauseErrorReason != null ) {
            this.CauseErrorReason = CauseErrorReason;
        }
        if ( CauseErrorRemedy != null ) {
            this.CauseErrorRemedy = CauseErrorRemedy;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DataTransferred != null ) {
            this.DataTransferred = DataTransferred;
        }
        if ( EffectiveThroughput != null ) {
            this.EffectiveThroughput = EffectiveThroughput;
        }
        if ( FailureReason != null ) {
            this.FailureReason = FailureReason;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsCancelable != null ) {
            this.IsCancelable = IsCancelable;
        }
        if ( IsPolarisEventSeries != null ) {
            this.IsPolarisEventSeries = IsPolarisEventSeries;
        }
        if ( LastEventAddedAt != null ) {
            this.LastEventAddedAt = LastEventAddedAt;
        }
        if ( LastUpdated != null ) {
            this.LastUpdated = LastUpdated;
        }
        if ( LastVerifiedAt != null ) {
            this.LastVerifiedAt = LastVerifiedAt;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( LogicalSize != null ) {
            this.LogicalSize = LogicalSize;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( OrgName != null ) {
            this.OrgName = OrgName;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( ActivityConnection != null ) {
            this.ActivityConnection = ActivityConnection;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( Organizations != null ) {
            this.Organizations = Organizations;
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
        //      C# -> ActivityStatusEnum? LastActivityStatus
        // GraphQL -> lastActivityStatus: ActivityStatusEnum! (enum)
        if (this.LastActivityStatus != null) {
            s += ind + "lastActivityStatus\n" ;
        }
        //      C# -> ActivityTypeEnum? LastActivityType
        // GraphQL -> lastActivityType: ActivityTypeEnum! (enum)
        if (this.LastActivityType != null) {
            s += ind + "lastActivityType\n" ;
        }
        //      C# -> ActivityObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ActivityObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (this.Severity != null) {
            s += ind + "severity\n" ;
        }
        //      C# -> System.String? ActivitySeriesId
        // GraphQL -> activitySeriesId: UUID! (scalar)
        if (this.ActivitySeriesId != null) {
            s += ind + "activitySeriesId\n" ;
        }
        //      C# -> System.String? CauseErrorCode
        // GraphQL -> causeErrorCode: String (scalar)
        if (this.CauseErrorCode != null) {
            s += ind + "causeErrorCode\n" ;
        }
        //      C# -> System.String? CauseErrorMessage
        // GraphQL -> causeErrorMessage: String (scalar)
        if (this.CauseErrorMessage != null) {
            s += ind + "causeErrorMessage\n" ;
        }
        //      C# -> System.String? CauseErrorReason
        // GraphQL -> causeErrorReason: String (scalar)
        if (this.CauseErrorReason != null) {
            s += ind + "causeErrorReason\n" ;
        }
        //      C# -> System.String? CauseErrorRemedy
        // GraphQL -> causeErrorRemedy: String (scalar)
        if (this.CauseErrorRemedy != null) {
            s += ind + "causeErrorRemedy\n" ;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            s += ind + "clusterName\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.Int64? DataTransferred
        // GraphQL -> dataTransferred: Long (scalar)
        if (this.DataTransferred != null) {
            s += ind + "dataTransferred\n" ;
        }
        //      C# -> System.Int64? EffectiveThroughput
        // GraphQL -> effectiveThroughput: Long (scalar)
        if (this.EffectiveThroughput != null) {
            s += ind + "effectiveThroughput\n" ;
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (this.FailureReason != null) {
            s += ind + "failureReason\n" ;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID (scalar)
        if (this.Fid != null) {
            s += ind + "fid\n" ;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsCancelable
        // GraphQL -> isCancelable: Boolean (scalar)
        if (this.IsCancelable != null) {
            s += ind + "isCancelable\n" ;
        }
        //      C# -> System.Boolean? IsPolarisEventSeries
        // GraphQL -> isPolarisEventSeries: Boolean! (scalar)
        if (this.IsPolarisEventSeries != null) {
            s += ind + "isPolarisEventSeries\n" ;
        }
        //      C# -> DateTime? LastEventAddedAt
        // GraphQL -> lastEventAddedAt: DateTime (scalar)
        if (this.LastEventAddedAt != null) {
            s += ind + "lastEventAddedAt\n" ;
        }
        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime! (scalar)
        if (this.LastUpdated != null) {
            s += ind + "lastUpdated\n" ;
        }
        //      C# -> DateTime? LastVerifiedAt
        // GraphQL -> lastVerifiedAt: DateTime (scalar)
        if (this.LastVerifiedAt != null) {
            s += ind + "lastVerifiedAt\n" ;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            s += ind + "location\n" ;
        }
        //      C# -> System.Int64? LogicalSize
        // GraphQL -> logicalSize: Long (scalar)
        if (this.LogicalSize != null) {
            s += ind + "logicalSize\n" ;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            s += ind + "objectId\n" ;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String (scalar)
        if (this.ObjectName != null) {
            s += ind + "objectName\n" ;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID (scalar)
        if (this.OrgId != null) {
            s += ind + "orgId\n" ;
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        if (this.OrgName != null) {
            s += ind + "orgName\n" ;
        }
        //      C# -> System.String? Progress
        // GraphQL -> progress: String (scalar)
        if (this.Progress != null) {
            s += ind + "progress\n" ;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> ActivityConnection? ActivityConnection
        // GraphQL -> activityConnection: ActivityConnection! (type)
        if (this.ActivityConnection != null) {
            s += ind + "activityConnection {\n" + this.ActivityConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            s += ind + "cluster {\n" + this.Cluster.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<Org>? Organizations
        // GraphQL -> organizations: [Org!]! (type)
        if (this.Organizations != null) {
            s += ind + "organizations {\n" + this.Organizations.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ActivityStatusEnum? LastActivityStatus
        // GraphQL -> lastActivityStatus: ActivityStatusEnum! (enum)
        if (this.LastActivityStatus == null && Exploration.Includes(parent + ".lastActivityStatus", true))
        {
            this.LastActivityStatus = new ActivityStatusEnum();
        }
        //      C# -> ActivityTypeEnum? LastActivityType
        // GraphQL -> lastActivityType: ActivityTypeEnum! (enum)
        if (this.LastActivityType == null && Exploration.Includes(parent + ".lastActivityType", true))
        {
            this.LastActivityType = new ActivityTypeEnum();
        }
        //      C# -> ActivityObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ActivityObjectTypeEnum! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new ActivityObjectTypeEnum();
        }
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (this.Severity == null && Exploration.Includes(parent + ".severity", true))
        {
            this.Severity = new ActivitySeverityEnum();
        }
        //      C# -> System.String? ActivitySeriesId
        // GraphQL -> activitySeriesId: UUID! (scalar)
        if (this.ActivitySeriesId == null && Exploration.Includes(parent + ".activitySeriesId", true))
        {
            this.ActivitySeriesId = new System.String("FETCH");
        }
        //      C# -> System.String? CauseErrorCode
        // GraphQL -> causeErrorCode: String (scalar)
        if (this.CauseErrorCode == null && Exploration.Includes(parent + ".causeErrorCode", true))
        {
            this.CauseErrorCode = new System.String("FETCH");
        }
        //      C# -> System.String? CauseErrorMessage
        // GraphQL -> causeErrorMessage: String (scalar)
        if (this.CauseErrorMessage == null && Exploration.Includes(parent + ".causeErrorMessage", true))
        {
            this.CauseErrorMessage = new System.String("FETCH");
        }
        //      C# -> System.String? CauseErrorReason
        // GraphQL -> causeErrorReason: String (scalar)
        if (this.CauseErrorReason == null && Exploration.Includes(parent + ".causeErrorReason", true))
        {
            this.CauseErrorReason = new System.String("FETCH");
        }
        //      C# -> System.String? CauseErrorRemedy
        // GraphQL -> causeErrorRemedy: String (scalar)
        if (this.CauseErrorRemedy == null && Exploration.Includes(parent + ".causeErrorRemedy", true))
        {
            this.CauseErrorRemedy = new System.String("FETCH");
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName", true))
        {
            this.ClusterName = new System.String("FETCH");
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = new System.String("FETCH");
        }
        //      C# -> System.Int64? DataTransferred
        // GraphQL -> dataTransferred: Long (scalar)
        if (this.DataTransferred == null && Exploration.Includes(parent + ".dataTransferred", true))
        {
            this.DataTransferred = new System.Int64();
        }
        //      C# -> System.Int64? EffectiveThroughput
        // GraphQL -> effectiveThroughput: Long (scalar)
        if (this.EffectiveThroughput == null && Exploration.Includes(parent + ".effectiveThroughput", true))
        {
            this.EffectiveThroughput = new System.Int64();
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (this.FailureReason == null && Exploration.Includes(parent + ".failureReason", true))
        {
            this.FailureReason = new System.String("FETCH");
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID (scalar)
        if (this.Fid == null && Exploration.Includes(parent + ".fid", true))
        {
            this.Fid = new System.String("FETCH");
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.Int64();
        }
        //      C# -> System.Boolean? IsCancelable
        // GraphQL -> isCancelable: Boolean (scalar)
        if (this.IsCancelable == null && Exploration.Includes(parent + ".isCancelable", true))
        {
            this.IsCancelable = true;
        }
        //      C# -> System.Boolean? IsPolarisEventSeries
        // GraphQL -> isPolarisEventSeries: Boolean! (scalar)
        if (this.IsPolarisEventSeries == null && Exploration.Includes(parent + ".isPolarisEventSeries", true))
        {
            this.IsPolarisEventSeries = true;
        }
        //      C# -> DateTime? LastEventAddedAt
        // GraphQL -> lastEventAddedAt: DateTime (scalar)
        if (this.LastEventAddedAt == null && Exploration.Includes(parent + ".lastEventAddedAt", true))
        {
            this.LastEventAddedAt = new DateTime();
        }
        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime! (scalar)
        if (this.LastUpdated == null && Exploration.Includes(parent + ".lastUpdated", true))
        {
            this.LastUpdated = new DateTime();
        }
        //      C# -> DateTime? LastVerifiedAt
        // GraphQL -> lastVerifiedAt: DateTime (scalar)
        if (this.LastVerifiedAt == null && Exploration.Includes(parent + ".lastVerifiedAt", true))
        {
            this.LastVerifiedAt = new DateTime();
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location == null && Exploration.Includes(parent + ".location", true))
        {
            this.Location = new System.String("FETCH");
        }
        //      C# -> System.Int64? LogicalSize
        // GraphQL -> logicalSize: Long (scalar)
        if (this.LogicalSize == null && Exploration.Includes(parent + ".logicalSize", true))
        {
            this.LogicalSize = new System.Int64();
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId == null && Exploration.Includes(parent + ".objectId", true))
        {
            this.ObjectId = new System.String("FETCH");
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String (scalar)
        if (this.ObjectName == null && Exploration.Includes(parent + ".objectName", true))
        {
            this.ObjectName = new System.String("FETCH");
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID (scalar)
        if (this.OrgId == null && Exploration.Includes(parent + ".orgId", true))
        {
            this.OrgId = new System.String("FETCH");
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        if (this.OrgName == null && Exploration.Includes(parent + ".orgName", true))
        {
            this.OrgName = new System.String("FETCH");
        }
        //      C# -> System.String? Progress
        // GraphQL -> progress: String (scalar)
        if (this.Progress == null && Exploration.Includes(parent + ".progress", true))
        {
            this.Progress = new System.String("FETCH");
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = new DateTime();
        }
        //      C# -> ActivityConnection? ActivityConnection
        // GraphQL -> activityConnection: ActivityConnection! (type)
        if (this.ActivityConnection == null && Exploration.Includes(parent + ".activityConnection"))
        {
            this.ActivityConnection = new ActivityConnection();
            this.ActivityConnection.ApplyExploratoryFieldSpec(parent + ".activityConnection");
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> List<Org>? Organizations
        // GraphQL -> organizations: [Org!]! (type)
        if (this.Organizations == null && Exploration.Includes(parent + ".organizations"))
        {
            this.Organizations = new List<Org>();
            this.Organizations.ApplyExploratoryFieldSpec(parent + ".organizations");
        }
    }


    #endregion

    } // class ActivitySeries
    
    #endregion

    public static class ListActivitySeriesExtensions
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
            this List<ActivitySeries> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ActivitySeries> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivitySeries());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types