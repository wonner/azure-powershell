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
    /// SQL stored procedure activity type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SqlServerStoredProcedure")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSSqlServerStoredProcedureActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PSSqlServerStoredProcedureActivity class.
        /// </summary>
        public PSSqlServerStoredProcedureActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets stored procedure name. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.storedProcedureName")]
        public object StoredProcedureName { get; set; }

        /// <summary>
        /// Gets or sets value and type setting for stored procedure
        /// parameters. Example: "{Parameter1: {value: "1", type: "int"}}".
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.storedProcedureParameters")]
        public IDictionary<string, StoredProcedureParameter> StoredProcedureParameters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (StoredProcedureName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StoredProcedureName");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new SqlServerStoredProcedureActivity(this.Name, this.StoredProcedureName);
            activity.StoredProcedureParameters = this.StoredProcedureParameters;
            activity.LinkedServiceName = this.LinkedServiceName;
            activity.Policy = this.Policy;
            activity.Description = this.Description;
            IList<PSActivityDependency> pSDependsOn = this.DependsOn;
            if (pSDependsOn != null)
            {
                IList<ActivityDependency> dependsOn = new List<ActivityDependency>();
                foreach (PSActivityDependency pSDependOn in pSDependsOn)
                {
                    dependsOn.Add(pSDependOn?.ToSdkObject());
                }
                activity.DependsOn = dependsOn;
            }
            IList<PSUserProperty> pSUserProperties = this.UserProperties;
            if (pSUserProperties != null)
            {
                IList<UserProperty> userProperties = new List<UserProperty>();
                foreach (PSUserProperty pSUserProperty in pSUserProperties)
                {
                    userProperties.Add(pSUserProperty?.ToSdkObject());
                }
                activity.UserProperties = userProperties;
            }
            return activity;
        }
    }
}

