// LookupAccountReply.cs
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
    #region LookupAccountReply
    public class LookupAccountReply: BaseType
    {
        #region members

        //      C# -> AccountState? AccountState
        // GraphQL -> accountState: AccountState! (enum)
        [JsonProperty("accountState")]
        public AccountState? AccountState { get; set; }

        //      C# -> AccountType? AccountType
        // GraphQL -> accountType: AccountType! (enum)
        [JsonProperty("accountType")]
        public AccountType? AccountType { get; set; }

        //      C# -> DateTime? AccountExpiryDate
        // GraphQL -> accountExpiryDate: DateTime (scalar)
        [JsonProperty("accountExpiryDate")]
        public DateTime? AccountExpiryDate { get; set; }

        //      C# -> System.Int64? AccountHoldLength
        // GraphQL -> accountHoldLength: Long! (scalar)
        [JsonProperty("accountHoldLength")]
        public System.Int64? AccountHoldLength { get; set; }

        //      C# -> System.Int64? HoldWarningLength
        // GraphQL -> holdWarningLength: Long! (scalar)
        [JsonProperty("holdWarningLength")]
        public System.Int64? HoldWarningLength { get; set; }


        #endregion

    #region methods

    public LookupAccountReply Set(
        AccountState? AccountState = null,
        AccountType? AccountType = null,
        DateTime? AccountExpiryDate = null,
        System.Int64? AccountHoldLength = null,
        System.Int64? HoldWarningLength = null
    ) 
    {
        if ( AccountState != null ) {
            this.AccountState = AccountState;
        }
        if ( AccountType != null ) {
            this.AccountType = AccountType;
        }
        if ( AccountExpiryDate != null ) {
            this.AccountExpiryDate = AccountExpiryDate;
        }
        if ( AccountHoldLength != null ) {
            this.AccountHoldLength = AccountHoldLength;
        }
        if ( HoldWarningLength != null ) {
            this.HoldWarningLength = HoldWarningLength;
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
        //      C# -> AccountState? AccountState
        // GraphQL -> accountState: AccountState! (enum)
        if (this.AccountState != null) {
            s += ind + "accountState\n" ;
        }
        //      C# -> AccountType? AccountType
        // GraphQL -> accountType: AccountType! (enum)
        if (this.AccountType != null) {
            s += ind + "accountType\n" ;
        }
        //      C# -> DateTime? AccountExpiryDate
        // GraphQL -> accountExpiryDate: DateTime (scalar)
        if (this.AccountExpiryDate != null) {
            s += ind + "accountExpiryDate\n" ;
        }
        //      C# -> System.Int64? AccountHoldLength
        // GraphQL -> accountHoldLength: Long! (scalar)
        if (this.AccountHoldLength != null) {
            s += ind + "accountHoldLength\n" ;
        }
        //      C# -> System.Int64? HoldWarningLength
        // GraphQL -> holdWarningLength: Long! (scalar)
        if (this.HoldWarningLength != null) {
            s += ind + "holdWarningLength\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AccountState? AccountState
        // GraphQL -> accountState: AccountState! (enum)
        if (this.AccountState == null && Exploration.Includes(parent + ".accountState", true))
        {
            this.AccountState = new AccountState();
        }
        //      C# -> AccountType? AccountType
        // GraphQL -> accountType: AccountType! (enum)
        if (this.AccountType == null && Exploration.Includes(parent + ".accountType", true))
        {
            this.AccountType = new AccountType();
        }
        //      C# -> DateTime? AccountExpiryDate
        // GraphQL -> accountExpiryDate: DateTime (scalar)
        if (this.AccountExpiryDate == null && Exploration.Includes(parent + ".accountExpiryDate", true))
        {
            this.AccountExpiryDate = new DateTime();
        }
        //      C# -> System.Int64? AccountHoldLength
        // GraphQL -> accountHoldLength: Long! (scalar)
        if (this.AccountHoldLength == null && Exploration.Includes(parent + ".accountHoldLength", true))
        {
            this.AccountHoldLength = new System.Int64();
        }
        //      C# -> System.Int64? HoldWarningLength
        // GraphQL -> holdWarningLength: Long! (scalar)
        if (this.HoldWarningLength == null && Exploration.Includes(parent + ".holdWarningLength", true))
        {
            this.HoldWarningLength = new System.Int64();
        }
    }


    #endregion

    } // class LookupAccountReply
    
    #endregion

    public static class ListLookupAccountReplyExtensions
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
            this List<LookupAccountReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LookupAccountReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new LookupAccountReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types