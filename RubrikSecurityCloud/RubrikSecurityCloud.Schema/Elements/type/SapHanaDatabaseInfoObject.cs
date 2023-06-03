// SapHanaDatabaseInfoObject.cs
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
    #region SapHanaDatabaseInfoObject
    public class SapHanaDatabaseInfoObject: BaseType
    {
        #region members

        //      C# -> System.Int64? ApproxDbSizeInMb
        // GraphQL -> approxDbSizeInMb: Long! (scalar)
        [JsonProperty("approxDbSizeInMb")]
        public System.Int64? ApproxDbSizeInMb { get; set; }

        //      C# -> System.String? BackintPath
        // GraphQL -> backintPath: String! (scalar)
        [JsonProperty("backintPath")]
        public System.String? BackintPath { get; set; }

        //      C# -> System.String? DatabaseType
        // GraphQL -> databaseType: String! (scalar)
        [JsonProperty("databaseType")]
        public System.String? DatabaseType { get; set; }

        //      C# -> System.Int32? LogBackupIntervalSecs
        // GraphQL -> logBackupIntervalSecs: Int! (scalar)
        [JsonProperty("logBackupIntervalSecs")]
        public System.Int32? LogBackupIntervalSecs { get; set; }

        //      C# -> System.String? LogMode
        // GraphQL -> logMode: String! (scalar)
        [JsonProperty("logMode")]
        public System.String? LogMode { get; set; }

        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        [JsonProperty("numChannels")]
        public System.Int32? NumChannels { get; set; }

        //      C# -> System.String? ParamFilePath
        // GraphQL -> paramFilePath: String! (scalar)
        [JsonProperty("paramFilePath")]
        public System.String? ParamFilePath { get; set; }

        //      C# -> System.String? RestoreConfiguredSrcDatabaseId
        // GraphQL -> restoreConfiguredSrcDatabaseId: String! (scalar)
        [JsonProperty("restoreConfiguredSrcDatabaseId")]
        public System.String? RestoreConfiguredSrcDatabaseId { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }


        #endregion

    #region methods

    public SapHanaDatabaseInfoObject Set(
        System.Int64? ApproxDbSizeInMb = null,
        System.String? BackintPath = null,
        System.String? DatabaseType = null,
        System.Int32? LogBackupIntervalSecs = null,
        System.String? LogMode = null,
        System.Int32? NumChannels = null,
        System.String? ParamFilePath = null,
        System.String? RestoreConfiguredSrcDatabaseId = null,
        System.String? Status = null
    ) 
    {
        if ( ApproxDbSizeInMb != null ) {
            this.ApproxDbSizeInMb = ApproxDbSizeInMb;
        }
        if ( BackintPath != null ) {
            this.BackintPath = BackintPath;
        }
        if ( DatabaseType != null ) {
            this.DatabaseType = DatabaseType;
        }
        if ( LogBackupIntervalSecs != null ) {
            this.LogBackupIntervalSecs = LogBackupIntervalSecs;
        }
        if ( LogMode != null ) {
            this.LogMode = LogMode;
        }
        if ( NumChannels != null ) {
            this.NumChannels = NumChannels;
        }
        if ( ParamFilePath != null ) {
            this.ParamFilePath = ParamFilePath;
        }
        if ( RestoreConfiguredSrcDatabaseId != null ) {
            this.RestoreConfiguredSrcDatabaseId = RestoreConfiguredSrcDatabaseId;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.Int64? ApproxDbSizeInMb
        // GraphQL -> approxDbSizeInMb: Long! (scalar)
        if (this.ApproxDbSizeInMb != null) {
            s += ind + "approxDbSizeInMb\n" ;
        }
        //      C# -> System.String? BackintPath
        // GraphQL -> backintPath: String! (scalar)
        if (this.BackintPath != null) {
            s += ind + "backintPath\n" ;
        }
        //      C# -> System.String? DatabaseType
        // GraphQL -> databaseType: String! (scalar)
        if (this.DatabaseType != null) {
            s += ind + "databaseType\n" ;
        }
        //      C# -> System.Int32? LogBackupIntervalSecs
        // GraphQL -> logBackupIntervalSecs: Int! (scalar)
        if (this.LogBackupIntervalSecs != null) {
            s += ind + "logBackupIntervalSecs\n" ;
        }
        //      C# -> System.String? LogMode
        // GraphQL -> logMode: String! (scalar)
        if (this.LogMode != null) {
            s += ind + "logMode\n" ;
        }
        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        if (this.NumChannels != null) {
            s += ind + "numChannels\n" ;
        }
        //      C# -> System.String? ParamFilePath
        // GraphQL -> paramFilePath: String! (scalar)
        if (this.ParamFilePath != null) {
            s += ind + "paramFilePath\n" ;
        }
        //      C# -> System.String? RestoreConfiguredSrcDatabaseId
        // GraphQL -> restoreConfiguredSrcDatabaseId: String! (scalar)
        if (this.RestoreConfiguredSrcDatabaseId != null) {
            s += ind + "restoreConfiguredSrcDatabaseId\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? ApproxDbSizeInMb
        // GraphQL -> approxDbSizeInMb: Long! (scalar)
        if (this.ApproxDbSizeInMb == null && Exploration.Includes(parent + ".approxDbSizeInMb", true))
        {
            this.ApproxDbSizeInMb = new System.Int64();
        }
        //      C# -> System.String? BackintPath
        // GraphQL -> backintPath: String! (scalar)
        if (this.BackintPath == null && Exploration.Includes(parent + ".backintPath", true))
        {
            this.BackintPath = new System.String("FETCH");
        }
        //      C# -> System.String? DatabaseType
        // GraphQL -> databaseType: String! (scalar)
        if (this.DatabaseType == null && Exploration.Includes(parent + ".databaseType", true))
        {
            this.DatabaseType = new System.String("FETCH");
        }
        //      C# -> System.Int32? LogBackupIntervalSecs
        // GraphQL -> logBackupIntervalSecs: Int! (scalar)
        if (this.LogBackupIntervalSecs == null && Exploration.Includes(parent + ".logBackupIntervalSecs", true))
        {
            this.LogBackupIntervalSecs = new System.Int32();
        }
        //      C# -> System.String? LogMode
        // GraphQL -> logMode: String! (scalar)
        if (this.LogMode == null && Exploration.Includes(parent + ".logMode", true))
        {
            this.LogMode = new System.String("FETCH");
        }
        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        if (this.NumChannels == null && Exploration.Includes(parent + ".numChannels", true))
        {
            this.NumChannels = new System.Int32();
        }
        //      C# -> System.String? ParamFilePath
        // GraphQL -> paramFilePath: String! (scalar)
        if (this.ParamFilePath == null && Exploration.Includes(parent + ".paramFilePath", true))
        {
            this.ParamFilePath = new System.String("FETCH");
        }
        //      C# -> System.String? RestoreConfiguredSrcDatabaseId
        // GraphQL -> restoreConfiguredSrcDatabaseId: String! (scalar)
        if (this.RestoreConfiguredSrcDatabaseId == null && Exploration.Includes(parent + ".restoreConfiguredSrcDatabaseId", true))
        {
            this.RestoreConfiguredSrcDatabaseId = new System.String("FETCH");
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new System.String("FETCH");
        }
    }


    #endregion

    } // class SapHanaDatabaseInfoObject
    
    #endregion

    public static class ListSapHanaDatabaseInfoObjectExtensions
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
            this List<SapHanaDatabaseInfoObject> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaDatabaseInfoObject> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaDatabaseInfoObject());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types