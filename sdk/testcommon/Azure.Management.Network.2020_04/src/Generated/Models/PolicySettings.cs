// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> Defines contents of a web application firewall global configuration. </summary>
    public partial class PolicySettings
    {
        /// <summary> Initializes a new instance of PolicySettings. </summary>
        public PolicySettings()
        {
        }

        /// <summary> Initializes a new instance of PolicySettings. </summary>
        /// <param name="state"> The state of the policy. </param>
        /// <param name="mode"> The mode of the policy. </param>
        /// <param name="requestBodyCheck"> Whether to allow WAF to check request Body. </param>
        /// <param name="maxRequestBodySizeInKb"> Maximum request body size in Kb for WAF. </param>
        /// <param name="fileUploadLimitInMb"> Maximum file upload size in Mb for WAF. </param>
        internal PolicySettings(WebApplicationFirewallEnabledState? state, WebApplicationFirewallMode? mode, bool? requestBodyCheck, int? maxRequestBodySizeInKb, int? fileUploadLimitInMb)
        {
            State = state;
            Mode = mode;
            RequestBodyCheck = requestBodyCheck;
            MaxRequestBodySizeInKb = maxRequestBodySizeInKb;
            FileUploadLimitInMb = fileUploadLimitInMb;
        }

        /// <summary> The state of the policy. </summary>
        public WebApplicationFirewallEnabledState? State { get; set; }
        /// <summary> The mode of the policy. </summary>
        public WebApplicationFirewallMode? Mode { get; set; }
        /// <summary> Whether to allow WAF to check request Body. </summary>
        public bool? RequestBodyCheck { get; set; }
        /// <summary> Maximum request body size in Kb for WAF. </summary>
        public int? MaxRequestBodySizeInKb { get; set; }
        /// <summary> Maximum file upload size in Mb for WAF. </summary>
        public int? FileUploadLimitInMb { get; set; }
    }
}
