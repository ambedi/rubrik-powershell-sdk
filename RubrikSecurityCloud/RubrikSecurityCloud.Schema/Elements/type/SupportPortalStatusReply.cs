// SupportPortalStatusReply.cs
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
    #region SupportPortalStatusReply
    public class SupportPortalStatusReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsLoggedIn
        // GraphQL -> isLoggedIn: Boolean! (scalar)
        [JsonProperty("isLoggedIn")]
        public System.Boolean? IsLoggedIn { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        [JsonProperty("status")]
        public StatusResponse? Status { get; set; }


        #endregion

    #region methods

    public SupportPortalStatusReply Set(
        System.Boolean? IsLoggedIn = null,
        System.String? Username = null,
        StatusResponse? Status = null
    ) 
    {
        if ( IsLoggedIn != null ) {
            this.IsLoggedIn = IsLoggedIn;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.Boolean? IsLoggedIn
        // GraphQL -> isLoggedIn: Boolean! (scalar)
        if (this.IsLoggedIn != null) {
            s += ind + "isLoggedIn\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        if (this.Status != null) {
            s += ind + "status {\n" + this.Status.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsLoggedIn
        // GraphQL -> isLoggedIn: Boolean! (scalar)
        if (this.IsLoggedIn == null && Exploration.Includes(parent + ".isLoggedIn", true))
        {
            this.IsLoggedIn = true;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && Exploration.Includes(parent + ".username", true))
        {
            this.Username = new System.String("FETCH");
        }
        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        if (this.Status == null && Exploration.Includes(parent + ".status"))
        {
            this.Status = new StatusResponse();
            this.Status.ApplyExploratoryFieldSpec(parent + ".status");
        }
    }


    #endregion

    } // class SupportPortalStatusReply
    
    #endregion

    public static class ListSupportPortalStatusReplyExtensions
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
            this List<SupportPortalStatusReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SupportPortalStatusReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SupportPortalStatusReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types