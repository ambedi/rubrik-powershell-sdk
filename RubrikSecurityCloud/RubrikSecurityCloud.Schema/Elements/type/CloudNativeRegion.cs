// CloudNativeRegion.cs
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
    #region CloudNativeRegion
    public class CloudNativeRegion: BaseType
    {
        #region members

        //      C# -> AwsNativeRegion? AwsRegion
        // GraphQL -> awsRegion: AwsNativeRegion (enum)
        [JsonProperty("awsRegion")]
        public AwsNativeRegion? AwsRegion { get; set; }

        //      C# -> AzureNativeRegion? AzureRegion
        // GraphQL -> azureRegion: AzureNativeRegion (enum)
        [JsonProperty("azureRegion")]
        public AzureNativeRegion? AzureRegion { get; set; }

        //      C# -> GcpNativeRegion? GcpRegion
        // GraphQL -> gcpRegion: GcpNativeRegion (type)
        [JsonProperty("gcpRegion")]
        public GcpNativeRegion? GcpRegion { get; set; }


        #endregion

    #region methods

    public CloudNativeRegion Set(
        AwsNativeRegion? AwsRegion = null,
        AzureNativeRegion? AzureRegion = null,
        GcpNativeRegion? GcpRegion = null
    ) 
    {
        if ( AwsRegion != null ) {
            this.AwsRegion = AwsRegion;
        }
        if ( AzureRegion != null ) {
            this.AzureRegion = AzureRegion;
        }
        if ( GcpRegion != null ) {
            this.GcpRegion = GcpRegion;
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
        //      C# -> AwsNativeRegion? AwsRegion
        // GraphQL -> awsRegion: AwsNativeRegion (enum)
        if (this.AwsRegion != null) {
            s += ind + "awsRegion\n" ;
        }
        //      C# -> AzureNativeRegion? AzureRegion
        // GraphQL -> azureRegion: AzureNativeRegion (enum)
        if (this.AzureRegion != null) {
            s += ind + "azureRegion\n" ;
        }
        //      C# -> GcpNativeRegion? GcpRegion
        // GraphQL -> gcpRegion: GcpNativeRegion (type)
        if (this.GcpRegion != null) {
            s += ind + "gcpRegion {\n" + this.GcpRegion.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AwsNativeRegion? AwsRegion
        // GraphQL -> awsRegion: AwsNativeRegion (enum)
        if (this.AwsRegion == null && Exploration.Includes(parent + ".awsRegion", true))
        {
            this.AwsRegion = new AwsNativeRegion();
        }
        //      C# -> AzureNativeRegion? AzureRegion
        // GraphQL -> azureRegion: AzureNativeRegion (enum)
        if (this.AzureRegion == null && Exploration.Includes(parent + ".azureRegion", true))
        {
            this.AzureRegion = new AzureNativeRegion();
        }
        //      C# -> GcpNativeRegion? GcpRegion
        // GraphQL -> gcpRegion: GcpNativeRegion (type)
        if (this.GcpRegion == null && Exploration.Includes(parent + ".gcpRegion"))
        {
            this.GcpRegion = new GcpNativeRegion();
            this.GcpRegion.ApplyExploratoryFieldSpec(parent + ".gcpRegion");
        }
    }


    #endregion

    } // class CloudNativeRegion
    
    #endregion

    public static class ListCloudNativeRegionExtensions
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
            this List<CloudNativeRegion> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeRegion> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeRegion());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types