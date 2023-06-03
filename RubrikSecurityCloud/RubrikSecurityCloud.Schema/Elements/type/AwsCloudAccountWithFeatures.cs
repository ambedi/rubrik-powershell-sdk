// AwsCloudAccountWithFeatures.cs
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
    #region AwsCloudAccountWithFeatures
    public class AwsCloudAccountWithFeatures: BaseType
    {
        #region members

        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount (type)
        [JsonProperty("awsCloudAccount")]
        public AwsCloudAccount? AwsCloudAccount { get; set; }

        //      C# -> List<FeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [FeatureDetail!]! (type)
        [JsonProperty("featureDetails")]
        public List<FeatureDetail>? FeatureDetails { get; set; }


        #endregion

    #region methods

    public AwsCloudAccountWithFeatures Set(
        AwsCloudAccount? AwsCloudAccount = null,
        List<FeatureDetail>? FeatureDetails = null
    ) 
    {
        if ( AwsCloudAccount != null ) {
            this.AwsCloudAccount = AwsCloudAccount;
        }
        if ( FeatureDetails != null ) {
            this.FeatureDetails = FeatureDetails;
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
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount (type)
        if (this.AwsCloudAccount != null) {
            s += ind + "awsCloudAccount {\n" + this.AwsCloudAccount.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<FeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [FeatureDetail!]! (type)
        if (this.FeatureDetails != null) {
            s += ind + "featureDetails {\n" + this.FeatureDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount (type)
        if (this.AwsCloudAccount == null && Exploration.Includes(parent + ".awsCloudAccount"))
        {
            this.AwsCloudAccount = new AwsCloudAccount();
            this.AwsCloudAccount.ApplyExploratoryFieldSpec(parent + ".awsCloudAccount");
        }
        //      C# -> List<FeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [FeatureDetail!]! (type)
        if (this.FeatureDetails == null && Exploration.Includes(parent + ".featureDetails"))
        {
            this.FeatureDetails = new List<FeatureDetail>();
            this.FeatureDetails.ApplyExploratoryFieldSpec(parent + ".featureDetails");
        }
    }


    #endregion

    } // class AwsCloudAccountWithFeatures
    
    #endregion

    public static class ListAwsCloudAccountWithFeaturesExtensions
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
            this List<AwsCloudAccountWithFeatures> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsCloudAccountWithFeatures> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCloudAccountWithFeatures());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types