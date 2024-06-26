// MosaicModifyStoreRequestInput.cs
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
    #region MosaicModifyStoreRequestInput

    public class MosaicModifyStoreRequestInput: IInput
    {
        #region members

        //      C# -> System.String? AccessKeyId
        // GraphQL -> accessKeyId: String (scalar)
        [JsonProperty("accessKeyId")]
        public System.String? AccessKeyId { get; set; }

        //      C# -> System.String? SecretKey
        // GraphQL -> secretKey: String (scalar)
        [JsonProperty("secretKey")]
        public System.String? SecretKey { get; set; }

        //      C# -> System.Boolean? SkipKeyFileConfig
        // GraphQL -> skipKeyFileConfig: Boolean (scalar)
        [JsonProperty("skipKeyFileConfig")]
        public System.Boolean? SkipKeyFileConfig { get; set; }

        //      C# -> System.String? StoreName
        // GraphQL -> storeName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("storeName")]
        public System.String? StoreName { get; set; }


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

    } // class MosaicModifyStoreRequestInput
    #endregion

} // namespace RubrikSecurityCloud.Types