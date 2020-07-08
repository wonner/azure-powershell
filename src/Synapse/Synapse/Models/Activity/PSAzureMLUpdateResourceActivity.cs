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
    /// Azure ML Update Resource management activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureMLUpdateResource")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSAzureMLUpdateResourceActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSAzureMLUpdateResourceActivity
        /// class.
        /// </summary>
        public PSAzureMLUpdateResourceActivity(string referenceName)
        {
            TrainedModelLinkedServiceName = new LinkedServiceReference(referenceName);
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Trained Model module in the Web Service
        /// experiment to be updated. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.trainedModelName")]
        public object TrainedModelName { get; set; }

        /// <summary>
        /// Gets or sets name of Azure Storage linked service holding the
        /// .ilearner file that will be uploaded by the update operation.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.trainedModelLinkedServiceName")]
        public LinkedServiceReference TrainedModelLinkedServiceName { get; set; }

        /// <summary>
        /// Gets or sets the relative file path in trainedModelLinkedService to
        /// represent the .ilearner file that will be uploaded by the update
        /// operation.  Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.trainedModelFilePath")]
        public object TrainedModelFilePath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (TrainedModelName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TrainedModelName");
            }
            if (TrainedModelLinkedServiceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TrainedModelLinkedServiceName");
            }
            if (TrainedModelFilePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TrainedModelFilePath");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new AzureMLUpdateResourceActivity(this.Name, this.TrainedModelName, this.TrainedModelLinkedServiceName, this.TrainedModelFilePath);
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

