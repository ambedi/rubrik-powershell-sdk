// AzureSubscriptionWithExoConfigs.cs
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
    #region AzureSubscriptionWithExoConfigs
    public class AzureSubscriptionWithExoConfigs: BaseType
    {
        #region members

        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        [JsonProperty("azureSubscriptionNativeId")]
        public System.String? AzureSubscriptionNativeId { get; set; }

        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        [JsonProperty("azureSubscriptionRubrikId")]
        public System.String? AzureSubscriptionRubrikId { get; set; }

        //      C# -> List<System.String>? MappedCloudAccountIds
        // GraphQL -> mappedCloudAccountIds: [UUID!]! (scalar)
        [JsonProperty("mappedCloudAccountIds")]
        public List<System.String>? MappedCloudAccountIds { get; set; }

        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        [JsonProperty("subscriptionName")]
        public System.String? SubscriptionName { get; set; }

        //      C# -> List<AzureExocomputeConfigDetails>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        [JsonProperty("exocomputeConfigs")]
        public List<AzureExocomputeConfigDetails>? ExocomputeConfigs { get; set; }

        //      C# -> AzureCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: AzureCloudAccountFeatureDetail! (type)
        [JsonProperty("featureDetail")]
        public AzureCloudAccountFeatureDetail? FeatureDetail { get; set; }

        //      C# -> List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs
        // GraphQL -> mappedExocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        [JsonProperty("mappedExocomputeConfigs")]
        public List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs { get; set; }

        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        [JsonProperty("mappedExocomputeSubscription")]
        public AzureMappedExocomputeSubscription? MappedExocomputeSubscription { get; set; }


        #endregion

    #region methods

    public AzureSubscriptionWithExoConfigs Set(
        System.String? AzureSubscriptionNativeId = null,
        System.String? AzureSubscriptionRubrikId = null,
        List<System.String>? MappedCloudAccountIds = null,
        System.String? SubscriptionName = null,
        List<AzureExocomputeConfigDetails>? ExocomputeConfigs = null,
        AzureCloudAccountFeatureDetail? FeatureDetail = null,
        List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs = null,
        AzureMappedExocomputeSubscription? MappedExocomputeSubscription = null
    ) 
    {
        if ( AzureSubscriptionNativeId != null ) {
            this.AzureSubscriptionNativeId = AzureSubscriptionNativeId;
        }
        if ( AzureSubscriptionRubrikId != null ) {
            this.AzureSubscriptionRubrikId = AzureSubscriptionRubrikId;
        }
        if ( MappedCloudAccountIds != null ) {
            this.MappedCloudAccountIds = MappedCloudAccountIds;
        }
        if ( SubscriptionName != null ) {
            this.SubscriptionName = SubscriptionName;
        }
        if ( ExocomputeConfigs != null ) {
            this.ExocomputeConfigs = ExocomputeConfigs;
        }
        if ( FeatureDetail != null ) {
            this.FeatureDetail = FeatureDetail;
        }
        if ( MappedExocomputeConfigs != null ) {
            this.MappedExocomputeConfigs = MappedExocomputeConfigs;
        }
        if ( MappedExocomputeSubscription != null ) {
            this.MappedExocomputeSubscription = MappedExocomputeSubscription;
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
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (this.AzureSubscriptionNativeId != null) {
            s += ind + "azureSubscriptionNativeId\n" ;
        }
        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        if (this.AzureSubscriptionRubrikId != null) {
            s += ind + "azureSubscriptionRubrikId\n" ;
        }
        //      C# -> List<System.String>? MappedCloudAccountIds
        // GraphQL -> mappedCloudAccountIds: [UUID!]! (scalar)
        if (this.MappedCloudAccountIds != null) {
            s += ind + "mappedCloudAccountIds\n" ;
        }
        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        if (this.SubscriptionName != null) {
            s += ind + "subscriptionName\n" ;
        }
        //      C# -> List<AzureExocomputeConfigDetails>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        if (this.ExocomputeConfigs != null) {
            s += ind + "exocomputeConfigs {\n" + this.ExocomputeConfigs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> AzureCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: AzureCloudAccountFeatureDetail! (type)
        if (this.FeatureDetail != null) {
            s += ind + "featureDetail {\n" + this.FeatureDetail.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs
        // GraphQL -> mappedExocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        if (this.MappedExocomputeConfigs != null) {
            s += ind + "mappedExocomputeConfigs {\n" + this.MappedExocomputeConfigs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        if (this.MappedExocomputeSubscription != null) {
            s += ind + "mappedExocomputeSubscription {\n" + this.MappedExocomputeSubscription.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (this.AzureSubscriptionNativeId == null && Exploration.Includes(parent + ".azureSubscriptionNativeId", true))
        {
            this.AzureSubscriptionNativeId = new System.String("FETCH");
        }
        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        if (this.AzureSubscriptionRubrikId == null && Exploration.Includes(parent + ".azureSubscriptionRubrikId", true))
        {
            this.AzureSubscriptionRubrikId = new System.String("FETCH");
        }
        //      C# -> List<System.String>? MappedCloudAccountIds
        // GraphQL -> mappedCloudAccountIds: [UUID!]! (scalar)
        if (this.MappedCloudAccountIds == null && Exploration.Includes(parent + ".mappedCloudAccountIds", true))
        {
            this.MappedCloudAccountIds = new List<System.String>();
        }
        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        if (this.SubscriptionName == null && Exploration.Includes(parent + ".subscriptionName", true))
        {
            this.SubscriptionName = new System.String("FETCH");
        }
        //      C# -> List<AzureExocomputeConfigDetails>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        if (this.ExocomputeConfigs == null && Exploration.Includes(parent + ".exocomputeConfigs"))
        {
            this.ExocomputeConfigs = new List<AzureExocomputeConfigDetails>();
            this.ExocomputeConfigs.ApplyExploratoryFieldSpec(parent + ".exocomputeConfigs");
        }
        //      C# -> AzureCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: AzureCloudAccountFeatureDetail! (type)
        if (this.FeatureDetail == null && Exploration.Includes(parent + ".featureDetail"))
        {
            this.FeatureDetail = new AzureCloudAccountFeatureDetail();
            this.FeatureDetail.ApplyExploratoryFieldSpec(parent + ".featureDetail");
        }
        //      C# -> List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs
        // GraphQL -> mappedExocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        if (this.MappedExocomputeConfigs == null && Exploration.Includes(parent + ".mappedExocomputeConfigs"))
        {
            this.MappedExocomputeConfigs = new List<AzureExocomputeConfigDetails>();
            this.MappedExocomputeConfigs.ApplyExploratoryFieldSpec(parent + ".mappedExocomputeConfigs");
        }
        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        if (this.MappedExocomputeSubscription == null && Exploration.Includes(parent + ".mappedExocomputeSubscription"))
        {
            this.MappedExocomputeSubscription = new AzureMappedExocomputeSubscription();
            this.MappedExocomputeSubscription.ApplyExploratoryFieldSpec(parent + ".mappedExocomputeSubscription");
        }
    }


    #endregion

    } // class AzureSubscriptionWithExoConfigs
    
    #endregion

    public static class ListAzureSubscriptionWithExoConfigsExtensions
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
            this List<AzureSubscriptionWithExoConfigs> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureSubscriptionWithExoConfigs> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureSubscriptionWithExoConfigs());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types