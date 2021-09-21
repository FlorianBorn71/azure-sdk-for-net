// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Resource type Sku object
    /// </summary>
    public partial class ResourceTypeSku
    {
        /// <summary>
        /// Initializes a new instance of the ResourceTypeSku class.
        /// </summary>
        public ResourceTypeSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceTypeSku class.
        /// </summary>
        /// <param name="resourceType">The resource type.</param>
        /// <param name="skus">The skus.</param>
        public ResourceTypeSku(string resourceType = default(string), IList<SkuInformation> skus = default(IList<SkuInformation>))
        {
            ResourceType = resourceType;
            Skus = skus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; private set; }

        /// <summary>
        /// Gets the skus.
        /// </summary>
        [JsonProperty(PropertyName = "skus")]
        public IList<SkuInformation> Skus { get; private set; }

    }
}
