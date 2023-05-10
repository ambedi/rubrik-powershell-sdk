﻿using System;
using Rubrik.SecurityCloud.NetSDK.Client.Models.Authentication;

namespace RubrikSecurityCloud.PowerShell.Models
{
	public class RscPsSessionInfo
	{
		public string ClientId { get; }
		public AuthenticationState AuthenticationState{ get; }
        public string SdkSchemaVersion { get; }
        public string ServerVersion { get; }

        public RscPsSessionInfo(string clientId, AuthenticationState authState,
			string sdkSchemaVersion, string serverVersion)
		{
			this.ClientId = clientId;
			this.AuthenticationState = authState;
			this.SdkSchemaVersion = sdkSchemaVersion;
			this.ServerVersion = serverVersion;
		}
	}
}

