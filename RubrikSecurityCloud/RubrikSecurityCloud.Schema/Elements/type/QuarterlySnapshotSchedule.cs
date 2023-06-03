// QuarterlySnapshotSchedule.cs
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
    #region QuarterlySnapshotSchedule
    public class QuarterlySnapshotSchedule: BaseType
    {
        #region members

        //      C# -> DayOfQuarter? DayOfQuarter
        // GraphQL -> dayOfQuarter: DayOfQuarter! (enum)
        [JsonProperty("dayOfQuarter")]
        public DayOfQuarter? DayOfQuarter { get; set; }

        //      C# -> Month? QuarterStartMonth
        // GraphQL -> quarterStartMonth: Month! (enum)
        [JsonProperty("quarterStartMonth")]
        public Month? QuarterStartMonth { get; set; }

        //      C# -> BasicSnapshotSchedule? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
        [JsonProperty("basicSchedule")]
        public BasicSnapshotSchedule? BasicSchedule { get; set; }


        #endregion

    #region methods

    public QuarterlySnapshotSchedule Set(
        DayOfQuarter? DayOfQuarter = null,
        Month? QuarterStartMonth = null,
        BasicSnapshotSchedule? BasicSchedule = null
    ) 
    {
        if ( DayOfQuarter != null ) {
            this.DayOfQuarter = DayOfQuarter;
        }
        if ( QuarterStartMonth != null ) {
            this.QuarterStartMonth = QuarterStartMonth;
        }
        if ( BasicSchedule != null ) {
            this.BasicSchedule = BasicSchedule;
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
        //      C# -> DayOfQuarter? DayOfQuarter
        // GraphQL -> dayOfQuarter: DayOfQuarter! (enum)
        if (this.DayOfQuarter != null) {
            s += ind + "dayOfQuarter\n" ;
        }
        //      C# -> Month? QuarterStartMonth
        // GraphQL -> quarterStartMonth: Month! (enum)
        if (this.QuarterStartMonth != null) {
            s += ind + "quarterStartMonth\n" ;
        }
        //      C# -> BasicSnapshotSchedule? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
        if (this.BasicSchedule != null) {
            s += ind + "basicSchedule {\n" + this.BasicSchedule.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DayOfQuarter? DayOfQuarter
        // GraphQL -> dayOfQuarter: DayOfQuarter! (enum)
        if (this.DayOfQuarter == null && Exploration.Includes(parent + ".dayOfQuarter", true))
        {
            this.DayOfQuarter = new DayOfQuarter();
        }
        //      C# -> Month? QuarterStartMonth
        // GraphQL -> quarterStartMonth: Month! (enum)
        if (this.QuarterStartMonth == null && Exploration.Includes(parent + ".quarterStartMonth", true))
        {
            this.QuarterStartMonth = new Month();
        }
        //      C# -> BasicSnapshotSchedule? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
        if (this.BasicSchedule == null && Exploration.Includes(parent + ".basicSchedule"))
        {
            this.BasicSchedule = new BasicSnapshotSchedule();
            this.BasicSchedule.ApplyExploratoryFieldSpec(parent + ".basicSchedule");
        }
    }


    #endregion

    } // class QuarterlySnapshotSchedule
    
    #endregion

    public static class ListQuarterlySnapshotScheduleExtensions
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
            this List<QuarterlySnapshotSchedule> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<QuarterlySnapshotSchedule> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new QuarterlySnapshotSchedule());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types