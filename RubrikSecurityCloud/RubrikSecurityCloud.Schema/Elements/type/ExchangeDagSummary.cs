// ExchangeDagSummary.cs
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
    #region ExchangeDagSummary
    public class ExchangeDagSummary: BaseType
    {
        #region members

        //      C# -> ExchangeBackupPreference? BackupPreference
        // GraphQL -> backupPreference: ExchangeBackupPreference! (enum)
        [JsonProperty("backupPreference")]
        public ExchangeBackupPreference? BackupPreference { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.String? ConfiguredSlaType
        // GraphQL -> configuredSlaType: String! (scalar)
        [JsonProperty("configuredSlaType")]
        public System.String? ConfiguredSlaType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public ExchangeDagSummary Set(
        ExchangeBackupPreference? BackupPreference = null,
        System.String? ConfiguredSlaDomainId = null,
        System.String? ConfiguredSlaType = null,
        System.String? Id = null,
        System.String? Name = null
    ) 
    {
        if ( BackupPreference != null ) {
            this.BackupPreference = BackupPreference;
        }
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( ConfiguredSlaType != null ) {
            this.ConfiguredSlaType = ConfiguredSlaType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> ExchangeBackupPreference? BackupPreference
        // GraphQL -> backupPreference: ExchangeBackupPreference! (enum)
        if (this.BackupPreference != null) {
            s += ind + "backupPreference\n" ;
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            s += ind + "configuredSlaDomainId\n" ;
        }
        //      C# -> System.String? ConfiguredSlaType
        // GraphQL -> configuredSlaType: String! (scalar)
        if (this.ConfiguredSlaType != null) {
            s += ind + "configuredSlaType\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ExchangeBackupPreference? BackupPreference
        // GraphQL -> backupPreference: ExchangeBackupPreference! (enum)
        if (this.BackupPreference == null && Exploration.Includes(parent + ".backupPreference", true))
        {
            this.BackupPreference = new ExchangeBackupPreference();
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (this.ConfiguredSlaDomainId == null && Exploration.Includes(parent + ".configuredSlaDomainId", true))
        {
            this.ConfiguredSlaDomainId = new System.String("FETCH");
        }
        //      C# -> System.String? ConfiguredSlaType
        // GraphQL -> configuredSlaType: String! (scalar)
        if (this.ConfiguredSlaType == null && Exploration.Includes(parent + ".configuredSlaType", true))
        {
            this.ConfiguredSlaType = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
    }


    #endregion

    } // class ExchangeDagSummary
    
    #endregion

    public static class ListExchangeDagSummaryExtensions
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
            this List<ExchangeDagSummary> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ExchangeDagSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ExchangeDagSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types