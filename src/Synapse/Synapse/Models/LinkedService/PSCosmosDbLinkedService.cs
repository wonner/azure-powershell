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
    /// Microsoft Azure Cosmos Database (CosmosDB) linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("CosmosDb")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSCosmosDbLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSCosmosDbLinkedService class.
        /// </summary>
        public PSCosmosDbLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the connection string. Type: string, SecureString or
        /// AzureKeyVaultSecretReference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectionString")]
        public object ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the endpoint of the Azure CosmosDB account. Type:
        /// string (or Expression with resultType string)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accountEndpoint")]
        public object AccountEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the name of the database. Type: string (or Expression
        /// with resultType string)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.database")]
        public object Database { get; set; }

        /// <summary>
        /// Gets or sets the account key of the Azure CosmosDB account. Type:
        /// SecureString or AzureKeyVaultSecretReference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accountKey")]
        public SecretBase AccountKey { get; set; }

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
            var linkedService = new CosmosDbLinkedService();
            linkedService.ConnectionString = this.ConnectionString;
            linkedService.AccountEndpoint = this.AccountEndpoint;
            linkedService.Database = this.Database;
            linkedService.AccountKey = this.AccountKey;
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

