// K8sRbsInfo.cs
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
    #region K8sRbsInfo
    public class K8sRbsInfo: BaseType
    {
        #region members

        //      C# -> System.String? KuprClusterUuid
        // GraphQL -> kuprClusterUuid: UUID! (scalar)
        [JsonProperty("kuprClusterUuid")]
        public System.String? KuprClusterUuid { get; set; }

        //      C# -> System.Int32? MaxPort
        // GraphQL -> maxPort: Int! (scalar)
        [JsonProperty("maxPort")]
        public System.Int32? MaxPort { get; set; }

        //      C# -> System.Int32? MinPort
        // GraphQL -> minPort: Int! (scalar)
        [JsonProperty("minPort")]
        public System.Int32? MinPort { get; set; }


        #endregion

    #region methods

    public K8sRbsInfo Set(
        System.String? KuprClusterUuid = null,
        System.Int32? MaxPort = null,
        System.Int32? MinPort = null
    ) 
    {
        if ( KuprClusterUuid != null ) {
            this.KuprClusterUuid = KuprClusterUuid;
        }
        if ( MaxPort != null ) {
            this.MaxPort = MaxPort;
        }
        if ( MinPort != null ) {
            this.MinPort = MinPort;
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
        //      C# -> System.String? KuprClusterUuid
        // GraphQL -> kuprClusterUuid: UUID! (scalar)
        if (this.KuprClusterUuid != null) {
            s += ind + "kuprClusterUuid\n" ;
        }
        //      C# -> System.Int32? MaxPort
        // GraphQL -> maxPort: Int! (scalar)
        if (this.MaxPort != null) {
            s += ind + "maxPort\n" ;
        }
        //      C# -> System.Int32? MinPort
        // GraphQL -> minPort: Int! (scalar)
        if (this.MinPort != null) {
            s += ind + "minPort\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? KuprClusterUuid
        // GraphQL -> kuprClusterUuid: UUID! (scalar)
        if (this.KuprClusterUuid == null && Exploration.Includes(parent + ".kuprClusterUuid", true))
        {
            this.KuprClusterUuid = new System.String("FETCH");
        }
        //      C# -> System.Int32? MaxPort
        // GraphQL -> maxPort: Int! (scalar)
        if (this.MaxPort == null && Exploration.Includes(parent + ".maxPort", true))
        {
            this.MaxPort = new System.Int32();
        }
        //      C# -> System.Int32? MinPort
        // GraphQL -> minPort: Int! (scalar)
        if (this.MinPort == null && Exploration.Includes(parent + ".minPort", true))
        {
            this.MinPort = new System.Int32();
        }
    }


    #endregion

    } // class K8sRbsInfo
    
    #endregion

    public static class ListK8sRbsInfoExtensions
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
            this List<K8sRbsInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<K8sRbsInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sRbsInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types