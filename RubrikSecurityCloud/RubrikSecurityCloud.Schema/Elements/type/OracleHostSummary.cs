// OracleHostSummary.cs
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
    #region OracleHostSummary
    public class OracleHostSummary: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        [JsonProperty("hasLogConfigFromSla")]
        public System.Boolean? HasLogConfigFromSla { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        [JsonProperty("numDbs")]
        public System.Int32? NumDbs { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
        // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
        [JsonProperty("infraPath")]
        public List<ManagedHierarchyObjectAncestor>? InfraPath { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }


        #endregion

    #region methods

    public OracleHostSummary Set(
        System.Boolean? HasLogConfigFromSla = null,
        System.String? HostId = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Int32? NumDbs = null,
        System.String? PrimaryClusterId = null,
        System.String? Status = null,
        List<ManagedHierarchyObjectAncestor>? InfraPath = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( HasLogConfigFromSla != null ) {
            this.HasLogConfigFromSla = HasLogConfigFromSla;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumDbs != null ) {
            this.NumDbs = NumDbs;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( InfraPath != null ) {
            this.InfraPath = InfraPath;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
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
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (this.HasLogConfigFromSla != null) {
            s += ind + "hasLogConfigFromSla\n" ;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (this.HostId != null) {
            s += ind + "hostId\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        if (this.NumDbs != null) {
            s += ind + "numDbs\n" ;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            s += ind + "primaryClusterId\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
        // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
        if (this.InfraPath != null) {
            s += ind + "infraPath {\n" + this.InfraPath.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            s += ind + "slaAssignable {\n" + this.SlaAssignable.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (this.HasLogConfigFromSla == null && Exploration.Includes(parent + ".hasLogConfigFromSla", true))
        {
            this.HasLogConfigFromSla = true;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (this.HostId == null && Exploration.Includes(parent + ".hostId", true))
        {
            this.HostId = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        if (this.NumDbs == null && Exploration.Includes(parent + ".numDbs", true))
        {
            this.NumDbs = new System.Int32();
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId", true))
        {
            this.PrimaryClusterId = new System.String("FETCH");
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new System.String("FETCH");
        }
        //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
        // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
        if (this.InfraPath == null && Exploration.Includes(parent + ".infraPath"))
        {
            this.InfraPath = new List<ManagedHierarchyObjectAncestor>();
            this.InfraPath.ApplyExploratoryFieldSpec(parent + ".infraPath");
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
        {
            this.SlaAssignable = new SlaAssignable();
            this.SlaAssignable.ApplyExploratoryFieldSpec(parent + ".slaAssignable");
        }
    }


    #endregion

    } // class OracleHostSummary
    
    #endregion

    public static class ListOracleHostSummaryExtensions
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
            this List<OracleHostSummary> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleHostSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleHostSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types