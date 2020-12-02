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
    /// DatabricksSparkPython activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DatabricksSparkPython")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSDatabricksSparkPythonActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSDatabricksSparkPythonActivity
        /// class.
        /// </summary>
        public PSDatabricksSparkPythonActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URI of the Python file to be executed. DBFS paths
        /// are supported. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.pythonFile")]
        public object PythonFile { get; set; }

        /// <summary>
        /// Gets or sets command line parameters that will be passed to the
        /// Python file.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.parameters")]
        public IList<object> Parameters { get; set; }

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
            if (PythonFile == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PythonFile");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new DatabricksSparkPythonActivity(this.Name, this.PythonFile);
            this.Parameters?.ForEach(item => activity.Parameters.Add(item));
            this.Libraries?.ForEach(item => activity.Libraries.Add(item));
            activity.LinkedServiceName = this.LinkedServiceName;
            activity.Policy = this.Policy?.ToSdkObject();
            SetProperties(activity);
            return activity;
        }
    }
}

