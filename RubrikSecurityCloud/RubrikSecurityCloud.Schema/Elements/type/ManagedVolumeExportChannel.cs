// ManagedVolumeExportChannel.cs
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
    #region ManagedVolumeExportChannel
    public class ManagedVolumeExportChannel: BaseType
    {
        #region members

        //      C# -> DateTime? ExportDate
        // GraphQL -> exportDate: DateTime! (scalar)
        [JsonProperty("exportDate")]
        public DateTime? ExportDate { get; set; }

        //      C# -> System.String? FloatingIpAddress
        // GraphQL -> floatingIpAddress: String! (scalar)
        [JsonProperty("floatingIpAddress")]
        public System.String? FloatingIpAddress { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String! (scalar)
        [JsonProperty("mountPath")]
        public System.String? MountPath { get; set; }

        //      C# -> ManagedVolumeExportChannelStats? ChannelStats
        // GraphQL -> channelStats: ManagedVolumeExportChannelStats! (type)
        [JsonProperty("channelStats")]
        public ManagedVolumeExportChannelStats? ChannelStats { get; set; }

        //      C# -> ManagedVolumeMountSpec? MountSpec
        // GraphQL -> mountSpec: ManagedVolumeMountSpec! (type)
        [JsonProperty("mountSpec")]
        public ManagedVolumeMountSpec? MountSpec { get; set; }


        #endregion

    #region methods

    public ManagedVolumeExportChannel Set(
        DateTime? ExportDate = null,
        System.String? FloatingIpAddress = null,
        System.String? Id = null,
        System.String? MountPath = null,
        ManagedVolumeExportChannelStats? ChannelStats = null,
        ManagedVolumeMountSpec? MountSpec = null
    ) 
    {
        if ( ExportDate != null ) {
            this.ExportDate = ExportDate;
        }
        if ( FloatingIpAddress != null ) {
            this.FloatingIpAddress = FloatingIpAddress;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( MountPath != null ) {
            this.MountPath = MountPath;
        }
        if ( ChannelStats != null ) {
            this.ChannelStats = ChannelStats;
        }
        if ( MountSpec != null ) {
            this.MountSpec = MountSpec;
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
        //      C# -> DateTime? ExportDate
        // GraphQL -> exportDate: DateTime! (scalar)
        if (this.ExportDate != null) {
            s += ind + "exportDate\n" ;
        }
        //      C# -> System.String? FloatingIpAddress
        // GraphQL -> floatingIpAddress: String! (scalar)
        if (this.FloatingIpAddress != null) {
            s += ind + "floatingIpAddress\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String! (scalar)
        if (this.MountPath != null) {
            s += ind + "mountPath\n" ;
        }
        //      C# -> ManagedVolumeExportChannelStats? ChannelStats
        // GraphQL -> channelStats: ManagedVolumeExportChannelStats! (type)
        if (this.ChannelStats != null) {
            s += ind + "channelStats {\n" + this.ChannelStats.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumeMountSpec? MountSpec
        // GraphQL -> mountSpec: ManagedVolumeMountSpec! (type)
        if (this.MountSpec != null) {
            s += ind + "mountSpec {\n" + this.MountSpec.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DateTime? ExportDate
        // GraphQL -> exportDate: DateTime! (scalar)
        if (this.ExportDate == null && Exploration.Includes(parent + ".exportDate", true))
        {
            this.ExportDate = new DateTime();
        }
        //      C# -> System.String? FloatingIpAddress
        // GraphQL -> floatingIpAddress: String! (scalar)
        if (this.FloatingIpAddress == null && Exploration.Includes(parent + ".floatingIpAddress", true))
        {
            this.FloatingIpAddress = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String! (scalar)
        if (this.MountPath == null && Exploration.Includes(parent + ".mountPath", true))
        {
            this.MountPath = new System.String("FETCH");
        }
        //      C# -> ManagedVolumeExportChannelStats? ChannelStats
        // GraphQL -> channelStats: ManagedVolumeExportChannelStats! (type)
        if (this.ChannelStats == null && Exploration.Includes(parent + ".channelStats"))
        {
            this.ChannelStats = new ManagedVolumeExportChannelStats();
            this.ChannelStats.ApplyExploratoryFieldSpec(parent + ".channelStats");
        }
        //      C# -> ManagedVolumeMountSpec? MountSpec
        // GraphQL -> mountSpec: ManagedVolumeMountSpec! (type)
        if (this.MountSpec == null && Exploration.Includes(parent + ".mountSpec"))
        {
            this.MountSpec = new ManagedVolumeMountSpec();
            this.MountSpec.ApplyExploratoryFieldSpec(parent + ".mountSpec");
        }
    }


    #endregion

    } // class ManagedVolumeExportChannel
    
    #endregion

    public static class ListManagedVolumeExportChannelExtensions
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
            this List<ManagedVolumeExportChannel> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeExportChannel> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeExportChannel());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types