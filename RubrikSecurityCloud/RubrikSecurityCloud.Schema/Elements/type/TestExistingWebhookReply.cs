// TestExistingWebhookReply.cs
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
    #region TestExistingWebhookReply
    public class TestExistingWebhookReply: BaseType
    {
        #region members

        //      C# -> WebhookStatus? WebhookStatus
        // GraphQL -> webhookStatus: WebhookStatus! (enum)
        [JsonProperty("webhookStatus")]
        public WebhookStatus? WebhookStatus { get; set; }

        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        [JsonProperty("isSuccessful")]
        public System.Boolean? IsSuccessful { get; set; }

        //      C# -> ErrorInfo? ErrorInfo
        // GraphQL -> errorInfo: ErrorInfo (type)
        [JsonProperty("errorInfo")]
        public ErrorInfo? ErrorInfo { get; set; }


        #endregion

    #region methods

    public TestExistingWebhookReply Set(
        WebhookStatus? WebhookStatus = null,
        System.Boolean? IsSuccessful = null,
        ErrorInfo? ErrorInfo = null
    ) 
    {
        if ( WebhookStatus != null ) {
            this.WebhookStatus = WebhookStatus;
        }
        if ( IsSuccessful != null ) {
            this.IsSuccessful = IsSuccessful;
        }
        if ( ErrorInfo != null ) {
            this.ErrorInfo = ErrorInfo;
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
        //      C# -> WebhookStatus? WebhookStatus
        // GraphQL -> webhookStatus: WebhookStatus! (enum)
        if (this.WebhookStatus != null) {
            s += ind + "webhookStatus\n" ;
        }
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        if (this.IsSuccessful != null) {
            s += ind + "isSuccessful\n" ;
        }
        //      C# -> ErrorInfo? ErrorInfo
        // GraphQL -> errorInfo: ErrorInfo (type)
        if (this.ErrorInfo != null) {
            s += ind + "errorInfo {\n" + this.ErrorInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> WebhookStatus? WebhookStatus
        // GraphQL -> webhookStatus: WebhookStatus! (enum)
        if (this.WebhookStatus == null && Exploration.Includes(parent + ".webhookStatus", true))
        {
            this.WebhookStatus = new WebhookStatus();
        }
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        if (this.IsSuccessful == null && Exploration.Includes(parent + ".isSuccessful", true))
        {
            this.IsSuccessful = true;
        }
        //      C# -> ErrorInfo? ErrorInfo
        // GraphQL -> errorInfo: ErrorInfo (type)
        if (this.ErrorInfo == null && Exploration.Includes(parent + ".errorInfo"))
        {
            this.ErrorInfo = new ErrorInfo();
            this.ErrorInfo.ApplyExploratoryFieldSpec(parent + ".errorInfo");
        }
    }


    #endregion

    } // class TestExistingWebhookReply
    
    #endregion

    public static class ListTestExistingWebhookReplyExtensions
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
            this List<TestExistingWebhookReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TestExistingWebhookReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TestExistingWebhookReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types