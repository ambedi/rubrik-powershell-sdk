// CdmInventorySubHierarchyRoot.cs
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
    #region CdmInventorySubHierarchyRoot
    public class CdmInventorySubHierarchyRoot: BaseType
    {
        #region members

        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        [JsonProperty("rootEnum")]
        public InventorySubHierarchyRootEnum? RootEnum { get; set; }

        //      C# -> CdmHierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: CdmHierarchyObjectConnection! (type)
        [JsonProperty("childConnection")]
        public CdmHierarchyObjectConnection? ChildConnection { get; set; }

        //      C# -> CdmHierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: CdmHierarchyObjectConnection! (type)
        [JsonProperty("descendantConnection")]
        public CdmHierarchyObjectConnection? DescendantConnection { get; set; }

        //      C# -> CdmHierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: CdmHierarchyObjectConnection! (type)
        [JsonProperty("topLevelDescendantConnection")]
        public CdmHierarchyObjectConnection? TopLevelDescendantConnection { get; set; }


        #endregion

    #region methods

    public CdmInventorySubHierarchyRoot Set(
        InventorySubHierarchyRootEnum? RootEnum = null,
        CdmHierarchyObjectConnection? ChildConnection = null,
        CdmHierarchyObjectConnection? DescendantConnection = null,
        CdmHierarchyObjectConnection? TopLevelDescendantConnection = null
    ) 
    {
        if ( RootEnum != null ) {
            this.RootEnum = RootEnum;
        }
        if ( ChildConnection != null ) {
            this.ChildConnection = ChildConnection;
        }
        if ( DescendantConnection != null ) {
            this.DescendantConnection = DescendantConnection;
        }
        if ( TopLevelDescendantConnection != null ) {
            this.TopLevelDescendantConnection = TopLevelDescendantConnection;
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
        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        if (this.RootEnum != null) {
            s += ind + "rootEnum\n" ;
        }
        //      C# -> CdmHierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: CdmHierarchyObjectConnection! (type)
        if (this.ChildConnection != null) {
            s += ind + "childConnection {\n" + this.ChildConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmHierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: CdmHierarchyObjectConnection! (type)
        if (this.DescendantConnection != null) {
            s += ind + "descendantConnection {\n" + this.DescendantConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmHierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: CdmHierarchyObjectConnection! (type)
        if (this.TopLevelDescendantConnection != null) {
            s += ind + "topLevelDescendantConnection {\n" + this.TopLevelDescendantConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        if (this.RootEnum == null && Exploration.Includes(parent + ".rootEnum", true))
        {
            this.RootEnum = new InventorySubHierarchyRootEnum();
        }
        //      C# -> CdmHierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: CdmHierarchyObjectConnection! (type)
        if (this.ChildConnection == null && Exploration.Includes(parent + ".childConnection"))
        {
            this.ChildConnection = new CdmHierarchyObjectConnection();
            this.ChildConnection.ApplyExploratoryFieldSpec(parent + ".childConnection");
        }
        //      C# -> CdmHierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: CdmHierarchyObjectConnection! (type)
        if (this.DescendantConnection == null && Exploration.Includes(parent + ".descendantConnection"))
        {
            this.DescendantConnection = new CdmHierarchyObjectConnection();
            this.DescendantConnection.ApplyExploratoryFieldSpec(parent + ".descendantConnection");
        }
        //      C# -> CdmHierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: CdmHierarchyObjectConnection! (type)
        if (this.TopLevelDescendantConnection == null && Exploration.Includes(parent + ".topLevelDescendantConnection"))
        {
            this.TopLevelDescendantConnection = new CdmHierarchyObjectConnection();
            this.TopLevelDescendantConnection.ApplyExploratoryFieldSpec(parent + ".topLevelDescendantConnection");
        }
    }


    #endregion

    } // class CdmInventorySubHierarchyRoot
    
    #endregion

    public static class ListCdmInventorySubHierarchyRootExtensions
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
            this List<CdmInventorySubHierarchyRoot> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmInventorySubHierarchyRoot> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmInventorySubHierarchyRoot());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types