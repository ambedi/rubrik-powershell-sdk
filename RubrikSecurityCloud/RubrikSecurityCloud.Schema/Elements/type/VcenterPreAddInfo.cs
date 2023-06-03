// VcenterPreAddInfo.cs
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
    #region VcenterPreAddInfo
    public class VcenterPreAddInfo: BaseType
    {
        #region members

        //      C# -> List<ClusterHostGroupInfo>? ClusterHostGroupInfo
        // GraphQL -> clusterHostGroupInfo: [ClusterHostGroupInfo!]! (type)
        [JsonProperty("clusterHostGroupInfo")]
        public List<ClusterHostGroupInfo>? ClusterHostGroupInfo { get; set; }


        #endregion

    #region methods

    public VcenterPreAddInfo Set(
        List<ClusterHostGroupInfo>? ClusterHostGroupInfo = null
    ) 
    {
        if ( ClusterHostGroupInfo != null ) {
            this.ClusterHostGroupInfo = ClusterHostGroupInfo;
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
        //      C# -> List<ClusterHostGroupInfo>? ClusterHostGroupInfo
        // GraphQL -> clusterHostGroupInfo: [ClusterHostGroupInfo!]! (type)
        if (this.ClusterHostGroupInfo != null) {
            s += ind + "clusterHostGroupInfo {\n" + this.ClusterHostGroupInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<ClusterHostGroupInfo>? ClusterHostGroupInfo
        // GraphQL -> clusterHostGroupInfo: [ClusterHostGroupInfo!]! (type)
        if (this.ClusterHostGroupInfo == null && Exploration.Includes(parent + ".clusterHostGroupInfo"))
        {
            this.ClusterHostGroupInfo = new List<ClusterHostGroupInfo>();
            this.ClusterHostGroupInfo.ApplyExploratoryFieldSpec(parent + ".clusterHostGroupInfo");
        }
    }


    #endregion

    } // class VcenterPreAddInfo
    
    #endregion

    public static class ListVcenterPreAddInfoExtensions
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
            this List<VcenterPreAddInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VcenterPreAddInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VcenterPreAddInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types