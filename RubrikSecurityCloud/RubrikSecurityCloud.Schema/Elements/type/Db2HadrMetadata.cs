// Db2HadrMetadata.cs
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
    #region Db2HadrMetadata
    public class Db2HadrMetadata: BaseType
    {
        #region members

        //      C# -> List<Db2HadrInstanceInfo>? InstancesInfoList
        // GraphQL -> instancesInfoList: [Db2HadrInstanceInfo!]! (type)
        [JsonProperty("instancesInfoList")]
        public List<Db2HadrInstanceInfo>? InstancesInfoList { get; set; }


        #endregion

    #region methods

    public Db2HadrMetadata Set(
        List<Db2HadrInstanceInfo>? InstancesInfoList = null
    ) 
    {
        if ( InstancesInfoList != null ) {
            this.InstancesInfoList = InstancesInfoList;
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
        //      C# -> List<Db2HadrInstanceInfo>? InstancesInfoList
        // GraphQL -> instancesInfoList: [Db2HadrInstanceInfo!]! (type)
        if (this.InstancesInfoList != null) {
            s += ind + "instancesInfoList {\n" + this.InstancesInfoList.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<Db2HadrInstanceInfo>? InstancesInfoList
        // GraphQL -> instancesInfoList: [Db2HadrInstanceInfo!]! (type)
        if (this.InstancesInfoList == null && Exploration.Includes(parent + ".instancesInfoList"))
        {
            this.InstancesInfoList = new List<Db2HadrInstanceInfo>();
            this.InstancesInfoList.ApplyExploratoryFieldSpec(parent + ".instancesInfoList");
        }
    }


    #endregion

    } // class Db2HadrMetadata
    
    #endregion

    public static class ListDb2HadrMetadataExtensions
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
            this List<Db2HadrMetadata> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Db2HadrMetadata> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2HadrMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types