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
    /// Azure Data Explorer command activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureDataExplorerCommand")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSAzureDataExplorerCommandActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PSAzureDataExplorerCommandActivity class.
        /// </summary>
        public PSAzureDataExplorerCommandActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a control command, according to the Azure Data
        /// Explorer command syntax. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.command")]
        public object Command { get; set; }

        /// <summary>
        /// Gets or sets control command timeout. Type: string (or Expression
        /// with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9]))..)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.commandTimeout")]
        public object CommandTimeout { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Command == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Command");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new AzureDataExplorerCommandActivity(this.Name, this.Command);
            activity.CommandTimeout = this.CommandTimeout;
            activity.LinkedServiceName = this.LinkedServiceName;
            activity.Policy = this.Policy.ToSdkObject();
            SetProperties(activity);
            return activity;
        }
    }
}

