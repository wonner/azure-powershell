// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Binary dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Binary")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSBinaryDataset : PSDataset
    {
        /// <summary>
        /// Initializes a new instance of the PSBinaryDataset class.
        /// </summary>
        public PSBinaryDataset()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location of the Binary storage.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.location")]
        public PSDatasetLocation Location { get; set; }

        /// <summary>
        /// Gets or sets the data compression method used for the binary
        /// dataset.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.compression")]
        public PSDatasetCompression Compression { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }

        public override Dataset ToSdkObject()
        {
            var dataset = new BinaryDataset(this.LinkedServiceName);
            dataset.Location = this.Location.ToSdkObject();
            dataset.Compression = this.Compression.ToSdkObject();
            SetProperties(dataset);
            return dataset;
        }
    }
}

