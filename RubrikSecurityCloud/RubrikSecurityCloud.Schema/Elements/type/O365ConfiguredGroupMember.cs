// O365ConfiguredGroupMember.cs
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
    #region O365ConfiguredGroupMember
    public class O365ConfiguredGroupMember: BaseType
    {
        #region members

        //      C# -> O365ConfiguredGroupMemberType? ObjectType
        // GraphQL -> objectType: O365ConfiguredGroupMemberType! (enum)
        [JsonProperty("objectType")]
        public O365ConfiguredGroupMemberType? ObjectType { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Pdl
        // GraphQL -> pdl: String! (scalar)
        [JsonProperty("pdl")]
        public System.String? Pdl { get; set; }

        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        [JsonProperty("url")]
        public System.String? Url { get; set; }


        #endregion

    #region methods

    public O365ConfiguredGroupMember Set(
        O365ConfiguredGroupMemberType? ObjectType = null,
        System.String? DisplayName = null,
        System.String? Id = null,
        System.String? Pdl = null,
        System.String? Url = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Pdl != null ) {
            this.Pdl = Pdl;
        }
        if ( Url != null ) {
            this.Url = Url;
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
        //      C# -> O365ConfiguredGroupMemberType? ObjectType
        // GraphQL -> objectType: O365ConfiguredGroupMemberType! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            s += ind + "displayName\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Pdl
        // GraphQL -> pdl: String! (scalar)
        if (this.Pdl != null) {
            s += ind + "pdl\n" ;
        }
        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        if (this.Url != null) {
            s += ind + "url\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> O365ConfiguredGroupMemberType? ObjectType
        // GraphQL -> objectType: O365ConfiguredGroupMemberType! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new O365ConfiguredGroupMemberType();
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName == null && Exploration.Includes(parent + ".displayName", true))
        {
            this.DisplayName = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? Pdl
        // GraphQL -> pdl: String! (scalar)
        if (this.Pdl == null && Exploration.Includes(parent + ".pdl", true))
        {
            this.Pdl = new System.String("FETCH");
        }
        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        if (this.Url == null && Exploration.Includes(parent + ".url", true))
        {
            this.Url = new System.String("FETCH");
        }
    }


    #endregion

    } // class O365ConfiguredGroupMember
    
    #endregion

    public static class ListO365ConfiguredGroupMemberExtensions
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
            this List<O365ConfiguredGroupMember> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365ConfiguredGroupMember> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new O365ConfiguredGroupMember());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types