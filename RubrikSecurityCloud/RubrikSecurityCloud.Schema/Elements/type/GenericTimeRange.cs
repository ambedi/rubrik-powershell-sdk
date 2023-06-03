// GenericTimeRange.cs
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
    #region GenericTimeRange
    public class GenericTimeRange: BaseType
    {
        #region members

        //      C# -> TimeRange? AbsoluteTimeRange
        // GraphQL -> absoluteTimeRange: TimeRange (type)
        [JsonProperty("absoluteTimeRange")]
        public TimeRange? AbsoluteTimeRange { get; set; }

        //      C# -> RelativeTimeRange? RelativeTimeRange
        // GraphQL -> relativeTimeRange: RelativeTimeRange (type)
        [JsonProperty("relativeTimeRange")]
        public RelativeTimeRange? RelativeTimeRange { get; set; }


        #endregion

    #region methods

    public GenericTimeRange Set(
        TimeRange? AbsoluteTimeRange = null,
        RelativeTimeRange? RelativeTimeRange = null
    ) 
    {
        if ( AbsoluteTimeRange != null ) {
            this.AbsoluteTimeRange = AbsoluteTimeRange;
        }
        if ( RelativeTimeRange != null ) {
            this.RelativeTimeRange = RelativeTimeRange;
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
        //      C# -> TimeRange? AbsoluteTimeRange
        // GraphQL -> absoluteTimeRange: TimeRange (type)
        if (this.AbsoluteTimeRange != null) {
            s += ind + "absoluteTimeRange {\n" + this.AbsoluteTimeRange.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> RelativeTimeRange? RelativeTimeRange
        // GraphQL -> relativeTimeRange: RelativeTimeRange (type)
        if (this.RelativeTimeRange != null) {
            s += ind + "relativeTimeRange {\n" + this.RelativeTimeRange.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> TimeRange? AbsoluteTimeRange
        // GraphQL -> absoluteTimeRange: TimeRange (type)
        if (this.AbsoluteTimeRange == null && Exploration.Includes(parent + ".absoluteTimeRange"))
        {
            this.AbsoluteTimeRange = new TimeRange();
            this.AbsoluteTimeRange.ApplyExploratoryFieldSpec(parent + ".absoluteTimeRange");
        }
        //      C# -> RelativeTimeRange? RelativeTimeRange
        // GraphQL -> relativeTimeRange: RelativeTimeRange (type)
        if (this.RelativeTimeRange == null && Exploration.Includes(parent + ".relativeTimeRange"))
        {
            this.RelativeTimeRange = new RelativeTimeRange();
            this.RelativeTimeRange.ApplyExploratoryFieldSpec(parent + ".relativeTimeRange");
        }
    }


    #endregion

    } // class GenericTimeRange
    
    #endregion

    public static class ListGenericTimeRangeExtensions
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
            this List<GenericTimeRange> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GenericTimeRange> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GenericTimeRange());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types