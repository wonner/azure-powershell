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
    /// Linked service for an HTTP source.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HttpServer")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSHttpLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSHttpLinkedService class.
        /// </summary>
        public PSHttpLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the base URL of the HTTP endpoint, e.g.
        /// http://www.microsoft.com. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.url")]
        public object Url { get; set; }

        /// <summary>
        /// Gets or sets the authentication type to be used to connect to the
        /// HTTP server. Possible values include: 'Basic', 'Anonymous',
        /// 'Digest', 'Windows', 'ClientCertificate'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets user name for Basic, Digest, or Windows
        /// authentication. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.userName")]
        public object UserName { get; set; }

        /// <summary>
        /// Gets or sets password for Basic, Digest, Windows, or
        /// ClientCertificate with EmbeddedCertData authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets base64 encoded certificate data for ClientCertificate
        /// authentication. For on-premises copy with ClientCertificate
        /// authentication, either CertThumbprint or EmbeddedCertData/Password
        /// should be specified. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.embeddedCertData")]
        public object EmbeddedCertData { get; set; }

        /// <summary>
        /// Gets or sets thumbprint of certificate for ClientCertificate
        /// authentication. Only valid for on-premises copy. For on-premises
        /// copy with ClientCertificate authentication, either CertThumbprint
        /// or EmbeddedCertData/Password should be specified. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.certThumbprint")]
        public object CertThumbprint { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Gets or sets if true, validate the HTTPS server SSL certificate.
        /// Default value is true. Type: boolean (or Expression with resultType
        /// boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.enableServerCertificateValidation")]
        public object EnableServerCertificateValidation { get; set; }

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

        public override LinkedService ToSdkObject()
        {
            var linkedService = new HttpLinkedService(this.Url);
            linkedService.AuthenticationType = this.AuthenticationType;
            linkedService.UserName = this.UserName;
            linkedService.Password = this.Password;
            linkedService.EmbeddedCertData = this.EmbeddedCertData;
            linkedService.CertThumbprint = this.CertThumbprint;
            linkedService.EncryptedCredential = this.EncryptedCredential;
            linkedService.EnableServerCertificateValidation = this.EnableServerCertificateValidation;
            linkedService.ConnectVia = this.ConnectVia?.ToSdkObject();
            linkedService.Description = this.Description;
            return linkedService;
        }
    }
}

