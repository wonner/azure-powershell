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
    /// DatabricksSparkJar activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DatabricksSparkJar")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSDatabricksSparkJarActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSDatabricksSparkJarActivity
        /// class.
        /// </summary>
        public PSDatabricksSparkJarActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the full name of the class containing the main method
        /// to be executed. This class must be contained in a JAR provided as a
        /// library. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mainClassName")]
        public object MainClassName { get; set; }

        /// <summary>
        /// Gets or sets parameters that will be passed to the main method.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.parameters")]
        public IList<object> Parameters { get; set; }

        /// <summary>
        /// Gets or sets a list of libraries to be installed on the cluster
        /// that will execute the job.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.libraries")]
        public IList<IDictionary<string, object>> Libraries { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (MainClassName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MainClassName");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new DatabricksSparkJarActivity(this.Name, this.MainClassName);
            activity.Parameters = this.Parameters;
            activity.Libraries = this.Libraries;
            activity.LinkedServiceName = this.LinkedServiceName;
            activity.Policy = this.Policy;
            activity.Description = this.Description;
            IList<PSActivityDependency> pSDependsOn = this.DependsOn;
            if (pSDependsOn != null)
            {
                IList<ActivityDependency> dependsOn = new List<ActivityDependency>();
                foreach (PSActivityDependency pSDependOn in pSDependsOn)
                {
                    dependsOn.Add(pSDependOn.ToSdkObject());
                }
                activity.DependsOn = dependsOn;
            }
            IList<PSUserProperty> pSUserProperties = this.UserProperties;
            if (pSUserProperties != null)
            {
                IList<UserProperty> userProperties = new List<UserProperty>();
                foreach (PSUserProperty pSUserProperty in pSUserProperties)
                {
                    userProperties.Add(pSUserProperty.ToSdkObject());
                }
                activity.UserProperties = userProperties;
            }
            return activity;
		}
    }
}

