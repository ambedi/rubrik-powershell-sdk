// PolarisSnapshotGroupByNew.cs
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
    #region PolarisSnapshotGroupByNew
    public class PolarisSnapshotGroupByNew: BaseType
    {
        #region members

        //      C# -> PolarisSnapshotConnection? PolarisSnapshotConnection
        // GraphQL -> polarisSnapshotConnection: PolarisSnapshotConnection! (type)
        [JsonProperty("polarisSnapshotConnection")]
        public PolarisSnapshotConnection? PolarisSnapshotConnection { get; set; }

        //      C# -> PolarisSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: PolarisSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public PolarisSnapshotGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public PolarisSnapshotGroupByNew Set(
        PolarisSnapshotConnection? PolarisSnapshotConnection = null,
        PolarisSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( PolarisSnapshotConnection != null ) {
            this.PolarisSnapshotConnection = PolarisSnapshotConnection;
        }
        if ( GroupByInfo != null ) {
            this.GroupByInfo = GroupByInfo;
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
        //      C# -> PolarisSnapshotConnection? PolarisSnapshotConnection
        // GraphQL -> polarisSnapshotConnection: PolarisSnapshotConnection! (type)
        if (this.PolarisSnapshotConnection != null) {
            s += ind + "polarisSnapshotConnection {\n" + this.PolarisSnapshotConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PolarisSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: PolarisSnapshotGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            s += ind + "groupByInfo {\n" + this.GroupByInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> PolarisSnapshotConnection? PolarisSnapshotConnection
        // GraphQL -> polarisSnapshotConnection: PolarisSnapshotConnection! (type)
        if (this.PolarisSnapshotConnection == null && Exploration.Includes(parent + ".polarisSnapshotConnection"))
        {
            this.PolarisSnapshotConnection = new PolarisSnapshotConnection();
            this.PolarisSnapshotConnection.ApplyExploratoryFieldSpec(parent + ".polarisSnapshotConnection");
        }
        //      C# -> PolarisSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: PolarisSnapshotGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<PolarisSnapshotGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
            this.GroupByInfo = (PolarisSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class PolarisSnapshotGroupByNew
    
    #endregion

    public static class ListPolarisSnapshotGroupByNewExtensions
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
            this List<PolarisSnapshotGroupByNew> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolarisSnapshotGroupByNew> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisSnapshotGroupByNew());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types