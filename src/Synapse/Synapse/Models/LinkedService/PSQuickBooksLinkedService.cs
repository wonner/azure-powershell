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
    /// QuickBooks server linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("QuickBooks")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSQuickBooksLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSQuickBooksLinkedService class.
        /// </summary>
        public PSQuickBooksLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the endpoint of the QuickBooks server. (i.e.
        /// quickbooks.api.intuit.com)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.endpoint")]
        public object Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the company ID of the QuickBooks company to authorize.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.companyId")]
        public object CompanyId { get; set; }

        /// <summary>
        /// Gets or sets the consumer key for OAuth 1.0 authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.consumerKey")]
        public object ConsumerKey { get; set; }

        /// <summary>
        /// Gets or sets the consumer secret for OAuth 1.0 authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.consumerSecret")]
        public SecretBase ConsumerSecret { get; set; }

        /// <summary>
        /// Gets or sets the access token for OAuth 1.0 authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accessToken")]
        public SecretBase AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the access token secret for OAuth 1.0 authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accessTokenSecret")]
        public SecretBase AccessTokenSecret { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the data source endpoints are
        /// encrypted using HTTPS. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useEncryptedEndpoints")]
        public object UseEncryptedEndpoints { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Endpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Endpoint");
            }
            if (CompanyId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CompanyId");
            }
            if (ConsumerKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConsumerKey");
            }
            if (ConsumerSecret == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConsumerSecret");
            }
            if (AccessToken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccessToken");
            }
            if (AccessTokenSecret == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccessTokenSecret");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new QuickBooksLinkedService(this.Endpoint, this.CompanyId, this.ConsumerKey, this.ConsumerSecret, this.AccessToken, this.AccessTokenSecret);
            linkedService.UseEncryptedEndpoints = this.UseEncryptedEndpoints;
            linkedService.EncryptedCredential = this.EncryptedCredential;
            linkedService.ConnectVia = this.ConnectVia?.ToSdkObject();
            linkedService.Description = this.Description;
            linkedService.Annotations = this.Annotations;
            IDictionary<string, PSParameterSpecification> pSParameters = this.Parameters;
            if (pSParameters != null)
            {
                IDictionary<string, ParameterSpecification> parameters = new Dictionary<string, ParameterSpecification>();
                foreach (var pSParameter in pSParameters)
                {
                    parameters.Add(pSParameter.Key, pSParameter.Value?.ToSdkObject());
                }
                linkedService.Parameters = parameters;
            }
            return linkedService;
        }
    }
}

