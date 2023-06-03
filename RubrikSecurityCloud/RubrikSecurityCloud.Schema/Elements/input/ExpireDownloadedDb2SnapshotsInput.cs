// ExpireDownloadedDb2SnapshotsInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ExpireDownloadedDb2SnapshotsInput

    public class ExpireDownloadedDb2SnapshotsInput: IInput
    {
        #region members

        //      C# -> DateTime? AfterTime
        // GraphQL -> afterTime: DateTime (scalar)
        [JsonProperty("afterTime")]
        public DateTime? AfterTime { get; set; }

        //      C# -> DateTime? BeforeTime
        // GraphQL -> beforeTime: DateTime (scalar)
        [JsonProperty("beforeTime")]
        public DateTime? BeforeTime { get; set; }

        //      C# -> System.Boolean? ShouldExpireLogsOnly
        // GraphQL -> shouldExpireLogsOnly: Boolean (scalar)
        [JsonProperty("shouldExpireLogsOnly")]
        public System.Boolean? ShouldExpireLogsOnly { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }


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

    } // class ExpireDownloadedDb2SnapshotsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types