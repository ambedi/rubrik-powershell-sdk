// RansomwareResultGroupByInfo.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region RansomwareResultGroupByInfo
    public interface RansomwareResultGroupByInfo: IFieldSpec {} // class RansomwareResultGroupByInfo
    #endregion

    public static class ListRansomwareResultGroupByInfoExtensions
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
            this List<RansomwareResultGroupByInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            string fieldspecs = "";
            foreach (RansomwareResultGroupByInfo item in list) 
            {
                fieldspecs += ind + " ... on " + item.GetType().Name + " {\n" + item.AsFieldSpec(indent+1) + ind + "}\n";
            }
            return fieldspecs;
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RansomwareResultGroupByInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                InterfaceHelper
                    .AddInstancesOfImplementingTypes<RansomwareResultGroupByInfo>(
                        ref list, 
                        instance => instance.ApplyExploratoryFieldSpec(parent));
            } else {
                foreach (RansomwareResultGroupByInfo item in list) {
                    item.ApplyExploratoryFieldSpec(parent);
                }
            }

        }
    }


} // namespace Rubrik.SecurityCloud.Types