// Cluster.cs
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
    #region Cluster
 
    public class Cluster: BaseType, ActivitySeriesGroupByInfo, AnomalyResultGroupByInfo, RansomwareResultGroupByInfo, SnappableGroupByInfo, TaskDetailGroupByInfo, TaskSummaryGroupByInfo
    {
        #region members

        //      C# -> List<Product>? LicensedProducts
        // GraphQL -> licensedProducts: [Product!]! (enum)
        [JsonProperty("licensedProducts")]
        public List<Product>? LicensedProducts { get; set; }

        //      C# -> ClusterPauseStatus? PauseStatus
        // GraphQL -> pauseStatus: ClusterPauseStatus (enum)
        [JsonProperty("pauseStatus")]
        public ClusterPauseStatus? PauseStatus { get; set; }

        //      C# -> ClusterProductEnum? ProductType
        // GraphQL -> productType: ClusterProductEnum (enum)
        [JsonProperty("productType")]
        public ClusterProductEnum? ProductType { get; set; }

        //      C# -> ClusterRegistrationMode? RegisteredMode
        // GraphQL -> registeredMode: ClusterRegistrationMode (enum)
        [JsonProperty("registeredMode")]
        public ClusterRegistrationMode? RegisteredMode { get; set; }

        //      C# -> ClusterStatus? Status
        // GraphQL -> status: ClusterStatus! (enum)
        [JsonProperty("status")]
        public ClusterStatus? Status { get; set; }

        //      C# -> ClusterSubStatus? SubStatus
        // GraphQL -> subStatus: ClusterSubStatus! (enum)
        [JsonProperty("subStatus")]
        public ClusterSubStatus? SubStatus { get; set; }

        //      C# -> ClusterSystemStatus? SystemStatus
        // GraphQL -> systemStatus: ClusterSystemStatus (enum)
        [JsonProperty("systemStatus")]
        public ClusterSystemStatus? SystemStatus { get; set; }

        //      C# -> ClusterTypeEnum? Type
        // GraphQL -> type: ClusterTypeEnum! (enum)
        [JsonProperty("type")]
        public ClusterTypeEnum? Type { get; set; }

        //      C# -> DateTime? ConnectivityLastUpdated
        // GraphQL -> connectivityLastUpdated: DateTime (scalar)
        [JsonProperty("connectivityLastUpdated")]
        public DateTime? ConnectivityLastUpdated { get; set; }

        //      C# -> System.String? DefaultAddress
        // GraphQL -> defaultAddress: String (scalar)
        [JsonProperty("defaultAddress")]
        public System.String? DefaultAddress { get; set; }

        //      C# -> System.Boolean? EncryptionEnabled
        // GraphQL -> encryptionEnabled: Boolean! (scalar)
        [JsonProperty("encryptionEnabled")]
        public System.Boolean? EncryptionEnabled { get; set; }

        //      C# -> System.Int64? EstimatedRunway
        // GraphQL -> estimatedRunway: Long! (scalar)
        [JsonProperty("estimatedRunway")]
        public System.Int64? EstimatedRunway { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        [JsonProperty("isHealthy")]
        public System.Boolean? IsHealthy { get; set; }

        //      C# -> DateTime? LastConnectionTime
        // GraphQL -> lastConnectionTime: DateTime (scalar)
        [JsonProperty("lastConnectionTime")]
        public DateTime? LastConnectionTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NoSqlWorkloadCount
        // GraphQL -> noSqlWorkloadCount: Int! (scalar)
        [JsonProperty("noSqlWorkloadCount")]
        public System.Int32? NoSqlWorkloadCount { get; set; }

        //      C# -> System.Boolean? PassesConnectivityCheck
        // GraphQL -> passesConnectivityCheck: Boolean (scalar)
        [JsonProperty("passesConnectivityCheck")]
        public System.Boolean? PassesConnectivityCheck { get; set; }

        //      C# -> DateTime? RegistrationTime
        // GraphQL -> registrationTime: DateTime! (scalar)
        [JsonProperty("registrationTime")]
        public DateTime? RegistrationTime { get; set; }

        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        [JsonProperty("snapshotCount")]
        public System.Int64? SnapshotCount { get; set; }

        //      C# -> System.String? SystemStatusMessage
        // GraphQL -> systemStatusMessage: String (scalar)
        [JsonProperty("systemStatusMessage")]
        public System.String? SystemStatusMessage { get; set; }

        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String (scalar)
        [JsonProperty("timezone")]
        public System.String? Timezone { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        [JsonProperty("activitySeriesConnection")]
        public ActivitySeriesConnection? ActivitySeriesConnection { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        [JsonProperty("authorizedOperations")]
        public AuthorizedOperations? AuthorizedOperations { get; set; }

        //      C# -> CcprovisionInfo? CcprovisionInfo
        // GraphQL -> ccprovisionInfo: CcprovisionInfo (type)
        [JsonProperty("ccprovisionInfo")]
        public CcprovisionInfo? CcprovisionInfo { get; set; }

        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        [JsonProperty("cdmClusterNodeDetails")]
        public List<CdmNodeDetail>? CdmClusterNodeDetails { get; set; }

        //      C# -> CdmUpgradeInfo? CdmUpgradeInfo
        // GraphQL -> cdmUpgradeInfo: CdmUpgradeInfo (type)
        [JsonProperty("cdmUpgradeInfo")]
        public CdmUpgradeInfo? CdmUpgradeInfo { get; set; }

        //      C# -> CcWithCloudInfo? CloudInfo
        // GraphQL -> cloudInfo: CcWithCloudInfo (type)
        [JsonProperty("cloudInfo")]
        public CcWithCloudInfo? CloudInfo { get; set; }

        //      C# -> ClusterDiskConnection? ClusterDiskConnection
        // GraphQL -> clusterDiskConnection: ClusterDiskConnection! (type)
        [JsonProperty("clusterDiskConnection")]
        public ClusterDiskConnection? ClusterDiskConnection { get; set; }

        //      C# -> ClusterNodeConnection? ClusterNodeConnection
        // GraphQL -> clusterNodeConnection: ClusterNodeConnection! (type)
        [JsonProperty("clusterNodeConnection")]
        public ClusterNodeConnection? ClusterNodeConnection { get; set; }

        //      C# -> List<ClusterNodeStats>? ClusterNodeStats
        // GraphQL -> clusterNodeStats: [ClusterNodeStats!]! (type)
        [JsonProperty("clusterNodeStats")]
        public List<ClusterNodeStats>? ClusterNodeStats { get; set; }

        //      C# -> ConfigProtectionInfo? ConfigProtectionInfo
        // GraphQL -> configProtectionInfo: ConfigProtectionInfo (type)
        [JsonProperty("configProtectionInfo")]
        public ConfigProtectionInfo? ConfigProtectionInfo { get; set; }

        //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
        // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
        [JsonProperty("datagovAutoEnablePolicyConfig")]
        public AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig { get; set; }

        //      C# -> PreviewerClusterConfig? DatagovPreviewerConfig
        // GraphQL -> datagovPreviewerConfig: PreviewerClusterConfig! (type)
        [JsonProperty("datagovPreviewerConfig")]
        public PreviewerClusterConfig? DatagovPreviewerConfig { get; set; }

        //      C# -> GeoLocation? GeoLocation
        // GraphQL -> geoLocation: GeoLocation (type)
        [JsonProperty("geoLocation")]
        public GeoLocation? GeoLocation { get; set; }

        //      C# -> GlobalManagerConnectivity? GlobalManagerConnectivityStatus
        // GraphQL -> globalManagerConnectivityStatus: GlobalManagerConnectivity (type)
        [JsonProperty("globalManagerConnectivityStatus")]
        public GlobalManagerConnectivity? GlobalManagerConnectivityStatus { get; set; }

        //      C# -> GetLambdaConfigReply? LambdaConfig
        // GraphQL -> lambdaConfig: GetLambdaConfigReply (type)
        [JsonProperty("lambdaConfig")]
        public GetLambdaConfigReply? LambdaConfig { get; set; }

        //      C# -> LambdaFeatureHistory? LambdaFeatureHistory
        // GraphQL -> lambdaFeatureHistory: LambdaFeatureHistory (type)
        [JsonProperty("lambdaFeatureHistory")]
        public LambdaFeatureHistory? LambdaFeatureHistory { get; set; }

        //      C# -> JobsReply? MetadataPullScheduler
        // GraphQL -> metadataPullScheduler: JobsReply (type)
        [JsonProperty("metadataPullScheduler")]
        public JobsReply? MetadataPullScheduler { get; set; }

        //      C# -> ClusterMetric? Metric
        // GraphQL -> metric: ClusterMetric (type)
        [JsonProperty("metric")]
        public ClusterMetric? Metric { get; set; }

        //      C# -> List<MetricTimeSeries>? MetricTimeSeries
        // GraphQL -> metricTimeSeries: [metricTimeSeries!]! (type)
        [JsonProperty("metricTimeSeries")]
        public List<MetricTimeSeries>? MetricTimeSeries { get; set; }

        //      C# -> List<ReplicationSource>? ReplicationSources
        // GraphQL -> replicationSources: [ReplicationSource!]! (type)
        [JsonProperty("replicationSources")]
        public List<ReplicationSource>? ReplicationSources { get; set; }

        //      C# -> List<ReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [ReplicationTarget!]! (type)
        [JsonProperty("replicationTargets")]
        public List<ReplicationTarget>? ReplicationTargets { get; set; }

        //      C# -> RubrikSyncStatus? RubrikSyncStatus
        // GraphQL -> rubrikSyncStatus: RubrikSyncStatus! (type)
        [JsonProperty("rubrikSyncStatus")]
        public RubrikSyncStatus? RubrikSyncStatus { get; set; }

        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        [JsonProperty("snappableConnection")]
        public SnappableConnection? SnappableConnection { get; set; }

        //      C# -> ClusterState? State
        // GraphQL -> state: clusterState! (type)
        [JsonProperty("state")]
        public ClusterState? State { get; set; }

        //      C# -> List<ClusterNode>? SystemStatusAffectedNodes
        // GraphQL -> systemStatusAffectedNodes: [ClusterNode!] (type)
        [JsonProperty("systemStatusAffectedNodes")]
        public List<ClusterNode>? SystemStatusAffectedNodes { get; set; }


        #endregion

    #region methods

    public Cluster Set(
        List<Product>? LicensedProducts = null,
        ClusterPauseStatus? PauseStatus = null,
        ClusterProductEnum? ProductType = null,
        ClusterRegistrationMode? RegisteredMode = null,
        ClusterStatus? Status = null,
        ClusterSubStatus? SubStatus = null,
        ClusterSystemStatus? SystemStatus = null,
        ClusterTypeEnum? Type = null,
        DateTime? ConnectivityLastUpdated = null,
        System.String? DefaultAddress = null,
        System.Boolean? EncryptionEnabled = null,
        System.Int64? EstimatedRunway = null,
        System.String? Id = null,
        System.Boolean? IsHealthy = null,
        DateTime? LastConnectionTime = null,
        System.String? Name = null,
        System.Int32? NoSqlWorkloadCount = null,
        System.Boolean? PassesConnectivityCheck = null,
        DateTime? RegistrationTime = null,
        System.Int64? SnapshotCount = null,
        System.String? SystemStatusMessage = null,
        System.String? Timezone = null,
        System.String? Version = null,
        ActivitySeriesConnection? ActivitySeriesConnection = null,
        List<Org>? AllOrgs = null,
        AuthorizedOperations? AuthorizedOperations = null,
        CcprovisionInfo? CcprovisionInfo = null,
        List<CdmNodeDetail>? CdmClusterNodeDetails = null,
        CdmUpgradeInfo? CdmUpgradeInfo = null,
        CcWithCloudInfo? CloudInfo = null,
        ClusterDiskConnection? ClusterDiskConnection = null,
        ClusterNodeConnection? ClusterNodeConnection = null,
        List<ClusterNodeStats>? ClusterNodeStats = null,
        ConfigProtectionInfo? ConfigProtectionInfo = null,
        AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig = null,
        PreviewerClusterConfig? DatagovPreviewerConfig = null,
        GeoLocation? GeoLocation = null,
        GlobalManagerConnectivity? GlobalManagerConnectivityStatus = null,
        GetLambdaConfigReply? LambdaConfig = null,
        LambdaFeatureHistory? LambdaFeatureHistory = null,
        JobsReply? MetadataPullScheduler = null,
        ClusterMetric? Metric = null,
        List<MetricTimeSeries>? MetricTimeSeries = null,
        List<ReplicationSource>? ReplicationSources = null,
        List<ReplicationTarget>? ReplicationTargets = null,
        RubrikSyncStatus? RubrikSyncStatus = null,
        SnappableConnection? SnappableConnection = null,
        ClusterState? State = null,
        List<ClusterNode>? SystemStatusAffectedNodes = null
    ) 
    {
        if ( LicensedProducts != null ) {
            this.LicensedProducts = LicensedProducts;
        }
        if ( PauseStatus != null ) {
            this.PauseStatus = PauseStatus;
        }
        if ( ProductType != null ) {
            this.ProductType = ProductType;
        }
        if ( RegisteredMode != null ) {
            this.RegisteredMode = RegisteredMode;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( SubStatus != null ) {
            this.SubStatus = SubStatus;
        }
        if ( SystemStatus != null ) {
            this.SystemStatus = SystemStatus;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( ConnectivityLastUpdated != null ) {
            this.ConnectivityLastUpdated = ConnectivityLastUpdated;
        }
        if ( DefaultAddress != null ) {
            this.DefaultAddress = DefaultAddress;
        }
        if ( EncryptionEnabled != null ) {
            this.EncryptionEnabled = EncryptionEnabled;
        }
        if ( EstimatedRunway != null ) {
            this.EstimatedRunway = EstimatedRunway;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsHealthy != null ) {
            this.IsHealthy = IsHealthy;
        }
        if ( LastConnectionTime != null ) {
            this.LastConnectionTime = LastConnectionTime;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NoSqlWorkloadCount != null ) {
            this.NoSqlWorkloadCount = NoSqlWorkloadCount;
        }
        if ( PassesConnectivityCheck != null ) {
            this.PassesConnectivityCheck = PassesConnectivityCheck;
        }
        if ( RegistrationTime != null ) {
            this.RegistrationTime = RegistrationTime;
        }
        if ( SnapshotCount != null ) {
            this.SnapshotCount = SnapshotCount;
        }
        if ( SystemStatusMessage != null ) {
            this.SystemStatusMessage = SystemStatusMessage;
        }
        if ( Timezone != null ) {
            this.Timezone = Timezone;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( ActivitySeriesConnection != null ) {
            this.ActivitySeriesConnection = ActivitySeriesConnection;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( CcprovisionInfo != null ) {
            this.CcprovisionInfo = CcprovisionInfo;
        }
        if ( CdmClusterNodeDetails != null ) {
            this.CdmClusterNodeDetails = CdmClusterNodeDetails;
        }
        if ( CdmUpgradeInfo != null ) {
            this.CdmUpgradeInfo = CdmUpgradeInfo;
        }
        if ( CloudInfo != null ) {
            this.CloudInfo = CloudInfo;
        }
        if ( ClusterDiskConnection != null ) {
            this.ClusterDiskConnection = ClusterDiskConnection;
        }
        if ( ClusterNodeConnection != null ) {
            this.ClusterNodeConnection = ClusterNodeConnection;
        }
        if ( ClusterNodeStats != null ) {
            this.ClusterNodeStats = ClusterNodeStats;
        }
        if ( ConfigProtectionInfo != null ) {
            this.ConfigProtectionInfo = ConfigProtectionInfo;
        }
        if ( DatagovAutoEnablePolicyConfig != null ) {
            this.DatagovAutoEnablePolicyConfig = DatagovAutoEnablePolicyConfig;
        }
        if ( DatagovPreviewerConfig != null ) {
            this.DatagovPreviewerConfig = DatagovPreviewerConfig;
        }
        if ( GeoLocation != null ) {
            this.GeoLocation = GeoLocation;
        }
        if ( GlobalManagerConnectivityStatus != null ) {
            this.GlobalManagerConnectivityStatus = GlobalManagerConnectivityStatus;
        }
        if ( LambdaConfig != null ) {
            this.LambdaConfig = LambdaConfig;
        }
        if ( LambdaFeatureHistory != null ) {
            this.LambdaFeatureHistory = LambdaFeatureHistory;
        }
        if ( MetadataPullScheduler != null ) {
            this.MetadataPullScheduler = MetadataPullScheduler;
        }
        if ( Metric != null ) {
            this.Metric = Metric;
        }
        if ( MetricTimeSeries != null ) {
            this.MetricTimeSeries = MetricTimeSeries;
        }
        if ( ReplicationSources != null ) {
            this.ReplicationSources = ReplicationSources;
        }
        if ( ReplicationTargets != null ) {
            this.ReplicationTargets = ReplicationTargets;
        }
        if ( RubrikSyncStatus != null ) {
            this.RubrikSyncStatus = RubrikSyncStatus;
        }
        if ( SnappableConnection != null ) {
            this.SnappableConnection = SnappableConnection;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( SystemStatusAffectedNodes != null ) {
            this.SystemStatusAffectedNodes = SystemStatusAffectedNodes;
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
        //      C# -> List<Product>? LicensedProducts
        // GraphQL -> licensedProducts: [Product!]! (enum)
        if (this.LicensedProducts != null) {
            s += ind + "licensedProducts\n" ;
        }
        //      C# -> ClusterPauseStatus? PauseStatus
        // GraphQL -> pauseStatus: ClusterPauseStatus (enum)
        if (this.PauseStatus != null) {
            s += ind + "pauseStatus\n" ;
        }
        //      C# -> ClusterProductEnum? ProductType
        // GraphQL -> productType: ClusterProductEnum (enum)
        if (this.ProductType != null) {
            s += ind + "productType\n" ;
        }
        //      C# -> ClusterRegistrationMode? RegisteredMode
        // GraphQL -> registeredMode: ClusterRegistrationMode (enum)
        if (this.RegisteredMode != null) {
            s += ind + "registeredMode\n" ;
        }
        //      C# -> ClusterStatus? Status
        // GraphQL -> status: ClusterStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> ClusterSubStatus? SubStatus
        // GraphQL -> subStatus: ClusterSubStatus! (enum)
        if (this.SubStatus != null) {
            s += ind + "subStatus\n" ;
        }
        //      C# -> ClusterSystemStatus? SystemStatus
        // GraphQL -> systemStatus: ClusterSystemStatus (enum)
        if (this.SystemStatus != null) {
            s += ind + "systemStatus\n" ;
        }
        //      C# -> ClusterTypeEnum? Type
        // GraphQL -> type: ClusterTypeEnum! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> DateTime? ConnectivityLastUpdated
        // GraphQL -> connectivityLastUpdated: DateTime (scalar)
        if (this.ConnectivityLastUpdated != null) {
            s += ind + "connectivityLastUpdated\n" ;
        }
        //      C# -> System.String? DefaultAddress
        // GraphQL -> defaultAddress: String (scalar)
        if (this.DefaultAddress != null) {
            s += ind + "defaultAddress\n" ;
        }
        //      C# -> System.Boolean? EncryptionEnabled
        // GraphQL -> encryptionEnabled: Boolean! (scalar)
        if (this.EncryptionEnabled != null) {
            s += ind + "encryptionEnabled\n" ;
        }
        //      C# -> System.Int64? EstimatedRunway
        // GraphQL -> estimatedRunway: Long! (scalar)
        if (this.EstimatedRunway != null) {
            s += ind + "estimatedRunway\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        if (this.IsHealthy != null) {
            s += ind + "isHealthy\n" ;
        }
        //      C# -> DateTime? LastConnectionTime
        // GraphQL -> lastConnectionTime: DateTime (scalar)
        if (this.LastConnectionTime != null) {
            s += ind + "lastConnectionTime\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NoSqlWorkloadCount
        // GraphQL -> noSqlWorkloadCount: Int! (scalar)
        if (this.NoSqlWorkloadCount != null) {
            s += ind + "noSqlWorkloadCount\n" ;
        }
        //      C# -> System.Boolean? PassesConnectivityCheck
        // GraphQL -> passesConnectivityCheck: Boolean (scalar)
        if (this.PassesConnectivityCheck != null) {
            s += ind + "passesConnectivityCheck\n" ;
        }
        //      C# -> DateTime? RegistrationTime
        // GraphQL -> registrationTime: DateTime! (scalar)
        if (this.RegistrationTime != null) {
            s += ind + "registrationTime\n" ;
        }
        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        if (this.SnapshotCount != null) {
            s += ind + "snapshotCount\n" ;
        }
        //      C# -> System.String? SystemStatusMessage
        // GraphQL -> systemStatusMessage: String (scalar)
        if (this.SystemStatusMessage != null) {
            s += ind + "systemStatusMessage\n" ;
        }
        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String (scalar)
        if (this.Timezone != null) {
            s += ind + "timezone\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        if (this.ActivitySeriesConnection != null) {
            s += ind + "activitySeriesConnection {\n" + this.ActivitySeriesConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            s += ind + "allOrgs {\n" + this.AllOrgs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations != null) {
            s += ind + "authorizedOperations {\n" + this.AuthorizedOperations.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CcprovisionInfo? CcprovisionInfo
        // GraphQL -> ccprovisionInfo: CcprovisionInfo (type)
        if (this.CcprovisionInfo != null) {
            s += ind + "ccprovisionInfo {\n" + this.CcprovisionInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        if (this.CdmClusterNodeDetails != null) {
            s += ind + "cdmClusterNodeDetails {\n" + this.CdmClusterNodeDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmUpgradeInfo? CdmUpgradeInfo
        // GraphQL -> cdmUpgradeInfo: CdmUpgradeInfo (type)
        if (this.CdmUpgradeInfo != null) {
            s += ind + "cdmUpgradeInfo {\n" + this.CdmUpgradeInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CcWithCloudInfo? CloudInfo
        // GraphQL -> cloudInfo: CcWithCloudInfo (type)
        if (this.CloudInfo != null) {
            s += ind + "cloudInfo {\n" + this.CloudInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ClusterDiskConnection? ClusterDiskConnection
        // GraphQL -> clusterDiskConnection: ClusterDiskConnection! (type)
        if (this.ClusterDiskConnection != null) {
            s += ind + "clusterDiskConnection {\n" + this.ClusterDiskConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ClusterNodeConnection? ClusterNodeConnection
        // GraphQL -> clusterNodeConnection: ClusterNodeConnection! (type)
        if (this.ClusterNodeConnection != null) {
            s += ind + "clusterNodeConnection {\n" + this.ClusterNodeConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ClusterNodeStats>? ClusterNodeStats
        // GraphQL -> clusterNodeStats: [ClusterNodeStats!]! (type)
        if (this.ClusterNodeStats != null) {
            s += ind + "clusterNodeStats {\n" + this.ClusterNodeStats.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ConfigProtectionInfo? ConfigProtectionInfo
        // GraphQL -> configProtectionInfo: ConfigProtectionInfo (type)
        if (this.ConfigProtectionInfo != null) {
            s += ind + "configProtectionInfo {\n" + this.ConfigProtectionInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
        // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
        if (this.DatagovAutoEnablePolicyConfig != null) {
            s += ind + "datagovAutoEnablePolicyConfig {\n" + this.DatagovAutoEnablePolicyConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PreviewerClusterConfig? DatagovPreviewerConfig
        // GraphQL -> datagovPreviewerConfig: PreviewerClusterConfig! (type)
        if (this.DatagovPreviewerConfig != null) {
            s += ind + "datagovPreviewerConfig {\n" + this.DatagovPreviewerConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> GeoLocation? GeoLocation
        // GraphQL -> geoLocation: GeoLocation (type)
        if (this.GeoLocation != null) {
            s += ind + "geoLocation {\n" + this.GeoLocation.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> GlobalManagerConnectivity? GlobalManagerConnectivityStatus
        // GraphQL -> globalManagerConnectivityStatus: GlobalManagerConnectivity (type)
        if (this.GlobalManagerConnectivityStatus != null) {
            s += ind + "globalManagerConnectivityStatus {\n" + this.GlobalManagerConnectivityStatus.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> GetLambdaConfigReply? LambdaConfig
        // GraphQL -> lambdaConfig: GetLambdaConfigReply (type)
        if (this.LambdaConfig != null) {
            s += ind + "lambdaConfig {\n" + this.LambdaConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> LambdaFeatureHistory? LambdaFeatureHistory
        // GraphQL -> lambdaFeatureHistory: LambdaFeatureHistory (type)
        if (this.LambdaFeatureHistory != null) {
            s += ind + "lambdaFeatureHistory {\n" + this.LambdaFeatureHistory.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> JobsReply? MetadataPullScheduler
        // GraphQL -> metadataPullScheduler: JobsReply (type)
        if (this.MetadataPullScheduler != null) {
            s += ind + "metadataPullScheduler {\n" + this.MetadataPullScheduler.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ClusterMetric? Metric
        // GraphQL -> metric: ClusterMetric (type)
        if (this.Metric != null) {
            s += ind + "metric {\n" + this.Metric.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<MetricTimeSeries>? MetricTimeSeries
        // GraphQL -> metricTimeSeries: [metricTimeSeries!]! (type)
        if (this.MetricTimeSeries != null) {
            s += ind + "metricTimeSeries {\n" + this.MetricTimeSeries.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ReplicationSource>? ReplicationSources
        // GraphQL -> replicationSources: [ReplicationSource!]! (type)
        if (this.ReplicationSources != null) {
            s += ind + "replicationSources {\n" + this.ReplicationSources.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [ReplicationTarget!]! (type)
        if (this.ReplicationTargets != null) {
            s += ind + "replicationTargets {\n" + this.ReplicationTargets.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> RubrikSyncStatus? RubrikSyncStatus
        // GraphQL -> rubrikSyncStatus: RubrikSyncStatus! (type)
        if (this.RubrikSyncStatus != null) {
            s += ind + "rubrikSyncStatus {\n" + this.RubrikSyncStatus.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        if (this.SnappableConnection != null) {
            s += ind + "snappableConnection {\n" + this.SnappableConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ClusterState? State
        // GraphQL -> state: clusterState! (type)
        if (this.State != null) {
            s += ind + "state {\n" + this.State.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ClusterNode>? SystemStatusAffectedNodes
        // GraphQL -> systemStatusAffectedNodes: [ClusterNode!] (type)
        if (this.SystemStatusAffectedNodes != null) {
            s += ind + "systemStatusAffectedNodes {\n" + this.SystemStatusAffectedNodes.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<Product>? LicensedProducts
        // GraphQL -> licensedProducts: [Product!]! (enum)
        if (this.LicensedProducts == null && Exploration.Includes(parent + ".licensedProducts", true))
        {
            this.LicensedProducts = new List<Product>();
        }
        //      C# -> ClusterPauseStatus? PauseStatus
        // GraphQL -> pauseStatus: ClusterPauseStatus (enum)
        if (this.PauseStatus == null && Exploration.Includes(parent + ".pauseStatus", true))
        {
            this.PauseStatus = new ClusterPauseStatus();
        }
        //      C# -> ClusterProductEnum? ProductType
        // GraphQL -> productType: ClusterProductEnum (enum)
        if (this.ProductType == null && Exploration.Includes(parent + ".productType", true))
        {
            this.ProductType = new ClusterProductEnum();
        }
        //      C# -> ClusterRegistrationMode? RegisteredMode
        // GraphQL -> registeredMode: ClusterRegistrationMode (enum)
        if (this.RegisteredMode == null && Exploration.Includes(parent + ".registeredMode", true))
        {
            this.RegisteredMode = new ClusterRegistrationMode();
        }
        //      C# -> ClusterStatus? Status
        // GraphQL -> status: ClusterStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new ClusterStatus();
        }
        //      C# -> ClusterSubStatus? SubStatus
        // GraphQL -> subStatus: ClusterSubStatus! (enum)
        if (this.SubStatus == null && Exploration.Includes(parent + ".subStatus", true))
        {
            this.SubStatus = new ClusterSubStatus();
        }
        //      C# -> ClusterSystemStatus? SystemStatus
        // GraphQL -> systemStatus: ClusterSystemStatus (enum)
        if (this.SystemStatus == null && Exploration.Includes(parent + ".systemStatus", true))
        {
            this.SystemStatus = new ClusterSystemStatus();
        }
        //      C# -> ClusterTypeEnum? Type
        // GraphQL -> type: ClusterTypeEnum! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new ClusterTypeEnum();
        }
        //      C# -> DateTime? ConnectivityLastUpdated
        // GraphQL -> connectivityLastUpdated: DateTime (scalar)
        if (this.ConnectivityLastUpdated == null && Exploration.Includes(parent + ".connectivityLastUpdated", true))
        {
            this.ConnectivityLastUpdated = new DateTime();
        }
        //      C# -> System.String? DefaultAddress
        // GraphQL -> defaultAddress: String (scalar)
        if (this.DefaultAddress == null && Exploration.Includes(parent + ".defaultAddress", true))
        {
            this.DefaultAddress = new System.String("FETCH");
        }
        //      C# -> System.Boolean? EncryptionEnabled
        // GraphQL -> encryptionEnabled: Boolean! (scalar)
        if (this.EncryptionEnabled == null && Exploration.Includes(parent + ".encryptionEnabled", true))
        {
            this.EncryptionEnabled = true;
        }
        //      C# -> System.Int64? EstimatedRunway
        // GraphQL -> estimatedRunway: Long! (scalar)
        if (this.EstimatedRunway == null && Exploration.Includes(parent + ".estimatedRunway", true))
        {
            this.EstimatedRunway = new System.Int64();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        if (this.IsHealthy == null && Exploration.Includes(parent + ".isHealthy", true))
        {
            this.IsHealthy = true;
        }
        //      C# -> DateTime? LastConnectionTime
        // GraphQL -> lastConnectionTime: DateTime (scalar)
        if (this.LastConnectionTime == null && Exploration.Includes(parent + ".lastConnectionTime", true))
        {
            this.LastConnectionTime = new DateTime();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> System.Int32? NoSqlWorkloadCount
        // GraphQL -> noSqlWorkloadCount: Int! (scalar)
        if (this.NoSqlWorkloadCount == null && Exploration.Includes(parent + ".noSqlWorkloadCount", true))
        {
            this.NoSqlWorkloadCount = new System.Int32();
        }
        //      C# -> System.Boolean? PassesConnectivityCheck
        // GraphQL -> passesConnectivityCheck: Boolean (scalar)
        if (this.PassesConnectivityCheck == null && Exploration.Includes(parent + ".passesConnectivityCheck", true))
        {
            this.PassesConnectivityCheck = true;
        }
        //      C# -> DateTime? RegistrationTime
        // GraphQL -> registrationTime: DateTime! (scalar)
        if (this.RegistrationTime == null && Exploration.Includes(parent + ".registrationTime", true))
        {
            this.RegistrationTime = new DateTime();
        }
        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        if (this.SnapshotCount == null && Exploration.Includes(parent + ".snapshotCount", true))
        {
            this.SnapshotCount = new System.Int64();
        }
        //      C# -> System.String? SystemStatusMessage
        // GraphQL -> systemStatusMessage: String (scalar)
        if (this.SystemStatusMessage == null && Exploration.Includes(parent + ".systemStatusMessage", true))
        {
            this.SystemStatusMessage = new System.String("FETCH");
        }
        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String (scalar)
        if (this.Timezone == null && Exploration.Includes(parent + ".timezone", true))
        {
            this.Timezone = new System.String("FETCH");
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = new System.String("FETCH");
        }
        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        if (this.ActivitySeriesConnection == null && Exploration.Includes(parent + ".activitySeriesConnection"))
        {
            this.ActivitySeriesConnection = new ActivitySeriesConnection();
            this.ActivitySeriesConnection.ApplyExploratoryFieldSpec(parent + ".activitySeriesConnection");
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(parent + ".allOrgs");
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations"))
        {
            this.AuthorizedOperations = new AuthorizedOperations();
            this.AuthorizedOperations.ApplyExploratoryFieldSpec(parent + ".authorizedOperations");
        }
        //      C# -> CcprovisionInfo? CcprovisionInfo
        // GraphQL -> ccprovisionInfo: CcprovisionInfo (type)
        if (this.CcprovisionInfo == null && Exploration.Includes(parent + ".ccprovisionInfo"))
        {
            this.CcprovisionInfo = new CcprovisionInfo();
            this.CcprovisionInfo.ApplyExploratoryFieldSpec(parent + ".ccprovisionInfo");
        }
        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        if (this.CdmClusterNodeDetails == null && Exploration.Includes(parent + ".cdmClusterNodeDetails"))
        {
            this.CdmClusterNodeDetails = new List<CdmNodeDetail>();
            this.CdmClusterNodeDetails.ApplyExploratoryFieldSpec(parent + ".cdmClusterNodeDetails");
        }
        //      C# -> CdmUpgradeInfo? CdmUpgradeInfo
        // GraphQL -> cdmUpgradeInfo: CdmUpgradeInfo (type)
        if (this.CdmUpgradeInfo == null && Exploration.Includes(parent + ".cdmUpgradeInfo"))
        {
            this.CdmUpgradeInfo = new CdmUpgradeInfo();
            this.CdmUpgradeInfo.ApplyExploratoryFieldSpec(parent + ".cdmUpgradeInfo");
        }
        //      C# -> CcWithCloudInfo? CloudInfo
        // GraphQL -> cloudInfo: CcWithCloudInfo (type)
        if (this.CloudInfo == null && Exploration.Includes(parent + ".cloudInfo"))
        {
            this.CloudInfo = new CcWithCloudInfo();
            this.CloudInfo.ApplyExploratoryFieldSpec(parent + ".cloudInfo");
        }
        //      C# -> ClusterDiskConnection? ClusterDiskConnection
        // GraphQL -> clusterDiskConnection: ClusterDiskConnection! (type)
        if (this.ClusterDiskConnection == null && Exploration.Includes(parent + ".clusterDiskConnection"))
        {
            this.ClusterDiskConnection = new ClusterDiskConnection();
            this.ClusterDiskConnection.ApplyExploratoryFieldSpec(parent + ".clusterDiskConnection");
        }
        //      C# -> ClusterNodeConnection? ClusterNodeConnection
        // GraphQL -> clusterNodeConnection: ClusterNodeConnection! (type)
        if (this.ClusterNodeConnection == null && Exploration.Includes(parent + ".clusterNodeConnection"))
        {
            this.ClusterNodeConnection = new ClusterNodeConnection();
            this.ClusterNodeConnection.ApplyExploratoryFieldSpec(parent + ".clusterNodeConnection");
        }
        //      C# -> List<ClusterNodeStats>? ClusterNodeStats
        // GraphQL -> clusterNodeStats: [ClusterNodeStats!]! (type)
        if (this.ClusterNodeStats == null && Exploration.Includes(parent + ".clusterNodeStats"))
        {
            this.ClusterNodeStats = new List<ClusterNodeStats>();
            this.ClusterNodeStats.ApplyExploratoryFieldSpec(parent + ".clusterNodeStats");
        }
        //      C# -> ConfigProtectionInfo? ConfigProtectionInfo
        // GraphQL -> configProtectionInfo: ConfigProtectionInfo (type)
        if (this.ConfigProtectionInfo == null && Exploration.Includes(parent + ".configProtectionInfo"))
        {
            this.ConfigProtectionInfo = new ConfigProtectionInfo();
            this.ConfigProtectionInfo.ApplyExploratoryFieldSpec(parent + ".configProtectionInfo");
        }
        //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
        // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
        if (this.DatagovAutoEnablePolicyConfig == null && Exploration.Includes(parent + ".datagovAutoEnablePolicyConfig"))
        {
            this.DatagovAutoEnablePolicyConfig = new AutoEnablePolicyClusterConfigReply();
            this.DatagovAutoEnablePolicyConfig.ApplyExploratoryFieldSpec(parent + ".datagovAutoEnablePolicyConfig");
        }
        //      C# -> PreviewerClusterConfig? DatagovPreviewerConfig
        // GraphQL -> datagovPreviewerConfig: PreviewerClusterConfig! (type)
        if (this.DatagovPreviewerConfig == null && Exploration.Includes(parent + ".datagovPreviewerConfig"))
        {
            this.DatagovPreviewerConfig = new PreviewerClusterConfig();
            this.DatagovPreviewerConfig.ApplyExploratoryFieldSpec(parent + ".datagovPreviewerConfig");
        }
        //      C# -> GeoLocation? GeoLocation
        // GraphQL -> geoLocation: GeoLocation (type)
        if (this.GeoLocation == null && Exploration.Includes(parent + ".geoLocation"))
        {
            this.GeoLocation = new GeoLocation();
            this.GeoLocation.ApplyExploratoryFieldSpec(parent + ".geoLocation");
        }
        //      C# -> GlobalManagerConnectivity? GlobalManagerConnectivityStatus
        // GraphQL -> globalManagerConnectivityStatus: GlobalManagerConnectivity (type)
        if (this.GlobalManagerConnectivityStatus == null && Exploration.Includes(parent + ".globalManagerConnectivityStatus"))
        {
            this.GlobalManagerConnectivityStatus = new GlobalManagerConnectivity();
            this.GlobalManagerConnectivityStatus.ApplyExploratoryFieldSpec(parent + ".globalManagerConnectivityStatus");
        }
        //      C# -> GetLambdaConfigReply? LambdaConfig
        // GraphQL -> lambdaConfig: GetLambdaConfigReply (type)
        if (this.LambdaConfig == null && Exploration.Includes(parent + ".lambdaConfig"))
        {
            this.LambdaConfig = new GetLambdaConfigReply();
            this.LambdaConfig.ApplyExploratoryFieldSpec(parent + ".lambdaConfig");
        }
        //      C# -> LambdaFeatureHistory? LambdaFeatureHistory
        // GraphQL -> lambdaFeatureHistory: LambdaFeatureHistory (type)
        if (this.LambdaFeatureHistory == null && Exploration.Includes(parent + ".lambdaFeatureHistory"))
        {
            this.LambdaFeatureHistory = new LambdaFeatureHistory();
            this.LambdaFeatureHistory.ApplyExploratoryFieldSpec(parent + ".lambdaFeatureHistory");
        }
        //      C# -> JobsReply? MetadataPullScheduler
        // GraphQL -> metadataPullScheduler: JobsReply (type)
        if (this.MetadataPullScheduler == null && Exploration.Includes(parent + ".metadataPullScheduler"))
        {
            this.MetadataPullScheduler = new JobsReply();
            this.MetadataPullScheduler.ApplyExploratoryFieldSpec(parent + ".metadataPullScheduler");
        }
        //      C# -> ClusterMetric? Metric
        // GraphQL -> metric: ClusterMetric (type)
        if (this.Metric == null && Exploration.Includes(parent + ".metric"))
        {
            this.Metric = new ClusterMetric();
            this.Metric.ApplyExploratoryFieldSpec(parent + ".metric");
        }
        //      C# -> List<MetricTimeSeries>? MetricTimeSeries
        // GraphQL -> metricTimeSeries: [metricTimeSeries!]! (type)
        if (this.MetricTimeSeries == null && Exploration.Includes(parent + ".metricTimeSeries"))
        {
            this.MetricTimeSeries = new List<MetricTimeSeries>();
            this.MetricTimeSeries.ApplyExploratoryFieldSpec(parent + ".metricTimeSeries");
        }
        //      C# -> List<ReplicationSource>? ReplicationSources
        // GraphQL -> replicationSources: [ReplicationSource!]! (type)
        if (this.ReplicationSources == null && Exploration.Includes(parent + ".replicationSources"))
        {
            this.ReplicationSources = new List<ReplicationSource>();
            this.ReplicationSources.ApplyExploratoryFieldSpec(parent + ".replicationSources");
        }
        //      C# -> List<ReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [ReplicationTarget!]! (type)
        if (this.ReplicationTargets == null && Exploration.Includes(parent + ".replicationTargets"))
        {
            this.ReplicationTargets = new List<ReplicationTarget>();
            this.ReplicationTargets.ApplyExploratoryFieldSpec(parent + ".replicationTargets");
        }
        //      C# -> RubrikSyncStatus? RubrikSyncStatus
        // GraphQL -> rubrikSyncStatus: RubrikSyncStatus! (type)
        if (this.RubrikSyncStatus == null && Exploration.Includes(parent + ".rubrikSyncStatus"))
        {
            this.RubrikSyncStatus = new RubrikSyncStatus();
            this.RubrikSyncStatus.ApplyExploratoryFieldSpec(parent + ".rubrikSyncStatus");
        }
        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        if (this.SnappableConnection == null && Exploration.Includes(parent + ".snappableConnection"))
        {
            this.SnappableConnection = new SnappableConnection();
            this.SnappableConnection.ApplyExploratoryFieldSpec(parent + ".snappableConnection");
        }
        //      C# -> ClusterState? State
        // GraphQL -> state: clusterState! (type)
        if (this.State == null && Exploration.Includes(parent + ".state"))
        {
            this.State = new ClusterState();
            this.State.ApplyExploratoryFieldSpec(parent + ".state");
        }
        //      C# -> List<ClusterNode>? SystemStatusAffectedNodes
        // GraphQL -> systemStatusAffectedNodes: [ClusterNode!] (type)
        if (this.SystemStatusAffectedNodes == null && Exploration.Includes(parent + ".systemStatusAffectedNodes"))
        {
            this.SystemStatusAffectedNodes = new List<ClusterNode>();
            this.SystemStatusAffectedNodes.ApplyExploratoryFieldSpec(parent + ".systemStatusAffectedNodes");
        }
    }


    #endregion

    } // class Cluster
    
    #endregion

    public static class ListClusterExtensions
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
            this List<Cluster> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Cluster> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Cluster());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types