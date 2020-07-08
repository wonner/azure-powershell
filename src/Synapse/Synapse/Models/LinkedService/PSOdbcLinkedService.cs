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
    /// Open Database Connectivity (ODBC) linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Odbc")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSOdbcLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSOdbcLinkedService class.
        /// </summary>
        public PSOdbcLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the non-access credential portion of the connection
        /// string as well as an optional encrypted credential. Type: string,
        /// SecureString or AzureKeyVaultSecretReference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectionString")]
        public object ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets type of authentication used to connect to the ODBC
        /// data store. Possible values are: Anonymous and Basic. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public object AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets the access credential portion of the connection string
        /// specified in driver-specific property-value format.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.credential")]
        public SecretBase Credential { get; set; }

        /// <summary>
        /// Gets or sets user name for Basic authentication. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.userName")]
        public object UserName { get; set; }

        /// <summary>
        /// Gets or sets password for Basic authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

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
            if (ConnectionString == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionString");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new OdbcLinkedService(this.ConnectionString);
            linkedService.AuthenticationType = this.AuthenticationType;
            linkedService.Credential = this.Credential;
            linkedService.UserName = this.UserName;
            linkedService.Password = this.Password;
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

