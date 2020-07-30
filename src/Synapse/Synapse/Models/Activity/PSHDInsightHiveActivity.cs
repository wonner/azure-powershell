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
    /// HDInsight Hive activity type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HDInsightHive")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSHDInsightHiveActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSHDInsightHiveActivity class.
        /// </summary>
        public PSHDInsightHiveActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets storage linked service references.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.storageLinkedServices")]
        public IList<LinkedServiceReference> StorageLinkedServices { get; set; }

        /// <summary>
        /// Gets or sets user specified arguments to HDInsightActivity.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.arguments")]
        public IList<object> Arguments { get; set; }

        /// <summary>
        /// Gets or sets debug info option. Possible values include: 'None',
        /// 'Always', 'Failure'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.getDebugInfo")]
        public string GetDebugInfo { get; set; }

        /// <summary>
        /// Gets or sets script path. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.scriptPath")]
        public object ScriptPath { get; set; }

        /// <summary>
        /// Gets or sets script linked service reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.scriptLinkedService")]
        public LinkedServiceReference ScriptLinkedService { get; set; }

        /// <summary>
        /// Gets or sets allows user to specify defines for Hive job request.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.defines")]
        public IDictionary<string, object> Defines { get; set; }

        /// <summary>
        /// Gets or sets user specified arguments under hivevar namespace.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.variables")]
        public IList<object> Variables { get; set; }

        /// <summary>
        /// Gets or sets query timeout value (in minutes).  Effective when the
        /// HDInsight cluster is with ESP (Enterprise Security Package)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.queryTimeout")]
        public int? QueryTimeout { get; set; }

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

        public override Activity ToSdkObject()
        {
            var activity = new HDInsightHiveActivity(this.Name);
            foreach (var item in this.StorageLinkedServices)
            {
                activity.StorageLinkedServices.Add(item);
            }
            foreach (var item in this.Arguments)
            {
                activity.Arguments.Add(item);
            }
            activity.GetDebugInfo = this.GetDebugInfo;
            activity.ScriptPath = this.ScriptPath;
            activity.ScriptLinkedService = this.ScriptLinkedService;
            foreach (var item in this.Defines)
            {
                activity.Defines.Add(item);
            }
            foreach (var item in this.Variables)
            {
                activity.Variables.Add(item);
            }
            activity.QueryTimeout = this.QueryTimeout;
            activity.LinkedServiceName = this.LinkedServiceName;
            activity.Policy = this.Policy;
            activity.Description = this.Description;
            IList<PSActivityDependency> pSDependsOn = this.DependsOn;
            if (pSDependsOn != null)
            {
                foreach (PSActivityDependency pSDependOn in pSDependsOn)
                {
                    activity.DependsOn.Add(pSDependOn?.ToSdkObject());
                }
            }
            IList<PSUserProperty> pSUserProperties = this.UserProperties;
            if (pSUserProperties != null)
            {
                foreach (PSUserProperty pSUserProperty in pSUserProperties)
                {
                    activity.UserProperties.Add(pSUserProperty?.ToSdkObject());
                }
            }
            return activity;
        }
    }
}

