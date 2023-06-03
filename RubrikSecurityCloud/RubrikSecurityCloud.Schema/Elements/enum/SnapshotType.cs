// SnapshotType.cs
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
    public enum SnapshotType
    {
        [EnumMember(Value = "ARCHIVED")]
        ARCHIVED,

        [EnumMember(Value = "REPLICATED")]
        REPLICATED,

        [EnumMember(Value = "SOURCE")]
        SOURCE


    } // enum SnapshotType

} // namespace Rubrik.SecurityCloud.Types