// UserLoginContext.cs
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
    #region UserLoginContext
    public class UserLoginContext: BaseType
    {
        #region members

        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        [JsonProperty("accountName")]
        public System.String? AccountName { get; set; }

        //      C# -> System.String? OrgFullName
        // GraphQL -> orgFullName: String! (scalar)
        [JsonProperty("orgFullName")]
        public System.String? OrgFullName { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> User? User
        // GraphQL -> user: User! (type)
        [JsonProperty("user")]
        public User? User { get; set; }


        #endregion

    #region methods

    public UserLoginContext Set(
        System.String? AccountName = null,
        System.String? OrgFullName = null,
        System.String? OrgId = null,
        System.String? OrgName = null,
        User? User = null
    ) 
    {
        if ( AccountName != null ) {
            this.AccountName = AccountName;
        }
        if ( OrgFullName != null ) {
            this.OrgFullName = OrgFullName;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( OrgName != null ) {
            this.OrgName = OrgName;
        }
        if ( User != null ) {
            this.User = User;
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
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (this.AccountName != null) {
            s += ind + "accountName\n" ;
        }
        //      C# -> System.String? OrgFullName
        // GraphQL -> orgFullName: String! (scalar)
        if (this.OrgFullName != null) {
            s += ind + "orgFullName\n" ;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            s += ind + "orgId\n" ;
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (this.OrgName != null) {
            s += ind + "orgName\n" ;
        }
        //      C# -> User? User
        // GraphQL -> user: User! (type)
        if (this.User != null) {
            s += ind + "user {\n" + this.User.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (this.AccountName == null && Exploration.Includes(parent + ".accountName", true))
        {
            this.AccountName = new System.String("FETCH");
        }
        //      C# -> System.String? OrgFullName
        // GraphQL -> orgFullName: String! (scalar)
        if (this.OrgFullName == null && Exploration.Includes(parent + ".orgFullName", true))
        {
            this.OrgFullName = new System.String("FETCH");
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId == null && Exploration.Includes(parent + ".orgId", true))
        {
            this.OrgId = new System.String("FETCH");
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (this.OrgName == null && Exploration.Includes(parent + ".orgName", true))
        {
            this.OrgName = new System.String("FETCH");
        }
        //      C# -> User? User
        // GraphQL -> user: User! (type)
        if (this.User == null && Exploration.Includes(parent + ".user"))
        {
            this.User = new User();
            this.User.ApplyExploratoryFieldSpec(parent + ".user");
        }
    }


    #endregion

    } // class UserLoginContext
    
    #endregion

    public static class ListUserLoginContextExtensions
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
            this List<UserLoginContext> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UserLoginContext> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UserLoginContext());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types