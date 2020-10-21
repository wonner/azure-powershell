// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    public partial struct FailoverDeploymentModel :
        System.IEquatable<FailoverDeploymentModel>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.FailoverDeploymentModel Classic = @"Classic";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.FailoverDeploymentModel NotApplicable = @"NotApplicable";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.FailoverDeploymentModel ResourceManager = @"ResourceManager";

        /// <summary>the value for an instance of the <see cref="FailoverDeploymentModel" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to FailoverDeploymentModel</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FailoverDeploymentModel" />.</param>
        internal static object CreateFrom(object value)
        {
            return new FailoverDeploymentModel(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type FailoverDeploymentModel</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.FailoverDeploymentModel e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type FailoverDeploymentModel (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is FailoverDeploymentModel && Equals((FailoverDeploymentModel)obj);
        }

        /// <summary>Creates an instance of the <see cref="FailoverDeploymentModel" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private FailoverDeploymentModel(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum FailoverDeploymentModel</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for FailoverDeploymentModel</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to FailoverDeploymentModel</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FailoverDeploymentModel" />.</param>

        public static implicit operator FailoverDeploymentModel(string value)
        {
            return new FailoverDeploymentModel(value);
        }

        /// <summary>Implicit operator to convert FailoverDeploymentModel to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="FailoverDeploymentModel" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.FailoverDeploymentModel e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum FailoverDeploymentModel</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.FailoverDeploymentModel e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.FailoverDeploymentModel e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum FailoverDeploymentModel</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.FailoverDeploymentModel e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.FailoverDeploymentModel e2)
        {
            return e2.Equals(e1);
        }
    }
}