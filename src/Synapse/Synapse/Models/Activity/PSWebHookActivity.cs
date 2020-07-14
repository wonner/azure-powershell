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
    /// WebHook activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("WebHook")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSWebHookActivity : PSControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSWebHookActivity class.
        /// </summary>
        public PSWebHookActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Static constructor for PSWebHookActivity class.
        /// </summary>
        static PSWebHookActivity()
        {
            Method = "POST";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets webHook activity target endpoint and path. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.url")]
        public object Url { get; set; }

        /// <summary>
        /// Gets or sets the timeout within which the webhook should be called
        /// back. If there is no value specified, it defaults to 10 minutes.
        /// Type: string. Pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.timeout")]
        public string Timeout { get; set; }

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
        /// Gets or sets when set to true, statusCode, output and error in
        /// callback request body will be consumed by activity. The activity
        /// can be marked as failed by setting statusCode &amp;gt;= 400 in
        /// callback request. Default is false. Type: boolean (or Expression
        /// with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.reportStatusOnCallBack")]
        public object ReportStatusOnCallBack { get; set; }

        /// <summary>
        /// Rest API method for target endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.method")]
        public static string Method { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new WebHookActivity(this.Name, this.Url);
            activity.Method = Method;
            activity.Timeout = this.Timeout;
            activity.Headers = this.Headers;
            activity.Body = this.Body;
            activity.Authentication = this.Authentication;
            activity.ReportStatusOnCallBack = this.ReportStatusOnCallBack;
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

