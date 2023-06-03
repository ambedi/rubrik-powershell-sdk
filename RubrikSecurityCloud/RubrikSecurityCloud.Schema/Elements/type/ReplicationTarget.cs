// ReplicationTarget.cs
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
    #region ReplicationTarget
    public class ReplicationTarget: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? TargetClusterAddress
        // GraphQL -> targetClusterAddress: String (scalar)
        [JsonProperty("targetClusterAddress")]
        public System.String? TargetClusterAddress { get; set; }

        //      C# -> System.String? TargetClusterName
        // GraphQL -> targetClusterName: String! (scalar)
        [JsonProperty("targetClusterName")]
        public System.String? TargetClusterName { get; set; }

        //      C# -> System.String? TargetClusterUuid
        // GraphQL -> targetClusterUuid: UUID! (scalar)
        [JsonProperty("targetClusterUuid")]
        public System.String? TargetClusterUuid { get; set; }

        //      C# -> System.Int64? TotalStorage
        // GraphQL -> totalStorage: Long (scalar)
        [JsonProperty("totalStorage")]
        public System.Int64? TotalStorage { get; set; }


        #endregion

    #region methods

    public ReplicationTarget Set(
        System.String? Id = null,
        System.String? TargetClusterAddress = null,
        System.String? TargetClusterName = null,
        System.String? TargetClusterUuid = null,
        System.Int64? TotalStorage = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( TargetClusterAddress != null ) {
            this.TargetClusterAddress = TargetClusterAddress;
        }
        if ( TargetClusterName != null ) {
            this.TargetClusterName = TargetClusterName;
        }
        if ( TargetClusterUuid != null ) {
            this.TargetClusterUuid = TargetClusterUuid;
        }
        if ( TotalStorage != null ) {
            this.TotalStorage = TotalStorage;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? TargetClusterAddress
        // GraphQL -> targetClusterAddress: String (scalar)
        if (this.TargetClusterAddress != null) {
            s += ind + "targetClusterAddress\n" ;
        }
        //      C# -> System.String? TargetClusterName
        // GraphQL -> targetClusterName: String! (scalar)
        if (this.TargetClusterName != null) {
            s += ind + "targetClusterName\n" ;
        }
        //      C# -> System.String? TargetClusterUuid
        // GraphQL -> targetClusterUuid: UUID! (scalar)
        if (this.TargetClusterUuid != null) {
            s += ind + "targetClusterUuid\n" ;
        }
        //      C# -> System.Int64? TotalStorage
        // GraphQL -> totalStorage: Long (scalar)
        if (this.TotalStorage != null) {
            s += ind + "totalStorage\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? TargetClusterAddress
        // GraphQL -> targetClusterAddress: String (scalar)
        if (this.TargetClusterAddress == null && Exploration.Includes(parent + ".targetClusterAddress", true))
        {
            this.TargetClusterAddress = new System.String("FETCH");
        }
        //      C# -> System.String? TargetClusterName
        // GraphQL -> targetClusterName: String! (scalar)
        if (this.TargetClusterName == null && Exploration.Includes(parent + ".targetClusterName", true))
        {
            this.TargetClusterName = new System.String("FETCH");
        }
        //      C# -> System.String? TargetClusterUuid
        // GraphQL -> targetClusterUuid: UUID! (scalar)
        if (this.TargetClusterUuid == null && Exploration.Includes(parent + ".targetClusterUuid", true))
        {
            this.TargetClusterUuid = new System.String("FETCH");
        }
        //      C# -> System.Int64? TotalStorage
        // GraphQL -> totalStorage: Long (scalar)
        if (this.TotalStorage == null && Exploration.Includes(parent + ".totalStorage", true))
        {
            this.TotalStorage = new System.Int64();
        }
    }


    #endregion

    } // class ReplicationTarget
    
    #endregion

    public static class ListReplicationTargetExtensions
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
            this List<ReplicationTarget> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationTarget> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationTarget());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types