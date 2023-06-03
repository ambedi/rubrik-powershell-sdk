// K8sNamespaceConnection.cs
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
    #region K8sNamespaceConnection
    public class K8sNamespaceConnection: BaseType
    {
        #region members

        //      C# -> System.Int32? AggregateK8sPvcs
        // GraphQL -> aggregateK8sPvcs: Int! (scalar)
        [JsonProperty("aggregateK8sPvcs")]
        public System.Int32? AggregateK8sPvcs { get; set; }

        //      C# -> System.Int32? AggregateK8sWorkloads
        // GraphQL -> aggregateK8sWorkloads: Int! (scalar)
        [JsonProperty("aggregateK8sWorkloads")]
        public System.Int32? AggregateK8sWorkloads { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> List<K8sNamespaceEdge>? Edges
        // GraphQL -> edges: [K8sNamespaceEdge!]! (type)
        [JsonProperty("edges")]
        public List<K8sNamespaceEdge>? Edges { get; set; }

        //      C# -> List<K8sNamespace>? Nodes
        // GraphQL -> nodes: [K8sNamespace!]! (type)
        [JsonProperty("nodes")]
        public List<K8sNamespace>? Nodes { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public K8sNamespaceConnection Set(
        System.Int32? AggregateK8sPvcs = null,
        System.Int32? AggregateK8sWorkloads = null,
        System.Int32? Count = null,
        List<K8sNamespaceEdge>? Edges = null,
        List<K8sNamespace>? Nodes = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( AggregateK8sPvcs != null ) {
            this.AggregateK8sPvcs = AggregateK8sPvcs;
        }
        if ( AggregateK8sWorkloads != null ) {
            this.AggregateK8sWorkloads = AggregateK8sWorkloads;
        }
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( Edges != null ) {
            this.Edges = Edges;
        }
        if ( Nodes != null ) {
            this.Nodes = Nodes;
        }
        if ( PageInfo != null ) {
            this.PageInfo = PageInfo;
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
        //      C# -> System.Int32? AggregateK8sPvcs
        // GraphQL -> aggregateK8sPvcs: Int! (scalar)
        if (this.AggregateK8sPvcs != null) {
            s += ind + "aggregateK8sPvcs\n" ;
        }
        //      C# -> System.Int32? AggregateK8sWorkloads
        // GraphQL -> aggregateK8sWorkloads: Int! (scalar)
        if (this.AggregateK8sWorkloads != null) {
            s += ind + "aggregateK8sWorkloads\n" ;
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> List<K8sNamespaceEdge>? Edges
        // GraphQL -> edges: [K8sNamespaceEdge!]! (type)
        if (this.Edges != null) {
            s += ind + "edges {\n" + this.Edges.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<K8sNamespace>? Nodes
        // GraphQL -> nodes: [K8sNamespace!]! (type)
        if (this.Nodes != null) {
            s += ind + "nodes {\n" + this.Nodes.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            s += ind + "pageInfo {\n" + this.PageInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? AggregateK8sPvcs
        // GraphQL -> aggregateK8sPvcs: Int! (scalar)
        if (this.AggregateK8sPvcs == null && Exploration.Includes(parent + ".aggregateK8sPvcs", true))
        {
            this.AggregateK8sPvcs = new System.Int32();
        }
        //      C# -> System.Int32? AggregateK8sWorkloads
        // GraphQL -> aggregateK8sWorkloads: Int! (scalar)
        if (this.AggregateK8sWorkloads == null && Exploration.Includes(parent + ".aggregateK8sWorkloads", true))
        {
            this.AggregateK8sWorkloads = new System.Int32();
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = new System.Int32();
        }
        //      C# -> List<K8sNamespaceEdge>? Edges
        // GraphQL -> edges: [K8sNamespaceEdge!]! (type)
        if (this.Edges == null && Exploration.Includes(parent + ".edges"))
        {
            this.Edges = new List<K8sNamespaceEdge>();
            this.Edges.ApplyExploratoryFieldSpec(parent + ".edges");
        }
        //      C# -> List<K8sNamespace>? Nodes
        // GraphQL -> nodes: [K8sNamespace!]! (type)
        if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
        {
            this.Nodes = new List<K8sNamespace>();
            this.Nodes.ApplyExploratoryFieldSpec(parent + ".nodes");
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo == null && Exploration.Includes(parent + ".pageInfo"))
        {
            this.PageInfo = new PageInfo();
            this.PageInfo.ApplyExploratoryFieldSpec(parent + ".pageInfo");
        }
    }


    #endregion

    } // class K8sNamespaceConnection
    
    #endregion

    public static class ListK8sNamespaceConnectionExtensions
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
            this List<K8sNamespaceConnection> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<K8sNamespaceConnection> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sNamespaceConnection());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types