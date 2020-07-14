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
    /// Execute pipeline activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ExecutePipeline")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSExecutePipelineActivity : PSControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSExecutePipelineActivity class.
        /// </summary>
        public PSExecutePipelineActivity(string referenceName)
        {
            Pipeline = new PipelineReference(referenceName);
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets pipeline reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.pipeline")]
        public PipelineReference Pipeline { get; set; }

        /// <summary>
        /// Gets or sets pipeline parameters.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.parameters")]
        public IDictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// Gets or sets defines whether activity execution will wait for the
        /// dependent pipeline execution to finish. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.waitOnCompletion")]
        public bool? WaitOnCompletion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Pipeline == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Pipeline");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new ExecutePipelineActivity(this.Name, this.Pipeline);
            activity.Parameters = this.Parameters;
            activity.WaitOnCompletion = this.WaitOnCompletion;
            activity.Description = this.Description;
            IList<PSActivityDependency> pSDependsOn = this.DependsOn;
            if (pSDependsOn != null)
            {
                IList<ActivityDependency> dependsOn = new List<ActivityDependency>();
                foreach (PSActivityDependency pSDependOn in pSDependsOn)
                {
                    dependsOn.Add(pSDependOn?.ToSdkObject());
                }
                activity.DependsOn = dependsOn;
            }
            IList<PSUserProperty> pSUserProperties = this.UserProperties;
            if (pSUserProperties != null)
            {
                IList<UserProperty> userProperties = new List<UserProperty>();
                foreach (PSUserProperty pSUserProperty in pSUserProperties)
                {
                    userProperties.Add(pSUserProperty?.ToSdkObject());
                }
                activity.UserProperties = userProperties;
            }
            return activity;
        }
    }
}

