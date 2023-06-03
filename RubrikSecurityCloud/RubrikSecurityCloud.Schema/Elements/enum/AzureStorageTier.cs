// AzureStorageTier.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum AzureStorageTier
    {
        [EnumMember(Value = "ARCHIVE")]
        ARCHIVE,

        [EnumMember(Value = "COOL")]
        COOL,

        [EnumMember(Value = "HOT")]
        HOT,

        [EnumMember(Value = "UNKNOWN_STORAGE_TIER")]
        UNKNOWN_STORAGE_TIER


    } // enum AzureStorageTier

} // namespace Rubrik.SecurityCloud.Types