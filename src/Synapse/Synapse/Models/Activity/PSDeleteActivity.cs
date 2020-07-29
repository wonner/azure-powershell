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
    /// Delete activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Delete")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSDeleteActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSDeleteActivity class.
        /// </summary>
        public PSDeleteActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if true, files or sub-folders under current folder
        /// path will be deleted recursively. Default is false. Type: boolean
        /// (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.recursive")]
        public object Recursive { get; set; }

        /// <summary>
        /// Gets or sets the max concurrent connections to connect data source
        /// at the same time.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.maxConcurrentConnections")]
        public int? MaxConcurrentConnections { get; set; }

        /// <summary>
        /// Gets or sets whether to record detailed logs of delete-activity
        /// execution. Default value is false. Type: boolean (or Expression
        /// with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.enableLogging")]
        public object EnableLogging { get; set; }

        /// <summary>
        /// Gets or sets log storage settings customer need to provide when
        /// enableLogging is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.logStorageSettings")]
        public LogStorageSettings LogStorageSettings { get; set; }

        /// <summary>
        /// Gets or sets delete activity dataset reference.
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
            if (MaxConcurrentConnections < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxConcurrentConnections", 1);
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new DeleteActivity(this.Name, this.Dataset);
            activity.Recursive = this.Recursive;
            activity.MaxConcurrentConnections = this.MaxConcurrentConnections;
            activity.EnableLogging = this.EnableLogging;
            activity.LogStorageSettings = this.LogStorageSettings;
            activity.LinkedServiceName = this.LinkedServiceName;
            activity.Policy = this.Policy;
            activity.Description = this.Description;

            return activity;
        }
    }
}

