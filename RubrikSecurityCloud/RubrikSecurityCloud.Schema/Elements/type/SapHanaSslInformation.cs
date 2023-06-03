// SapHanaSslInformation.cs
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
    #region SapHanaSslInformation
    public class SapHanaSslInformation: BaseType
    {
        #region members

        //      C# -> SapHanaEncryptionProvider? EncryptionProvider
        // GraphQL -> encryptionProvider: SapHanaEncryptionProvider! (enum)
        [JsonProperty("encryptionProvider")]
        public SapHanaEncryptionProvider? EncryptionProvider { get; set; }

        //      C# -> System.String? CryptoLibPath
        // GraphQL -> cryptoLibPath: String! (scalar)
        [JsonProperty("cryptoLibPath")]
        public System.String? CryptoLibPath { get; set; }

        //      C# -> System.String? HostNameInCertificate
        // GraphQL -> hostNameInCertificate: String! (scalar)
        [JsonProperty("hostNameInCertificate")]
        public System.String? HostNameInCertificate { get; set; }

        //      C# -> System.String? KeyStorePath
        // GraphQL -> keyStorePath: String! (scalar)
        [JsonProperty("keyStorePath")]
        public System.String? KeyStorePath { get; set; }

        //      C# -> System.Boolean? ShouldEncrypt
        // GraphQL -> shouldEncrypt: Boolean! (scalar)
        [JsonProperty("shouldEncrypt")]
        public System.Boolean? ShouldEncrypt { get; set; }

        //      C# -> System.Boolean? ShouldValidateCertificate
        // GraphQL -> shouldValidateCertificate: Boolean! (scalar)
        [JsonProperty("shouldValidateCertificate")]
        public System.Boolean? ShouldValidateCertificate { get; set; }

        //      C# -> System.String? TrustStorePath
        // GraphQL -> trustStorePath: String! (scalar)
        [JsonProperty("trustStorePath")]
        public System.String? TrustStorePath { get; set; }


        #endregion

    #region methods

    public SapHanaSslInformation Set(
        SapHanaEncryptionProvider? EncryptionProvider = null,
        System.String? CryptoLibPath = null,
        System.String? HostNameInCertificate = null,
        System.String? KeyStorePath = null,
        System.Boolean? ShouldEncrypt = null,
        System.Boolean? ShouldValidateCertificate = null,
        System.String? TrustStorePath = null
    ) 
    {
        if ( EncryptionProvider != null ) {
            this.EncryptionProvider = EncryptionProvider;
        }
        if ( CryptoLibPath != null ) {
            this.CryptoLibPath = CryptoLibPath;
        }
        if ( HostNameInCertificate != null ) {
            this.HostNameInCertificate = HostNameInCertificate;
        }
        if ( KeyStorePath != null ) {
            this.KeyStorePath = KeyStorePath;
        }
        if ( ShouldEncrypt != null ) {
            this.ShouldEncrypt = ShouldEncrypt;
        }
        if ( ShouldValidateCertificate != null ) {
            this.ShouldValidateCertificate = ShouldValidateCertificate;
        }
        if ( TrustStorePath != null ) {
            this.TrustStorePath = TrustStorePath;
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
        //      C# -> SapHanaEncryptionProvider? EncryptionProvider
        // GraphQL -> encryptionProvider: SapHanaEncryptionProvider! (enum)
        if (this.EncryptionProvider != null) {
            s += ind + "encryptionProvider\n" ;
        }
        //      C# -> System.String? CryptoLibPath
        // GraphQL -> cryptoLibPath: String! (scalar)
        if (this.CryptoLibPath != null) {
            s += ind + "cryptoLibPath\n" ;
        }
        //      C# -> System.String? HostNameInCertificate
        // GraphQL -> hostNameInCertificate: String! (scalar)
        if (this.HostNameInCertificate != null) {
            s += ind + "hostNameInCertificate\n" ;
        }
        //      C# -> System.String? KeyStorePath
        // GraphQL -> keyStorePath: String! (scalar)
        if (this.KeyStorePath != null) {
            s += ind + "keyStorePath\n" ;
        }
        //      C# -> System.Boolean? ShouldEncrypt
        // GraphQL -> shouldEncrypt: Boolean! (scalar)
        if (this.ShouldEncrypt != null) {
            s += ind + "shouldEncrypt\n" ;
        }
        //      C# -> System.Boolean? ShouldValidateCertificate
        // GraphQL -> shouldValidateCertificate: Boolean! (scalar)
        if (this.ShouldValidateCertificate != null) {
            s += ind + "shouldValidateCertificate\n" ;
        }
        //      C# -> System.String? TrustStorePath
        // GraphQL -> trustStorePath: String! (scalar)
        if (this.TrustStorePath != null) {
            s += ind + "trustStorePath\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SapHanaEncryptionProvider? EncryptionProvider
        // GraphQL -> encryptionProvider: SapHanaEncryptionProvider! (enum)
        if (this.EncryptionProvider == null && Exploration.Includes(parent + ".encryptionProvider", true))
        {
            this.EncryptionProvider = new SapHanaEncryptionProvider();
        }
        //      C# -> System.String? CryptoLibPath
        // GraphQL -> cryptoLibPath: String! (scalar)
        if (this.CryptoLibPath == null && Exploration.Includes(parent + ".cryptoLibPath", true))
        {
            this.CryptoLibPath = new System.String("FETCH");
        }
        //      C# -> System.String? HostNameInCertificate
        // GraphQL -> hostNameInCertificate: String! (scalar)
        if (this.HostNameInCertificate == null && Exploration.Includes(parent + ".hostNameInCertificate", true))
        {
            this.HostNameInCertificate = new System.String("FETCH");
        }
        //      C# -> System.String? KeyStorePath
        // GraphQL -> keyStorePath: String! (scalar)
        if (this.KeyStorePath == null && Exploration.Includes(parent + ".keyStorePath", true))
        {
            this.KeyStorePath = new System.String("FETCH");
        }
        //      C# -> System.Boolean? ShouldEncrypt
        // GraphQL -> shouldEncrypt: Boolean! (scalar)
        if (this.ShouldEncrypt == null && Exploration.Includes(parent + ".shouldEncrypt", true))
        {
            this.ShouldEncrypt = true;
        }
        //      C# -> System.Boolean? ShouldValidateCertificate
        // GraphQL -> shouldValidateCertificate: Boolean! (scalar)
        if (this.ShouldValidateCertificate == null && Exploration.Includes(parent + ".shouldValidateCertificate", true))
        {
            this.ShouldValidateCertificate = true;
        }
        //      C# -> System.String? TrustStorePath
        // GraphQL -> trustStorePath: String! (scalar)
        if (this.TrustStorePath == null && Exploration.Includes(parent + ".trustStorePath", true))
        {
            this.TrustStorePath = new System.String("FETCH");
        }
    }


    #endregion

    } // class SapHanaSslInformation
    
    #endregion

    public static class ListSapHanaSslInformationExtensions
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
            this List<SapHanaSslInformation> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaSslInformation> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaSslInformation());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types