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
    /// DatabricksNotebook activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DatabricksNotebook")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSDatabricksNotebookActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSDatabricksNotebookActivity
        /// class.
        /// </summary>
        public PSDatabricksNotebookActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the absolute path of the notebook to be run in the
        /// Databricks Workspace. This path must begin with a slash. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.notebookPath")]
        public object NotebookPath { get; set; }

        /// <summary>
        /// Gets or sets base parameters to be used for each run of this job.If
        /// the notebook takes a parameter that is not specified, the default
        /// value from the notebook will be used.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.baseParameters")]
        public IDictionary<string, object> BaseParameters { get; set; }

        /// <summary>
        /// Gets or sets a list of libraries to be installed on the cluster
        /// that will execute the job.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.libraries")]
        public IList<IDictionary<string, object>> Libraries { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (NotebookPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NotebookPath");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new DatabricksNotebookActivity(this.Name, this.NotebookPath);
            this.BaseParameters?.ForEach(item => activity.BaseParameters.Add(item));
            this.Libraries?.ForEach(item => activity.Libraries.Add(item));
            activity.LinkedServiceName = this.LinkedServiceName;
            activity.Policy = this.Policy.ToSdkObject();
            SetProperties(activity);
            return activity;
        }
    }
}

