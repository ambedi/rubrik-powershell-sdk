// VmwareVmRecoverableRanges.cs
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
    #region VmwareVmRecoverableRanges
    public class VmwareVmRecoverableRanges: BaseType
    {
        #region members

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }

        //      C# -> List<VmwareRecoverableRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [VmwareRecoverableRange!]! (type)
        [JsonProperty("recoverableRanges")]
        public List<VmwareRecoverableRange>? RecoverableRanges { get; set; }


        #endregion

    #region methods

    public VmwareVmRecoverableRanges Set(
        System.String? VmId = null,
        List<VmwareRecoverableRange>? RecoverableRanges = null
    ) 
    {
        if ( VmId != null ) {
            this.VmId = VmId;
        }
        if ( RecoverableRanges != null ) {
            this.RecoverableRanges = RecoverableRanges;
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
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId != null) {
            s += ind + "vmId\n" ;
        }
        //      C# -> List<VmwareRecoverableRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [VmwareRecoverableRange!]! (type)
        if (this.RecoverableRanges != null) {
            s += ind + "recoverableRanges {\n" + this.RecoverableRanges.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId == null && Exploration.Includes(parent + ".vmId", true))
        {
            this.VmId = new System.String("FETCH");
        }
        //      C# -> List<VmwareRecoverableRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [VmwareRecoverableRange!]! (type)
        if (this.RecoverableRanges == null && Exploration.Includes(parent + ".recoverableRanges"))
        {
            this.RecoverableRanges = new List<VmwareRecoverableRange>();
            this.RecoverableRanges.ApplyExploratoryFieldSpec(parent + ".recoverableRanges");
        }
    }


    #endregion

    } // class VmwareVmRecoverableRanges
    
    #endregion

    public static class ListVmwareVmRecoverableRangesExtensions
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
            this List<VmwareVmRecoverableRanges> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareVmRecoverableRanges> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareVmRecoverableRanges());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types