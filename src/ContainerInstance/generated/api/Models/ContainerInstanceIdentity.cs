// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Extensions;

    public partial class ContainerInstanceIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.IContainerInstanceIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.IContainerInstanceIdentityInternal
    {

        /// <summary>Backing field for <see cref="ContainerGroupName" /> property.</summary>
        private string _containerGroupName;

        /// <summary>The name of the container group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string ContainerGroupName { get => this._containerGroupName; set => this._containerGroupName = value; }

        /// <summary>Backing field for <see cref="ContainerName" /> property.</summary>
        private string _containerName;

        /// <summary>The name of the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string ContainerName { get => this._containerName; set => this._containerName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The identifier for the physical azure location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>
        /// Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI
        /// for every service call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="ContainerInstanceIdentity" /> instance.</summary>
        public ContainerInstanceIdentity()
        {

        }
    }
    public partial interface IContainerInstanceIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.IJsonSerializable
    {
        /// <summary>The name of the container group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the container group.",
        SerializedName = @"containerGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ContainerGroupName { get; set; }
        /// <summary>The name of the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the container instance.",
        SerializedName = @"containerName",
        PossibleTypes = new [] { typeof(string) })]
        string ContainerName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The identifier for the physical azure location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identifier for the physical azure location.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The name of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the resource group.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>
        /// Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI
        /// for every service call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface IContainerInstanceIdentityInternal

    {
        /// <summary>The name of the container group.</summary>
        string ContainerGroupName { get; set; }
        /// <summary>The name of the container instance.</summary>
        string ContainerName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The identifier for the physical azure location.</summary>
        string Location { get; set; }
        /// <summary>The name of the resource group.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>
        /// Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI
        /// for every service call.
        /// </summary>
        string SubscriptionId { get; set; }

    }
}