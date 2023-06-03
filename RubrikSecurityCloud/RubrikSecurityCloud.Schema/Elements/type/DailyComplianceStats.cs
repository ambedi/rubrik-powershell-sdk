// DailyComplianceStats.cs
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
    #region DailyComplianceStats
    public class DailyComplianceStats: BaseType
    {
        #region members

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> List<ComplianceFrequency>? Counts
        // GraphQL -> counts: [ComplianceFrequency!]! (type)
        [JsonProperty("counts")]
        public List<ComplianceFrequency>? Counts { get; set; }


        #endregion

    #region methods

    public DailyComplianceStats Set(
        DateTime? Date = null,
        List<ComplianceFrequency>? Counts = null
    ) 
    {
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( Counts != null ) {
            this.Counts = Counts;
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
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date != null) {
            s += ind + "date\n" ;
        }
        //      C# -> List<ComplianceFrequency>? Counts
        // GraphQL -> counts: [ComplianceFrequency!]! (type)
        if (this.Counts != null) {
            s += ind + "counts {\n" + this.Counts.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date == null && Exploration.Includes(parent + ".date", true))
        {
            this.Date = new DateTime();
        }
        //      C# -> List<ComplianceFrequency>? Counts
        // GraphQL -> counts: [ComplianceFrequency!]! (type)
        if (this.Counts == null && Exploration.Includes(parent + ".counts"))
        {
            this.Counts = new List<ComplianceFrequency>();
            this.Counts.ApplyExploratoryFieldSpec(parent + ".counts");
        }
    }


    #endregion

    } // class DailyComplianceStats
    
    #endregion

    public static class ListDailyComplianceStatsExtensions
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
            this List<DailyComplianceStats> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DailyComplianceStats> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DailyComplianceStats());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types