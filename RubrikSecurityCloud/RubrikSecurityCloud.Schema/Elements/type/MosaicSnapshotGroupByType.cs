// MosaicSnapshotGroupByType.cs
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
    #region MosaicSnapshotGroupByType
    public class MosaicSnapshotGroupByType: BaseType
    {
        #region members

        //      C# -> List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys
        // GraphQL -> allSnapshotGroupBys: [MosaicSnapshotGroupByType!]! (type)
        [JsonProperty("allSnapshotGroupBys")]
        public List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys { get; set; }

        //      C# -> MosaicSnapshotConnection? Snapshots
        // GraphQL -> snapshots: MosaicSnapshotConnection! (type)
        [JsonProperty("snapshots")]
        public MosaicSnapshotConnection? Snapshots { get; set; }

        //      C# -> MosaicSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MosaicSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public MosaicSnapshotGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public MosaicSnapshotGroupByType Set(
        List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys = null,
        MosaicSnapshotConnection? Snapshots = null,
        MosaicSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( AllSnapshotGroupBys != null ) {
            this.AllSnapshotGroupBys = AllSnapshotGroupBys;
        }
        if ( Snapshots != null ) {
            this.Snapshots = Snapshots;
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
        //      C# -> List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys
        // GraphQL -> allSnapshotGroupBys: [MosaicSnapshotGroupByType!]! (type)
        if (this.AllSnapshotGroupBys != null) {
            s += ind + "allSnapshotGroupBys {\n" + this.AllSnapshotGroupBys.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> MosaicSnapshotConnection? Snapshots
        // GraphQL -> snapshots: MosaicSnapshotConnection! (type)
        if (this.Snapshots != null) {
            s += ind + "snapshots {\n" + this.Snapshots.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> MosaicSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MosaicSnapshotGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            s += ind + "groupByInfo {\n" + this.GroupByInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys
        // GraphQL -> allSnapshotGroupBys: [MosaicSnapshotGroupByType!]! (type)
        if (this.AllSnapshotGroupBys == null && Exploration.Includes(parent + ".allSnapshotGroupBys"))
        {
            this.AllSnapshotGroupBys = new List<MosaicSnapshotGroupByType>();
            this.AllSnapshotGroupBys.ApplyExploratoryFieldSpec(parent + ".allSnapshotGroupBys");
        }
        //      C# -> MosaicSnapshotConnection? Snapshots
        // GraphQL -> snapshots: MosaicSnapshotConnection! (type)
        if (this.Snapshots == null && Exploration.Includes(parent + ".snapshots"))
        {
            this.Snapshots = new MosaicSnapshotConnection();
            this.Snapshots.ApplyExploratoryFieldSpec(parent + ".snapshots");
        }
        //      C# -> MosaicSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MosaicSnapshotGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<MosaicSnapshotGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
            this.GroupByInfo = (MosaicSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class MosaicSnapshotGroupByType
    
    #endregion

    public static class ListMosaicSnapshotGroupByTypeExtensions
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
            this List<MosaicSnapshotGroupByType> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MosaicSnapshotGroupByType> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicSnapshotGroupByType());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types