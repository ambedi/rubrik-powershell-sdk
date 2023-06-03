// CcProvisionJobReply.cs
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
    #region CcProvisionJobReply
    public class CcProvisionJobReply: BaseType
    {
        #region members

        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long! (scalar)
        [JsonProperty("jobId")]
        public System.Int64? JobId { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        [JsonProperty("success")]
        public System.Boolean? Success { get; set; }


        #endregion

    #region methods

    public CcProvisionJobReply Set(
        System.Int64? JobId = null,
        System.String? Message = null,
        System.Boolean? Success = null
    ) 
    {
        if ( JobId != null ) {
            this.JobId = JobId;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( Success != null ) {
            this.Success = Success;
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
        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long! (scalar)
        if (this.JobId != null) {
            s += ind + "jobId\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        if (this.Success != null) {
            s += ind + "success\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long! (scalar)
        if (this.JobId == null && Exploration.Includes(parent + ".jobId", true))
        {
            this.JobId = new System.Int64();
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = new System.String("FETCH");
        }
        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        if (this.Success == null && Exploration.Includes(parent + ".success", true))
        {
            this.Success = true;
        }
    }


    #endregion

    } // class CcProvisionJobReply
    
    #endregion

    public static class ListCcProvisionJobReplyExtensions
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
            this List<CcProvisionJobReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CcProvisionJobReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CcProvisionJobReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types