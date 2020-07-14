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
    /// Execute SSIS package activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ExecuteSSISPackage")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSExecuteSsisPackageActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSExecuteSSISPackageActivity
        /// class.
        /// </summary>
        public PSExecuteSsisPackageActivity(string referenceName)
        {
            ConnectVia = new IntegrationRuntimeReference(referenceName);
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SSIS package location.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.packageLocation")]
        public SsisPackageLocation PackageLocation { get; set; }

        /// <summary>
        /// Gets or sets specifies the runtime to execute SSIS package. The
        /// value should be "x86" or "x64". Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.runtime")]
        public object Runtime { get; set; }

        /// <summary>
        /// Gets or sets the logging level of SSIS package execution. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.loggingLevel")]
        public object LoggingLevel { get; set; }

        /// <summary>
        /// Gets or sets the environment path to execute the SSIS package.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.environmentPath")]
        public object EnvironmentPath { get; set; }

        /// <summary>
        /// Gets or sets the package execution credential.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.executionCredential")]
        public SsisExecutionCredential ExecutionCredential { get; set; }

        /// <summary>
        /// Gets or sets the integration runtime reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectVia")]
        public IntegrationRuntimeReference ConnectVia { get; set; }

        /// <summary>
        /// Gets or sets the project level parameters to execute the SSIS
        /// package.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.projectParameters")]
        public IDictionary<string, SsisExecutionParameter> ProjectParameters { get; set; }

        /// <summary>
        /// Gets or sets the package level parameters to execute the SSIS
        /// package.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.packageParameters")]
        public IDictionary<string, SsisExecutionParameter> PackageParameters { get; set; }

        /// <summary>
        /// Gets or sets the project level connection managers to execute the
        /// SSIS package.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.projectConnectionManagers")]
        public IDictionary<string, IDictionary<string, SsisExecutionParameter>> ProjectConnectionManagers { get; set; }

        /// <summary>
        /// Gets or sets the package level connection managers to execute the
        /// SSIS package.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.packageConnectionManagers")]
        public IDictionary<string, IDictionary<string, SsisExecutionParameter>> PackageConnectionManagers { get; set; }

        /// <summary>
        /// Gets or sets the property overrides to execute the SSIS package.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.propertyOverrides")]
        public IDictionary<string, SsisPropertyOverride> PropertyOverrides { get; set; }

        /// <summary>
        /// Gets or sets SSIS package execution log location.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.logLocation")]
        public SsisLogLocation LogLocation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (PackageLocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PackageLocation");
            }
            if (ConnectVia == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectVia");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new ExecuteSsisPackageActivity(this.Name, this.PackageLocation, this.ConnectVia);
            activity.Runtime = this.Runtime;
            activity.LoggingLevel = this.LoggingLevel;
            activity.EnvironmentPath = this.EnvironmentPath;
            activity.ExecutionCredential = this.ExecutionCredential;
            activity.ProjectParameters = this.ProjectParameters;
            activity.PackageParameters = this.PackageParameters;
            activity.ProjectConnectionManagers = (IDictionary<string, object>)this.ProjectConnectionManagers;
            activity.PackageConnectionManagers = (IDictionary<string, object>)this.PackageConnectionManagers;
            activity.PropertyOverrides = this.PropertyOverrides;
            activity.LogLocation = this.LogLocation;
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

