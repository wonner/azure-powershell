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
    /// Azure ML Service linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureMLService")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSAzureMLServiceLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSAzureMLServiceLinkedService
        /// class.
        /// </summary>
        public PSAzureMLServiceLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azure ML Service workspace subscription ID. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.subscriptionId")]
        public object SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets azure ML Service workspace resource group name. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.resourceGroupName")]
        public object ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets azure ML Service workspace name. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mlWorkspaceName")]
        public object MlWorkspaceName { get; set; }

        /// <summary>
        /// Gets or sets the ID of the service principal used to authenticate
        /// against the endpoint of a published Azure ML Service pipeline.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the key of the service principal used to authenticate
        /// against the endpoint of a published Azure ML Service pipeline.
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
            if (SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubscriptionId");
            }
            if (ResourceGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceGroupName");
            }
            if (MlWorkspaceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MlWorkspaceName");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new AzureMLServiceLinkedService(this.SubscriptionId, this.ResourceGroupName, this.MlWorkspaceName);
            linkedService.ServicePrincipalId = this.ServicePrincipalId;
            linkedService.ServicePrincipalKey = this.ServicePrincipalKey;
            linkedService.Tenant = this.Tenant;
            linkedService.EncryptedCredential = this.EncryptedCredential;
            linkedService.ConnectVia = this.ConnectVia.ToSdkObject();
            linkedService.Description = this.Description;
            linkedService.Annotations = this.Annotations;
            IDictionary<string, PSParameterSpecification> pSParameters = this.Parameters;
            if (pSParameters != null)
            {
                IDictionary<string, ParameterSpecification> parameters = new Dictionary<string, ParameterSpecification>();
                foreach (var pSParameter in pSParameters)
                {
                    parameters.Add(pSParameter.Key, pSParameter.Value.ToSdkObject());
                }
                linkedService.Parameters = parameters;
            }
            return linkedService;
        }
    }
}

