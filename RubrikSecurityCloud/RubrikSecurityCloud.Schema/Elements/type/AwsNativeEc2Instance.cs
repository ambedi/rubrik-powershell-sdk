// AwsNativeEc2Instance.cs
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
    #region AwsNativeEc2Instance
 
    public class AwsNativeEc2Instance: BaseType, AwsNativeAccountDescendantType, AwsNativeAccountLogicalChildType, AwsNativeHierarchyObject, HierarchyObject, PolarisHierarchyObject, PolarisHierarchySnappable
    {
        #region members

        //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> OsType? OsType
        // GraphQL -> osType: OsType! (enum)
        [JsonProperty("osType")]
        public OsType? OsType { get; set; }

        //      C# -> AwsNativeRegion? Region
        // GraphQL -> region: AwsNativeRegion! (enum)
        [JsonProperty("region")]
        public AwsNativeRegion? Region { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        [JsonProperty("configuredSlaDomain")]
        public SlaDomain? ConfiguredSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        [JsonProperty("effectiveRetentionSlaDomain")]
        public SlaDomain? EffectiveRetentionSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        [JsonProperty("effectiveSlaDomain")]
        public SlaDomain? EffectiveSlaDomain { get; set; }

        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> System.String? AwsAccountRubrikId
        // GraphQL -> awsAccountRubrikId: String! (scalar)
        [JsonProperty("awsAccountRubrikId")]
        public System.String? AwsAccountRubrikId { get; set; }

        //      C# -> System.String? AwsNativeAccountName
        // GraphQL -> awsNativeAccountName: String! (scalar)
        [JsonProperty("awsNativeAccountName")]
        public System.String? AwsNativeAccountName { get; set; }

        //      C# -> System.String? CloudNativeId
        // GraphQL -> cloudNativeId: String! (scalar)
        [JsonProperty("cloudNativeId")]
        public System.String? CloudNativeId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        [JsonProperty("instanceName")]
        public System.String? InstanceName { get; set; }

        //      C# -> System.String? InstanceNativeId
        // GraphQL -> instanceNativeId: String! (scalar)
        [JsonProperty("instanceNativeId")]
        public System.String? InstanceNativeId { get; set; }

        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        [JsonProperty("instanceType")]
        public System.String? InstanceType { get; set; }

        //      C# -> System.Boolean? IsExocomputeConfigured
        // GraphQL -> isExocomputeConfigured: Boolean! (scalar)
        [JsonProperty("isExocomputeConfigured")]
        public System.Boolean? IsExocomputeConfigured { get; set; }

        //      C# -> System.Boolean? IsIndexingEnabled
        // GraphQL -> isIndexingEnabled: Boolean! (scalar)
        [JsonProperty("isIndexingEnabled")]
        public System.Boolean? IsIndexingEnabled { get; set; }

        //      C# -> System.Boolean? IsMarketplace
        // GraphQL -> isMarketplace: Boolean! (scalar)
        [JsonProperty("isMarketplace")]
        public System.Boolean? IsMarketplace { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        [JsonProperty("nativeName")]
        public System.String? NativeName { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        [JsonProperty("onDemandSnapshotCount")]
        public System.Int32? OnDemandSnapshotCount { get; set; }

        //      C# -> System.String? PrivateIp
        // GraphQL -> privateIp: String! (scalar)
        [JsonProperty("privateIp")]
        public System.String? PrivateIp { get; set; }

        //      C# -> System.String? PublicIp
        // GraphQL -> publicIp: String! (scalar)
        [JsonProperty("publicIp")]
        public System.String? PublicIp { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.String? SshKeyPairName
        // GraphQL -> sshKeyPairName: String! (scalar)
        [JsonProperty("sshKeyPairName")]
        public System.String? SshKeyPairName { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> System.String? VpcName
        // GraphQL -> vpcName: String! (scalar)
        [JsonProperty("vpcName")]
        public System.String? VpcName { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> List<AwsNativeEbsVolume>? AttachedEbsVolumes
        // GraphQL -> attachedEbsVolumes: [AwsNativeEbsVolume!]! (type)
        [JsonProperty("attachedEbsVolumes")]
        public List<AwsNativeEbsVolume>? AttachedEbsVolumes { get; set; }

        //      C# -> List<AttachmentSpecForEc2Instance>? AttachmentSpecs
        // GraphQL -> attachmentSpecs: [AttachmentSpecForEc2Instance!]! (type)
        [JsonProperty("attachmentSpecs")]
        public List<AttachmentSpecForEc2Instance>? AttachmentSpecs { get; set; }

        //      C# -> AwsNativeAccount? AwsNativeAccount
        // GraphQL -> awsNativeAccount: AwsNativeAccount! (type)
        [JsonProperty("awsNativeAccount")]
        public AwsNativeAccount? AwsNativeAccount { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> PhysicalHost? HostInfo
        // GraphQL -> hostInfo: PhysicalHost (type)
        [JsonProperty("hostInfo")]
        public PhysicalHost? HostInfo { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        [JsonProperty("newestIndexedSnapshot")]
        public PolarisSnapshot? NewestIndexedSnapshot { get; set; }

        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        [JsonProperty("newestSnapshot")]
        public PolarisSnapshot? NewestSnapshot { get; set; }

        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        [JsonProperty("oldestSnapshot")]
        public PolarisSnapshot? OldestSnapshot { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        [JsonProperty("snapshotConnection")]
        public PolarisSnapshotConnection? SnapshotConnection { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        [JsonProperty("snapshotGroupByConnection")]
        public PolarisSnapshotGroupByConnection? SnapshotGroupByConnection { get; set; }

        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        [JsonProperty("snapshotGroupByNewConnection")]
        public PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection { get; set; }

        //      C# -> List<Tag>? Tags
        // GraphQL -> tags: [Tag!]! (type)
        [JsonProperty("tags")]
        public List<Tag>? Tags { get; set; }

        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        [JsonProperty("workloadSnapshotConnection")]
        public GenericSnapshotConnection? WorkloadSnapshotConnection { get; set; }


        #endregion

    #region methods

    public AwsNativeEc2Instance Set(
        List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        OsType? OsType = null,
        AwsNativeRegion? Region = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        System.String? AvailabilityZone = null,
        System.String? AwsAccountRubrikId = null,
        System.String? AwsNativeAccountName = null,
        System.String? CloudNativeId = null,
        System.String? Id = null,
        System.String? InstanceName = null,
        System.String? InstanceNativeId = null,
        System.String? InstanceType = null,
        System.Boolean? IsExocomputeConfigured = null,
        System.Boolean? IsIndexingEnabled = null,
        System.Boolean? IsMarketplace = null,
        System.Boolean? IsRelic = null,
        System.String? Name = null,
        System.String? NativeName = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.String? PrivateIp = null,
        System.String? PublicIp = null,
        System.Boolean? SlaPauseStatus = null,
        System.String? SshKeyPairName = null,
        System.String? VpcId = null,
        System.String? VpcName = null,
        List<Org>? AllOrgs = null,
        List<AwsNativeEbsVolume>? AttachedEbsVolumes = null,
        List<AttachmentSpecForEc2Instance>? AttachmentSpecs = null,
        AwsNativeAccount? AwsNativeAccount = null,
        PathNode? EffectiveSlaSourceObject = null,
        PhysicalHost? HostInfo = null,
        List<PathNode>? LogicalPath = null,
        PolarisSnapshot? NewestIndexedSnapshot = null,
        PolarisSnapshot? NewestSnapshot = null,
        PolarisSnapshot? OldestSnapshot = null,
        List<PathNode>? PhysicalPath = null,
        PolarisSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        PolarisSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection = null,
        List<Tag>? Tags = null,
        GenericSnapshotConnection? WorkloadSnapshotConnection = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( ConfiguredSlaDomain != null ) {
            this.ConfiguredSlaDomain = ConfiguredSlaDomain;
        }
        if ( EffectiveRetentionSlaDomain != null ) {
            this.EffectiveRetentionSlaDomain = EffectiveRetentionSlaDomain;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        if ( AvailabilityZone != null ) {
            this.AvailabilityZone = AvailabilityZone;
        }
        if ( AwsAccountRubrikId != null ) {
            this.AwsAccountRubrikId = AwsAccountRubrikId;
        }
        if ( AwsNativeAccountName != null ) {
            this.AwsNativeAccountName = AwsNativeAccountName;
        }
        if ( CloudNativeId != null ) {
            this.CloudNativeId = CloudNativeId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( InstanceName != null ) {
            this.InstanceName = InstanceName;
        }
        if ( InstanceNativeId != null ) {
            this.InstanceNativeId = InstanceNativeId;
        }
        if ( InstanceType != null ) {
            this.InstanceType = InstanceType;
        }
        if ( IsExocomputeConfigured != null ) {
            this.IsExocomputeConfigured = IsExocomputeConfigured;
        }
        if ( IsIndexingEnabled != null ) {
            this.IsIndexingEnabled = IsIndexingEnabled;
        }
        if ( IsMarketplace != null ) {
            this.IsMarketplace = IsMarketplace;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeName != null ) {
            this.NativeName = NativeName;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( OnDemandSnapshotCount != null ) {
            this.OnDemandSnapshotCount = OnDemandSnapshotCount;
        }
        if ( PrivateIp != null ) {
            this.PrivateIp = PrivateIp;
        }
        if ( PublicIp != null ) {
            this.PublicIp = PublicIp;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( SshKeyPairName != null ) {
            this.SshKeyPairName = SshKeyPairName;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
        }
        if ( VpcName != null ) {
            this.VpcName = VpcName;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AttachedEbsVolumes != null ) {
            this.AttachedEbsVolumes = AttachedEbsVolumes;
        }
        if ( AttachmentSpecs != null ) {
            this.AttachmentSpecs = AttachmentSpecs;
        }
        if ( AwsNativeAccount != null ) {
            this.AwsNativeAccount = AwsNativeAccount;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( HostInfo != null ) {
            this.HostInfo = HostInfo;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( NewestIndexedSnapshot != null ) {
            this.NewestIndexedSnapshot = NewestIndexedSnapshot;
        }
        if ( NewestSnapshot != null ) {
            this.NewestSnapshot = NewestSnapshot;
        }
        if ( OldestSnapshot != null ) {
            this.OldestSnapshot = OldestSnapshot;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( SnapshotConnection != null ) {
            this.SnapshotConnection = SnapshotConnection;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        if ( SnapshotGroupByConnection != null ) {
            this.SnapshotGroupByConnection = SnapshotGroupByConnection;
        }
        if ( SnapshotGroupByNewConnection != null ) {
            this.SnapshotGroupByNewConnection = SnapshotGroupByNewConnection;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
        }
        if ( WorkloadSnapshotConnection != null ) {
            this.WorkloadSnapshotConnection = WorkloadSnapshotConnection;
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
        //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
        if (this.AuthorizedOperations != null) {
            s += ind + "authorizedOperations\n" ;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> OsType? OsType
        // GraphQL -> osType: OsType! (enum)
        if (this.OsType != null) {
            s += ind + "osType\n" ;
        }
        //      C# -> AwsNativeRegion? Region
        // GraphQL -> region: AwsNativeRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment != null) {
            s += ind + "slaAssignment\n" ;
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain != null) {
            s += ind + "configuredSlaDomain {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.ConfiguredSlaDomain).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain != null) {
            s += ind + "effectiveRetentionSlaDomain {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveRetentionSlaDomain).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
            s += ind + "effectiveSlaDomain {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveSlaDomain).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (this.AvailabilityZone != null) {
            s += ind + "availabilityZone\n" ;
        }
        //      C# -> System.String? AwsAccountRubrikId
        // GraphQL -> awsAccountRubrikId: String! (scalar)
        if (this.AwsAccountRubrikId != null) {
            s += ind + "awsAccountRubrikId\n" ;
        }
        //      C# -> System.String? AwsNativeAccountName
        // GraphQL -> awsNativeAccountName: String! (scalar)
        if (this.AwsNativeAccountName != null) {
            s += ind + "awsNativeAccountName\n" ;
        }
        //      C# -> System.String? CloudNativeId
        // GraphQL -> cloudNativeId: String! (scalar)
        if (this.CloudNativeId != null) {
            s += ind + "cloudNativeId\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        if (this.InstanceName != null) {
            s += ind + "instanceName\n" ;
        }
        //      C# -> System.String? InstanceNativeId
        // GraphQL -> instanceNativeId: String! (scalar)
        if (this.InstanceNativeId != null) {
            s += ind + "instanceNativeId\n" ;
        }
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (this.InstanceType != null) {
            s += ind + "instanceType\n" ;
        }
        //      C# -> System.Boolean? IsExocomputeConfigured
        // GraphQL -> isExocomputeConfigured: Boolean! (scalar)
        if (this.IsExocomputeConfigured != null) {
            s += ind + "isExocomputeConfigured\n" ;
        }
        //      C# -> System.Boolean? IsIndexingEnabled
        // GraphQL -> isIndexingEnabled: Boolean! (scalar)
        if (this.IsIndexingEnabled != null) {
            s += ind + "isIndexingEnabled\n" ;
        }
        //      C# -> System.Boolean? IsMarketplace
        // GraphQL -> isMarketplace: Boolean! (scalar)
        if (this.IsMarketplace != null) {
            s += ind + "isMarketplace\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        if (this.NativeName != null) {
            s += ind + "nativeName\n" ;
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants != null) {
            s += ind + "numWorkloadDescendants\n" ;
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount != null) {
            s += ind + "onDemandSnapshotCount\n" ;
        }
        //      C# -> System.String? PrivateIp
        // GraphQL -> privateIp: String! (scalar)
        if (this.PrivateIp != null) {
            s += ind + "privateIp\n" ;
        }
        //      C# -> System.String? PublicIp
        // GraphQL -> publicIp: String! (scalar)
        if (this.PublicIp != null) {
            s += ind + "publicIp\n" ;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            s += ind + "slaPauseStatus\n" ;
        }
        //      C# -> System.String? SshKeyPairName
        // GraphQL -> sshKeyPairName: String! (scalar)
        if (this.SshKeyPairName != null) {
            s += ind + "sshKeyPairName\n" ;
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId != null) {
            s += ind + "vpcId\n" ;
        }
        //      C# -> System.String? VpcName
        // GraphQL -> vpcName: String! (scalar)
        if (this.VpcName != null) {
            s += ind + "vpcName\n" ;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            s += ind + "allOrgs {\n" + this.AllOrgs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<AwsNativeEbsVolume>? AttachedEbsVolumes
        // GraphQL -> attachedEbsVolumes: [AwsNativeEbsVolume!]! (type)
        if (this.AttachedEbsVolumes != null) {
            s += ind + "attachedEbsVolumes {\n" + this.AttachedEbsVolumes.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<AttachmentSpecForEc2Instance>? AttachmentSpecs
        // GraphQL -> attachmentSpecs: [AttachmentSpecForEc2Instance!]! (type)
        if (this.AttachmentSpecs != null) {
            s += ind + "attachmentSpecs {\n" + this.AttachmentSpecs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> AwsNativeAccount? AwsNativeAccount
        // GraphQL -> awsNativeAccount: AwsNativeAccount! (type)
        if (this.AwsNativeAccount != null) {
            s += ind + "awsNativeAccount {\n" + this.AwsNativeAccount.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            s += ind + "effectiveSlaSourceObject {\n" + this.EffectiveSlaSourceObject.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PhysicalHost? HostInfo
        // GraphQL -> hostInfo: PhysicalHost (type)
        if (this.HostInfo != null) {
            s += ind + "hostInfo {\n" + this.HostInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            s += ind + "logicalPath {\n" + this.LogicalPath.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        if (this.NewestIndexedSnapshot != null) {
            s += ind + "newestIndexedSnapshot {\n" + this.NewestIndexedSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        if (this.NewestSnapshot != null) {
            s += ind + "newestSnapshot {\n" + this.NewestSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        if (this.OldestSnapshot != null) {
            s += ind + "oldestSnapshot {\n" + this.OldestSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            s += ind + "physicalPath {\n" + this.PhysicalPath.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        if (this.SnapshotConnection != null) {
            s += ind + "snapshotConnection {\n" + this.SnapshotConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            s += ind + "snapshotDistribution {\n" + this.SnapshotDistribution.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection != null) {
            s += ind + "snapshotGroupByConnection {\n" + this.SnapshotGroupByConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        if (this.SnapshotGroupByNewConnection != null) {
            s += ind + "snapshotGroupByNewConnection {\n" + this.SnapshotGroupByNewConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<Tag>? Tags
        // GraphQL -> tags: [Tag!]! (type)
        if (this.Tags != null) {
            s += ind + "tags {\n" + this.Tags.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        if (this.WorkloadSnapshotConnection != null) {
            s += ind + "workloadSnapshotConnection {\n" + this.WorkloadSnapshotConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
        if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations", true))
        {
            this.AuthorizedOperations = new List<PolarisSnappableAuthorizedOperationsEnum>();
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new HierarchyObjectTypeEnum();
        }
        //      C# -> OsType? OsType
        // GraphQL -> osType: OsType! (enum)
        if (this.OsType == null && Exploration.Includes(parent + ".osType", true))
        {
            this.OsType = new OsType();
        }
        //      C# -> AwsNativeRegion? Region
        // GraphQL -> region: AwsNativeRegion! (enum)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = new AwsNativeRegion();
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment", true))
        {
            this.SlaAssignment = new SlaAssignmentTypeEnum();
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain == null && Exploration.Includes(parent + ".configuredSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".configuredSlaDomain");
            this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain == null && Exploration.Includes(parent + ".effectiveRetentionSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".effectiveRetentionSlaDomain");
            this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain == null && Exploration.Includes(parent + ".effectiveSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".effectiveSlaDomain");
            this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (this.AvailabilityZone == null && Exploration.Includes(parent + ".availabilityZone", true))
        {
            this.AvailabilityZone = new System.String("FETCH");
        }
        //      C# -> System.String? AwsAccountRubrikId
        // GraphQL -> awsAccountRubrikId: String! (scalar)
        if (this.AwsAccountRubrikId == null && Exploration.Includes(parent + ".awsAccountRubrikId", true))
        {
            this.AwsAccountRubrikId = new System.String("FETCH");
        }
        //      C# -> System.String? AwsNativeAccountName
        // GraphQL -> awsNativeAccountName: String! (scalar)
        if (this.AwsNativeAccountName == null && Exploration.Includes(parent + ".awsNativeAccountName", true))
        {
            this.AwsNativeAccountName = new System.String("FETCH");
        }
        //      C# -> System.String? CloudNativeId
        // GraphQL -> cloudNativeId: String! (scalar)
        if (this.CloudNativeId == null && Exploration.Includes(parent + ".cloudNativeId", true))
        {
            this.CloudNativeId = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        if (this.InstanceName == null && Exploration.Includes(parent + ".instanceName", true))
        {
            this.InstanceName = new System.String("FETCH");
        }
        //      C# -> System.String? InstanceNativeId
        // GraphQL -> instanceNativeId: String! (scalar)
        if (this.InstanceNativeId == null && Exploration.Includes(parent + ".instanceNativeId", true))
        {
            this.InstanceNativeId = new System.String("FETCH");
        }
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (this.InstanceType == null && Exploration.Includes(parent + ".instanceType", true))
        {
            this.InstanceType = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsExocomputeConfigured
        // GraphQL -> isExocomputeConfigured: Boolean! (scalar)
        if (this.IsExocomputeConfigured == null && Exploration.Includes(parent + ".isExocomputeConfigured", true))
        {
            this.IsExocomputeConfigured = true;
        }
        //      C# -> System.Boolean? IsIndexingEnabled
        // GraphQL -> isIndexingEnabled: Boolean! (scalar)
        if (this.IsIndexingEnabled == null && Exploration.Includes(parent + ".isIndexingEnabled", true))
        {
            this.IsIndexingEnabled = true;
        }
        //      C# -> System.Boolean? IsMarketplace
        // GraphQL -> isMarketplace: Boolean! (scalar)
        if (this.IsMarketplace == null && Exploration.Includes(parent + ".isMarketplace", true))
        {
            this.IsMarketplace = true;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        if (this.NativeName == null && Exploration.Includes(parent + ".nativeName", true))
        {
            this.NativeName = new System.String("FETCH");
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants == null && Exploration.Includes(parent + ".numWorkloadDescendants", true))
        {
            this.NumWorkloadDescendants = new System.Int32();
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount == null && Exploration.Includes(parent + ".onDemandSnapshotCount", true))
        {
            this.OnDemandSnapshotCount = new System.Int32();
        }
        //      C# -> System.String? PrivateIp
        // GraphQL -> privateIp: String! (scalar)
        if (this.PrivateIp == null && Exploration.Includes(parent + ".privateIp", true))
        {
            this.PrivateIp = new System.String("FETCH");
        }
        //      C# -> System.String? PublicIp
        // GraphQL -> publicIp: String! (scalar)
        if (this.PublicIp == null && Exploration.Includes(parent + ".publicIp", true))
        {
            this.PublicIp = new System.String("FETCH");
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus", true))
        {
            this.SlaPauseStatus = true;
        }
        //      C# -> System.String? SshKeyPairName
        // GraphQL -> sshKeyPairName: String! (scalar)
        if (this.SshKeyPairName == null && Exploration.Includes(parent + ".sshKeyPairName", true))
        {
            this.SshKeyPairName = new System.String("FETCH");
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId == null && Exploration.Includes(parent + ".vpcId", true))
        {
            this.VpcId = new System.String("FETCH");
        }
        //      C# -> System.String? VpcName
        // GraphQL -> vpcName: String! (scalar)
        if (this.VpcName == null && Exploration.Includes(parent + ".vpcName", true))
        {
            this.VpcName = new System.String("FETCH");
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(parent + ".allOrgs");
        }
        //      C# -> List<AwsNativeEbsVolume>? AttachedEbsVolumes
        // GraphQL -> attachedEbsVolumes: [AwsNativeEbsVolume!]! (type)
        if (this.AttachedEbsVolumes == null && Exploration.Includes(parent + ".attachedEbsVolumes"))
        {
            this.AttachedEbsVolumes = new List<AwsNativeEbsVolume>();
            this.AttachedEbsVolumes.ApplyExploratoryFieldSpec(parent + ".attachedEbsVolumes");
        }
        //      C# -> List<AttachmentSpecForEc2Instance>? AttachmentSpecs
        // GraphQL -> attachmentSpecs: [AttachmentSpecForEc2Instance!]! (type)
        if (this.AttachmentSpecs == null && Exploration.Includes(parent + ".attachmentSpecs"))
        {
            this.AttachmentSpecs = new List<AttachmentSpecForEc2Instance>();
            this.AttachmentSpecs.ApplyExploratoryFieldSpec(parent + ".attachmentSpecs");
        }
        //      C# -> AwsNativeAccount? AwsNativeAccount
        // GraphQL -> awsNativeAccount: AwsNativeAccount! (type)
        if (this.AwsNativeAccount == null && Exploration.Includes(parent + ".awsNativeAccount"))
        {
            this.AwsNativeAccount = new AwsNativeAccount();
            this.AwsNativeAccount.ApplyExploratoryFieldSpec(parent + ".awsNativeAccount");
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
        {
            this.EffectiveSlaSourceObject = new PathNode();
            this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(parent + ".effectiveSlaSourceObject");
        }
        //      C# -> PhysicalHost? HostInfo
        // GraphQL -> hostInfo: PhysicalHost (type)
        if (this.HostInfo == null && Exploration.Includes(parent + ".hostInfo"))
        {
            this.HostInfo = new PhysicalHost();
            this.HostInfo.ApplyExploratoryFieldSpec(parent + ".hostInfo");
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
        {
            this.LogicalPath = new List<PathNode>();
            this.LogicalPath.ApplyExploratoryFieldSpec(parent + ".logicalPath");
        }
        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        if (this.NewestIndexedSnapshot == null && Exploration.Includes(parent + ".newestIndexedSnapshot"))
        {
            this.NewestIndexedSnapshot = new PolarisSnapshot();
            this.NewestIndexedSnapshot.ApplyExploratoryFieldSpec(parent + ".newestIndexedSnapshot");
        }
        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        if (this.NewestSnapshot == null && Exploration.Includes(parent + ".newestSnapshot"))
        {
            this.NewestSnapshot = new PolarisSnapshot();
            this.NewestSnapshot.ApplyExploratoryFieldSpec(parent + ".newestSnapshot");
        }
        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        if (this.OldestSnapshot == null && Exploration.Includes(parent + ".oldestSnapshot"))
        {
            this.OldestSnapshot = new PolarisSnapshot();
            this.OldestSnapshot.ApplyExploratoryFieldSpec(parent + ".oldestSnapshot");
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
        {
            this.PhysicalPath = new List<PathNode>();
            this.PhysicalPath.ApplyExploratoryFieldSpec(parent + ".physicalPath");
        }
        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        if (this.SnapshotConnection == null && Exploration.Includes(parent + ".snapshotConnection"))
        {
            this.SnapshotConnection = new PolarisSnapshotConnection();
            this.SnapshotConnection.ApplyExploratoryFieldSpec(parent + ".snapshotConnection");
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
        {
            this.SnapshotDistribution = new SnapshotDistribution();
            this.SnapshotDistribution.ApplyExploratoryFieldSpec(parent + ".snapshotDistribution");
        }
        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection == null && Exploration.Includes(parent + ".snapshotGroupByConnection"))
        {
            this.SnapshotGroupByConnection = new PolarisSnapshotGroupByConnection();
            this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(parent + ".snapshotGroupByConnection");
        }
        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        if (this.SnapshotGroupByNewConnection == null && Exploration.Includes(parent + ".snapshotGroupByNewConnection"))
        {
            this.SnapshotGroupByNewConnection = new PolarisSnapshotGroupByNewConnection();
            this.SnapshotGroupByNewConnection.ApplyExploratoryFieldSpec(parent + ".snapshotGroupByNewConnection");
        }
        //      C# -> List<Tag>? Tags
        // GraphQL -> tags: [Tag!]! (type)
        if (this.Tags == null && Exploration.Includes(parent + ".tags"))
        {
            this.Tags = new List<Tag>();
            this.Tags.ApplyExploratoryFieldSpec(parent + ".tags");
        }
        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        if (this.WorkloadSnapshotConnection == null && Exploration.Includes(parent + ".workloadSnapshotConnection"))
        {
            this.WorkloadSnapshotConnection = new GenericSnapshotConnection();
            this.WorkloadSnapshotConnection.ApplyExploratoryFieldSpec(parent + ".workloadSnapshotConnection");
        }
    }


    #endregion

    } // class AwsNativeEc2Instance
    
    #endregion

    public static class ListAwsNativeEc2InstanceExtensions
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
            this List<AwsNativeEc2Instance> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsNativeEc2Instance> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsNativeEc2Instance());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types