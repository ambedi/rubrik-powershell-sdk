// FileAccessResult.cs
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
    #region FileAccessResult
    public class FileAccessResult: BaseType
    {
        #region members

        //      C# -> ActivityAccessType? AccessType
        // GraphQL -> accessType: ActivityAccessType! (enum)
        [JsonProperty("accessType")]
        public ActivityAccessType? AccessType { get; set; }

        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        [JsonProperty("directory")]
        public System.String? Directory { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        [JsonProperty("nativePath")]
        public System.String? NativePath { get; set; }

        //      C# -> System.Int32? NumAccesses
        // GraphQL -> numAccesses: Int! (scalar)
        [JsonProperty("numAccesses")]
        public System.Int32? NumAccesses { get; set; }


        #endregion

    #region methods

    public FileAccessResult Set(
        ActivityAccessType? AccessType = null,
        System.String? Directory = null,
        System.String? Filename = null,
        System.String? NativePath = null,
        System.Int32? NumAccesses = null
    ) 
    {
        if ( AccessType != null ) {
            this.AccessType = AccessType;
        }
        if ( Directory != null ) {
            this.Directory = Directory;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( NativePath != null ) {
            this.NativePath = NativePath;
        }
        if ( NumAccesses != null ) {
            this.NumAccesses = NumAccesses;
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
        //      C# -> ActivityAccessType? AccessType
        // GraphQL -> accessType: ActivityAccessType! (enum)
        if (this.AccessType != null) {
            s += ind + "accessType\n" ;
        }
        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        if (this.Directory != null) {
            s += ind + "directory\n" ;
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename != null) {
            s += ind + "filename\n" ;
        }
        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        if (this.NativePath != null) {
            s += ind + "nativePath\n" ;
        }
        //      C# -> System.Int32? NumAccesses
        // GraphQL -> numAccesses: Int! (scalar)
        if (this.NumAccesses != null) {
            s += ind + "numAccesses\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ActivityAccessType? AccessType
        // GraphQL -> accessType: ActivityAccessType! (enum)
        if (this.AccessType == null && Exploration.Includes(parent + ".accessType", true))
        {
            this.AccessType = new ActivityAccessType();
        }
        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        if (this.Directory == null && Exploration.Includes(parent + ".directory", true))
        {
            this.Directory = new System.String("FETCH");
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename == null && Exploration.Includes(parent + ".filename", true))
        {
            this.Filename = new System.String("FETCH");
        }
        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        if (this.NativePath == null && Exploration.Includes(parent + ".nativePath", true))
        {
            this.NativePath = new System.String("FETCH");
        }
        //      C# -> System.Int32? NumAccesses
        // GraphQL -> numAccesses: Int! (scalar)
        if (this.NumAccesses == null && Exploration.Includes(parent + ".numAccesses", true))
        {
            this.NumAccesses = new System.Int32();
        }
    }


    #endregion

    } // class FileAccessResult
    
    #endregion

    public static class ListFileAccessResultExtensions
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
            this List<FileAccessResult> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FileAccessResult> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FileAccessResult());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types