// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Containers.ContainerRegistry
{
    internal static partial class ContainerRegistryAudienceExtensions
    {
        public static string ToSerialString(this ContainerRegistryAudience value) => value switch
        {
            ContainerRegistryAudience.AzureChina => "AzureChina",
            ContainerRegistryAudience.AzureGermany => "AzureGermany",
            ContainerRegistryAudience.AzureGovernment => "AzureGovernment",
            ContainerRegistryAudience.AzurePublicCloud => "AzurePublicCloud",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ContainerRegistryAudience value.")
        };

        public static ContainerRegistryAudience ToContainerRegistryAudience(this string value)
        {
            if (string.Equals(value, "AzureChina", StringComparison.InvariantCultureIgnoreCase)) return ContainerRegistryAudience.AzureChina;
            if (string.Equals(value, "AzureGermany", StringComparison.InvariantCultureIgnoreCase)) return ContainerRegistryAudience.AzureGermany;
            if (string.Equals(value, "AzureGovernment", StringComparison.InvariantCultureIgnoreCase)) return ContainerRegistryAudience.AzureGovernment;
            if (string.Equals(value, "AzurePublicCloud", StringComparison.InvariantCultureIgnoreCase)) return ContainerRegistryAudience.AzurePublicCloud;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ContainerRegistryAudience value.");
        }
    }
}
