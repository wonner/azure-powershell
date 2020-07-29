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
    /// This activity is used for iterating over a collection and execute given
    /// activities.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ForEach")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSForEachActivity : PSControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSForEachActivity class.
        /// </summary>
        public PSForEachActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets should the loop be executed in sequence or in parallel
        /// (max 50)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.isSequential")]
        public bool? IsSequential { get; set; }

        /// <summary>
        /// Gets or sets batch count to be used for controlling the number of
        /// parallel execution (when isSequential is set to false).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.batchCount")]
        public int? BatchCount { get; set; }

        /// <summary>
        /// Gets or sets collection to iterate.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.items")]
        public Expression Items { get; set; }

        /// <summary>
        /// Gets or sets list of activities to execute .
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.activities")]
        public IList<PSActivity> Activities { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Items == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Items");
            }
            if (Activities == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Activities");
            }
            if (BatchCount > 50)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "BatchCount", 50);
            }
            if (Activities != null)
            {
                foreach (var element in Activities)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new ForEachActivity(this.Name, this.Items, this.Activities?.Select(element => element.ToSdkObject()));
            activity.IsSequential = this.IsSequential;
            activity.BatchCount = this.BatchCount;
            activity.Description = this.Description;

            return activity;
        }
    }
}

