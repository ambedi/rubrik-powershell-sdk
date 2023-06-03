// MongodbSslOptions.cs
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
    #region MongodbSslOptions
    public class MongodbSslOptions: BaseType
    {
        #region members

        //      C# -> SourceSslCertReqs? SslCertRequirements
        // GraphQL -> sslCertRequirements: SourceSslCertReqs! (enum)
        [JsonProperty("sslCertRequirements")]
        public SourceSslCertReqs? SslCertRequirements { get; set; }

        //      C# -> System.Boolean? Ssl
        // GraphQL -> ssl: Boolean! (scalar)
        [JsonProperty("ssl")]
        public System.Boolean? Ssl { get; set; }

        //      C# -> System.String? SslCaCerts
        // GraphQL -> sslCaCerts: String! (scalar)
        [JsonProperty("sslCaCerts")]
        public System.String? SslCaCerts { get; set; }

        //      C# -> System.String? SslCertfile
        // GraphQL -> sslCertfile: String! (scalar)
        [JsonProperty("sslCertfile")]
        public System.String? SslCertfile { get; set; }

        //      C# -> System.String? SslKeyfile
        // GraphQL -> sslKeyfile: String! (scalar)
        [JsonProperty("sslKeyfile")]
        public System.String? SslKeyfile { get; set; }


        #endregion

    #region methods

    public MongodbSslOptions Set(
        SourceSslCertReqs? SslCertRequirements = null,
        System.Boolean? Ssl = null,
        System.String? SslCaCerts = null,
        System.String? SslCertfile = null,
        System.String? SslKeyfile = null
    ) 
    {
        if ( SslCertRequirements != null ) {
            this.SslCertRequirements = SslCertRequirements;
        }
        if ( Ssl != null ) {
            this.Ssl = Ssl;
        }
        if ( SslCaCerts != null ) {
            this.SslCaCerts = SslCaCerts;
        }
        if ( SslCertfile != null ) {
            this.SslCertfile = SslCertfile;
        }
        if ( SslKeyfile != null ) {
            this.SslKeyfile = SslKeyfile;
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
        //      C# -> SourceSslCertReqs? SslCertRequirements
        // GraphQL -> sslCertRequirements: SourceSslCertReqs! (enum)
        if (this.SslCertRequirements != null) {
            s += ind + "sslCertRequirements\n" ;
        }
        //      C# -> System.Boolean? Ssl
        // GraphQL -> ssl: Boolean! (scalar)
        if (this.Ssl != null) {
            s += ind + "ssl\n" ;
        }
        //      C# -> System.String? SslCaCerts
        // GraphQL -> sslCaCerts: String! (scalar)
        if (this.SslCaCerts != null) {
            s += ind + "sslCaCerts\n" ;
        }
        //      C# -> System.String? SslCertfile
        // GraphQL -> sslCertfile: String! (scalar)
        if (this.SslCertfile != null) {
            s += ind + "sslCertfile\n" ;
        }
        //      C# -> System.String? SslKeyfile
        // GraphQL -> sslKeyfile: String! (scalar)
        if (this.SslKeyfile != null) {
            s += ind + "sslKeyfile\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SourceSslCertReqs? SslCertRequirements
        // GraphQL -> sslCertRequirements: SourceSslCertReqs! (enum)
        if (this.SslCertRequirements == null && Exploration.Includes(parent + ".sslCertRequirements", true))
        {
            this.SslCertRequirements = new SourceSslCertReqs();
        }
        //      C# -> System.Boolean? Ssl
        // GraphQL -> ssl: Boolean! (scalar)
        if (this.Ssl == null && Exploration.Includes(parent + ".ssl", true))
        {
            this.Ssl = true;
        }
        //      C# -> System.String? SslCaCerts
        // GraphQL -> sslCaCerts: String! (scalar)
        if (this.SslCaCerts == null && Exploration.Includes(parent + ".sslCaCerts", true))
        {
            this.SslCaCerts = new System.String("FETCH");
        }
        //      C# -> System.String? SslCertfile
        // GraphQL -> sslCertfile: String! (scalar)
        if (this.SslCertfile == null && Exploration.Includes(parent + ".sslCertfile", true))
        {
            this.SslCertfile = new System.String("FETCH");
        }
        //      C# -> System.String? SslKeyfile
        // GraphQL -> sslKeyfile: String! (scalar)
        if (this.SslKeyfile == null && Exploration.Includes(parent + ".sslKeyfile", true))
        {
            this.SslKeyfile = new System.String("FETCH");
        }
    }


    #endregion

    } // class MongodbSslOptions
    
    #endregion

    public static class ListMongodbSslOptionsExtensions
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
            this List<MongodbSslOptions> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MongodbSslOptions> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MongodbSslOptions());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types