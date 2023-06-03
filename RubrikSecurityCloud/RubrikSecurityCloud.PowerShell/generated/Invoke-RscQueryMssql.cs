// Invoke-RscQueryMssql.cs
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
        "RscQueryMssql",
        DefaultParameterSetName = "Database")
    ]
    public class Invoke_RscQueryMssql : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // TopLevelDescendant parameter set
        //
        // GraphQL operation: mssqlTopLevelDescendants(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   typeFilter: [HierarchyObjectTypeEnum!],   filter: [Filter!], ):MssqlTopLevelDescendantTypeConnection!
        //
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of the highest-level Microsoft SQL Objects accessible by the current user.
                GraphQL operation: mssqlTopLevelDescendants(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   typeFilter: [HierarchyObjectTypeEnum!],   filter: [Filter!], ):MssqlTopLevelDescendantTypeConnection!
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
        // Database parameter set
        //
        // GraphQL operation: mssqlDatabases(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):MssqlDatabaseConnection!
        //
        [Parameter(
            ParameterSetName = "Database",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of Microsoft SQL Databases.
                GraphQL operation: mssqlDatabases(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):MssqlDatabaseConnection!
                ",
            Position = 0
        )]
        public SwitchParameter Database { get; set; }

        
        // -------------------------------------------------------------------
        // AvailabilityGroup parameter set
        //
        // GraphQL operation: mssqlAvailabilityGroup(fid: UUID!):MssqlAvailabilityGroup!
        //
        [Parameter(
            ParameterSetName = "AvailabilityGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                A Microsoft SQL Availability Group.
                GraphQL operation: mssqlAvailabilityGroup(fid: UUID!):MssqlAvailabilityGroup!
                ",
            Position = 0
        )]
        public SwitchParameter AvailabilityGroup { get; set; }

        [Parameter(
            ParameterSetName = "AvailabilityGroup",
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
        // Instance parameter set
        //
        // GraphQL operation: mssqlInstance(fid: UUID!):MssqlInstance!
        //
        [Parameter(
            ParameterSetName = "Instance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                A Microsoft SQL Instance.
                GraphQL operation: mssqlInstance(fid: UUID!):MssqlInstance!
                ",
            Position = 0
        )]
        public SwitchParameter Instance { get; set; }

        
        // -------------------------------------------------------------------
        // RecoverableRange parameter set
        //
        // GraphQL operation: mssqlRecoverableRanges(input: GetMssqlDbRecoverableRangesInput!):MssqlRecoverableRangeListResponse!
        //
        [Parameter(
            ParameterSetName = "RecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                List of recoverable ranges for a Microsoft SQL Database.
                GraphQL operation: mssqlRecoverableRanges(input: GetMssqlDbRecoverableRangesInput!):MssqlRecoverableRangeListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter RecoverableRange { get; set; }

        [Parameter(
            ParameterSetName = "RecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Input for V1GetMssqlDbRecoverableRanges.
                GraphQL argument input: GetMssqlDbRecoverableRangesInput!
                "
        )]
        public GetMssqlDbRecoverableRangesInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // DatabaseMissedSnapshot parameter set
        //
        // GraphQL operation: mssqlDatabaseMissedSnapshots(input: GetMissedMssqlDbSnapshotsInput!):MissedSnapshotListResponse!
        //
        [Parameter(
            ParameterSetName = "DatabaseMissedSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                List of missed snapshots for a Microsoft SQL Database.
                GraphQL operation: mssqlDatabaseMissedSnapshots(input: GetMissedMssqlDbSnapshotsInput!):MissedSnapshotListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter DatabaseMissedSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // CompatibleInstance parameter set
        //
        // GraphQL operation: mssqlCompatibleInstances(input: GetCompatibleMssqlInstancesV1Input!):MssqlInstanceSummaryListResponse!
        //
        [Parameter(
            ParameterSetName = "CompatibleInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns all compatible instances for export for the specified recovery time.
                GraphQL operation: mssqlCompatibleInstances(input: GetCompatibleMssqlInstancesV1Input!):MssqlInstanceSummaryListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter CompatibleInstance { get; set; }

        
        // -------------------------------------------------------------------
        // DatabaseMissedRecoverableRange parameter set
        //
        // GraphQL operation: mssqlDatabaseMissedRecoverableRanges(input: GetMssqlDbMissedRecoverableRangesInput!):MssqlMissedRecoverableRangeListResponse!
        //
        [Parameter(
            ParameterSetName = "DatabaseMissedRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                List of missed recoverable ranges for a Microsoft SQL Database.
                GraphQL operation: mssqlDatabaseMissedRecoverableRanges(input: GetMssqlDbMissedRecoverableRangesInput!):MssqlMissedRecoverableRangeListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter DatabaseMissedRecoverableRange { get; set; }

        
        // -------------------------------------------------------------------
        // allDatabaseRestoreFile parameter set
        //
        // GraphQL operation: allMssqlDatabaseRestoreFiles(input: MssqlGetRestoreFilesV1Input!):V1MssqlGetRestoreFilesV1Response!
        //
        [Parameter(
            ParameterSetName = "allDatabaseRestoreFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Provides a list of database files to be restored for the specified restore or export operation.
                GraphQL operation: allMssqlDatabaseRestoreFiles(input: MssqlGetRestoreFilesV1Input!):V1MssqlGetRestoreFilesV1Response!
                ",
            Position = 0
        )]
        public SwitchParameter allDatabaseRestoreFile { get; set; }

        
        // -------------------------------------------------------------------
        // DatabaseLiveMount parameter set
        //
        // GraphQL operation: mssqlDatabaseLiveMounts(,   first: Int,   after: String,   sortBy: MssqlDatabaseLiveMountSortByInput,   filters: [MssqlDatabaseLiveMountFilterInput!], ):MssqlDatabaseLiveMountConnection!
        //
        [Parameter(
            ParameterSetName = "DatabaseLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of Microsoft SQL Database live mounts.
                GraphQL operation: mssqlDatabaseLiveMounts(,   first: Int,   after: String,   sortBy: MssqlDatabaseLiveMountSortByInput,   filters: [MssqlDatabaseLiveMountFilterInput!], ):MssqlDatabaseLiveMountConnection!
                ",
            Position = 0
        )]
        public SwitchParameter DatabaseLiveMount { get; set; }

        [Parameter(
            ParameterSetName = "DatabaseLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Filters for Mssql database live mounts.
                GraphQL argument filters: [MssqlDatabaseLiveMountFilterInput!]
                "
        )]
        public List<MssqlDatabaseLiveMountFilterInput>? Filters { get; set; }
        
        // -------------------------------------------------------------------
        // DefaultPropertie parameter set
        //
        // GraphQL operation: mssqlDefaultProperties(input: GetDefaultDbPropertiesV1Input!):UpdateMssqlDefaultPropertiesReply!
        //
        [Parameter(
            ParameterSetName = "DefaultPropertie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The current default properties for Microsoft SQL databases.
                GraphQL operation: mssqlDefaultProperties(input: GetDefaultDbPropertiesV1Input!):UpdateMssqlDefaultPropertiesReply!
                ",
            Position = 0
        )]
        public SwitchParameter DefaultPropertie { get; set; }

        
        // -------------------------------------------------------------------
        // DatabaseRestoreEstimate parameter set
        //
        // GraphQL operation: mssqlDatabaseRestoreEstimate(input: MssqlRestoreEstimateV1Input!):MssqlRestoreEstimateResult!
        //
        [Parameter(
            ParameterSetName = "DatabaseRestoreEstimate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns a size estimate for a restore, export, or mount.
                GraphQL operation: mssqlDatabaseRestoreEstimate(input: MssqlRestoreEstimateV1Input!):MssqlRestoreEstimateResult!
                ",
            Position = 0
        )]
        public SwitchParameter DatabaseRestoreEstimate { get; set; }

        
        // -------------------------------------------------------------------
        // cdmLogShippingTarget parameter set
        //
        // GraphQL operation: cdmMssqlLogShippingTargets(,   first: Int,   after: String,   sortBy: MssqlLogShippingTargetSortByInput,   filters: [MssqlLogShippingTargetFilterInput!], ):MssqlLogShippingTargetConnection!
        //
        [Parameter(
            ParameterSetName = "cdmLogShippingTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of Microsoft SQL log shipping target.
                GraphQL operation: cdmMssqlLogShippingTargets(,   first: Int,   after: String,   sortBy: MssqlLogShippingTargetSortByInput,   filters: [MssqlLogShippingTargetFilterInput!], ):MssqlLogShippingTargetConnection!
                ",
            Position = 0
        )]
        public SwitchParameter cdmLogShippingTarget { get; set; }

        
        // -------------------------------------------------------------------
        // LogShippingTarget parameter set
        //
        // GraphQL operation: mssqlLogShippingTargets(input: QueryLogShippingConfigurationsV2Input!):MssqlLogShippingSummaryV2ListResponse
        //
        [Parameter(
            ParameterSetName = "LogShippingTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                List of filtered Microsoft SQL log shipping targets.
                GraphQL operation: mssqlLogShippingTargets(input: QueryLogShippingConfigurationsV2Input!):MssqlLogShippingSummaryV2ListResponse
                ",
            Position = 0
        )]
        public SwitchParameter LogShippingTarget { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "TopLevelDescendant":
                        this.ProcessRecord_TopLevelDescendant();
                        break;
                    case "Database":
                        this.ProcessRecord_Database();
                        break;
                    case "AvailabilityGroup":
                        this.ProcessRecord_AvailabilityGroup();
                        break;
                    case "Instance":
                        this.ProcessRecord_Instance();
                        break;
                    case "RecoverableRange":
                        this.ProcessRecord_RecoverableRange();
                        break;
                    case "DatabaseMissedSnapshot":
                        this.ProcessRecord_DatabaseMissedSnapshot();
                        break;
                    case "CompatibleInstance":
                        this.ProcessRecord_CompatibleInstance();
                        break;
                    case "DatabaseMissedRecoverableRange":
                        this.ProcessRecord_DatabaseMissedRecoverableRange();
                        break;
                    case "allDatabaseRestoreFile":
                        this.ProcessRecord_allDatabaseRestoreFile();
                        break;
                    case "DatabaseLiveMount":
                        this.ProcessRecord_DatabaseLiveMount();
                        break;
                    case "DefaultPropertie":
                        this.ProcessRecord_DefaultPropertie();
                        break;
                    case "DatabaseRestoreEstimate":
                        this.ProcessRecord_DatabaseRestoreEstimate();
                        break;
                    case "cdmLogShippingTarget":
                        this.ProcessRecord_cdmLogShippingTarget();
                        break;
                    case "LogShippingTarget":
                        this.ProcessRecord_LogShippingTarget();
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
                    "Invoke-RscQueryMssql",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // mssqlTopLevelDescendants.
        protected void ProcessRecord_TopLevelDescendant()
        {
            this._logger.name += " -TopLevelDescendant";
            // Invoke graphql operation mssqlTopLevelDescendants
            InvokeQueryMssqlTopLevelDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabases.
        protected void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
            // Invoke graphql operation mssqlDatabases
            InvokeQueryMssqlDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlAvailabilityGroup.
        protected void ProcessRecord_AvailabilityGroup()
        {
            this._logger.name += " -AvailabilityGroup";
            // Invoke graphql operation mssqlAvailabilityGroup
            InvokeQueryMssqlAvailabilityGroup();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlInstance.
        protected void ProcessRecord_Instance()
        {
            this._logger.name += " -Instance";
            // Invoke graphql operation mssqlInstance
            InvokeQueryMssqlInstance();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlRecoverableRanges.
        protected void ProcessRecord_RecoverableRange()
        {
            this._logger.name += " -RecoverableRange";
            // Invoke graphql operation mssqlRecoverableRanges
            InvokeQueryMssqlRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseMissedSnapshots.
        protected void ProcessRecord_DatabaseMissedSnapshot()
        {
            this._logger.name += " -DatabaseMissedSnapshot";
            // Invoke graphql operation mssqlDatabaseMissedSnapshots
            InvokeQueryMssqlDatabaseMissedSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlCompatibleInstances.
        protected void ProcessRecord_CompatibleInstance()
        {
            this._logger.name += " -CompatibleInstance";
            // Invoke graphql operation mssqlCompatibleInstances
            InvokeQueryMssqlCompatibleInstances();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseMissedRecoverableRanges.
        protected void ProcessRecord_DatabaseMissedRecoverableRange()
        {
            this._logger.name += " -DatabaseMissedRecoverableRange";
            // Invoke graphql operation mssqlDatabaseMissedRecoverableRanges
            InvokeQueryMssqlDatabaseMissedRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // allMssqlDatabaseRestoreFiles.
        protected void ProcessRecord_allDatabaseRestoreFile()
        {
            this._logger.name += " -allDatabaseRestoreFile";
            // Invoke graphql operation allMssqlDatabaseRestoreFiles
            InvokeQueryAllMssqlDatabaseRestoreFiles();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseLiveMounts.
        protected void ProcessRecord_DatabaseLiveMount()
        {
            this._logger.name += " -DatabaseLiveMount";
            // Invoke graphql operation mssqlDatabaseLiveMounts
            InvokeQueryMssqlDatabaseLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDefaultProperties.
        protected void ProcessRecord_DefaultPropertie()
        {
            this._logger.name += " -DefaultPropertie";
            // Invoke graphql operation mssqlDefaultProperties
            InvokeQueryMssqlDefaultProperties();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseRestoreEstimate.
        protected void ProcessRecord_DatabaseRestoreEstimate()
        {
            this._logger.name += " -DatabaseRestoreEstimate";
            // Invoke graphql operation mssqlDatabaseRestoreEstimate
            InvokeQueryMssqlDatabaseRestoreEstimate();
        }

        // This parameter set invokes a single graphql operation:
        // cdmMssqlLogShippingTargets.
        protected void ProcessRecord_cdmLogShippingTarget()
        {
            this._logger.name += " -cdmLogShippingTarget";
            // Invoke graphql operation cdmMssqlLogShippingTargets
            InvokeQueryCdmMssqlLogShippingTargets();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlLogShippingTargets.
        protected void ProcessRecord_LogShippingTarget()
        {
            this._logger.name += " -LogShippingTarget";
            // Invoke graphql operation mssqlLogShippingTargets
            InvokeQueryMssqlLogShippingTargets();
        }


        // Invoke GraphQL Query:
        // mssqlTopLevelDescendants(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): MssqlTopLevelDescendantTypeConnection!
        protected void InvokeQueryMssqlTopLevelDescendants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            MssqlTopLevelDescendantTypeConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MssqlTopLevelDescendantTypeConnection)psObject.BaseObject;
                } else {
                    fields = (MssqlTopLevelDescendantTypeConnection)this.Field;
                }
            }
            string document = Query.MssqlTopLevelDescendants(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlTopLevelDescendants");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlTopLevelDescendants" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlTopLevelDescendants",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MssqlTopLevelDescendantTypeConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // mssqlDatabases(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MssqlDatabaseConnection!
        protected void InvokeQueryMssqlDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            MssqlDatabaseConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MssqlDatabaseConnection)psObject.BaseObject;
                } else {
                    fields = (MssqlDatabaseConnection)this.Field;
                }
            }
            string document = Query.MssqlDatabases(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlDatabases");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlDatabases" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlDatabases",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MssqlDatabaseConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // mssqlAvailabilityGroup(fid: UUID!): MssqlAvailabilityGroup!
        protected void InvokeQueryMssqlAvailabilityGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            MssqlAvailabilityGroup? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MssqlAvailabilityGroup)psObject.BaseObject;
                } else {
                    fields = (MssqlAvailabilityGroup)this.Field;
                }
            }
            string document = Query.MssqlAvailabilityGroup(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlAvailabilityGroup");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlAvailabilityGroup" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlAvailabilityGroup",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MssqlAvailabilityGroup", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // mssqlInstance(fid: UUID!): MssqlInstance!
        protected void InvokeQueryMssqlInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            MssqlInstance? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MssqlInstance)psObject.BaseObject;
                } else {
                    fields = (MssqlInstance)this.Field;
                }
            }
            string document = Query.MssqlInstance(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlInstance");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlInstance" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlInstance",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MssqlInstance", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // mssqlRecoverableRanges(input: GetMssqlDbRecoverableRangesInput!): MssqlRecoverableRangeListResponse!
        protected void InvokeQueryMssqlRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMssqlDbRecoverableRangesInput!"),
            };
            MssqlRecoverableRangeListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MssqlRecoverableRangeListResponse)psObject.BaseObject;
                } else {
                    fields = (MssqlRecoverableRangeListResponse)this.Field;
                }
            }
            string document = Query.MssqlRecoverableRanges(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlRecoverableRanges");
            var parameters = "($input: GetMssqlDbRecoverableRangesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlRecoverableRanges" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlRecoverableRanges",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MssqlRecoverableRangeListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // mssqlDatabaseMissedSnapshots(input: GetMissedMssqlDbSnapshotsInput!): MissedSnapshotListResponse!
        protected void InvokeQueryMssqlDatabaseMissedSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMissedMssqlDbSnapshotsInput!"),
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
            string document = Query.MssqlDatabaseMissedSnapshots(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlDatabaseMissedSnapshots");
            var parameters = "($input: GetMissedMssqlDbSnapshotsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlDatabaseMissedSnapshots" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlDatabaseMissedSnapshots",
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
        // mssqlCompatibleInstances(input: GetCompatibleMssqlInstancesV1Input!): MssqlInstanceSummaryListResponse!
        protected void InvokeQueryMssqlCompatibleInstances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetCompatibleMssqlInstancesV1Input!"),
            };
            MssqlInstanceSummaryListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MssqlInstanceSummaryListResponse)psObject.BaseObject;
                } else {
                    fields = (MssqlInstanceSummaryListResponse)this.Field;
                }
            }
            string document = Query.MssqlCompatibleInstances(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlCompatibleInstances");
            var parameters = "($input: GetCompatibleMssqlInstancesV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlCompatibleInstances" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlCompatibleInstances",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MssqlInstanceSummaryListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // mssqlDatabaseMissedRecoverableRanges(input: GetMssqlDbMissedRecoverableRangesInput!): MssqlMissedRecoverableRangeListResponse!
        protected void InvokeQueryMssqlDatabaseMissedRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMssqlDbMissedRecoverableRangesInput!"),
            };
            MssqlMissedRecoverableRangeListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MssqlMissedRecoverableRangeListResponse)psObject.BaseObject;
                } else {
                    fields = (MssqlMissedRecoverableRangeListResponse)this.Field;
                }
            }
            string document = Query.MssqlDatabaseMissedRecoverableRanges(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlDatabaseMissedRecoverableRanges");
            var parameters = "($input: GetMssqlDbMissedRecoverableRangesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlDatabaseMissedRecoverableRanges" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlDatabaseMissedRecoverableRanges",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MssqlMissedRecoverableRangeListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allMssqlDatabaseRestoreFiles(input: MssqlGetRestoreFilesV1Input!): V1MssqlGetRestoreFilesV1Response!
        protected void InvokeQueryAllMssqlDatabaseRestoreFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MssqlGetRestoreFilesV1Input!"),
            };
            V1MssqlGetRestoreFilesV1Response? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (V1MssqlGetRestoreFilesV1Response)psObject.BaseObject;
                } else {
                    fields = (V1MssqlGetRestoreFilesV1Response)this.Field;
                }
            }
            string document = Query.AllMssqlDatabaseRestoreFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllMssqlDatabaseRestoreFiles");
            var parameters = "($input: MssqlGetRestoreFilesV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllMssqlDatabaseRestoreFiles" + parameters + "{" + document + "}",
                OperationName = "QueryAllMssqlDatabaseRestoreFiles",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "V1MssqlGetRestoreFilesV1Response", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // mssqlDatabaseLiveMounts(
        //     first: Int
        //     after: String
        //     sortBy: MssqlDatabaseLiveMountSortByInput
        //     filters: [MssqlDatabaseLiveMountFilterInput!]
        //   ): MssqlDatabaseLiveMountConnection!
        protected void InvokeQueryMssqlDatabaseLiveMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "MssqlDatabaseLiveMountSortByInput"),
                Tuple.Create("filters", "[MssqlDatabaseLiveMountFilterInput!]"),
            };
            MssqlDatabaseLiveMountConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MssqlDatabaseLiveMountConnection)psObject.BaseObject;
                } else {
                    fields = (MssqlDatabaseLiveMountConnection)this.Field;
                }
            }
            string document = Query.MssqlDatabaseLiveMounts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlDatabaseLiveMounts");
            var parameters = "($first: Int,$after: String,$sortBy: MssqlDatabaseLiveMountSortByInput,$filters: [MssqlDatabaseLiveMountFilterInput!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlDatabaseLiveMounts" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlDatabaseLiveMounts",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MssqlDatabaseLiveMountConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // mssqlDefaultProperties(input: GetDefaultDbPropertiesV1Input!): UpdateMssqlDefaultPropertiesReply!
        protected void InvokeQueryMssqlDefaultProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetDefaultDbPropertiesV1Input!"),
            };
            UpdateMssqlDefaultPropertiesReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateMssqlDefaultPropertiesReply)psObject.BaseObject;
                } else {
                    fields = (UpdateMssqlDefaultPropertiesReply)this.Field;
                }
            }
            string document = Query.MssqlDefaultProperties(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlDefaultProperties");
            var parameters = "($input: GetDefaultDbPropertiesV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlDefaultProperties" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlDefaultProperties",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateMssqlDefaultPropertiesReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // mssqlDatabaseRestoreEstimate(input: MssqlRestoreEstimateV1Input!): MssqlRestoreEstimateResult!
        protected void InvokeQueryMssqlDatabaseRestoreEstimate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MssqlRestoreEstimateV1Input!"),
            };
            MssqlRestoreEstimateResult? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MssqlRestoreEstimateResult)psObject.BaseObject;
                } else {
                    fields = (MssqlRestoreEstimateResult)this.Field;
                }
            }
            string document = Query.MssqlDatabaseRestoreEstimate(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlDatabaseRestoreEstimate");
            var parameters = "($input: MssqlRestoreEstimateV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlDatabaseRestoreEstimate" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlDatabaseRestoreEstimate",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MssqlRestoreEstimateResult", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // cdmMssqlLogShippingTargets(
        //     first: Int
        //     after: String
        //     sortBy: MssqlLogShippingTargetSortByInput
        //     filters: [MssqlLogShippingTargetFilterInput!]
        //   ): MssqlLogShippingTargetConnection!
        protected void InvokeQueryCdmMssqlLogShippingTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "MssqlLogShippingTargetSortByInput"),
                Tuple.Create("filters", "[MssqlLogShippingTargetFilterInput!]"),
            };
            MssqlLogShippingTargetConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MssqlLogShippingTargetConnection)psObject.BaseObject;
                } else {
                    fields = (MssqlLogShippingTargetConnection)this.Field;
                }
            }
            string document = Query.CdmMssqlLogShippingTargets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.CdmMssqlLogShippingTargets");
            var parameters = "($first: Int,$after: String,$sortBy: MssqlLogShippingTargetSortByInput,$filters: [MssqlLogShippingTargetFilterInput!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryCdmMssqlLogShippingTargets" + parameters + "{" + document + "}",
                OperationName = "QueryCdmMssqlLogShippingTargets",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MssqlLogShippingTargetConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // mssqlLogShippingTargets(input: QueryLogShippingConfigurationsV2Input!): MssqlLogShippingSummaryV2ListResponse
        protected void InvokeQueryMssqlLogShippingTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryLogShippingConfigurationsV2Input!"),
            };
            MssqlLogShippingSummaryV2ListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MssqlLogShippingSummaryV2ListResponse)psObject.BaseObject;
                } else {
                    fields = (MssqlLogShippingSummaryV2ListResponse)this.Field;
                }
            }
            string document = Query.MssqlLogShippingTargets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlLogShippingTargets");
            var parameters = "($input: QueryLogShippingConfigurationsV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlLogShippingTargets" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlLogShippingTargets",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MssqlLogShippingSummaryV2ListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryMssql
}