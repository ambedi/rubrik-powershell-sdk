// MssqlInstanceDetail.cs
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
    #region MssqlInstanceDetail
    public class MssqlInstanceDetail: BaseType
    {
        #region members

        //      C# -> MssqlInstanceSummary? MssqlInstanceSummary
        // GraphQL -> mssqlInstanceSummary: MssqlInstanceSummary (type)
        [JsonProperty("mssqlInstanceSummary")]
        public MssqlInstanceSummary? MssqlInstanceSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlInstanceDetail";
    }

    public MssqlInstanceDetail Set(
        MssqlInstanceSummary? MssqlInstanceSummary = null
    ) 
    {
        if ( MssqlInstanceSummary != null ) {
            this.MssqlInstanceSummary = MssqlInstanceSummary;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> MssqlInstanceSummary? MssqlInstanceSummary
        // GraphQL -> mssqlInstanceSummary: MssqlInstanceSummary (type)
        if (this.MssqlInstanceSummary != null) {
            var fspec = this.MssqlInstanceSummary.AsFieldSpec(conf.Child("mssqlInstanceSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mssqlInstanceSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MssqlInstanceSummary? MssqlInstanceSummary
        // GraphQL -> mssqlInstanceSummary: MssqlInstanceSummary (type)
        if (ec.Includes("mssqlInstanceSummary",false))
        {
            if(this.MssqlInstanceSummary == null) {

                this.MssqlInstanceSummary = new MssqlInstanceSummary();
                this.MssqlInstanceSummary.ApplyExploratoryFieldSpec(ec.NewChild("mssqlInstanceSummary"));

            } else {

                this.MssqlInstanceSummary.ApplyExploratoryFieldSpec(ec.NewChild("mssqlInstanceSummary"));

            }
        }
        else if (this.MssqlInstanceSummary != null && ec.Excludes("mssqlInstanceSummary",false))
        {
            this.MssqlInstanceSummary = null;
        }
    }


    #endregion

    } // class MssqlInstanceDetail
    
    #endregion

    public static class ListMssqlInstanceDetailExtensions
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
            this List<MssqlInstanceDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<MssqlInstanceDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlInstanceDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlInstanceDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlInstanceDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types