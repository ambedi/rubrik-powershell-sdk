// DbParameterGroup.cs
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
    #region DbParameterGroup
    public class DbParameterGroup: BaseType
    {
        #region members

        //      C# -> AwsNativeRdsType? RdsType
        // GraphQL -> rdsType: AwsNativeRdsType! (enum)
        [JsonProperty("rdsType")]
        public AwsNativeRdsType? RdsType { get; set; }

        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        [JsonProperty("arn")]
        public System.String? Arn { get; set; }

        //      C# -> System.String? Family
        // GraphQL -> family: String! (scalar)
        [JsonProperty("family")]
        public System.String? Family { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public DbParameterGroup Set(
        AwsNativeRdsType? RdsType = null,
        System.String? Arn = null,
        System.String? Family = null,
        System.String? Name = null
    ) 
    {
        if ( RdsType != null ) {
            this.RdsType = RdsType;
        }
        if ( Arn != null ) {
            this.Arn = Arn;
        }
        if ( Family != null ) {
            this.Family = Family;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> AwsNativeRdsType? RdsType
        // GraphQL -> rdsType: AwsNativeRdsType! (enum)
        if (this.RdsType != null) {
            s += ind + "rdsType\n" ;
        }
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (this.Arn != null) {
            s += ind + "arn\n" ;
        }
        //      C# -> System.String? Family
        // GraphQL -> family: String! (scalar)
        if (this.Family != null) {
            s += ind + "family\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AwsNativeRdsType? RdsType
        // GraphQL -> rdsType: AwsNativeRdsType! (enum)
        if (this.RdsType == null && Exploration.Includes(parent + ".rdsType", true))
        {
            this.RdsType = new AwsNativeRdsType();
        }
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (this.Arn == null && Exploration.Includes(parent + ".arn", true))
        {
            this.Arn = new System.String("FETCH");
        }
        //      C# -> System.String? Family
        // GraphQL -> family: String! (scalar)
        if (this.Family == null && Exploration.Includes(parent + ".family", true))
        {
            this.Family = new System.String("FETCH");
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
    }


    #endregion

    } // class DbParameterGroup
    
    #endregion

    public static class ListDbParameterGroupExtensions
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
            this List<DbParameterGroup> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DbParameterGroup> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DbParameterGroup());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types