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
    /// Vertica linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Vertica")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSVerticaLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSVerticaLinkedService class.
        /// </summary>
        public PSVerticaLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an ODBC connection string. Type: string, SecureString
        /// or AzureKeyVaultSecretReference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectionString")]
        public object ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the Azure key vault secret reference of password in
        /// connection string.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.pwd")]
        public AzureKeyVaultSecretReference Pwd { get; set; }

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
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new VerticaLinkedService();
            linkedService.ConnectionString = this.ConnectionString;
            linkedService.Pwd = this.Pwd;
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

