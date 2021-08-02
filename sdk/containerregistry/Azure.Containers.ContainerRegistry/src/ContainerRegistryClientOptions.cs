﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary>
    /// Options that allow users to configure the requests sent to the Container Registry service.
    /// </summary>
    public class ContainerRegistryClientOptions : ClientOptions
    {
        internal string Version { get; }

        /// <summary>
        /// </summary>
        public ContainerRegistryAudience Audience { get; set; } = ContainerRegistryAudience.AzurePublicCloud;

        /// <summary>
        /// Create an instance of the options for configuring request sent to the Container Registry service.
        /// </summary>
        /// <param name="version"></param>
        public ContainerRegistryClientOptions(ServiceVersion version = ServiceVersion.V1_0)
        {
            Version = version switch
            {
                ServiceVersion.V1_0 => "1.0",
                _ => throw new ArgumentException($"The service version {version} is not supported by this library.", nameof(version))
            };
            AddHeadersAndQueryParameters();
        }

        /// <summary>
        /// Add headers and query parameters in <see cref="DiagnosticsOptions.LoggedHeaderNames"/> and <see cref="DiagnosticsOptions.LoggedQueryParameters"/>
        /// </summary>
        private void AddHeadersAndQueryParameters()
        {
            Diagnostics.LoggedQueryParameters.Add("orderby");
            Diagnostics.LoggedQueryParameters.Add("n");
            Diagnostics.LoggedQueryParameters.Add("last");
            Diagnostics.LoggedQueryParameters.Add("digest");
        }

        /// <summary>
        /// The versions of the Container Registry service supported by this client library.
        /// </summary>
        public enum ServiceVersion
        {
            /// <summary>
            /// </summary>
#pragma warning disable CA1707 // Remove the underscores from member name
            V1_0 = 1
#pragma warning restore
        }
    }
}
