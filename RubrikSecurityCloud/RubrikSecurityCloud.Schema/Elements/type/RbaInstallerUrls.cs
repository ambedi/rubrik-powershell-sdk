// RbaInstallerUrls.cs
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
    #region RbaInstallerUrls
    public class RbaInstallerUrls: BaseType
    {
        #region members

        //      C# -> System.String? DebianHashSha256
        // GraphQL -> debianHashSha256: String! (scalar)
        [JsonProperty("debianHashSha256")]
        public System.String? DebianHashSha256 { get; set; }

        //      C# -> System.String? DebianUrl
        // GraphQL -> debianUrl: String! (scalar)
        [JsonProperty("debianUrl")]
        public System.String? DebianUrl { get; set; }

        //      C# -> System.String? RpmHashSha256
        // GraphQL -> rpmHashSha256: String! (scalar)
        [JsonProperty("rpmHashSha256")]
        public System.String? RpmHashSha256 { get; set; }

        //      C# -> System.String? RpmUrl
        // GraphQL -> rpmUrl: String! (scalar)
        [JsonProperty("rpmUrl")]
        public System.String? RpmUrl { get; set; }

        //      C# -> System.String? WindowsHashSha256
        // GraphQL -> windowsHashSha256: String! (scalar)
        [JsonProperty("windowsHashSha256")]
        public System.String? WindowsHashSha256 { get; set; }

        //      C# -> System.String? WindowsUrl
        // GraphQL -> windowsUrl: String! (scalar)
        [JsonProperty("windowsUrl")]
        public System.String? WindowsUrl { get; set; }


        #endregion

    #region methods

    public RbaInstallerUrls Set(
        System.String? DebianHashSha256 = null,
        System.String? DebianUrl = null,
        System.String? RpmHashSha256 = null,
        System.String? RpmUrl = null,
        System.String? WindowsHashSha256 = null,
        System.String? WindowsUrl = null
    ) 
    {
        if ( DebianHashSha256 != null ) {
            this.DebianHashSha256 = DebianHashSha256;
        }
        if ( DebianUrl != null ) {
            this.DebianUrl = DebianUrl;
        }
        if ( RpmHashSha256 != null ) {
            this.RpmHashSha256 = RpmHashSha256;
        }
        if ( RpmUrl != null ) {
            this.RpmUrl = RpmUrl;
        }
        if ( WindowsHashSha256 != null ) {
            this.WindowsHashSha256 = WindowsHashSha256;
        }
        if ( WindowsUrl != null ) {
            this.WindowsUrl = WindowsUrl;
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
        //      C# -> System.String? DebianHashSha256
        // GraphQL -> debianHashSha256: String! (scalar)
        if (this.DebianHashSha256 != null) {
            s += ind + "debianHashSha256\n" ;
        }
        //      C# -> System.String? DebianUrl
        // GraphQL -> debianUrl: String! (scalar)
        if (this.DebianUrl != null) {
            s += ind + "debianUrl\n" ;
        }
        //      C# -> System.String? RpmHashSha256
        // GraphQL -> rpmHashSha256: String! (scalar)
        if (this.RpmHashSha256 != null) {
            s += ind + "rpmHashSha256\n" ;
        }
        //      C# -> System.String? RpmUrl
        // GraphQL -> rpmUrl: String! (scalar)
        if (this.RpmUrl != null) {
            s += ind + "rpmUrl\n" ;
        }
        //      C# -> System.String? WindowsHashSha256
        // GraphQL -> windowsHashSha256: String! (scalar)
        if (this.WindowsHashSha256 != null) {
            s += ind + "windowsHashSha256\n" ;
        }
        //      C# -> System.String? WindowsUrl
        // GraphQL -> windowsUrl: String! (scalar)
        if (this.WindowsUrl != null) {
            s += ind + "windowsUrl\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? DebianHashSha256
        // GraphQL -> debianHashSha256: String! (scalar)
        if (this.DebianHashSha256 == null && Exploration.Includes(parent + ".debianHashSha256", true))
        {
            this.DebianHashSha256 = new System.String("FETCH");
        }
        //      C# -> System.String? DebianUrl
        // GraphQL -> debianUrl: String! (scalar)
        if (this.DebianUrl == null && Exploration.Includes(parent + ".debianUrl", true))
        {
            this.DebianUrl = new System.String("FETCH");
        }
        //      C# -> System.String? RpmHashSha256
        // GraphQL -> rpmHashSha256: String! (scalar)
        if (this.RpmHashSha256 == null && Exploration.Includes(parent + ".rpmHashSha256", true))
        {
            this.RpmHashSha256 = new System.String("FETCH");
        }
        //      C# -> System.String? RpmUrl
        // GraphQL -> rpmUrl: String! (scalar)
        if (this.RpmUrl == null && Exploration.Includes(parent + ".rpmUrl", true))
        {
            this.RpmUrl = new System.String("FETCH");
        }
        //      C# -> System.String? WindowsHashSha256
        // GraphQL -> windowsHashSha256: String! (scalar)
        if (this.WindowsHashSha256 == null && Exploration.Includes(parent + ".windowsHashSha256", true))
        {
            this.WindowsHashSha256 = new System.String("FETCH");
        }
        //      C# -> System.String? WindowsUrl
        // GraphQL -> windowsUrl: String! (scalar)
        if (this.WindowsUrl == null && Exploration.Includes(parent + ".windowsUrl", true))
        {
            this.WindowsUrl = new System.String("FETCH");
        }
    }


    #endregion

    } // class RbaInstallerUrls
    
    #endregion

    public static class ListRbaInstallerUrlsExtensions
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
            this List<RbaInstallerUrls> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RbaInstallerUrls> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RbaInstallerUrls());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types