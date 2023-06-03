// PatchNutanixMountV1Reply.cs
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
    #region PatchNutanixMountV1Reply
    public class PatchNutanixMountV1Reply: BaseType
    {
        #region members

        //      C# -> NutanixVmMountSummary? NutanixVmMountSummary
        // GraphQL -> nutanixVmMountSummary: NutanixVmMountSummary (type)
        [JsonProperty("nutanixVmMountSummary")]
        public NutanixVmMountSummary? NutanixVmMountSummary { get; set; }


        #endregion

    #region methods

    public PatchNutanixMountV1Reply Set(
        NutanixVmMountSummary? NutanixVmMountSummary = null
    ) 
    {
        if ( NutanixVmMountSummary != null ) {
            this.NutanixVmMountSummary = NutanixVmMountSummary;
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
        //      C# -> NutanixVmMountSummary? NutanixVmMountSummary
        // GraphQL -> nutanixVmMountSummary: NutanixVmMountSummary (type)
        if (this.NutanixVmMountSummary != null) {
            s += ind + "nutanixVmMountSummary {\n" + this.NutanixVmMountSummary.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> NutanixVmMountSummary? NutanixVmMountSummary
        // GraphQL -> nutanixVmMountSummary: NutanixVmMountSummary (type)
        if (this.NutanixVmMountSummary == null && Exploration.Includes(parent + ".nutanixVmMountSummary"))
        {
            this.NutanixVmMountSummary = new NutanixVmMountSummary();
            this.NutanixVmMountSummary.ApplyExploratoryFieldSpec(parent + ".nutanixVmMountSummary");
        }
    }


    #endregion

    } // class PatchNutanixMountV1Reply
    
    #endregion

    public static class ListPatchNutanixMountV1ReplyExtensions
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
            this List<PatchNutanixMountV1Reply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PatchNutanixMountV1Reply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PatchNutanixMountV1Reply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types