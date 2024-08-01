// AzureKeyVaultInfoInput.cs
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
    #region AzureKeyVaultInfoInput

    public class AzureKeyVaultInfoInput: IInput
    {
        #region members

        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("instanceName")]
        public System.String? InstanceName { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clientSecret")]
        public System.String? ClientSecret { get; set; }

        //      C# -> System.String? VaultUrl
        // GraphQL -> vaultUrl: URL! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("vaultUrl")]
        public System.String? VaultUrl { get; set; }


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

    } // class AzureKeyVaultInfoInput
    #endregion

} // namespace RubrikSecurityCloud.Types