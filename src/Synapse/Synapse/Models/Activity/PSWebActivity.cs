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
    /// Web activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("WebActivity")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSWebActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSWebActivity class.
        /// </summary>
        public PSWebActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets rest API method for target endpoint. Possible values
        /// include: 'GET', 'POST', 'PUT', 'DELETE'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets web activity target endpoint and path. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.url")]
        public object Url { get; set; }

        /// <summary>
        /// Gets or sets represents the headers that will be sent to the
        /// request. For example, to set the language and type on a request:
        /// "headers" : { "Accept-Language": "en-us", "Content-Type":
        /// "application/json" }. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.headers")]
        public object Headers { get; set; }

        /// <summary>
        /// Gets or sets represents the payload that will be sent to the
        /// endpoint. Required for POST/PUT method, not allowed for GET method
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.body")]
        public object Body { get; set; }

        /// <summary>
        /// Gets or sets authentication method used for calling the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authentication")]
        public WebActivityAuthentication Authentication { get; set; }

        /// <summary>
        /// Gets or sets list of datasets passed to web endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.datasets")]
        public IList<DatasetReference> Datasets { get; set; }

        /// <summary>
        /// Gets or sets list of linked services passed to web endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.linkedServices")]
        public IList<LinkedServiceReference> LinkedServices { get; set; }

        /// <summary>
        /// Gets or sets the integration runtime reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectVia")]
        public IntegrationRuntimeReference ConnectVia { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Method == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Method");
            }
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new WebActivity(this.Name, this.Method, this.Url);
            activity.Headers = this.Headers;
            activity.Body = this.Body;
            activity.Authentication = this.Authentication;
            activity.Datasets = this.Datasets;
            activity.LinkedServices = this.LinkedServices;
            activity.ConnectVia = this.ConnectVia;
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

