// SnappableAggregation.cs
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
    #region SnappableAggregation
    public class SnappableAggregation: BaseType
    {
        #region members

        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long! (scalar)
        [JsonProperty("archiveStorage")]
        public System.Int64? ArchiveStorage { get; set; }

        //      C# -> System.Int64? LastSnapshotLogicalBytes
        // GraphQL -> lastSnapshotLogicalBytes: Long! (scalar)
        [JsonProperty("lastSnapshotLogicalBytes")]
        public System.Int64? LastSnapshotLogicalBytes { get; set; }

        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long! (scalar)
        [JsonProperty("logicalBytes")]
        public System.Int64? LogicalBytes { get; set; }

        //      C# -> System.Int32? MissedSnapshots
        // GraphQL -> missedSnapshots: Int! (scalar)
        [JsonProperty("missedSnapshots")]
        public System.Int32? MissedSnapshots { get; set; }

        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long! (scalar)
        [JsonProperty("physicalBytes")]
        public System.Int64? PhysicalBytes { get; set; }

        //      C# -> System.Int64? ReplicaStorage
        // GraphQL -> replicaStorage: Long! (scalar)
        [JsonProperty("replicaStorage")]
        public System.Int64? ReplicaStorage { get; set; }

        //      C# -> System.Int32? TotalSnapshots
        // GraphQL -> totalSnapshots: Int! (scalar)
        [JsonProperty("totalSnapshots")]
        public System.Int32? TotalSnapshots { get; set; }

        //      C# -> System.Int64? TransferredBytes
        // GraphQL -> transferredBytes: Long! (scalar)
        [JsonProperty("transferredBytes")]
        public System.Int64? TransferredBytes { get; set; }


        #endregion

    #region methods

    public SnappableAggregation Set(
        System.Int64? ArchiveStorage = null,
        System.Int64? LastSnapshotLogicalBytes = null,
        System.Int64? LogicalBytes = null,
        System.Int32? MissedSnapshots = null,
        System.Int64? PhysicalBytes = null,
        System.Int64? ReplicaStorage = null,
        System.Int32? TotalSnapshots = null,
        System.Int64? TransferredBytes = null
    ) 
    {
        if ( ArchiveStorage != null ) {
            this.ArchiveStorage = ArchiveStorage;
        }
        if ( LastSnapshotLogicalBytes != null ) {
            this.LastSnapshotLogicalBytes = LastSnapshotLogicalBytes;
        }
        if ( LogicalBytes != null ) {
            this.LogicalBytes = LogicalBytes;
        }
        if ( MissedSnapshots != null ) {
            this.MissedSnapshots = MissedSnapshots;
        }
        if ( PhysicalBytes != null ) {
            this.PhysicalBytes = PhysicalBytes;
        }
        if ( ReplicaStorage != null ) {
            this.ReplicaStorage = ReplicaStorage;
        }
        if ( TotalSnapshots != null ) {
            this.TotalSnapshots = TotalSnapshots;
        }
        if ( TransferredBytes != null ) {
            this.TransferredBytes = TransferredBytes;
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
        // GraphQL -> archiveStorage: Long! (scalar)
        if (this.ArchiveStorage != null) {
            s += ind + "archiveStorage\n" ;
        }
        //      C# -> System.Int64? LastSnapshotLogicalBytes
        // GraphQL -> lastSnapshotLogicalBytes: Long! (scalar)
        if (this.LastSnapshotLogicalBytes != null) {
            s += ind + "lastSnapshotLogicalBytes\n" ;
        }
        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long! (scalar)
        if (this.LogicalBytes != null) {
            s += ind + "logicalBytes\n" ;
        }
        //      C# -> System.Int32? MissedSnapshots
        // GraphQL -> missedSnapshots: Int! (scalar)
        if (this.MissedSnapshots != null) {
            s += ind + "missedSnapshots\n" ;
        }
        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long! (scalar)
        if (this.PhysicalBytes != null) {
            s += ind + "physicalBytes\n" ;
        }
        //      C# -> System.Int64? ReplicaStorage
        // GraphQL -> replicaStorage: Long! (scalar)
        if (this.ReplicaStorage != null) {
            s += ind + "replicaStorage\n" ;
        }
        //      C# -> System.Int32? TotalSnapshots
        // GraphQL -> totalSnapshots: Int! (scalar)
        if (this.TotalSnapshots != null) {
            s += ind + "totalSnapshots\n" ;
        }
        //      C# -> System.Int64? TransferredBytes
        // GraphQL -> transferredBytes: Long! (scalar)
        if (this.TransferredBytes != null) {
            s += ind + "transferredBytes\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long! (scalar)
        if (this.ArchiveStorage == null && Exploration.Includes(parent + ".archiveStorage", true))
        {
            this.ArchiveStorage = new System.Int64();
        }
        //      C# -> System.Int64? LastSnapshotLogicalBytes
        // GraphQL -> lastSnapshotLogicalBytes: Long! (scalar)
        if (this.LastSnapshotLogicalBytes == null && Exploration.Includes(parent + ".lastSnapshotLogicalBytes", true))
        {
            this.LastSnapshotLogicalBytes = new System.Int64();
        }
        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long! (scalar)
        if (this.LogicalBytes == null && Exploration.Includes(parent + ".logicalBytes", true))
        {
            this.LogicalBytes = new System.Int64();
        }
        //      C# -> System.Int32? MissedSnapshots
        // GraphQL -> missedSnapshots: Int! (scalar)
        if (this.MissedSnapshots == null && Exploration.Includes(parent + ".missedSnapshots", true))
        {
            this.MissedSnapshots = new System.Int32();
        }
        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long! (scalar)
        if (this.PhysicalBytes == null && Exploration.Includes(parent + ".physicalBytes", true))
        {
            this.PhysicalBytes = new System.Int64();
        }
        //      C# -> System.Int64? ReplicaStorage
        // GraphQL -> replicaStorage: Long! (scalar)
        if (this.ReplicaStorage == null && Exploration.Includes(parent + ".replicaStorage", true))
        {
            this.ReplicaStorage = new System.Int64();
        }
        //      C# -> System.Int32? TotalSnapshots
        // GraphQL -> totalSnapshots: Int! (scalar)
        if (this.TotalSnapshots == null && Exploration.Includes(parent + ".totalSnapshots", true))
        {
            this.TotalSnapshots = new System.Int32();
        }
        //      C# -> System.Int64? TransferredBytes
        // GraphQL -> transferredBytes: Long! (scalar)
        if (this.TransferredBytes == null && Exploration.Includes(parent + ".transferredBytes", true))
        {
            this.TransferredBytes = new System.Int64();
        }
    }


    #endregion

    } // class SnappableAggregation
    
    #endregion

    public static class ListSnappableAggregationExtensions
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
            this List<SnappableAggregation> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnappableAggregation> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnappableAggregation());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types