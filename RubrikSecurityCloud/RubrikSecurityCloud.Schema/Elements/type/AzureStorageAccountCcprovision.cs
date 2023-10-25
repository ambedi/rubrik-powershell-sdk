// AzureStorageAccountCcprovision.cs
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region AzureStorageAccountCcprovision
    public class AzureStorageAccountCcprovision: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        [JsonProperty("resourceGroup")]
        public System.String? ResourceGroup { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureStorageAccountCcprovision";
    }

    public AzureStorageAccountCcprovision Set(
        System.String? Name = null,
        System.String? ResourceGroup = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ResourceGroup != null ) {
            this.ResourceGroup = ResourceGroup;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        if (this.ResourceGroup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceGroup\n" ;
            } else {
                s += ind + "resourceGroup\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        if (ec.Includes("resourceGroup",true))
        {
            if(this.ResourceGroup == null) {

                this.ResourceGroup = "FETCH";

            } else {


            }
        }
        else if (this.ResourceGroup != null && ec.Excludes("resourceGroup",true))
        {
            this.ResourceGroup = null;
        }
    }


    #endregion

    } // class AzureStorageAccountCcprovision
    
    #endregion

    public static class ListAzureStorageAccountCcprovisionExtensions
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
            this List<AzureStorageAccountCcprovision> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AzureStorageAccountCcprovision> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureStorageAccountCcprovision> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureStorageAccountCcprovision());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureStorageAccountCcprovision> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types