// UpdateProxyConfigReply.cs
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
    #region UpdateProxyConfigReply
    public class UpdateProxyConfigReply: BaseType
    {
        #region members

        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        [JsonProperty("host")]
        public System.String? Host { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> System.String? Protocol
        // GraphQL -> protocol: String! (scalar)
        [JsonProperty("protocol")]
        public System.String? Protocol { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }


        #endregion

    #region methods

    public UpdateProxyConfigReply Set(
        System.String? Host = null,
        System.Int32? Port = null,
        System.String? Protocol = null,
        System.String? Username = null
    ) 
    {
        if ( Host != null ) {
            this.Host = Host;
        }
        if ( Port != null ) {
            this.Port = Port;
        }
        if ( Protocol != null ) {
            this.Protocol = Protocol;
        }
        if ( Username != null ) {
            this.Username = Username;
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
        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        if (this.Host != null) {
            s += ind + "host\n" ;
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int (scalar)
        if (this.Port != null) {
            s += ind + "port\n" ;
        }
        //      C# -> System.String? Protocol
        // GraphQL -> protocol: String! (scalar)
        if (this.Protocol != null) {
            s += ind + "protocol\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        if (this.Host == null && Exploration.Includes(parent + ".host", true))
        {
            this.Host = new System.String("FETCH");
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int (scalar)
        if (this.Port == null && Exploration.Includes(parent + ".port", true))
        {
            this.Port = new System.Int32();
        }
        //      C# -> System.String? Protocol
        // GraphQL -> protocol: String! (scalar)
        if (this.Protocol == null && Exploration.Includes(parent + ".protocol", true))
        {
            this.Protocol = new System.String("FETCH");
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        if (this.Username == null && Exploration.Includes(parent + ".username", true))
        {
            this.Username = new System.String("FETCH");
        }
    }


    #endregion

    } // class UpdateProxyConfigReply
    
    #endregion

    public static class ListUpdateProxyConfigReplyExtensions
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
            this List<UpdateProxyConfigReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateProxyConfigReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateProxyConfigReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types