// CategorizedTprRequestedChangeEntry.cs
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region CategorizedTprRequestedChangeEntry
    public class CategorizedTprRequestedChangeEntry: BaseType
    {
        #region members

        //      C# -> System.String? CategoryName
        // GraphQL -> categoryName: String! (scalar)
        [JsonProperty("categoryName")]
        public System.String? CategoryName { get; set; }

        //      C# -> List<TprRequestedChangeEntry>? Entries
        // GraphQL -> entries: [TprRequestedChangeEntry!]! (type)
        [JsonProperty("entries")]
        public List<TprRequestedChangeEntry>? Entries { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CategorizedTprRequestedChangeEntry";
    }

    public CategorizedTprRequestedChangeEntry Set(
        System.String? CategoryName = null,
        List<TprRequestedChangeEntry>? Entries = null
    ) 
    {
        if ( CategoryName != null ) {
            this.CategoryName = CategoryName;
        }
        if ( Entries != null ) {
            this.Entries = Entries;
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
        //      C# -> System.String? CategoryName
        // GraphQL -> categoryName: String! (scalar)
        if (this.CategoryName != null) {
            s += ind + "categoryName\n" ;
        }
        //      C# -> List<TprRequestedChangeEntry>? Entries
        // GraphQL -> entries: [TprRequestedChangeEntry!]! (type)
        if (this.Entries != null) {
            var fspec = this.Entries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "entries {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CategoryName
        // GraphQL -> categoryName: String! (scalar)
        if (this.CategoryName == null && Exploration.Includes(parent + ".categoryName", true))
        {
            this.CategoryName = "FETCH";
        }
        //      C# -> List<TprRequestedChangeEntry>? Entries
        // GraphQL -> entries: [TprRequestedChangeEntry!]! (type)
        if (this.Entries == null && Exploration.Includes(parent + ".entries"))
        {
            this.Entries = new List<TprRequestedChangeEntry>();
            this.Entries.ApplyExploratoryFieldSpec(parent + ".entries");
        }
    }


    #endregion

    } // class CategorizedTprRequestedChangeEntry
    
    #endregion

    public static class ListCategorizedTprRequestedChangeEntryExtensions
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
            this List<CategorizedTprRequestedChangeEntry> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CategorizedTprRequestedChangeEntry> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CategorizedTprRequestedChangeEntry());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types