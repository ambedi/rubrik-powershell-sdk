// Db2LogSnapshot.cs
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
    #region Db2LogSnapshot
    public class Db2LogSnapshot: BaseType
    {
        #region members

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long! (scalar)
        [JsonProperty("internalTimestamp")]
        public System.Int64? InternalTimestamp { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        [JsonProperty("workloadType")]
        public System.String? WorkloadType { get; set; }

        //      C# -> Db2LogSnapshotAppMetadata? AppMetadata
        // GraphQL -> appMetadata: Db2LogSnapshotAppMetadata (type)
        [JsonProperty("appMetadata")]
        public Db2LogSnapshotAppMetadata? AppMetadata { get; set; }


        #endregion

    #region methods

    public Db2LogSnapshot Set(
        System.String? CdmId = null,
        System.String? ClusterUuid = null,
        DateTime? Date = null,
        System.String? Fid = null,
        System.Int64? InternalTimestamp = null,
        System.Boolean? IsArchived = null,
        System.String? WorkloadId = null,
        System.String? WorkloadType = null,
        Db2LogSnapshotAppMetadata? AppMetadata = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( InternalTimestamp != null ) {
            this.InternalTimestamp = InternalTimestamp;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
        }
        if ( AppMetadata != null ) {
            this.AppMetadata = AppMetadata;
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
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            s += ind + "cdmId\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (this.Date != null) {
            s += ind + "date\n" ;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid != null) {
            s += ind + "fid\n" ;
        }
        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long! (scalar)
        if (this.InternalTimestamp != null) {
            s += ind + "internalTimestamp\n" ;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId != null) {
            s += ind + "workloadId\n" ;
        }
        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        if (this.WorkloadType != null) {
            s += ind + "workloadType\n" ;
        }
        //      C# -> Db2LogSnapshotAppMetadata? AppMetadata
        // GraphQL -> appMetadata: Db2LogSnapshotAppMetadata (type)
        if (this.AppMetadata != null) {
            s += ind + "appMetadata {\n" + this.AppMetadata.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId == null && Exploration.Includes(parent + ".cdmId", true))
        {
            this.CdmId = new System.String("FETCH");
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = new System.String("FETCH");
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (this.Date == null && Exploration.Includes(parent + ".date", true))
        {
            this.Date = new DateTime();
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid == null && Exploration.Includes(parent + ".fid", true))
        {
            this.Fid = new System.String("FETCH");
        }
        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long! (scalar)
        if (this.InternalTimestamp == null && Exploration.Includes(parent + ".internalTimestamp", true))
        {
            this.InternalTimestamp = new System.Int64();
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived", true))
        {
            this.IsArchived = true;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId", true))
        {
            this.WorkloadId = new System.String("FETCH");
        }
        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        if (this.WorkloadType == null && Exploration.Includes(parent + ".workloadType", true))
        {
            this.WorkloadType = new System.String("FETCH");
        }
        //      C# -> Db2LogSnapshotAppMetadata? AppMetadata
        // GraphQL -> appMetadata: Db2LogSnapshotAppMetadata (type)
        if (this.AppMetadata == null && Exploration.Includes(parent + ".appMetadata"))
        {
            this.AppMetadata = new Db2LogSnapshotAppMetadata();
            this.AppMetadata.ApplyExploratoryFieldSpec(parent + ".appMetadata");
        }
    }


    #endregion

    } // class Db2LogSnapshot
    
    #endregion

    public static class ListDb2LogSnapshotExtensions
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
            this List<Db2LogSnapshot> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Db2LogSnapshot> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2LogSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types