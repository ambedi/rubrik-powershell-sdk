// AddGlobalCertificateReply.cs
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
    #region AddGlobalCertificateReply
    public class AddGlobalCertificateReply: BaseType
    {
        #region members

        //      C# -> GlobalCertificate? Certificate
        // GraphQL -> certificate: GlobalCertificate! (type)
        [JsonProperty("certificate")]
        public GlobalCertificate? Certificate { get; set; }

        //      C# -> List<CertificateClusterOperationError>? ClusterErrors
        // GraphQL -> clusterErrors: [CertificateClusterOperationError!]! (type)
        [JsonProperty("clusterErrors")]
        public List<CertificateClusterOperationError>? ClusterErrors { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AddGlobalCertificateReply";
    }

    public AddGlobalCertificateReply Set(
        GlobalCertificate? Certificate = null,
        List<CertificateClusterOperationError>? ClusterErrors = null
    ) 
    {
        if ( Certificate != null ) {
            this.Certificate = Certificate;
        }
        if ( ClusterErrors != null ) {
            this.ClusterErrors = ClusterErrors;
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
        //      C# -> GlobalCertificate? Certificate
        // GraphQL -> certificate: GlobalCertificate! (type)
        if (this.Certificate != null) {
            var fspec = this.Certificate.AsFieldSpec(conf.Child("certificate"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "certificate" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CertificateClusterOperationError>? ClusterErrors
        // GraphQL -> clusterErrors: [CertificateClusterOperationError!]! (type)
        if (this.ClusterErrors != null) {
            var fspec = this.ClusterErrors.AsFieldSpec(conf.Child("clusterErrors"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterErrors" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> GlobalCertificate? Certificate
        // GraphQL -> certificate: GlobalCertificate! (type)
        if (ec.Includes("certificate",false))
        {
            if(this.Certificate == null) {

                this.Certificate = new GlobalCertificate();
                this.Certificate.ApplyExploratoryFieldSpec(ec.NewChild("certificate"));

            } else {

                this.Certificate.ApplyExploratoryFieldSpec(ec.NewChild("certificate"));

            }
        }
        else if (this.Certificate != null && ec.Excludes("certificate",false))
        {
            this.Certificate = null;
        }
        //      C# -> List<CertificateClusterOperationError>? ClusterErrors
        // GraphQL -> clusterErrors: [CertificateClusterOperationError!]! (type)
        if (ec.Includes("clusterErrors",false))
        {
            if(this.ClusterErrors == null) {

                this.ClusterErrors = new List<CertificateClusterOperationError>();
                this.ClusterErrors.ApplyExploratoryFieldSpec(ec.NewChild("clusterErrors"));

            } else {

                this.ClusterErrors.ApplyExploratoryFieldSpec(ec.NewChild("clusterErrors"));

            }
        }
        else if (this.ClusterErrors != null && ec.Excludes("clusterErrors",false))
        {
            this.ClusterErrors = null;
        }
    }


    #endregion

    } // class AddGlobalCertificateReply
    
    #endregion

    public static class ListAddGlobalCertificateReplyExtensions
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
            this List<AddGlobalCertificateReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AddGlobalCertificateReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AddGlobalCertificateReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AddGlobalCertificateReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AddGlobalCertificateReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types