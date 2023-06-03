// Invoke-RscQueryNutanix.cs
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
        "RscQueryNutanix",
        DefaultParameterSetName = "Cluster")
    ]
    public class Invoke_RscQueryNutanix : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // TopLevelDescendant parameter set
        //
        // GraphQL operation: nutanixTopLevelDescendants(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   typeFilter: [HierarchyObjectTypeEnum!],   filter: [Filter!], ):CdmHierarchyObjectConnection!
        //
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of the highest-level Nutanix Objects accessible by the current user.
                GraphQL operation: nutanixTopLevelDescendants(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   typeFilter: [HierarchyObjectTypeEnum!],   filter: [Filter!], ):CdmHierarchyObjectConnection!
                ",
            Position = 0
        )]
        public SwitchParameter TopLevelDescendant { get; set; }

        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the first n elements from the list.
                GraphQL argument first: Int
                "
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the elements in the list that come after the specified cursor.
                GraphQL argument after: String
                "
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Sort hierarchy objects by hierarchy field.
                GraphQL argument sortBy: HierarchySortByField
                "
        )]
        public HierarchySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Sorting order for the results.
                GraphQL argument sortOrder: SortOrder
                "
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Types of objects to include.
                GraphQL argument typeFilter: [HierarchyObjectTypeEnum!]
                "
        )]
        public List<HierarchyObjectTypeEnum>? TypeFilter { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The hierarchy object filter.
                GraphQL argument filter: [Filter!]
                "
        )]
        public List<Filter>? Filter { get; set; }
        
        // -------------------------------------------------------------------
        // TopLevelDescendantsV2 parameter set
        //
        // GraphQL operation: nutanixTopLevelDescendantsV2(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   typeFilter: [HierarchyObjectTypeEnum!],   filter: [Filter!], ):NutanixTopLevelDescendantTypeConnection!
        //
        [Parameter(
            ParameterSetName = "TopLevelDescendantsV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of the highest-level Nutanix Objects accessible by the current user.
                GraphQL operation: nutanixTopLevelDescendantsV2(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   typeFilter: [HierarchyObjectTypeEnum!],   filter: [Filter!], ):NutanixTopLevelDescendantTypeConnection!
                ",
            Position = 0
        )]
        public SwitchParameter TopLevelDescendantsV2 { get; set; }

        
        // -------------------------------------------------------------------
        // Cluster parameter set
        //
        // GraphQL operation: nutanixCluster(fid: UUID!):NutanixCluster!
        //
        [Parameter(
            ParameterSetName = "Cluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                A Nutanix Cluster.
                GraphQL operation: nutanixCluster(fid: UUID!):NutanixCluster!
                ",
            Position = 0
        )]
        public SwitchParameter Cluster { get; set; }

        [Parameter(
            ParameterSetName = "Cluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The Rubrik UUID for the object.
                GraphQL argument fid: UUID!
                "
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // PrismCentral parameter set
        //
        // GraphQL operation: nutanixPrismCentrals(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):NutanixPrismCentralConnection!
        //
        [Parameter(
            ParameterSetName = "PrismCentral",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of Nutanix Prism Central objects.
                GraphQL operation: nutanixPrismCentrals(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):NutanixPrismCentralConnection!
                ",
            Position = 0
        )]
        public SwitchParameter PrismCentral { get; set; }

        
        // -------------------------------------------------------------------
        // Categorie parameter set
        //
        // GraphQL operation: nutanixCategories(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):NutanixCategoryConnection!
        //
        [Parameter(
            ParameterSetName = "Categorie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of Nutanix Category objects.
                GraphQL operation: nutanixCategories(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):NutanixCategoryConnection!
                ",
            Position = 0
        )]
        public SwitchParameter Categorie { get; set; }

        
        // -------------------------------------------------------------------
        // CategoryValue parameter set
        //
        // GraphQL operation: nutanixCategoryValues(fid: UUID!):NutanixCategoryValueConnection!
        //
        [Parameter(
            ParameterSetName = "CategoryValue",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of Nutanix Category Value objects.
                GraphQL operation: nutanixCategoryValues(fid: UUID!):NutanixCategoryValueConnection!
                ",
            Position = 0
        )]
        public SwitchParameter CategoryValue { get; set; }

        
        // -------------------------------------------------------------------
        // CategoryValueVm parameter set
        //
        // GraphQL operation: nutanixCategoryValueVms(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):NutanixVmConnection!
        //
        [Parameter(
            ParameterSetName = "CategoryValueVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of Nutanix Virtual Machines in a Category Value.
                GraphQL operation: nutanixCategoryValueVms(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):NutanixVmConnection!
                ",
            Position = 0
        )]
        public SwitchParameter CategoryValueVm { get; set; }

        
        // -------------------------------------------------------------------
        // Vm parameter set
        //
        // GraphQL operation: nutanixVm(fid: UUID!):NutanixVm!
        //
        [Parameter(
            ParameterSetName = "Vm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                A Nutanix Virtual Machine.
                GraphQL operation: nutanixVm(fid: UUID!):NutanixVm!
                ",
            Position = 0
        )]
        public SwitchParameter Vm { get; set; }

        
        // -------------------------------------------------------------------
        // Mount parameter set
        //
        // GraphQL operation: nutanixMounts(,   first: Int,   after: String,   filters: [NutanixLiveMountFilterInput!],   sortBy: NutanixLiveMountSortByInput, ):NutanixLiveMountConnection!
        //
        [Parameter(
            ParameterSetName = "Mount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Nutanix Live Mount Connection.
                GraphQL operation: nutanixMounts(,   first: Int,   after: String,   filters: [NutanixLiveMountFilterInput!],   sortBy: NutanixLiveMountSortByInput, ):NutanixLiveMountConnection!
                ",
            Position = 0
        )]
        public SwitchParameter Mount { get; set; }

        [Parameter(
            ParameterSetName = "Mount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Filter for Nutanix virtual machine live mounts.
                GraphQL argument filters: [NutanixLiveMountFilterInput!]
                "
        )]
        public List<NutanixLiveMountFilterInput>? Filters { get; set; }
        
        // -------------------------------------------------------------------
        // ClusterContainer parameter set
        //
        // GraphQL operation: nutanixClusterContainers(input: GetContainersInput!):NutanixContainerListResponse!
        //
        [Parameter(
            ParameterSetName = "ClusterContainer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get list of containers on this cluster

Supported in v5.0+
Query the nutanix cluster to get the list of containers, used for export purposes.
                GraphQL operation: nutanixClusterContainers(input: GetContainersInput!):NutanixContainerListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter ClusterContainer { get; set; }

        [Parameter(
            ParameterSetName = "ClusterContainer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Input for InternalGetContainers.
                GraphQL argument input: GetContainersInput!
                "
        )]
        public GetContainersInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // ClusterNetwork parameter set
        //
        // GraphQL operation: nutanixClusterNetworks(input: GetNutanixNetworksInput!):NutanixNetworkListResponse!
        //
        [Parameter(
            ParameterSetName = "ClusterNetwork",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get list of networks on this cluster

Supported in v8.1+
Retrieves the list of networks by querying the Nutanix cluster. The list of networks is used for restore purposes.
                GraphQL operation: nutanixClusterNetworks(input: GetNutanixNetworksInput!):NutanixNetworkListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter ClusterNetwork { get; set; }

        
        // -------------------------------------------------------------------
        // ClusterAsyncRequestStatus parameter set
        //
        // GraphQL operation: nutanixClusterAsyncRequestStatus(input: GetNutanixClusterAsyncRequestStatusInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "ClusterAsyncRequestStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get Nutanix cluster async request

Supported in v5.0+
Get details about a Nutanix cluster-related async request.
                GraphQL operation: nutanixClusterAsyncRequestStatus(input: GetNutanixClusterAsyncRequestStatusInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter ClusterAsyncRequestStatus { get; set; }

        
        // -------------------------------------------------------------------
        // VmAsyncRequestStatus parameter set
        //
        // GraphQL operation: nutanixVmAsyncRequestStatus(input: GetNutanixVmAsyncRequestStatusInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VmAsyncRequestStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                v5.0-v8.0: Get VM async request details
v8.1+: Get virtual machine async request details

Supported in v5.0+
v5.0-v8.0: Get details about a Nutanix VM-related async request.
v8.1+: Get details about a Nutanix virtual machine-related async request.
                GraphQL operation: nutanixVmAsyncRequestStatus(input: GetNutanixVmAsyncRequestStatusInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter VmAsyncRequestStatus { get; set; }

        
        // -------------------------------------------------------------------
        // searchVm parameter set
        //
        // GraphQL operation: searchNutanixVm(input: SearchNutanixVmInput!):SearchResponseListResponse!
        //
        [Parameter(
            ParameterSetName = "searchVm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                v5.0-v8.0: Search for file in Nutanix VM
v8.1+: Search for file in Nutanix virtual machine

Supported in v5.0+
Search for a file within the Nutanix Virtual Machine. Search via full path prefix or filename prefix.
                GraphQL operation: searchNutanixVm(input: SearchNutanixVmInput!):SearchResponseListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter searchVm { get; set; }

        
        // -------------------------------------------------------------------
        // VmMissedSnapshot parameter set
        //
        // GraphQL operation: nutanixVmMissedSnapshots(input: NutanixMissedSnapshotsInput!):MissedSnapshotListResponse!
        //
        [Parameter(
            ParameterSetName = "VmMissedSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                v5.0-v8.0: Get details about missed snapshots for a VM
v8.1+: Get details about missed snapshots for a virtual machine

Supported in v5.0+
v5.0-v8.0: Retrieve the time of the day when the snapshots were missed specific to a vm.
v8.1+: Retrieve the time of the day when the snapshots were missed specific to a virtual machine.
                GraphQL operation: nutanixVmMissedSnapshots(input: NutanixMissedSnapshotsInput!):MissedSnapshotListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter VmMissedSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // BrowseSnapshot parameter set
        //
        // GraphQL operation: nutanixBrowseSnapshot(input: BrowseNutanixSnapshotInput!):BrowseResponseListResponse!
        //
        [Parameter(
            ParameterSetName = "BrowseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                v5.0-v8.0: Lists all files in VM snapshot
v8.1+: Lists all files in virtual machine snapshot

Supported in v5.0+
Lists all files and directories in a given path.
                GraphQL operation: nutanixBrowseSnapshot(input: BrowseNutanixSnapshotInput!):BrowseResponseListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter BrowseSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // SnapshotDetail parameter set
        //
        // GraphQL operation: nutanixSnapshotDetail(input: GetNutanixSnapshotDetailInput!):NutanixVmSnapshotDetail!
        //
        [Parameter(
            ParameterSetName = "SnapshotDetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Supported in v5.0+. Get Nutanix virtual machine snapshot details.
 Retrieve detailed information about a snapshot.
                GraphQL operation: nutanixSnapshotDetail(input: GetNutanixSnapshotDetailInput!):NutanixVmSnapshotDetail!
                ",
            Position = 0
        )]
        public SwitchParameter SnapshotDetail { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "TopLevelDescendant":
                        this.ProcessRecord_TopLevelDescendant();
                        break;
                    case "TopLevelDescendantsV2":
                        this.ProcessRecord_TopLevelDescendantsV2();
                        break;
                    case "Cluster":
                        this.ProcessRecord_Cluster();
                        break;
                    case "PrismCentral":
                        this.ProcessRecord_PrismCentral();
                        break;
                    case "Categorie":
                        this.ProcessRecord_Categorie();
                        break;
                    case "CategoryValue":
                        this.ProcessRecord_CategoryValue();
                        break;
                    case "CategoryValueVm":
                        this.ProcessRecord_CategoryValueVm();
                        break;
                    case "Vm":
                        this.ProcessRecord_Vm();
                        break;
                    case "Mount":
                        this.ProcessRecord_Mount();
                        break;
                    case "ClusterContainer":
                        this.ProcessRecord_ClusterContainer();
                        break;
                    case "ClusterNetwork":
                        this.ProcessRecord_ClusterNetwork();
                        break;
                    case "ClusterAsyncRequestStatus":
                        this.ProcessRecord_ClusterAsyncRequestStatus();
                        break;
                    case "VmAsyncRequestStatus":
                        this.ProcessRecord_VmAsyncRequestStatus();
                        break;
                    case "searchVm":
                        this.ProcessRecord_searchVm();
                        break;
                    case "VmMissedSnapshot":
                        this.ProcessRecord_VmMissedSnapshot();
                        break;
                    case "BrowseSnapshot":
                        this.ProcessRecord_BrowseSnapshot();
                        break;
                    case "SnapshotDetail":
                        this.ProcessRecord_SnapshotDetail();
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
                    "Invoke-RscQueryNutanix",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // nutanixTopLevelDescendants.
        protected void ProcessRecord_TopLevelDescendant()
        {
            this._logger.name += " -TopLevelDescendant";
            // Invoke graphql operation nutanixTopLevelDescendants
            InvokeQueryNutanixTopLevelDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixTopLevelDescendantsV2.
        protected void ProcessRecord_TopLevelDescendantsV2()
        {
            this._logger.name += " -TopLevelDescendantsV2";
            // Invoke graphql operation nutanixTopLevelDescendantsV2
            InvokeQueryNutanixTopLevelDescendantsV2();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixCluster.
        protected void ProcessRecord_Cluster()
        {
            this._logger.name += " -Cluster";
            // Invoke graphql operation nutanixCluster
            InvokeQueryNutanixCluster();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixPrismCentrals.
        protected void ProcessRecord_PrismCentral()
        {
            this._logger.name += " -PrismCentral";
            // Invoke graphql operation nutanixPrismCentrals
            InvokeQueryNutanixPrismCentrals();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixCategories.
        protected void ProcessRecord_Categorie()
        {
            this._logger.name += " -Categorie";
            // Invoke graphql operation nutanixCategories
            InvokeQueryNutanixCategories();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixCategoryValues.
        protected void ProcessRecord_CategoryValue()
        {
            this._logger.name += " -CategoryValue";
            // Invoke graphql operation nutanixCategoryValues
            InvokeQueryNutanixCategoryValues();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixCategoryValueVms.
        protected void ProcessRecord_CategoryValueVm()
        {
            this._logger.name += " -CategoryValueVm";
            // Invoke graphql operation nutanixCategoryValueVms
            InvokeQueryNutanixCategoryValueVms();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixVm.
        protected void ProcessRecord_Vm()
        {
            this._logger.name += " -Vm";
            // Invoke graphql operation nutanixVm
            InvokeQueryNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixMounts.
        protected void ProcessRecord_Mount()
        {
            this._logger.name += " -Mount";
            // Invoke graphql operation nutanixMounts
            InvokeQueryNutanixMounts();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixClusterContainers.
        protected void ProcessRecord_ClusterContainer()
        {
            this._logger.name += " -ClusterContainer";
            // Invoke graphql operation nutanixClusterContainers
            InvokeQueryNutanixClusterContainers();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixClusterNetworks.
        protected void ProcessRecord_ClusterNetwork()
        {
            this._logger.name += " -ClusterNetwork";
            // Invoke graphql operation nutanixClusterNetworks
            InvokeQueryNutanixClusterNetworks();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixClusterAsyncRequestStatus.
        protected void ProcessRecord_ClusterAsyncRequestStatus()
        {
            this._logger.name += " -ClusterAsyncRequestStatus";
            // Invoke graphql operation nutanixClusterAsyncRequestStatus
            InvokeQueryNutanixClusterAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixVmAsyncRequestStatus.
        protected void ProcessRecord_VmAsyncRequestStatus()
        {
            this._logger.name += " -VmAsyncRequestStatus";
            // Invoke graphql operation nutanixVmAsyncRequestStatus
            InvokeQueryNutanixVmAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // searchNutanixVm.
        protected void ProcessRecord_searchVm()
        {
            this._logger.name += " -searchVm";
            // Invoke graphql operation searchNutanixVm
            InvokeQuerySearchNutanixVm();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixVmMissedSnapshots.
        protected void ProcessRecord_VmMissedSnapshot()
        {
            this._logger.name += " -VmMissedSnapshot";
            // Invoke graphql operation nutanixVmMissedSnapshots
            InvokeQueryNutanixVmMissedSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixBrowseSnapshot.
        protected void ProcessRecord_BrowseSnapshot()
        {
            this._logger.name += " -BrowseSnapshot";
            // Invoke graphql operation nutanixBrowseSnapshot
            InvokeQueryNutanixBrowseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // nutanixSnapshotDetail.
        protected void ProcessRecord_SnapshotDetail()
        {
            this._logger.name += " -SnapshotDetail";
            // Invoke graphql operation nutanixSnapshotDetail
            InvokeQueryNutanixSnapshotDetail();
        }


        // Invoke GraphQL Query:
        // nutanixTopLevelDescendants(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): CdmHierarchyObjectConnection!
        protected void InvokeQueryNutanixTopLevelDescendants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            CdmHierarchyObjectConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CdmHierarchyObjectConnection)psObject.BaseObject;
                } else {
                    fields = (CdmHierarchyObjectConnection)this.Field;
                }
            }
            string document = Query.NutanixTopLevelDescendants(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixTopLevelDescendants");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixTopLevelDescendants" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixTopLevelDescendants",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CdmHierarchyObjectConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixTopLevelDescendantsV2(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): NutanixTopLevelDescendantTypeConnection!
        protected void InvokeQueryNutanixTopLevelDescendantsV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            NutanixTopLevelDescendantTypeConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixTopLevelDescendantTypeConnection)psObject.BaseObject;
                } else {
                    fields = (NutanixTopLevelDescendantTypeConnection)this.Field;
                }
            }
            string document = Query.NutanixTopLevelDescendantsV2(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixTopLevelDescendantsV2");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixTopLevelDescendantsV2" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixTopLevelDescendantsV2",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixTopLevelDescendantTypeConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixCluster(fid: UUID!): NutanixCluster!
        protected void InvokeQueryNutanixCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            NutanixCluster? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixCluster)psObject.BaseObject;
                } else {
                    fields = (NutanixCluster)this.Field;
                }
            }
            string document = Query.NutanixCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixCluster");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixCluster" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixCluster",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixCluster", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixPrismCentrals(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): NutanixPrismCentralConnection!
        protected void InvokeQueryNutanixPrismCentrals()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            NutanixPrismCentralConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixPrismCentralConnection)psObject.BaseObject;
                } else {
                    fields = (NutanixPrismCentralConnection)this.Field;
                }
            }
            string document = Query.NutanixPrismCentrals(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixPrismCentrals");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixPrismCentrals" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixPrismCentrals",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixPrismCentralConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixCategories(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): NutanixCategoryConnection!
        protected void InvokeQueryNutanixCategories()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            NutanixCategoryConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixCategoryConnection)psObject.BaseObject;
                } else {
                    fields = (NutanixCategoryConnection)this.Field;
                }
            }
            string document = Query.NutanixCategories(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixCategories");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixCategories" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixCategories",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixCategoryConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixCategoryValues(fid: UUID!): NutanixCategoryValueConnection!
        protected void InvokeQueryNutanixCategoryValues()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            NutanixCategoryValueConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixCategoryValueConnection)psObject.BaseObject;
                } else {
                    fields = (NutanixCategoryValueConnection)this.Field;
                }
            }
            string document = Query.NutanixCategoryValues(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixCategoryValues");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixCategoryValues" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixCategoryValues",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixCategoryValueConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixCategoryValueVms(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): NutanixVmConnection!
        protected void InvokeQueryNutanixCategoryValueVms()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            NutanixVmConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixVmConnection)psObject.BaseObject;
                } else {
                    fields = (NutanixVmConnection)this.Field;
                }
            }
            string document = Query.NutanixCategoryValueVms(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixCategoryValueVms");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixCategoryValueVms" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixCategoryValueVms",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixVmConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixVm(fid: UUID!): NutanixVm!
        protected void InvokeQueryNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            NutanixVm? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixVm)psObject.BaseObject;
                } else {
                    fields = (NutanixVm)this.Field;
                }
            }
            string document = Query.NutanixVm(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixVm");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixVm" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixVm",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixVm", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixMounts(
        //     first: Int
        //     after: String
        //     filters: [NutanixLiveMountFilterInput!]
        //     sortBy: NutanixLiveMountSortByInput
        //   ): NutanixLiveMountConnection!
        protected void InvokeQueryNutanixMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[NutanixLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "NutanixLiveMountSortByInput"),
            };
            NutanixLiveMountConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixLiveMountConnection)psObject.BaseObject;
                } else {
                    fields = (NutanixLiveMountConnection)this.Field;
                }
            }
            string document = Query.NutanixMounts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixMounts");
            var parameters = "($first: Int,$after: String,$filters: [NutanixLiveMountFilterInput!],$sortBy: NutanixLiveMountSortByInput)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixMounts" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixMounts",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixLiveMountConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixClusterContainers(input: GetContainersInput!): NutanixContainerListResponse!
        protected void InvokeQueryNutanixClusterContainers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetContainersInput!"),
            };
            NutanixContainerListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixContainerListResponse)psObject.BaseObject;
                } else {
                    fields = (NutanixContainerListResponse)this.Field;
                }
            }
            string document = Query.NutanixClusterContainers(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixClusterContainers");
            var parameters = "($input: GetContainersInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixClusterContainers" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixClusterContainers",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixContainerListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixClusterNetworks(input: GetNutanixNetworksInput!): NutanixNetworkListResponse!
        protected void InvokeQueryNutanixClusterNetworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixNetworksInput!"),
            };
            NutanixNetworkListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixNetworkListResponse)psObject.BaseObject;
                } else {
                    fields = (NutanixNetworkListResponse)this.Field;
                }
            }
            string document = Query.NutanixClusterNetworks(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixClusterNetworks");
            var parameters = "($input: GetNutanixNetworksInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixClusterNetworks" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixClusterNetworks",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixNetworkListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixClusterAsyncRequestStatus(input: GetNutanixClusterAsyncRequestStatusInput!): AsyncRequestStatus!
        protected void InvokeQueryNutanixClusterAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixClusterAsyncRequestStatusInput!"),
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
            string document = Query.NutanixClusterAsyncRequestStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixClusterAsyncRequestStatus");
            var parameters = "($input: GetNutanixClusterAsyncRequestStatusInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixClusterAsyncRequestStatus" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixClusterAsyncRequestStatus",
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

        // Invoke GraphQL Query:
        // nutanixVmAsyncRequestStatus(input: GetNutanixVmAsyncRequestStatusInput!): AsyncRequestStatus!
        protected void InvokeQueryNutanixVmAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixVmAsyncRequestStatusInput!"),
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
            string document = Query.NutanixVmAsyncRequestStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixVmAsyncRequestStatus");
            var parameters = "($input: GetNutanixVmAsyncRequestStatusInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixVmAsyncRequestStatus" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixVmAsyncRequestStatus",
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

        // Invoke GraphQL Query:
        // searchNutanixVm(input: SearchNutanixVmInput!): SearchResponseListResponse!
        protected void InvokeQuerySearchNutanixVm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SearchNutanixVmInput!"),
            };
            SearchResponseListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (SearchResponseListResponse)psObject.BaseObject;
                } else {
                    fields = (SearchResponseListResponse)this.Field;
                }
            }
            string document = Query.SearchNutanixVm(ref fields);
            this._input.Initialize(argDefs, fields, "Query.SearchNutanixVm");
            var parameters = "($input: SearchNutanixVmInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QuerySearchNutanixVm" + parameters + "{" + document + "}",
                OperationName = "QuerySearchNutanixVm",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "SearchResponseListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixVmMissedSnapshots(input: NutanixMissedSnapshotsInput!): MissedSnapshotListResponse!
        protected void InvokeQueryNutanixVmMissedSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "NutanixMissedSnapshotsInput!"),
            };
            MissedSnapshotListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MissedSnapshotListResponse)psObject.BaseObject;
                } else {
                    fields = (MissedSnapshotListResponse)this.Field;
                }
            }
            string document = Query.NutanixVmMissedSnapshots(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixVmMissedSnapshots");
            var parameters = "($input: NutanixMissedSnapshotsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixVmMissedSnapshots" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixVmMissedSnapshots",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MissedSnapshotListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixBrowseSnapshot(input: BrowseNutanixSnapshotInput!): BrowseResponseListResponse!
        protected void InvokeQueryNutanixBrowseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BrowseNutanixSnapshotInput!"),
            };
            BrowseResponseListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BrowseResponseListResponse)psObject.BaseObject;
                } else {
                    fields = (BrowseResponseListResponse)this.Field;
                }
            }
            string document = Query.NutanixBrowseSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixBrowseSnapshot");
            var parameters = "($input: BrowseNutanixSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixBrowseSnapshot" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixBrowseSnapshot",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BrowseResponseListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // nutanixSnapshotDetail(input: GetNutanixSnapshotDetailInput!): NutanixVmSnapshotDetail!
        protected void InvokeQueryNutanixSnapshotDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixSnapshotDetailInput!"),
            };
            NutanixVmSnapshotDetail? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NutanixVmSnapshotDetail)psObject.BaseObject;
                } else {
                    fields = (NutanixVmSnapshotDetail)this.Field;
                }
            }
            string document = Query.NutanixSnapshotDetail(ref fields);
            this._input.Initialize(argDefs, fields, "Query.NutanixSnapshotDetail");
            var parameters = "($input: GetNutanixSnapshotDetailInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryNutanixSnapshotDetail" + parameters + "{" + document + "}",
                OperationName = "QueryNutanixSnapshotDetail",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NutanixVmSnapshotDetail", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryNutanix
}