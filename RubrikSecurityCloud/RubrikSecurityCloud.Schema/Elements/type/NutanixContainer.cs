// NutanixContainer.cs
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
    #region NutanixContainer
    public class NutanixContainer: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        [JsonProperty("naturalId")]
        public System.String? NaturalId { get; set; }


        #endregion

    #region methods

    public NutanixContainer Set(
        System.String? Name = null,
        System.String? NaturalId = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NaturalId != null ) {
            this.NaturalId = NaturalId;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (this.NaturalId != null) {
            s += ind + "naturalId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (this.NaturalId == null && Exploration.Includes(parent + ".naturalId", true))
        {
            this.NaturalId = new System.String("FETCH");
        }
    }


    #endregion

    } // class NutanixContainer
    
    #endregion

    public static class ListNutanixContainerExtensions
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
            this List<NutanixContainer> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NutanixContainer> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixContainer());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types