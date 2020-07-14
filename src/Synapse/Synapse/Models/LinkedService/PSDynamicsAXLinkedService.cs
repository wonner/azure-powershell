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
    /// Dynamics AX linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DynamicsAX")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSDynamicsAXLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSDynamicsAXLinkedService class.
        /// </summary>
        public PSDynamicsAXLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Dynamics AX (or Dynamics 365 Finance and
        /// Operations) instance OData endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.url")]
        public object Url { get; set; }

        /// <summary>
        /// Gets or sets specify the application's client ID. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets specify the application's key. Mark this field as a
        /// SecureString to store it securely in Data Factory, or reference a
        /// secret stored in Azure Key Vault. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets specify the tenant information (domain name or tenant
        /// ID) under which your application resides. Retrieve it by hovering
        /// the mouse in the top-right corner of the Azure portal. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tenant")]
        public object Tenant { get; set; }

        /// <summary>
        /// Gets or sets specify the resource you are requesting authorization.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.aadResourceId")]
        public object AadResourceId { get; set; }

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
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
            if (ServicePrincipalId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServicePrincipalId");
            }
            if (ServicePrincipalKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServicePrincipalKey");
            }
            if (Tenant == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tenant");
            }
            if (AadResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AadResourceId");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new DynamicsAXLinkedService(this.Url, this.ServicePrincipalId, this.ServicePrincipalKey, this.Tenant, this.AadResourceId);
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

