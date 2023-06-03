// OracleNonSlaProperties.cs
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
    #region OracleNonSlaProperties
    public class OracleNonSlaProperties: BaseType
    {
        #region members

        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int (scalar)
        [JsonProperty("hostLogRetentionHours")]
        public System.Int32? HostLogRetentionHours { get; set; }

        //      C# -> System.String? HostMount
        // GraphQL -> hostMount: String! (scalar)
        [JsonProperty("hostMount")]
        public System.String? HostMount { get; set; }

        //      C# -> System.Int32? LogBackupFrequencyInMinutes
        // GraphQL -> logBackupFrequencyInMinutes: Int! (scalar)
        [JsonProperty("logBackupFrequencyInMinutes")]
        public System.Int32? LogBackupFrequencyInMinutes { get; set; }

        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        [JsonProperty("logRetentionHours")]
        public System.Int32? LogRetentionHours { get; set; }

        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        [JsonProperty("numChannels")]
        public System.Int32? NumChannels { get; set; }


        #endregion

    #region methods

    public OracleNonSlaProperties Set(
        System.Int32? HostLogRetentionHours = null,
        System.String? HostMount = null,
        System.Int32? LogBackupFrequencyInMinutes = null,
        System.Int32? LogRetentionHours = null,
        System.Int32? NumChannels = null
    ) 
    {
        if ( HostLogRetentionHours != null ) {
            this.HostLogRetentionHours = HostLogRetentionHours;
        }
        if ( HostMount != null ) {
            this.HostMount = HostMount;
        }
        if ( LogBackupFrequencyInMinutes != null ) {
            this.LogBackupFrequencyInMinutes = LogBackupFrequencyInMinutes;
        }
        if ( LogRetentionHours != null ) {
            this.LogRetentionHours = LogRetentionHours;
        }
        if ( NumChannels != null ) {
            this.NumChannels = NumChannels;
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
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int (scalar)
        if (this.HostLogRetentionHours != null) {
            s += ind + "hostLogRetentionHours\n" ;
        }
        //      C# -> System.String? HostMount
        // GraphQL -> hostMount: String! (scalar)
        if (this.HostMount != null) {
            s += ind + "hostMount\n" ;
        }
        //      C# -> System.Int32? LogBackupFrequencyInMinutes
        // GraphQL -> logBackupFrequencyInMinutes: Int! (scalar)
        if (this.LogBackupFrequencyInMinutes != null) {
            s += ind + "logBackupFrequencyInMinutes\n" ;
        }
        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        if (this.LogRetentionHours != null) {
            s += ind + "logRetentionHours\n" ;
        }
        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        if (this.NumChannels != null) {
            s += ind + "numChannels\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int (scalar)
        if (this.HostLogRetentionHours == null && Exploration.Includes(parent + ".hostLogRetentionHours", true))
        {
            this.HostLogRetentionHours = new System.Int32();
        }
        //      C# -> System.String? HostMount
        // GraphQL -> hostMount: String! (scalar)
        if (this.HostMount == null && Exploration.Includes(parent + ".hostMount", true))
        {
            this.HostMount = new System.String("FETCH");
        }
        //      C# -> System.Int32? LogBackupFrequencyInMinutes
        // GraphQL -> logBackupFrequencyInMinutes: Int! (scalar)
        if (this.LogBackupFrequencyInMinutes == null && Exploration.Includes(parent + ".logBackupFrequencyInMinutes", true))
        {
            this.LogBackupFrequencyInMinutes = new System.Int32();
        }
        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        if (this.LogRetentionHours == null && Exploration.Includes(parent + ".logRetentionHours", true))
        {
            this.LogRetentionHours = new System.Int32();
        }
        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        if (this.NumChannels == null && Exploration.Includes(parent + ".numChannels", true))
        {
            this.NumChannels = new System.Int32();
        }
    }


    #endregion

    } // class OracleNonSlaProperties
    
    #endregion

    public static class ListOracleNonSlaPropertiesExtensions
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
            this List<OracleNonSlaProperties> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleNonSlaProperties> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleNonSlaProperties());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types