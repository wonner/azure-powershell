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
    /// This activity verifies that an external resource exists.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Validation")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSValidationActivity : PSControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSValidationActivity class.
        /// </summary>
        public PSValidationActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the timeout for the activity to run. If
        /// there is no value specified, it takes the value of
        /// TimeSpan.FromDays(7) which is 1 week as default. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.timeout")]
        public object Timeout { get; set; }

        /// <summary>
        /// Gets or sets a delay in seconds between validation attempts. If no
        /// value is specified, 10 seconds will be used as the default. Type:
        /// integer (or Expression with resultType integer).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sleep")]
        public object Sleep { get; set; }

        /// <summary>
        /// Gets or sets can be used if dataset points to a file. The file must
        /// be greater than or equal in size to the value specified. Type:
        /// integer (or Expression with resultType integer).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.minimumSize")]
        public object MinimumSize { get; set; }

        /// <summary>
        /// Gets or sets can be used if dataset points to a folder. If set to
        /// true, the folder must have at least one file. If set to false, the
        /// folder must be empty. Type: boolean (or Expression with resultType
        /// boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.childItems")]
        public object ChildItems { get; set; }

        /// <summary>
        /// Gets or sets validation activity dataset reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.dataset")]
        public DatasetReference Dataset { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Dataset == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Dataset");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new ValidationActivity(this.Name, this.Dataset);
            activity.Timeout = this.Timeout;
            activity.Sleep = this.Sleep;
            activity.MinimumSize = this.MinimumSize;
            activity.ChildItems = this.ChildItems;
            activity.Description = this.Description;

            return activity;
        }
    }
}

