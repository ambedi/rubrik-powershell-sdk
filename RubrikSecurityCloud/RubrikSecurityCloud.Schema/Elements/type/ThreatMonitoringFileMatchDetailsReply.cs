// ThreatMonitoringFileMatchDetailsReply.cs
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
    #region ThreatMonitoringFileMatchDetailsReply
    public class ThreatMonitoringFileMatchDetailsReply: BaseType
    {
        #region members

        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        [JsonProperty("matchType")]
        public IndicatorOfCompromiseKind? MatchType { get; set; }

        //      C# -> DateTime? DetectedSnapshotDate
        // GraphQL -> detectedSnapshotDate: DateTime (scalar)
        [JsonProperty("detectedSnapshotDate")]
        public DateTime? DetectedSnapshotDate { get; set; }

        //      C# -> System.String? FirstDetectedSnapshotFid
        // GraphQL -> firstDetectedSnapshotFid: String! (scalar)
        [JsonProperty("firstDetectedSnapshotFid")]
        public System.String? FirstDetectedSnapshotFid { get; set; }

        //      C# -> System.String? IntelSource
        // GraphQL -> intelSource: String! (scalar)
        [JsonProperty("intelSource")]
        public System.String? IntelSource { get; set; }

        //      C# -> System.String? IocAttribute
        // GraphQL -> iocAttribute: String! (scalar)
        [JsonProperty("iocAttribute")]
        public System.String? IocAttribute { get; set; }

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }


        #endregion

    #region methods

    public ThreatMonitoringFileMatchDetailsReply Set(
        IndicatorOfCompromiseKind? MatchType = null,
        DateTime? DetectedSnapshotDate = null,
        System.String? FirstDetectedSnapshotFid = null,
        System.String? IntelSource = null,
        System.String? IocAttribute = null,
        System.Boolean? IsQuarantined = null
    ) 
    {
        if ( MatchType != null ) {
            this.MatchType = MatchType;
        }
        if ( DetectedSnapshotDate != null ) {
            this.DetectedSnapshotDate = DetectedSnapshotDate;
        }
        if ( FirstDetectedSnapshotFid != null ) {
            this.FirstDetectedSnapshotFid = FirstDetectedSnapshotFid;
        }
        if ( IntelSource != null ) {
            this.IntelSource = IntelSource;
        }
        if ( IocAttribute != null ) {
            this.IocAttribute = IocAttribute;
        }
        if ( IsQuarantined != null ) {
            this.IsQuarantined = IsQuarantined;
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
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (this.MatchType != null) {
            s += ind + "matchType\n" ;
        }
        //      C# -> DateTime? DetectedSnapshotDate
        // GraphQL -> detectedSnapshotDate: DateTime (scalar)
        if (this.DetectedSnapshotDate != null) {
            s += ind + "detectedSnapshotDate\n" ;
        }
        //      C# -> System.String? FirstDetectedSnapshotFid
        // GraphQL -> firstDetectedSnapshotFid: String! (scalar)
        if (this.FirstDetectedSnapshotFid != null) {
            s += ind + "firstDetectedSnapshotFid\n" ;
        }
        //      C# -> System.String? IntelSource
        // GraphQL -> intelSource: String! (scalar)
        if (this.IntelSource != null) {
            s += ind + "intelSource\n" ;
        }
        //      C# -> System.String? IocAttribute
        // GraphQL -> iocAttribute: String! (scalar)
        if (this.IocAttribute != null) {
            s += ind + "iocAttribute\n" ;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined != null) {
            s += ind + "isQuarantined\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (this.MatchType == null && Exploration.Includes(parent + ".matchType", true))
        {
            this.MatchType = new IndicatorOfCompromiseKind();
        }
        //      C# -> DateTime? DetectedSnapshotDate
        // GraphQL -> detectedSnapshotDate: DateTime (scalar)
        if (this.DetectedSnapshotDate == null && Exploration.Includes(parent + ".detectedSnapshotDate", true))
        {
            this.DetectedSnapshotDate = new DateTime();
        }
        //      C# -> System.String? FirstDetectedSnapshotFid
        // GraphQL -> firstDetectedSnapshotFid: String! (scalar)
        if (this.FirstDetectedSnapshotFid == null && Exploration.Includes(parent + ".firstDetectedSnapshotFid", true))
        {
            this.FirstDetectedSnapshotFid = new System.String("FETCH");
        }
        //      C# -> System.String? IntelSource
        // GraphQL -> intelSource: String! (scalar)
        if (this.IntelSource == null && Exploration.Includes(parent + ".intelSource", true))
        {
            this.IntelSource = new System.String("FETCH");
        }
        //      C# -> System.String? IocAttribute
        // GraphQL -> iocAttribute: String! (scalar)
        if (this.IocAttribute == null && Exploration.Includes(parent + ".iocAttribute", true))
        {
            this.IocAttribute = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined == null && Exploration.Includes(parent + ".isQuarantined", true))
        {
            this.IsQuarantined = true;
        }
    }


    #endregion

    } // class ThreatMonitoringFileMatchDetailsReply
    
    #endregion

    public static class ListThreatMonitoringFileMatchDetailsReplyExtensions
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
            this List<ThreatMonitoringFileMatchDetailsReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ThreatMonitoringFileMatchDetailsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatMonitoringFileMatchDetailsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types