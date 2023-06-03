// AddManagedVolumeReply.cs
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
    #region AddManagedVolumeReply
    public class AddManagedVolumeReply: BaseType
    {
        #region members

        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }

        //      C# -> UpdateManagedVolumeReply? ManagedVolumeSummary
        // GraphQL -> managedVolumeSummary: UpdateManagedVolumeReply (type)
        [JsonProperty("managedVolumeSummary")]
        public UpdateManagedVolumeReply? ManagedVolumeSummary { get; set; }


        #endregion

    #region methods

    public AddManagedVolumeReply Set(
        AsyncRequestStatus? AsyncRequestStatus = null,
        UpdateManagedVolumeReply? ManagedVolumeSummary = null
    ) 
    {
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
        }
        if ( ManagedVolumeSummary != null ) {
            this.ManagedVolumeSummary = ManagedVolumeSummary;
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
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus != null) {
            s += ind + "asyncRequestStatus {\n" + this.AsyncRequestStatus.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> UpdateManagedVolumeReply? ManagedVolumeSummary
        // GraphQL -> managedVolumeSummary: UpdateManagedVolumeReply (type)
        if (this.ManagedVolumeSummary != null) {
            s += ind + "managedVolumeSummary {\n" + this.ManagedVolumeSummary.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus == null && Exploration.Includes(parent + ".asyncRequestStatus"))
        {
            this.AsyncRequestStatus = new AsyncRequestStatus();
            this.AsyncRequestStatus.ApplyExploratoryFieldSpec(parent + ".asyncRequestStatus");
        }
        //      C# -> UpdateManagedVolumeReply? ManagedVolumeSummary
        // GraphQL -> managedVolumeSummary: UpdateManagedVolumeReply (type)
        if (this.ManagedVolumeSummary == null && Exploration.Includes(parent + ".managedVolumeSummary"))
        {
            this.ManagedVolumeSummary = new UpdateManagedVolumeReply();
            this.ManagedVolumeSummary.ApplyExploratoryFieldSpec(parent + ".managedVolumeSummary");
        }
    }


    #endregion

    } // class AddManagedVolumeReply
    
    #endregion

    public static class ListAddManagedVolumeReplyExtensions
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
            this List<AddManagedVolumeReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AddManagedVolumeReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AddManagedVolumeReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types