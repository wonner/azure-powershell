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
    /// Phoenix server linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Phoenix")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSPhoenixLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSPhoenixLinkedService class.
        /// </summary>
        public PSPhoenixLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the IP address or host name of the Phoenix server.
        /// (i.e. 192.168.222.160)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.host")]
        public object Host { get; set; }

        /// <summary>
        /// Gets or sets the TCP port that the Phoenix server uses to listen
        /// for client connections. The default value is 8765.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.port")]
        public object Port { get; set; }

        /// <summary>
        /// Gets or sets the partial URL corresponding to the Phoenix server.
        /// (i.e. /gateway/sandbox/phoenix/version). The default value is
        /// hbasephoenix if using WindowsAzureHDInsightService.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.httpPath")]
        public object HttpPath { get; set; }

        /// <summary>
        /// Gets or sets the authentication mechanism used to connect to the
        /// Phoenix server. Possible values include: 'Anonymous',
        /// 'UsernameAndPassword', 'WindowsAzureHDInsightService'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets the user name used to connect to the Phoenix server.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets the password corresponding to the user name.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the connections to the server are
        /// encrypted using SSL. The default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.enableSsl")]
        public object EnableSsl { get; set; }

        /// <summary>
        /// Gets or sets the full path of the .pem file containing trusted CA
        /// certificates for verifying the server when connecting over SSL.
        /// This property can only be set when using SSL on self-hosted IR. The
        /// default value is the cacerts.pem file installed with the IR.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.trustedCertPath")]
        public object TrustedCertPath { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to use a CA certificate from the
        /// system trust store or from a specified PEM file. The default value
        /// is false.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useSystemTrustStore")]
        public object UseSystemTrustStore { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to require a CA-issued SSL
        /// certificate name to match the host name of the server when
        /// connecting over SSL. The default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.allowHostNameCNMismatch")]
        public object AllowHostNameCNMismatch { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to allow self-signed certificates
        /// from the server. The default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.allowSelfSignedServerCert")]
        public object AllowSelfSignedServerCert { get; set; }

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
            if (Host == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Host");
            }
            if (AuthenticationType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AuthenticationType");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new PhoenixLinkedService(this.Host, this.AuthenticationType);
            linkedService.Port = this.Port;
            linkedService.HttpPath = this.HttpPath;
            linkedService.Username = this.Username;
            linkedService.Password = this.Password;
            linkedService.EnableSsl = this.EnableSsl;
            linkedService.TrustedCertPath = this.TrustedCertPath;
            linkedService.UseSystemTrustStore = this.UseSystemTrustStore;
            linkedService.AllowHostNameCNMismatch = this.AllowHostNameCNMismatch;
            linkedService.AllowSelfSignedServerCert = this.AllowSelfSignedServerCert;
            linkedService.EncryptedCredential = this.EncryptedCredential;
            linkedService.ConnectVia = this.ConnectVia?.ToSdkObject();
            linkedService.Description = this.Description;
            return linkedService;
        }
    }
}

