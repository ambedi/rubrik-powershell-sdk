// VirtualMachineScriptDetailInput.cs
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
    #region VirtualMachineScriptDetailInput

    public class VirtualMachineScriptDetailInput: IInput
    {
        #region members

        //      C# -> VirtualMachineScriptDetailFailureHandling? FailureHandling
        // GraphQL -> failureHandling: VirtualMachineScriptDetailFailureHandling! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("failureHandling")]
        public VirtualMachineScriptDetailFailureHandling? FailureHandling { get; set; }

        //      C# -> System.String? ScriptPath
        // GraphQL -> scriptPath: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("scriptPath")]
        public System.String? ScriptPath { get; set; }

        //      C# -> System.Int64? TimeoutMs
        // GraphQL -> timeoutMs: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("timeoutMs")]
        public System.Int64? TimeoutMs { get; set; }


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

    } // class VirtualMachineScriptDetailInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types