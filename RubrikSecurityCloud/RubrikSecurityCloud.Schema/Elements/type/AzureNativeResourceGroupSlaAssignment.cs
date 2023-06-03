// AzureNativeResourceGroupSlaAssignment.cs
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
    #region AzureNativeResourceGroupSlaAssignment
    public class AzureNativeResourceGroupSlaAssignment: BaseType
    {
        #region members

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> GlobalSlaReply? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: GlobalSlaReply! (type)
        [JsonProperty("configuredSlaDomain")]
        public GlobalSlaReply? ConfiguredSlaDomain { get; set; }

        //      C# -> GlobalSlaReply? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: GlobalSlaReply! (type)
        [JsonProperty("effectiveSlaDomain")]
        public GlobalSlaReply? EffectiveSlaDomain { get; set; }


        #endregion

    #region methods

    public AzureNativeResourceGroupSlaAssignment Set(
        SlaAssignmentTypeEnum? SlaAssignment = null,
        GlobalSlaReply? ConfiguredSlaDomain = null,
        GlobalSlaReply? EffectiveSlaDomain = null
    ) 
    {
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( ConfiguredSlaDomain != null ) {
            this.ConfiguredSlaDomain = ConfiguredSlaDomain;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
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
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment != null) {
            s += ind + "slaAssignment\n" ;
        }
        //      C# -> GlobalSlaReply? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: GlobalSlaReply! (type)
        if (this.ConfiguredSlaDomain != null) {
            s += ind + "configuredSlaDomain {\n" + this.ConfiguredSlaDomain.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> GlobalSlaReply? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: GlobalSlaReply! (type)
        if (this.EffectiveSlaDomain != null) {
            s += ind + "effectiveSlaDomain {\n" + this.EffectiveSlaDomain.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment", true))
        {
            this.SlaAssignment = new SlaAssignmentTypeEnum();
        }
        //      C# -> GlobalSlaReply? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: GlobalSlaReply! (type)
        if (this.ConfiguredSlaDomain == null && Exploration.Includes(parent + ".configuredSlaDomain"))
        {
            this.ConfiguredSlaDomain = new GlobalSlaReply();
            this.ConfiguredSlaDomain.ApplyExploratoryFieldSpec(parent + ".configuredSlaDomain");
        }
        //      C# -> GlobalSlaReply? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: GlobalSlaReply! (type)
        if (this.EffectiveSlaDomain == null && Exploration.Includes(parent + ".effectiveSlaDomain"))
        {
            this.EffectiveSlaDomain = new GlobalSlaReply();
            this.EffectiveSlaDomain.ApplyExploratoryFieldSpec(parent + ".effectiveSlaDomain");
        }
    }


    #endregion

    } // class AzureNativeResourceGroupSlaAssignment
    
    #endregion

    public static class ListAzureNativeResourceGroupSlaAssignmentExtensions
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
            this List<AzureNativeResourceGroupSlaAssignment> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeResourceGroupSlaAssignment> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeResourceGroupSlaAssignment());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types