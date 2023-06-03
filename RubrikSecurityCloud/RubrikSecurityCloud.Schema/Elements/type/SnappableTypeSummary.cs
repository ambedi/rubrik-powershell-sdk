// SnappableTypeSummary.cs
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
    #region SnappableTypeSummary
    public class SnappableTypeSummary: BaseType
    {
        #region members

        //      C# -> HierarchyObjectTypeEnum? SnappableType
        // GraphQL -> snappableType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("snappableType")]
        public HierarchyObjectTypeEnum? SnappableType { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }


        #endregion

    #region methods

    public SnappableTypeSummary Set(
        HierarchyObjectTypeEnum? SnappableType = null,
        System.Int32? Count = null
    ) 
    {
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        if ( Count != null ) {
            this.Count = Count;
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
        //      C# -> HierarchyObjectTypeEnum? SnappableType
        // GraphQL -> snappableType: HierarchyObjectTypeEnum! (enum)
        if (this.SnappableType != null) {
            s += ind + "snappableType\n" ;
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> HierarchyObjectTypeEnum? SnappableType
        // GraphQL -> snappableType: HierarchyObjectTypeEnum! (enum)
        if (this.SnappableType == null && Exploration.Includes(parent + ".snappableType", true))
        {
            this.SnappableType = new HierarchyObjectTypeEnum();
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = new System.Int32();
        }
    }


    #endregion

    } // class SnappableTypeSummary
    
    #endregion

    public static class ListSnappableTypeSummaryExtensions
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
            this List<SnappableTypeSummary> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnappableTypeSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnappableTypeSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types