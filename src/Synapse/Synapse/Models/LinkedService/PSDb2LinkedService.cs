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
    /// Linked service for DB2 data source.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Db2")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSDb2LinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSDb2LinkedService class.
        /// </summary>
        public PSDb2LinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets server name for connection. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.server")]
        public object Server { get; set; }

        /// <summary>
        /// Gets or sets database name for connection. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.database")]
        public object Database { get; set; }

        /// <summary>
        /// Gets or sets authenticationType to be used for connection. Possible
        /// values include: 'Basic'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets username for authentication. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets password for authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets under where packages are created when querying
        /// database. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.packageCollection")]
        public object PackageCollection { get; set; }

        /// <summary>
        /// Gets or sets certificate Common Name when TLS is enabled. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.certificateCommonName")]
        public object CertificateCommonName { get; set; }

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
            var linkedService = new Db2LinkedService(this.Server, this.Database);
            linkedService.AuthenticationType = this.AuthenticationType;
            linkedService.Username = this.Username;
            linkedService.Password = this.Password;
            linkedService.PackageCollection = this.PackageCollection;
            linkedService.CertificateCommonName = this.CertificateCommonName;
            linkedService.EncryptedCredential = this.EncryptedCredential;
            linkedService.ConnectVia = this.ConnectVia?.ToSdkObject();
            linkedService.Description = this.Description;
            foreach (var item in this.Annotations)
            {
                linkedService.Annotations.Add(item);
            }
            IDictionary<string, PSParameterSpecification> pSParameters = this.Parameters;
            if (pSParameters != null)
            {
                foreach (var pSParameter in pSParameters)
                {
                    linkedService.Parameters.Add(pSParameter.Key, pSParameter.Value?.ToSdkObject());
                }
            }
            return linkedService;
        }
    }
}

