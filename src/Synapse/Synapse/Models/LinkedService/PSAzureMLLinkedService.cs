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
    /// Azure ML Studio Web Service linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureML")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSAzureMLLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSAzureMLLinkedService class.
        /// </summary>
        public PSAzureMLLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Batch Execution REST URL for an Azure ML Studio
        /// Web Service endpoint. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mlEndpoint")]
        public object MlEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the API key for accessing the Azure ML model endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.apiKey")]
        public SecretBase ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the Update Resource REST URL for an Azure ML Studio
        /// Web Service endpoint. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.updateResourceEndpoint")]
        public object UpdateResourceEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the ID of the service principal used to authenticate
        /// against the ARM-based updateResourceEndpoint of an Azure ML Studio
        /// web service. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the key of the service principal used to authenticate
        /// against the ARM-based updateResourceEndpoint of an Azure ML Studio
        /// web service.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets the name or ID of the tenant to which the service
        /// principal belongs. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tenant")]
        public object Tenant { get; set; }

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
            if (MlEndpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MlEndpoint");
            }
            if (ApiKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApiKey");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new AzureMLLinkedService(this.MlEndpoint, this.ApiKey);
            linkedService.UpdateResourceEndpoint = this.UpdateResourceEndpoint;
            linkedService.ServicePrincipalId = this.ServicePrincipalId;
            linkedService.ServicePrincipalKey = this.ServicePrincipalKey;
            linkedService.Tenant = this.Tenant;
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

