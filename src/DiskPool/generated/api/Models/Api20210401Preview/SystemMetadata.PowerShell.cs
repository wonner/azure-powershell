namespace Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.PowerShell;

    /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemMetadataTypeConverter))]
    public partial class SystemMetadata
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.SystemMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadata" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadata DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemMetadata(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.SystemMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadata" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadata DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SystemMetadata(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemMetadata" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadata FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.SystemMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemMetadata(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).CreatedBy = (string) content.GetValueForProperty("CreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).CreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).CreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType?) content.GetValueForProperty("CreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).CreatedByType, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).LastModifiedBy = (string) content.GetValueForProperty("LastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).LastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).LastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType?) content.GetValueForProperty("LastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).LastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).LastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("LastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).LastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.SystemMetadata"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SystemMetadata(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).CreatedBy = (string) content.GetValueForProperty("CreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).CreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).CreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType?) content.GetValueForProperty("CreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).CreatedByType, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).LastModifiedBy = (string) content.GetValueForProperty("LastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).LastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).LastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType?) content.GetValueForProperty("LastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).LastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).LastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("LastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadataInternal)this).LastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Metadata pertaining to creation and last modification of the resource.
    [System.ComponentModel.TypeConverter(typeof(SystemMetadataTypeConverter))]
    public partial interface ISystemMetadata

    {

    }
}