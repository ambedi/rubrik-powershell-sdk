// PrePostScript.cs
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
    #region PrePostScript
    public class PrePostScript: BaseType
    {
        #region members

        //      C# -> PrePostScriptFailureHandlingEnum? FailureHandling
        // GraphQL -> failureHandling: PrePostScriptFailureHandlingEnum! (enum)
        [JsonProperty("failureHandling")]
        public PrePostScriptFailureHandlingEnum? FailureHandling { get; set; }

        //      C# -> System.String? ScriptPath
        // GraphQL -> scriptPath: String! (scalar)
        [JsonProperty("scriptPath")]
        public System.String? ScriptPath { get; set; }

        //      C# -> System.Int32? TimeoutMs
        // GraphQL -> timeoutMs: Int! (scalar)
        [JsonProperty("timeoutMs")]
        public System.Int32? TimeoutMs { get; set; }


        #endregion

    #region methods

    public PrePostScript Set(
        PrePostScriptFailureHandlingEnum? FailureHandling = null,
        System.String? ScriptPath = null,
        System.Int32? TimeoutMs = null
    ) 
    {
        if ( FailureHandling != null ) {
            this.FailureHandling = FailureHandling;
        }
        if ( ScriptPath != null ) {
            this.ScriptPath = ScriptPath;
        }
        if ( TimeoutMs != null ) {
            this.TimeoutMs = TimeoutMs;
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
        //      C# -> PrePostScriptFailureHandlingEnum? FailureHandling
        // GraphQL -> failureHandling: PrePostScriptFailureHandlingEnum! (enum)
        if (this.FailureHandling != null) {
            s += ind + "failureHandling\n" ;
        }
        //      C# -> System.String? ScriptPath
        // GraphQL -> scriptPath: String! (scalar)
        if (this.ScriptPath != null) {
            s += ind + "scriptPath\n" ;
        }
        //      C# -> System.Int32? TimeoutMs
        // GraphQL -> timeoutMs: Int! (scalar)
        if (this.TimeoutMs != null) {
            s += ind + "timeoutMs\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> PrePostScriptFailureHandlingEnum? FailureHandling
        // GraphQL -> failureHandling: PrePostScriptFailureHandlingEnum! (enum)
        if (this.FailureHandling == null && Exploration.Includes(parent + ".failureHandling", true))
        {
            this.FailureHandling = new PrePostScriptFailureHandlingEnum();
        }
        //      C# -> System.String? ScriptPath
        // GraphQL -> scriptPath: String! (scalar)
        if (this.ScriptPath == null && Exploration.Includes(parent + ".scriptPath", true))
        {
            this.ScriptPath = new System.String("FETCH");
        }
        //      C# -> System.Int32? TimeoutMs
        // GraphQL -> timeoutMs: Int! (scalar)
        if (this.TimeoutMs == null && Exploration.Includes(parent + ".timeoutMs", true))
        {
            this.TimeoutMs = new System.Int32();
        }
    }


    #endregion

    } // class PrePostScript
    
    #endregion

    public static class ListPrePostScriptExtensions
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
            this List<PrePostScript> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrePostScript> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PrePostScript());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types