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
    /// HDInsight Pig activity type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HDInsightPig")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSHDInsightPigActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSHDInsightPigActivity class.
        /// </summary>
        public PSHDInsightPigActivity()
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
        /// Gets or sets user specified arguments to HDInsightActivity. Type:
        /// array (or Expression with resultType array).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.arguments")]
        public object Arguments { get; set; }

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
        /// Gets or sets allows user to specify defines for Pig job request.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.defines")]
        public IDictionary<string, object> Defines { get; set; }

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
            var activity = new HDInsightPigActivity(this.Name);
            foreach (var item in this.StorageLinkedServices)
            {
                activity.StorageLinkedServices.Add(item);
            }
            activity.Arguments = this.Arguments;
            activity.GetDebugInfo = this.GetDebugInfo;
            activity.ScriptPath = this.ScriptPath;
            activity.ScriptLinkedService = this.ScriptLinkedService;
            foreach (var item in this.Defines)
            {
                activity.Defines.Add(item);
            }
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

