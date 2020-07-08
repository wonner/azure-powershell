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
    /// Linked service for Amazon Redshift.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AmazonRedshift")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSAmazonRedshiftLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSAmazonRedshiftLinkedService
        /// class.
        /// </summary>
        public PSAmazonRedshiftLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Amazon Redshift server. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.server")]
        public object Server { get; set; }

        /// <summary>
        /// Gets or sets the username of the Amazon Redshift source. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets the password of the Amazon Redshift source.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets the database name of the Amazon Redshift source. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.database")]
        public object Database { get; set; }

        /// <summary>
        /// Gets or sets the TCP port number that the Amazon Redshift server
        /// uses to listen for client connections. The default value is 5439.
        /// Type: integer (or Expression with resultType integer).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.port")]
        public object Port { get; set; }

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
            if (Server == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Server");
            }
            if (Database == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Database");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new AmazonRedshiftLinkedService(this.Server, this.Database);
            linkedService.Username = this.Username;
            linkedService.Password = this.Password;
            linkedService.Port = this.Port;
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

