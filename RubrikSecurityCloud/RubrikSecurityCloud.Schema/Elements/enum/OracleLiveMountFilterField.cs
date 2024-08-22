// OracleLiveMountFilterField.cs
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

namespace RubrikSecurityCloud.Types
{
    public enum OracleLiveMountFilterField
    {
        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "ORG_ID")]
        ORG_ID,

        [EnumMember(Value = "SOURCE_DATABASE_ID")]
        SOURCE_DATABASE_ID,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum OracleLiveMountFilterField

} // namespace RubrikSecurityCloud.Types