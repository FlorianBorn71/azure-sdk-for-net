// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The customDomain JSON object required for custom domain creation or update. </summary>
    public partial class CustomDomainOptions
    {
        /// <summary> Initializes a new instance of CustomDomainOptions. </summary>
        public CustomDomainOptions()
        {
        }

        /// <summary> The host name of the custom domain. Must be a domain name. </summary>
        public string HostName { get; set; }
    }
}
