// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Helpers.Storage.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Storage Account ManagementPolicies Rules. See more details in:
    /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
    /// </summary>
    public partial class ManagementPolicySchema
    {
        /// <summary>
        /// Initializes a new instance of the ManagementPolicySchema class.
        /// </summary>
        public ManagementPolicySchema()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagementPolicySchema class.
        /// </summary>
        /// <param name="rules">The Storage Account ManagementPolicies Rules.
        /// See more details in:
        /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.</param>
        public ManagementPolicySchema(IList<ManagementPolicyRule> rules)
        {
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Storage Account ManagementPolicies Rules. See more
        /// details in:
        /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<ManagementPolicyRule> Rules { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Rules == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Rules");
            }
            if (Rules != null)
            {
                foreach (var element in Rules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
