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
    /// Zoho server linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Zoho")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSZohoLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSZohoLinkedService class.
        /// </summary>
        public PSZohoLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the endpoint of the Zoho server. (i.e.
        /// crm.zoho.com/crm/private)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.endpoint")]
        public object Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the access token for Zoho authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accessToken")]
        public SecretBase AccessToken { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the data source endpoints are
        /// encrypted using HTTPS. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useEncryptedEndpoints")]
        public object UseEncryptedEndpoints { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to require the host name in the
        /// server's certificate to match the host name of the server when
        /// connecting over SSL. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useHostVerification")]
        public object UseHostVerification { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to verify the identity of the server
        /// when connecting over SSL. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.usePeerVerification")]
        public object UsePeerVerification { get; set; }

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
            if (Endpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Endpoint");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new ZohoLinkedService(this.Endpoint);
            linkedService.AccessToken = this.AccessToken;
            linkedService.UseEncryptedEndpoints = this.UseEncryptedEndpoints;
            linkedService.UseHostVerification = this.UseHostVerification;
            linkedService.UsePeerVerification = this.UsePeerVerification;
            linkedService.EncryptedCredential = this.EncryptedCredential;
            linkedService.ConnectVia = this.ConnectVia?.ToSdkObject();
            linkedService.Description = this.Description;
            return linkedService;
        }
    }
}

