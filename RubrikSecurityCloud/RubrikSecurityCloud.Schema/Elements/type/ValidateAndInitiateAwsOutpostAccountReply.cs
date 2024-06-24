// ValidateAndInitiateAwsOutpostAccountReply.cs
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
    #region ValidateAndInitiateAwsOutpostAccountReply
    public class ValidateAndInitiateAwsOutpostAccountReply: BaseType
    {
        #region members

        //      C# -> AwsOutpostAccountInitiateResponse? InitiateResponse
        // GraphQL -> initiateResponse: AwsOutpostAccountInitiateResponse (type)
        [JsonProperty("initiateResponse")]
        public AwsOutpostAccountInitiateResponse? InitiateResponse { get; set; }

        //      C# -> AwsOutpostAccountValidateResponse? ValidateResponse
        // GraphQL -> validateResponse: AwsOutpostAccountValidateResponse (type)
        [JsonProperty("validateResponse")]
        public AwsOutpostAccountValidateResponse? ValidateResponse { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidateAndInitiateAwsOutpostAccountReply";
    }

    public ValidateAndInitiateAwsOutpostAccountReply Set(
        AwsOutpostAccountInitiateResponse? InitiateResponse = null,
        AwsOutpostAccountValidateResponse? ValidateResponse = null
    ) 
    {
        if ( InitiateResponse != null ) {
            this.InitiateResponse = InitiateResponse;
        }
        if ( ValidateResponse != null ) {
            this.ValidateResponse = ValidateResponse;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AwsOutpostAccountInitiateResponse? InitiateResponse
        // GraphQL -> initiateResponse: AwsOutpostAccountInitiateResponse (type)
        if (this.InitiateResponse != null) {
            var fspec = this.InitiateResponse.AsFieldSpec(conf.Child("initiateResponse"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "initiateResponse" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsOutpostAccountValidateResponse? ValidateResponse
        // GraphQL -> validateResponse: AwsOutpostAccountValidateResponse (type)
        if (this.ValidateResponse != null) {
            var fspec = this.ValidateResponse.AsFieldSpec(conf.Child("validateResponse"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "validateResponse" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsOutpostAccountInitiateResponse? InitiateResponse
        // GraphQL -> initiateResponse: AwsOutpostAccountInitiateResponse (type)
        if (ec.Includes("initiateResponse",false))
        {
            if(this.InitiateResponse == null) {

                this.InitiateResponse = new AwsOutpostAccountInitiateResponse();
                this.InitiateResponse.ApplyExploratoryFieldSpec(ec.NewChild("initiateResponse"));

            } else {

                this.InitiateResponse.ApplyExploratoryFieldSpec(ec.NewChild("initiateResponse"));

            }
        }
        else if (this.InitiateResponse != null && ec.Excludes("initiateResponse",false))
        {
            this.InitiateResponse = null;
        }
        //      C# -> AwsOutpostAccountValidateResponse? ValidateResponse
        // GraphQL -> validateResponse: AwsOutpostAccountValidateResponse (type)
        if (ec.Includes("validateResponse",false))
        {
            if(this.ValidateResponse == null) {

                this.ValidateResponse = new AwsOutpostAccountValidateResponse();
                this.ValidateResponse.ApplyExploratoryFieldSpec(ec.NewChild("validateResponse"));

            } else {

                this.ValidateResponse.ApplyExploratoryFieldSpec(ec.NewChild("validateResponse"));

            }
        }
        else if (this.ValidateResponse != null && ec.Excludes("validateResponse",false))
        {
            this.ValidateResponse = null;
        }
    }


    #endregion

    } // class ValidateAndInitiateAwsOutpostAccountReply
    
    #endregion

    public static class ListValidateAndInitiateAwsOutpostAccountReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ValidateAndInitiateAwsOutpostAccountReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ValidateAndInitiateAwsOutpostAccountReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ValidateAndInitiateAwsOutpostAccountReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateAndInitiateAwsOutpostAccountReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValidateAndInitiateAwsOutpostAccountReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types