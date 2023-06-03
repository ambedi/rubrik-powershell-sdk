// Db2WorkloadDataBackupFile.cs
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
    #region Db2WorkloadDataBackupFile
    public class Db2WorkloadDataBackupFile: BaseType
    {
        #region members

        //      C# -> System.Int32? PartitionNum
        // GraphQL -> partitionNum: Int! (scalar)
        [JsonProperty("partitionNum")]
        public System.Int32? PartitionNum { get; set; }

        //      C# -> System.Int32? SequenceNum
        // GraphQL -> sequenceNum: Int! (scalar)
        [JsonProperty("sequenceNum")]
        public System.Int32? SequenceNum { get; set; }


        #endregion

    #region methods

    public Db2WorkloadDataBackupFile Set(
        System.Int32? PartitionNum = null,
        System.Int32? SequenceNum = null
    ) 
    {
        if ( PartitionNum != null ) {
            this.PartitionNum = PartitionNum;
        }
        if ( SequenceNum != null ) {
            this.SequenceNum = SequenceNum;
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
        //      C# -> System.Int32? PartitionNum
        // GraphQL -> partitionNum: Int! (scalar)
        if (this.PartitionNum != null) {
            s += ind + "partitionNum\n" ;
        }
        //      C# -> System.Int32? SequenceNum
        // GraphQL -> sequenceNum: Int! (scalar)
        if (this.SequenceNum != null) {
            s += ind + "sequenceNum\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? PartitionNum
        // GraphQL -> partitionNum: Int! (scalar)
        if (this.PartitionNum == null && Exploration.Includes(parent + ".partitionNum", true))
        {
            this.PartitionNum = new System.Int32();
        }
        //      C# -> System.Int32? SequenceNum
        // GraphQL -> sequenceNum: Int! (scalar)
        if (this.SequenceNum == null && Exploration.Includes(parent + ".sequenceNum", true))
        {
            this.SequenceNum = new System.Int32();
        }
    }


    #endregion

    } // class Db2WorkloadDataBackupFile
    
    #endregion

    public static class ListDb2WorkloadDataBackupFileExtensions
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
            this List<Db2WorkloadDataBackupFile> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Db2WorkloadDataBackupFile> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2WorkloadDataBackupFile());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types