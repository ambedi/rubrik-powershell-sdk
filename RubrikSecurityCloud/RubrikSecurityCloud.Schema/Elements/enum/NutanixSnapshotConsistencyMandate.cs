// NutanixSnapshotConsistencyMandate.cs
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
    public enum NutanixSnapshotConsistencyMandate
    {
        [EnumMember(Value = "APP_CONSISTENT")]
        APP_CONSISTENT,

        [EnumMember(Value = "AUTOMATIC")]
        AUTOMATIC,

        [EnumMember(Value = "CRASH_CONSISTENT")]
        CRASH_CONSISTENT


    } // enum NutanixSnapshotConsistencyMandate

} // namespace Rubrik.SecurityCloud.Types