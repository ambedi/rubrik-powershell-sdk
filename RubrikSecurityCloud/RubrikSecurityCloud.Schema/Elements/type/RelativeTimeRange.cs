// RelativeTimeRange.cs
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
    #region RelativeTimeRange
    public class RelativeTimeRange: BaseType
    {
        #region members

        //      C# -> TimeUnitEnum? Unit
        // GraphQL -> unit: TimeUnitEnum! (enum)
        [JsonProperty("unit")]
        public TimeUnitEnum? Unit { get; set; }

        //      C# -> System.Int32? Magnitude
        // GraphQL -> magnitude: Int! (scalar)
        [JsonProperty("magnitude")]
        public System.Int32? Magnitude { get; set; }


        #endregion

    #region methods

    public RelativeTimeRange Set(
        TimeUnitEnum? Unit = null,
        System.Int32? Magnitude = null
    ) 
    {
        if ( Unit != null ) {
            this.Unit = Unit;
        }
        if ( Magnitude != null ) {
            this.Magnitude = Magnitude;
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
        //      C# -> TimeUnitEnum? Unit
        // GraphQL -> unit: TimeUnitEnum! (enum)
        if (this.Unit != null) {
            s += ind + "unit\n" ;
        }
        //      C# -> System.Int32? Magnitude
        // GraphQL -> magnitude: Int! (scalar)
        if (this.Magnitude != null) {
            s += ind + "magnitude\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> TimeUnitEnum? Unit
        // GraphQL -> unit: TimeUnitEnum! (enum)
        if (this.Unit == null && Exploration.Includes(parent + ".unit", true))
        {
            this.Unit = new TimeUnitEnum();
        }
        //      C# -> System.Int32? Magnitude
        // GraphQL -> magnitude: Int! (scalar)
        if (this.Magnitude == null && Exploration.Includes(parent + ".magnitude", true))
        {
            this.Magnitude = new System.Int32();
        }
    }


    #endregion

    } // class RelativeTimeRange
    
    #endregion

    public static class ListRelativeTimeRangeExtensions
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
            this List<RelativeTimeRange> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RelativeTimeRange> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RelativeTimeRange());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types