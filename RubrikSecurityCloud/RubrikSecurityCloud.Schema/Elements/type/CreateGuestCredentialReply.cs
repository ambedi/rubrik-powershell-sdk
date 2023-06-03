// CreateGuestCredentialReply.cs
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
    #region CreateGuestCredentialReply
    public class CreateGuestCredentialReply: BaseType
    {
        #region members

        //      C# -> System.String? Domain
        // GraphQL -> domain: String (scalar)
        [JsonProperty("domain")]
        public System.String? Domain { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> BaseGuestCredentialDetail? BaseGuestCredentialDetail
        // GraphQL -> baseGuestCredentialDetail: BaseGuestCredentialDetail (type)
        [JsonProperty("baseGuestCredentialDetail")]
        public BaseGuestCredentialDetail? BaseGuestCredentialDetail { get; set; }


        #endregion

    #region methods

    public CreateGuestCredentialReply Set(
        System.String? Domain = null,
        System.String? Id = null,
        BaseGuestCredentialDetail? BaseGuestCredentialDetail = null
    ) 
    {
        if ( Domain != null ) {
            this.Domain = Domain;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( BaseGuestCredentialDetail != null ) {
            this.BaseGuestCredentialDetail = BaseGuestCredentialDetail;
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
        //      C# -> System.String? Domain
        // GraphQL -> domain: String (scalar)
        if (this.Domain != null) {
            s += ind + "domain\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> BaseGuestCredentialDetail? BaseGuestCredentialDetail
        // GraphQL -> baseGuestCredentialDetail: BaseGuestCredentialDetail (type)
        if (this.BaseGuestCredentialDetail != null) {
            s += ind + "baseGuestCredentialDetail {\n" + this.BaseGuestCredentialDetail.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Domain
        // GraphQL -> domain: String (scalar)
        if (this.Domain == null && Exploration.Includes(parent + ".domain", true))
        {
            this.Domain = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> BaseGuestCredentialDetail? BaseGuestCredentialDetail
        // GraphQL -> baseGuestCredentialDetail: BaseGuestCredentialDetail (type)
        if (this.BaseGuestCredentialDetail == null && Exploration.Includes(parent + ".baseGuestCredentialDetail"))
        {
            this.BaseGuestCredentialDetail = new BaseGuestCredentialDetail();
            this.BaseGuestCredentialDetail.ApplyExploratoryFieldSpec(parent + ".baseGuestCredentialDetail");
        }
    }


    #endregion

    } // class CreateGuestCredentialReply
    
    #endregion

    public static class ListCreateGuestCredentialReplyExtensions
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
            this List<CreateGuestCredentialReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CreateGuestCredentialReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateGuestCredentialReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types