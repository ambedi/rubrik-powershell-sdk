// LambdaSettings.cs
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
    #region LambdaSettings
    public class LambdaSettings: BaseType
    {
        #region members

        //      C# -> System.Single? AnomalyThreshold
        // GraphQL -> anomalyThreshold: Float (scalar)
        [JsonProperty("anomalyThreshold")]
        public System.Single? AnomalyThreshold { get; set; }

        //      C# -> System.Boolean? IsAnomalyAlertEnabled
        // GraphQL -> isAnomalyAlertEnabled: Boolean (scalar)
        [JsonProperty("isAnomalyAlertEnabled")]
        public System.Boolean? IsAnomalyAlertEnabled { get; set; }

        //      C# -> System.Single? RansomwareThreshold
        // GraphQL -> ransomwareThreshold: Float (scalar)
        [JsonProperty("ransomwareThreshold")]
        public System.Single? RansomwareThreshold { get; set; }


        #endregion

    #region methods

    public LambdaSettings Set(
        System.Single? AnomalyThreshold = null,
        System.Boolean? IsAnomalyAlertEnabled = null,
        System.Single? RansomwareThreshold = null
    ) 
    {
        if ( AnomalyThreshold != null ) {
            this.AnomalyThreshold = AnomalyThreshold;
        }
        if ( IsAnomalyAlertEnabled != null ) {
            this.IsAnomalyAlertEnabled = IsAnomalyAlertEnabled;
        }
        if ( RansomwareThreshold != null ) {
            this.RansomwareThreshold = RansomwareThreshold;
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
        //      C# -> System.Single? AnomalyThreshold
        // GraphQL -> anomalyThreshold: Float (scalar)
        if (this.AnomalyThreshold != null) {
            s += ind + "anomalyThreshold\n" ;
        }
        //      C# -> System.Boolean? IsAnomalyAlertEnabled
        // GraphQL -> isAnomalyAlertEnabled: Boolean (scalar)
        if (this.IsAnomalyAlertEnabled != null) {
            s += ind + "isAnomalyAlertEnabled\n" ;
        }
        //      C# -> System.Single? RansomwareThreshold
        // GraphQL -> ransomwareThreshold: Float (scalar)
        if (this.RansomwareThreshold != null) {
            s += ind + "ransomwareThreshold\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Single? AnomalyThreshold
        // GraphQL -> anomalyThreshold: Float (scalar)
        if (this.AnomalyThreshold == null && Exploration.Includes(parent + ".anomalyThreshold", true))
        {
            this.AnomalyThreshold = new System.Single();
        }
        //      C# -> System.Boolean? IsAnomalyAlertEnabled
        // GraphQL -> isAnomalyAlertEnabled: Boolean (scalar)
        if (this.IsAnomalyAlertEnabled == null && Exploration.Includes(parent + ".isAnomalyAlertEnabled", true))
        {
            this.IsAnomalyAlertEnabled = true;
        }
        //      C# -> System.Single? RansomwareThreshold
        // GraphQL -> ransomwareThreshold: Float (scalar)
        if (this.RansomwareThreshold == null && Exploration.Includes(parent + ".ransomwareThreshold", true))
        {
            this.RansomwareThreshold = new System.Single();
        }
    }


    #endregion

    } // class LambdaSettings
    
    #endregion

    public static class ListLambdaSettingsExtensions
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
            this List<LambdaSettings> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LambdaSettings> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new LambdaSettings());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types