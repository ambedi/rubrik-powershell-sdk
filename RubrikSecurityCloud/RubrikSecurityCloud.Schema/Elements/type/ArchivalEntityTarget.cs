// ArchivalEntityTarget.cs
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
    #region ArchivalEntityTarget
 
    public class ArchivalEntityTarget: BaseType, ArchivalEntity
    {
        #region members

        //      C# -> ArchivalEntityUseCaseType? UseCaseType
        // GraphQL -> useCaseType: ArchivalEntityUseCaseType! (enum)
        [JsonProperty("useCaseType")]
        public ArchivalEntityUseCaseType? UseCaseType { get; set; }

        //      C# -> Target? Target
        // GraphQL -> target: Target! (interface)
        [JsonProperty("target")]
        public Target? Target { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalEntityTarget";
    }

    public ArchivalEntityTarget Set(
        ArchivalEntityUseCaseType? UseCaseType = null,
        Target? Target = null
    ) 
    {
        if ( UseCaseType != null ) {
            this.UseCaseType = UseCaseType;
        }
        if ( Target != null ) {
            this.Target = Target;
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
        //      C# -> ArchivalEntityUseCaseType? UseCaseType
        // GraphQL -> useCaseType: ArchivalEntityUseCaseType! (enum)
        if (this.UseCaseType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "useCaseType\n" ;
            } else {
                s += ind + "useCaseType\n" ;
            }
        }
        //      C# -> Target? Target
        // GraphQL -> target: Target! (interface)
        if (this.Target != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.Target, conf.Child("target"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "target" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ArchivalEntityUseCaseType? UseCaseType
        // GraphQL -> useCaseType: ArchivalEntityUseCaseType! (enum)
        if (ec.Includes("useCaseType",true))
        {
            if(this.UseCaseType == null) {

                this.UseCaseType = new ArchivalEntityUseCaseType();

            } else {


            }
        }
        else if (this.UseCaseType != null && ec.Excludes("useCaseType",true))
        {
            this.UseCaseType = null;
        }
        //      C# -> Target? Target
        // GraphQL -> target: Target! (interface)
        if (ec.Includes("target",false))
        {
            if(this.Target == null) {

                var impls = new List<Target>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("target"));
                this.Target = (Target)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<Target>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("target"));
                this.Target = (Target)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Target != null && ec.Excludes("target",false))
        {
            this.Target = null;
        }
    }


    #endregion

    } // class ArchivalEntityTarget
    
    #endregion

    public static class ListArchivalEntityTargetExtensions
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
            this List<ArchivalEntityTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalEntityTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalEntityTarget> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalEntityTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalEntityTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types