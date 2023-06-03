// MountedVolume.cs
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
    #region MountedVolume
    public class MountedVolume: BaseType
    {
        #region members

        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String! (scalar)
        [JsonProperty("fileSystemType")]
        public System.String? FileSystemType { get; set; }

        //      C# -> System.String? HostMountPath
        // GraphQL -> hostMountPath: String (scalar)
        [JsonProperty("hostMountPath")]
        public System.String? HostMountPath { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> List<System.String>? OriginalMountPoints
        // GraphQL -> originalMountPoints: [String!]! (scalar)
        [JsonProperty("originalMountPoints")]
        public List<System.String>? OriginalMountPoints { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? SmbPath
        // GraphQL -> smbPath: String (scalar)
        [JsonProperty("smbPath")]
        public System.String? SmbPath { get; set; }


        #endregion

    #region methods

    public MountedVolume Set(
        System.String? FileSystemType = null,
        System.String? HostMountPath = null,
        System.String? Id = null,
        List<System.String>? OriginalMountPoints = null,
        System.Int64? Size = null,
        System.String? SmbPath = null
    ) 
    {
        if ( FileSystemType != null ) {
            this.FileSystemType = FileSystemType;
        }
        if ( HostMountPath != null ) {
            this.HostMountPath = HostMountPath;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( OriginalMountPoints != null ) {
            this.OriginalMountPoints = OriginalMountPoints;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( SmbPath != null ) {
            this.SmbPath = SmbPath;
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
        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String! (scalar)
        if (this.FileSystemType != null) {
            s += ind + "fileSystemType\n" ;
        }
        //      C# -> System.String? HostMountPath
        // GraphQL -> hostMountPath: String (scalar)
        if (this.HostMountPath != null) {
            s += ind + "hostMountPath\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> List<System.String>? OriginalMountPoints
        // GraphQL -> originalMountPoints: [String!]! (scalar)
        if (this.OriginalMountPoints != null) {
            s += ind + "originalMountPoints\n" ;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            s += ind + "size\n" ;
        }
        //      C# -> System.String? SmbPath
        // GraphQL -> smbPath: String (scalar)
        if (this.SmbPath != null) {
            s += ind + "smbPath\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String! (scalar)
        if (this.FileSystemType == null && Exploration.Includes(parent + ".fileSystemType", true))
        {
            this.FileSystemType = new System.String("FETCH");
        }
        //      C# -> System.String? HostMountPath
        // GraphQL -> hostMountPath: String (scalar)
        if (this.HostMountPath == null && Exploration.Includes(parent + ".hostMountPath", true))
        {
            this.HostMountPath = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> List<System.String>? OriginalMountPoints
        // GraphQL -> originalMountPoints: [String!]! (scalar)
        if (this.OriginalMountPoints == null && Exploration.Includes(parent + ".originalMountPoints", true))
        {
            this.OriginalMountPoints = new List<System.String>();
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size == null && Exploration.Includes(parent + ".size", true))
        {
            this.Size = new System.Int64();
        }
        //      C# -> System.String? SmbPath
        // GraphQL -> smbPath: String (scalar)
        if (this.SmbPath == null && Exploration.Includes(parent + ".smbPath", true))
        {
            this.SmbPath = new System.String("FETCH");
        }
    }


    #endregion

    } // class MountedVolume
    
    #endregion

    public static class ListMountedVolumeExtensions
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
            this List<MountedVolume> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MountedVolume> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MountedVolume());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types