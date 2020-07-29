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
    /// The azure blob storage linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureBlobStorage")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSAzureBlobStorageLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSAzureBlobStorageLinkedService
        /// class.
        /// </summary>
        public PSAzureBlobStorageLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the connection string. It is mutually exclusive with
        /// sasUri, serviceEndpoint property. Type: string, SecureString or
        /// AzureKeyVaultSecretReference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectionString")]
        public object ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the Azure key vault secret reference of accountKey in
        /// connection string.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accountKey")]
        public AzureKeyVaultSecretReference AccountKey { get; set; }

        /// <summary>
        /// Gets or sets SAS URI of the Azure Blob Storage resource. It is
        /// mutually exclusive with connectionString, serviceEndpoint property.
        /// Type: string, SecureString or AzureKeyVaultSecretReference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sasUri")]
        public object SasUri { get; set; }

        /// <summary>
        /// Gets or sets the Azure key vault secret reference of sasToken in
        /// sas uri.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sasToken")]
        public AzureKeyVaultSecretReference SasToken { get; set; }

        /// <summary>
        /// Gets or sets blob service endpoint of the Azure Blob Storage
        /// resource. It is mutually exclusive with connectionString, sasUri
        /// property.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.serviceEndpoint")]
        public string ServiceEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the ID of the service principal used to authenticate
        /// against Azure SQL Data Warehouse. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the key of the service principal used to authenticate
        /// against Azure SQL Data Warehouse.
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
        public string EncryptedCredential { get; set; }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new AzureBlobStorageLinkedService();
            linkedService.ConnectionString = this.ConnectionString;
            linkedService.AccountKey = this.AccountKey;
            linkedService.SasUri = this.SasUri;
            linkedService.SasToken = this.SasToken;
            linkedService.ServiceEndpoint = this.ServiceEndpoint;
            linkedService.ServicePrincipalId = this.ServicePrincipalId;
            linkedService.ServicePrincipalKey = this.ServicePrincipalKey;
            linkedService.Tenant = this.Tenant;
            linkedService.EncryptedCredential = this.EncryptedCredential;
            linkedService.ConnectVia = this.ConnectVia?.ToSdkObject();
            linkedService.Description = this.Description;
            return linkedService;
        }
    }
}

