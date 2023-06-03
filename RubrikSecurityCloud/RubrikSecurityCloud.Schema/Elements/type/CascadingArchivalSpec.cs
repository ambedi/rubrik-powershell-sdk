// CascadingArchivalSpec.cs
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
    #region CascadingArchivalSpec
    public class CascadingArchivalSpec: BaseType
    {
        #region members

        //      C# -> List<RetentionUnit>? Frequency
        // GraphQL -> frequency: [RetentionUnit!]! (enum)
        [JsonProperty("frequency")]
        public List<RetentionUnit>? Frequency { get; set; }

        //      C# -> Target? ArchivalLocation
        // GraphQL -> archivalLocation: Target (interface)
        [JsonProperty("archivalLocation")]
        public Target? ArchivalLocation { get; set; }

        //      C# -> Duration? ArchivalThreshold
        // GraphQL -> archivalThreshold: Duration (type)
        [JsonProperty("archivalThreshold")]
        public Duration? ArchivalThreshold { get; set; }

        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        [JsonProperty("archivalTieringSpec")]
        public ArchivalTieringSpec? ArchivalTieringSpec { get; set; }


        #endregion

    #region methods

    public CascadingArchivalSpec Set(
        List<RetentionUnit>? Frequency = null,
        Target? ArchivalLocation = null,
        Duration? ArchivalThreshold = null,
        ArchivalTieringSpec? ArchivalTieringSpec = null
    ) 
    {
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( ArchivalLocation != null ) {
            this.ArchivalLocation = ArchivalLocation;
        }
        if ( ArchivalThreshold != null ) {
            this.ArchivalThreshold = ArchivalThreshold;
        }
        if ( ArchivalTieringSpec != null ) {
            this.ArchivalTieringSpec = ArchivalTieringSpec;
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
        //      C# -> List<RetentionUnit>? Frequency
        // GraphQL -> frequency: [RetentionUnit!]! (enum)
        if (this.Frequency != null) {
            s += ind + "frequency\n" ;
        }
        //      C# -> Target? ArchivalLocation
        // GraphQL -> archivalLocation: Target (interface)
        if (this.ArchivalLocation != null) {
            s += ind + "archivalLocation {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.ArchivalLocation).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> Duration? ArchivalThreshold
        // GraphQL -> archivalThreshold: Duration (type)
        if (this.ArchivalThreshold != null) {
            s += ind + "archivalThreshold {\n" + this.ArchivalThreshold.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        if (this.ArchivalTieringSpec != null) {
            s += ind + "archivalTieringSpec {\n" + this.ArchivalTieringSpec.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<RetentionUnit>? Frequency
        // GraphQL -> frequency: [RetentionUnit!]! (enum)
        if (this.Frequency == null && Exploration.Includes(parent + ".frequency", true))
        {
            this.Frequency = new List<RetentionUnit>();
        }
        //      C# -> Target? ArchivalLocation
        // GraphQL -> archivalLocation: Target (interface)
        if (this.ArchivalLocation == null && Exploration.Includes(parent + ".archivalLocation"))
        {
            var impls = new List<Target>();
            impls.ApplyExploratoryFieldSpec(parent + ".archivalLocation");
            this.ArchivalLocation = (Target)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> Duration? ArchivalThreshold
        // GraphQL -> archivalThreshold: Duration (type)
        if (this.ArchivalThreshold == null && Exploration.Includes(parent + ".archivalThreshold"))
        {
            this.ArchivalThreshold = new Duration();
            this.ArchivalThreshold.ApplyExploratoryFieldSpec(parent + ".archivalThreshold");
        }
        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        if (this.ArchivalTieringSpec == null && Exploration.Includes(parent + ".archivalTieringSpec"))
        {
            this.ArchivalTieringSpec = new ArchivalTieringSpec();
            this.ArchivalTieringSpec.ApplyExploratoryFieldSpec(parent + ".archivalTieringSpec");
        }
    }


    #endregion

    } // class CascadingArchivalSpec
    
    #endregion

    public static class ListCascadingArchivalSpecExtensions
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
            this List<CascadingArchivalSpec> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CascadingArchivalSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CascadingArchivalSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types