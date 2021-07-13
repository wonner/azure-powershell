// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support
{

    /// <summary>Language extension that can run within KQL query.</summary>
    public partial struct LanguageExtensionName :
        System.IEquatable<LanguageExtensionName>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.LanguageExtensionName Python = @"PYTHON";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.LanguageExtensionName R = @"R";

        /// <summary>the value for an instance of the <see cref="LanguageExtensionName" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to LanguageExtensionName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LanguageExtensionName" />.</param>
        internal static object CreateFrom(object value)
        {
            return new LanguageExtensionName(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type LanguageExtensionName</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.LanguageExtensionName e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type LanguageExtensionName (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is LanguageExtensionName && Equals((LanguageExtensionName)obj);
        }

        /// <summary>Returns hashCode for enum LanguageExtensionName</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="LanguageExtensionName" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private LanguageExtensionName(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for LanguageExtensionName</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to LanguageExtensionName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LanguageExtensionName" />.</param>

        public static implicit operator LanguageExtensionName(string value)
        {
            return new LanguageExtensionName(value);
        }

        /// <summary>Implicit operator to convert LanguageExtensionName to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="LanguageExtensionName" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.LanguageExtensionName e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum LanguageExtensionName</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.LanguageExtensionName e1, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.LanguageExtensionName e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum LanguageExtensionName</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.LanguageExtensionName e1, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.LanguageExtensionName e2)
        {
            return e2.Equals(e1);
        }
    }
}