// NotificationForGetLicenseReply.cs
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
    #region NotificationForGetLicenseReply
    public class NotificationForGetLicenseReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        [JsonProperty("isSuccessful")]
        public System.Boolean? IsSuccessful { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NotificationForGetLicenseReply";
    }

    public NotificationForGetLicenseReply Set(
        System.Boolean? IsSuccessful = null
    ) 
    {
        if ( IsSuccessful != null ) {
            this.IsSuccessful = IsSuccessful;
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
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        if (this.IsSuccessful != null) {
            s += ind + "isSuccessful\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        if (this.IsSuccessful == null && Exploration.Includes(parent + ".isSuccessful", true))
        {
            this.IsSuccessful = true;
        }
    }


    #endregion

    } // class NotificationForGetLicenseReply
    
    #endregion

    public static class ListNotificationForGetLicenseReplyExtensions
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
            this List<NotificationForGetLicenseReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NotificationForGetLicenseReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NotificationForGetLicenseReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types