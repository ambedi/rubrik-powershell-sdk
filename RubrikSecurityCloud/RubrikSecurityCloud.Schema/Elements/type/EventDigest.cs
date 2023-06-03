// EventDigest.cs
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
    #region EventDigest
    public class EventDigest: BaseType
    {
        #region members

        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        [JsonProperty("account")]
        public System.String? Account { get; set; }

        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        [JsonProperty("clusterUuids")]
        public List<System.String>? ClusterUuids { get; set; }

        //      C# -> System.Int32? DigestId
        // GraphQL -> digestId: Int! (scalar)
        [JsonProperty("digestId")]
        public System.Int32? DigestId { get; set; }

        //      C# -> System.String? DigestName
        // GraphQL -> digestName: String! (scalar)
        [JsonProperty("digestName")]
        public System.String? DigestName { get; set; }

        //      C# -> System.String? EventDigestConfigJson
        // GraphQL -> eventDigestConfigJson: String! (scalar)
        [JsonProperty("eventDigestConfigJson")]
        public System.String? EventDigestConfigJson { get; set; }

        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        [JsonProperty("frequency")]
        public System.Int32? Frequency { get; set; }

        //      C# -> System.Boolean? IncludeAudits
        // GraphQL -> includeAudits: Boolean! (scalar)
        [JsonProperty("includeAudits")]
        public System.Boolean? IncludeAudits { get; set; }

        //      C# -> System.Boolean? IncludeEvents
        // GraphQL -> includeEvents: Boolean! (scalar)
        [JsonProperty("includeEvents")]
        public System.Boolean? IncludeEvents { get; set; }

        //      C# -> System.Boolean? IsImmediate
        // GraphQL -> isImmediate: Boolean! (scalar)
        [JsonProperty("isImmediate")]
        public System.Boolean? IsImmediate { get; set; }

        //      C# -> System.String? RecipientUserId
        // GraphQL -> recipientUserId: String! (scalar)
        [JsonProperty("recipientUserId")]
        public System.String? RecipientUserId { get; set; }


        #endregion

    #region methods

    public EventDigest Set(
        System.String? Account = null,
        List<System.String>? ClusterUuids = null,
        System.Int32? DigestId = null,
        System.String? DigestName = null,
        System.String? EventDigestConfigJson = null,
        System.Int32? Frequency = null,
        System.Boolean? IncludeAudits = null,
        System.Boolean? IncludeEvents = null,
        System.Boolean? IsImmediate = null,
        System.String? RecipientUserId = null
    ) 
    {
        if ( Account != null ) {
            this.Account = Account;
        }
        if ( ClusterUuids != null ) {
            this.ClusterUuids = ClusterUuids;
        }
        if ( DigestId != null ) {
            this.DigestId = DigestId;
        }
        if ( DigestName != null ) {
            this.DigestName = DigestName;
        }
        if ( EventDigestConfigJson != null ) {
            this.EventDigestConfigJson = EventDigestConfigJson;
        }
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( IncludeAudits != null ) {
            this.IncludeAudits = IncludeAudits;
        }
        if ( IncludeEvents != null ) {
            this.IncludeEvents = IncludeEvents;
        }
        if ( IsImmediate != null ) {
            this.IsImmediate = IsImmediate;
        }
        if ( RecipientUserId != null ) {
            this.RecipientUserId = RecipientUserId;
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
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (this.Account != null) {
            s += ind + "account\n" ;
        }
        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        if (this.ClusterUuids != null) {
            s += ind + "clusterUuids\n" ;
        }
        //      C# -> System.Int32? DigestId
        // GraphQL -> digestId: Int! (scalar)
        if (this.DigestId != null) {
            s += ind + "digestId\n" ;
        }
        //      C# -> System.String? DigestName
        // GraphQL -> digestName: String! (scalar)
        if (this.DigestName != null) {
            s += ind + "digestName\n" ;
        }
        //      C# -> System.String? EventDigestConfigJson
        // GraphQL -> eventDigestConfigJson: String! (scalar)
        if (this.EventDigestConfigJson != null) {
            s += ind + "eventDigestConfigJson\n" ;
        }
        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        if (this.Frequency != null) {
            s += ind + "frequency\n" ;
        }
        //      C# -> System.Boolean? IncludeAudits
        // GraphQL -> includeAudits: Boolean! (scalar)
        if (this.IncludeAudits != null) {
            s += ind + "includeAudits\n" ;
        }
        //      C# -> System.Boolean? IncludeEvents
        // GraphQL -> includeEvents: Boolean! (scalar)
        if (this.IncludeEvents != null) {
            s += ind + "includeEvents\n" ;
        }
        //      C# -> System.Boolean? IsImmediate
        // GraphQL -> isImmediate: Boolean! (scalar)
        if (this.IsImmediate != null) {
            s += ind + "isImmediate\n" ;
        }
        //      C# -> System.String? RecipientUserId
        // GraphQL -> recipientUserId: String! (scalar)
        if (this.RecipientUserId != null) {
            s += ind + "recipientUserId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Account
        // GraphQL -> account: String! (scalar)
        if (this.Account == null && Exploration.Includes(parent + ".account", true))
        {
            this.Account = new System.String("FETCH");
        }
        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        if (this.ClusterUuids == null && Exploration.Includes(parent + ".clusterUuids", true))
        {
            this.ClusterUuids = new List<System.String>();
        }
        //      C# -> System.Int32? DigestId
        // GraphQL -> digestId: Int! (scalar)
        if (this.DigestId == null && Exploration.Includes(parent + ".digestId", true))
        {
            this.DigestId = new System.Int32();
        }
        //      C# -> System.String? DigestName
        // GraphQL -> digestName: String! (scalar)
        if (this.DigestName == null && Exploration.Includes(parent + ".digestName", true))
        {
            this.DigestName = new System.String("FETCH");
        }
        //      C# -> System.String? EventDigestConfigJson
        // GraphQL -> eventDigestConfigJson: String! (scalar)
        if (this.EventDigestConfigJson == null && Exploration.Includes(parent + ".eventDigestConfigJson", true))
        {
            this.EventDigestConfigJson = new System.String("FETCH");
        }
        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        if (this.Frequency == null && Exploration.Includes(parent + ".frequency", true))
        {
            this.Frequency = new System.Int32();
        }
        //      C# -> System.Boolean? IncludeAudits
        // GraphQL -> includeAudits: Boolean! (scalar)
        if (this.IncludeAudits == null && Exploration.Includes(parent + ".includeAudits", true))
        {
            this.IncludeAudits = true;
        }
        //      C# -> System.Boolean? IncludeEvents
        // GraphQL -> includeEvents: Boolean! (scalar)
        if (this.IncludeEvents == null && Exploration.Includes(parent + ".includeEvents", true))
        {
            this.IncludeEvents = true;
        }
        //      C# -> System.Boolean? IsImmediate
        // GraphQL -> isImmediate: Boolean! (scalar)
        if (this.IsImmediate == null && Exploration.Includes(parent + ".isImmediate", true))
        {
            this.IsImmediate = true;
        }
        //      C# -> System.String? RecipientUserId
        // GraphQL -> recipientUserId: String! (scalar)
        if (this.RecipientUserId == null && Exploration.Includes(parent + ".recipientUserId", true))
        {
            this.RecipientUserId = new System.String("FETCH");
        }
    }


    #endregion

    } // class EventDigest
    
    #endregion

    public static class ListEventDigestExtensions
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
            this List<EventDigest> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<EventDigest> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new EventDigest());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types