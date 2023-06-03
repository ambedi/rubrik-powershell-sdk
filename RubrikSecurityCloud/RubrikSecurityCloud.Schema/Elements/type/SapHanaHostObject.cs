// SapHanaHostObject.cs
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
    #region SapHanaHostObject
    public class SapHanaHostObject: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? HostType
        // GraphQL -> hostType: String! (scalar)
        [JsonProperty("hostType")]
        public System.String? HostType { get; set; }

        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        [JsonProperty("hostUuid")]
        public System.String? HostUuid { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost! (type)
        [JsonProperty("host")]
        public PhysicalHost? Host { get; set; }


        #endregion

    #region methods

    public SapHanaHostObject Set(
        System.String? ClusterUuid = null,
        System.String? HostName = null,
        System.String? HostType = null,
        System.String? HostUuid = null,
        System.String? Status = null,
        PhysicalHost? Host = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( HostType != null ) {
            this.HostType = HostType;
        }
        if ( HostUuid != null ) {
            this.HostUuid = HostUuid;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Host != null ) {
            this.Host = Host;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            s += ind + "hostName\n" ;
        }
        //      C# -> System.String? HostType
        // GraphQL -> hostType: String! (scalar)
        if (this.HostType != null) {
            s += ind + "hostType\n" ;
        }
        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        if (this.HostUuid != null) {
            s += ind + "hostUuid\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost! (type)
        if (this.Host != null) {
            s += ind + "host {\n" + this.Host.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = new System.String("FETCH");
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName == null && Exploration.Includes(parent + ".hostName", true))
        {
            this.HostName = new System.String("FETCH");
        }
        //      C# -> System.String? HostType
        // GraphQL -> hostType: String! (scalar)
        if (this.HostType == null && Exploration.Includes(parent + ".hostType", true))
        {
            this.HostType = new System.String("FETCH");
        }
        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        if (this.HostUuid == null && Exploration.Includes(parent + ".hostUuid", true))
        {
            this.HostUuid = new System.String("FETCH");
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new System.String("FETCH");
        }
        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost! (type)
        if (this.Host == null && Exploration.Includes(parent + ".host"))
        {
            this.Host = new PhysicalHost();
            this.Host.ApplyExploratoryFieldSpec(parent + ".host");
        }
    }


    #endregion

    } // class SapHanaHostObject
    
    #endregion

    public static class ListSapHanaHostObjectExtensions
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
            this List<SapHanaHostObject> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaHostObject> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaHostObject());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types