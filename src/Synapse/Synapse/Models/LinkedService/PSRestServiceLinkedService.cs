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
    /// Rest Service linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("RestService")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSRestServiceLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSRestServiceLinkedService class.
        /// </summary>
        public PSRestServiceLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the base URL of the REST service.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.url")]
        public object Url { get; set; }

        /// <summary>
        /// Gets or sets whether to validate server side SSL certificate when
        /// connecting to the endpoint.The default value is true. Type: boolean
        /// (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.enableServerCertificateValidation")]
        public object EnableServerCertificateValidation { get; set; }

        /// <summary>
        /// Gets or sets type of authentication used to connect to the REST
        /// service. Possible values include: 'Anonymous', 'Basic',
        /// 'AadServicePrincipal', 'ManagedServiceIdentity'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets the user name used in Basic authentication type.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.userName")]
        public object UserName { get; set; }

        /// <summary>
        /// Gets or sets the password used in Basic authentication type.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets the application's client ID used in
        /// AadServicePrincipal authentication type.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the application's key used in AadServicePrincipal
        /// authentication type.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets the tenant information (domain name or tenant ID) used
        /// in AadServicePrincipal authentication type under which your
        /// application resides.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tenant")]
        public object Tenant { get; set; }

        /// <summary>
        /// Gets or sets the resource you are requesting authorization to use.
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
            if (AuthenticationType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AuthenticationType");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new RestServiceLinkedService(this.Url, this.AuthenticationType);
            linkedService.EnableServerCertificateValidation = this.EnableServerCertificateValidation;
            linkedService.UserName = this.UserName;
            linkedService.Password = this.Password;
            linkedService.ServicePrincipalId = this.ServicePrincipalId;
            linkedService.ServicePrincipalKey = this.ServicePrincipalKey;
            linkedService.Tenant = this.Tenant;
            linkedService.AadResourceId = this.AadResourceId;
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

