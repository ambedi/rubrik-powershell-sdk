// SaasFeature.cs
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
    public enum SaasFeature
    {
        [EnumMember(Value = "TYPE_AAD")]
        TYPE_AAD,

        [EnumMember(Value = "TYPE_CLOUD_DIRECT_HOSTED")]
        TYPE_CLOUD_DIRECT_HOSTED,

        [EnumMember(Value = "TYPE_M365")]
        TYPE_M365,

        [EnumMember(Value = "TYPE_SAAS_PROTECTION")]
        TYPE_SAAS_PROTECTION,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SaasFeature

} // namespace RubrikSecurityCloud.Types