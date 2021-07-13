namespace Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Extensions;

    /// <summary>Disk Pool Sku Details</summary>
    public partial class DiskPoolZoneInfo
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonObject into a new instance of <see cref="DiskPoolZoneInfo" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DiskPoolZoneInfo(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_sku = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonObject>("sku"), out var __jsonSku) ? Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.Sku.FromJson(__jsonSku) : Sku;}
            {_availabilityZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonArray>("availabilityZones"), out var __jsonAvailabilityZones) ? If( __jsonAvailabilityZones as Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : AvailabilityZone;}
            {_additionalCapability = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonArray>("additionalCapabilities"), out var __jsonAdditionalCapabilities) ? If( __jsonAdditionalCapabilities as Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : AdditionalCapability;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolZoneInfo.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolZoneInfo.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolZoneInfo FromJson(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonObject json ? new DiskPoolZoneInfo(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DiskPoolZoneInfo" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DiskPoolZoneInfo" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._sku ? (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonNode) this._sku.ToJson(null,serializationMode) : null, "sku" ,container.Add );
            if (null != this._availabilityZone)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.XNodeArray();
                foreach( var __x in this._availabilityZone )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("availabilityZones",__w);
            }
            if (null != this._additionalCapability)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.XNodeArray();
                foreach( var __s in this._additionalCapability )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("additionalCapabilities",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}