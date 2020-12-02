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
    using Microsoft.WindowsAzure.Commands.Utilities.Common;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// HDInsight streaming activity type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HDInsightStreaming")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSHDInsightStreamingActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSHDInsightStreamingActivity
        /// class.
        /// </summary>
        public PSHDInsightStreamingActivity()
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
        /// Gets or sets mapper executable name. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mapper")]
        public object Mapper { get; set; }

        /// <summary>
        /// Gets or sets reducer executable name. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.reducer")]
        public object Reducer { get; set; }

        /// <summary>
        /// Gets or sets input blob path. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.input")]
        public object Input { get; set; }

        /// <summary>
        /// Gets or sets output blob path. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.output")]
        public object Output { get; set; }

        /// <summary>
        /// Gets or sets paths to streaming job files. Can be directories.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.filePaths")]
        public IList<object> FilePaths { get; set; }

        /// <summary>
        /// Gets or sets linked service reference where the files are located.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.fileLinkedService")]
        public LinkedServiceReference FileLinkedService { get; set; }

        /// <summary>
        /// Gets or sets combiner executable name. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.combiner")]
        public object Combiner { get; set; }

        /// <summary>
        /// Gets or sets command line environment values.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.commandEnvironment")]
        public IList<object> CommandEnvironment { get; set; }

        /// <summary>
        /// Gets or sets allows user to specify defines for streaming job
        /// request.
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
            if (Mapper == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Mapper");
            }
            if (Reducer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Reducer");
            }
            if (Input == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Input");
            }
            if (Output == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Output");
            }
            if (FilePaths == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FilePaths");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new HDInsightStreamingActivity(this.Name, this.Mapper, this.Reducer, this.Input, this.Output, this.FilePaths);
            this.StorageLinkedServices?.ForEach(item => activity.StorageLinkedServices.Add(item));
            this.Arguments?.ForEach(item => activity.Arguments.Add(item));
            activity.GetDebugInfo = this.GetDebugInfo;
            activity.FileLinkedService = this.FileLinkedService;
            activity.Combiner = this.Combiner;
            this.CommandEnvironment?.ForEach(item => activity.CommandEnvironment.Add(item));
            this.Defines?.ForEach(item => activity.Defines.Add(item));
            activity.LinkedServiceName = this.LinkedServiceName;
            activity.Policy = this.Policy?.ToSdkObject();
            SetProperties(activity);
            return activity;
        }
    }
}

