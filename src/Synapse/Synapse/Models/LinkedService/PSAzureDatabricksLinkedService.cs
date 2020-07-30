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
    /// Azure Databricks linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureDatabricks")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSAzureDatabricksLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSAzureDatabricksLinkedService
        /// class.
        /// </summary>
        public PSAzureDatabricksLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets &amp;lt;REGION&amp;gt;.azuredatabricks.net, domain
        /// name of your Databricks deployment. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.domain")]
        public object Domain { get; set; }

        /// <summary>
        /// Gets or sets access token for databricks REST API. Refer to
        /// https://docs.azuredatabricks.net/api/latest/authentication.html.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accessToken")]
        public SecretBase AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the id of an existing interactive cluster that will be
        /// used for all runs of this activity. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.existingClusterId")]
        public object ExistingClusterId { get; set; }

        /// <summary>
        /// Gets or sets the id of an existing instance pool that will be used
        /// for all runs of this activity. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.instancePoolId")]
        public object InstancePoolId { get; set; }

        /// <summary>
        /// Gets or sets if not using an existing interactive cluster, this
        /// specifies the Spark version of a new job cluster or instance pool
        /// nodes created for each run of this activity. Required if
        /// instancePoolId is specified. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterVersion")]
        public object NewClusterVersion { get; set; }

        /// <summary>
        /// Gets or sets if not using an existing interactive cluster, this
        /// specifies the number of worker nodes to use for the new job cluster
        /// or instance pool. For new job clusters, this a string-formatted
        /// Int32, like '1' means numOfWorker is 1 or '1:10' means auto-scale
        /// from 1 (min) to 10 (max). For instance pools, this is a
        /// string-formatted Int32, and can only specify a fixed number of
        /// worker nodes, such as '2'. Required if newClusterVersion is
        /// specified. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterNumOfWorker")]
        public object NewClusterNumOfWorker { get; set; }

        /// <summary>
        /// Gets or sets the node type of the new job cluster. This property is
        /// required if newClusterVersion is specified and instancePoolId is
        /// not specified. If instancePoolId is specified, this property is
        /// ignored. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterNodeType")]
        public object NewClusterNodeType { get; set; }

        /// <summary>
        /// Gets or sets a set of optional, user-specified Spark configuration
        /// key-value pairs.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterSparkConf")]
        public IDictionary<string, object> NewClusterSparkConf { get; set; }

        /// <summary>
        /// Gets or sets a set of optional, user-specified Spark environment
        /// variables key-value pairs.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterSparkEnvVars")]
        public IDictionary<string, object> NewClusterSparkEnvVars { get; set; }

        /// <summary>
        /// Gets or sets additional tags for cluster resources. This property
        /// is ignored in instance pool configurations.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterCustomTags")]
        public IDictionary<string, object> NewClusterCustomTags { get; set; }

        /// <summary>
        /// Gets or sets the driver node type for the new job cluster. This
        /// property is ignored in instance pool configurations. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterDriverNodeType")]
        public object NewClusterDriverNodeType { get; set; }

        /// <summary>
        /// Gets or sets user-defined initialization scripts for the new
        /// cluster. Type: array of strings (or Expression with resultType
        /// array of strings).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterInitScripts")]
        public object NewClusterInitScripts { get; set; }

        /// <summary>
        /// Gets or sets enable the elastic disk on the new cluster. This
        /// property is now ignored, and takes the default elastic disk
        /// behavior in Databricks (elastic disks are always enabled). Type:
        /// boolean (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.newClusterEnableElasticDisk")]
        public object NewClusterEnableElasticDisk { get; set; }

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
            if (Domain == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Domain");
            }
            if (AccessToken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccessToken");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new AzureDatabricksLinkedService(this.Domain, this.AccessToken);
            linkedService.ExistingClusterId = this.ExistingClusterId;
            linkedService.InstancePoolId = this.InstancePoolId;
            linkedService.NewClusterVersion = this.NewClusterVersion;
            linkedService.NewClusterNumOfWorker = this.NewClusterNumOfWorker;
            linkedService.NewClusterNodeType = this.NewClusterNodeType;
            foreach (var item in this.NewClusterSparkConf)
            {
                linkedService.NewClusterSparkConf.Add(item);
            }
            foreach (var item in this.NewClusterSparkEnvVars)
            {
                linkedService.NewClusterSparkEnvVars.Add(item);
            }
            foreach (var item in this.NewClusterCustomTags)
            {
                linkedService.NewClusterCustomTags.Add(item);
            }
            linkedService.NewClusterDriverNodeType = this.NewClusterDriverNodeType;
            linkedService.NewClusterInitScripts = this.NewClusterInitScripts;
            linkedService.NewClusterEnableElasticDisk = this.NewClusterEnableElasticDisk;
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

