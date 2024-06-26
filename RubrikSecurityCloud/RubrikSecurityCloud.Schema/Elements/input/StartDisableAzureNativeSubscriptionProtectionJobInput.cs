// StartDisableAzureNativeSubscriptionProtectionJobInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region StartDisableAzureNativeSubscriptionProtectionJobInput

    public class StartDisableAzureNativeSubscriptionProtectionJobInput: IInput
    {
        #region members

        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("azureSubscriptionRubrikId")]
        public System.String? AzureSubscriptionRubrikId { get; set; }

        //      C# -> System.Boolean? ShouldDeleteNativeSnapshots
        // GraphQL -> shouldDeleteNativeSnapshots: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldDeleteNativeSnapshots")]
        public System.Boolean? ShouldDeleteNativeSnapshots { get; set; }

        //      C# -> AzureNativeProtectionFeature? AzureNativeProtectionFeature
        // GraphQL -> azureNativeProtectionFeature: AzureNativeProtectionFeature! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("azureNativeProtectionFeature")]
        public AzureNativeProtectionFeature? AzureNativeProtectionFeature { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class StartDisableAzureNativeSubscriptionProtectionJobInput
    #endregion

} // namespace RubrikSecurityCloud.Types