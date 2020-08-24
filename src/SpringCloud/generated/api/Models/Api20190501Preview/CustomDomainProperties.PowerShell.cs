namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.PowerShell;

    /// <summary>Custom domain of app resource payload.</summary>
    [System.ComponentModel.TypeConverter(typeof(CustomDomainPropertiesTypeConverter))]
    public partial class CustomDomainProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.CustomDomainProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CustomDomainProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainPropertiesInternal)this).AppName = (string) content.GetValueForProperty("AppName",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainPropertiesInternal)this).AppName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainPropertiesInternal)this).CertName = (string) content.GetValueForProperty("CertName",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainPropertiesInternal)this).CertName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainPropertiesInternal)this).Thumbprint = (string) content.GetValueForProperty("Thumbprint",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainPropertiesInternal)this).Thumbprint, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.CustomDomainProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CustomDomainProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainPropertiesInternal)this).AppName = (string) content.GetValueForProperty("AppName",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainPropertiesInternal)this).AppName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainPropertiesInternal)this).CertName = (string) content.GetValueForProperty("CertName",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainPropertiesInternal)this).CertName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainPropertiesInternal)this).Thumbprint = (string) content.GetValueForProperty("Thumbprint",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainPropertiesInternal)this).Thumbprint, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.CustomDomainProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CustomDomainProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.CustomDomainProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CustomDomainProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CustomDomainProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.ICustomDomainProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Custom domain of app resource payload.
    [System.ComponentModel.TypeConverter(typeof(CustomDomainPropertiesTypeConverter))]
    public partial interface ICustomDomainProperties

    {

    }
}