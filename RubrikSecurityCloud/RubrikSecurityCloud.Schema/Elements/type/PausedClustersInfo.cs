// PausedClustersInfo.cs
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
    #region PausedClustersInfo
    public class PausedClustersInfo: BaseType
    {
        #region members

        //      C# -> System.Int32? PausedClustersCount
        // GraphQL -> pausedClustersCount: Int! (scalar)
        [JsonProperty("pausedClustersCount")]
        public System.Int32? PausedClustersCount { get; set; }

        //      C# -> List<Cluster>? PausedClusters
        // GraphQL -> pausedClusters: [Cluster!] (type)
        [JsonProperty("pausedClusters")]
        public List<Cluster>? PausedClusters { get; set; }


        #endregion

    #region methods

    public PausedClustersInfo Set(
        System.Int32? PausedClustersCount = null,
        List<Cluster>? PausedClusters = null
    ) 
    {
        if ( PausedClustersCount != null ) {
            this.PausedClustersCount = PausedClustersCount;
        }
        if ( PausedClusters != null ) {
            this.PausedClusters = PausedClusters;
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
        //      C# -> System.Int32? PausedClustersCount
        // GraphQL -> pausedClustersCount: Int! (scalar)
        if (this.PausedClustersCount != null) {
            s += ind + "pausedClustersCount\n" ;
        }
        //      C# -> List<Cluster>? PausedClusters
        // GraphQL -> pausedClusters: [Cluster!] (type)
        if (this.PausedClusters != null) {
            s += ind + "pausedClusters {\n" + this.PausedClusters.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? PausedClustersCount
        // GraphQL -> pausedClustersCount: Int! (scalar)
        if (this.PausedClustersCount == null && Exploration.Includes(parent + ".pausedClustersCount", true))
        {
            this.PausedClustersCount = new System.Int32();
        }
        //      C# -> List<Cluster>? PausedClusters
        // GraphQL -> pausedClusters: [Cluster!] (type)
        if (this.PausedClusters == null && Exploration.Includes(parent + ".pausedClusters"))
        {
            this.PausedClusters = new List<Cluster>();
            this.PausedClusters.ApplyExploratoryFieldSpec(parent + ".pausedClusters");
        }
    }


    #endregion

    } // class PausedClustersInfo
    
    #endregion

    public static class ListPausedClustersInfoExtensions
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
            this List<PausedClustersInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PausedClustersInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PausedClustersInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types