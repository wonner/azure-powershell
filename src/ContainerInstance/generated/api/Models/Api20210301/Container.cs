namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Extensions;

    /// <summary>A container instance.</summary>
    public partial class Container :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainer,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal
    {

        /// <summary>The commands to execute within the container instance in exec form.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string[] Command { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).Command; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).Command = value ?? null /* arrayOf */; }

        /// <summary>The state of the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string CurrentState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentState; }

        /// <summary>The human-readable status of the container instance state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string CurrentStateDetailStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentStateDetailStatus; }

        /// <summary>
        /// The container instance exit codes correspond to those from the `docker run` command.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? CurrentStateExitCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentStateExitCode; }

        /// <summary>The date-time when the container instance state finished.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public global::System.DateTime? CurrentStateFinishTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentStateFinishTime; }

        /// <summary>The date-time when the container instance state started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public global::System.DateTime? CurrentStateStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentStateStartTime; }

        /// <summary>The environment variables to set in the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IEnvironmentVariable[] EnvironmentVariable { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).EnvironmentVariable; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).EnvironmentVariable = value ?? null /* arrayOf */; }

        /// <summary>The name of the image used to create the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string Image { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).Image; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).Image = value ; }

        /// <summary>The events of the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IEvent[] InstanceViewEvent { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).InstanceViewEvent; }

        /// <summary>The number of times that the container instance has been restarted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? InstanceViewRestartCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).InstanceViewRestartCount; }

        /// <summary>The CPU limit of this container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public double? LimitCpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LimitCpu; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LimitCpu = value ?? default(double); }

        /// <summary>The memory limit in GB of this container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public double? LimitMemoryInGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LimitMemoryInGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LimitMemoryInGb = value ?? default(double); }

        /// <summary>The count of the GPU resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? LimitsGpuCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LimitsGpuCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LimitsGpuCount = value ?? default(int); }

        /// <summary>The SKU of the GPU resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.GpuSku? LimitsGpuSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LimitsGpuSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LimitsGpuSku = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.GpuSku)""); }

        /// <summary>The commands to execute within the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string[] LivenessProbeExecCommand { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeExecCommand; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeExecCommand = value ?? null /* arrayOf */; }

        /// <summary>The failure threshold.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? LivenessProbeFailureThreshold { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeFailureThreshold; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeFailureThreshold = value ?? default(int); }

        /// <summary>The header name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string LivenessProbeHttpGetHttpHeadersName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeHttpGetHttpHeadersName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeHttpGetHttpHeadersName = value ?? null; }

        /// <summary>The header value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string LivenessProbeHttpGetHttpHeadersValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeHttpGetHttpHeadersValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeHttpGetHttpHeadersValue = value ?? null; }

        /// <summary>The path to probe.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string LivenessProbeHttpGetPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeHttpGetPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeHttpGetPath = value ?? null; }

        /// <summary>The port number to probe.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? LivenessProbeHttpGetPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeHttpGetPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeHttpGetPort = value ?? default(int); }

        /// <summary>The scheme.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.Scheme? LivenessProbeHttpGetScheme { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeHttpGetScheme; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeHttpGetScheme = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.Scheme)""); }

        /// <summary>The initial delay seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? LivenessProbeInitialDelaySecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeInitialDelaySecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeInitialDelaySecond = value ?? default(int); }

        /// <summary>The period seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? LivenessProbePeriodSecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbePeriodSecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbePeriodSecond = value ?? default(int); }

        /// <summary>The success threshold.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? LivenessProbeSuccessThreshold { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeSuccessThreshold; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeSuccessThreshold = value ?? default(int); }

        /// <summary>The timeout seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? LivenessProbeTimeoutSecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeTimeoutSecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeTimeoutSecond = value ?? default(int); }

        /// <summary>Internal Acessors for CurrentState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.CurrentState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentState = value; }

        /// <summary>Internal Acessors for CurrentStateDetailStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.CurrentStateDetailStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentStateDetailStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentStateDetailStatus = value; }

        /// <summary>Internal Acessors for CurrentStateExitCode</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.CurrentStateExitCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentStateExitCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentStateExitCode = value; }

        /// <summary>Internal Acessors for CurrentStateFinishTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.CurrentStateFinishTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentStateFinishTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentStateFinishTime = value; }

        /// <summary>Internal Acessors for CurrentStateStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.CurrentStateStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentStateStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).CurrentStateStartTime = value; }

        /// <summary>Internal Acessors for InstanceView</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInstanceView Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.InstanceView { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).InstanceView; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).InstanceView = value; }

        /// <summary>Internal Acessors for InstanceViewCurrentState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerState Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.InstanceViewCurrentState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).InstanceViewCurrentState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).InstanceViewCurrentState = value; }

        /// <summary>Internal Acessors for InstanceViewEvent</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IEvent[] Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.InstanceViewEvent { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).InstanceViewEvent; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).InstanceViewEvent = value; }

        /// <summary>Internal Acessors for InstanceViewPreviousState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerState Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.InstanceViewPreviousState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).InstanceViewPreviousState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).InstanceViewPreviousState = value; }

        /// <summary>Internal Acessors for InstanceViewRestartCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.InstanceViewRestartCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).InstanceViewRestartCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).InstanceViewRestartCount = value; }

        /// <summary>Internal Acessors for LimitGpu</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IGpuResource Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.LimitGpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LimitGpu; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LimitGpu = value; }

        /// <summary>Internal Acessors for LivenessProbe</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerProbe Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.LivenessProbe { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbe; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbe = value; }

        /// <summary>Internal Acessors for LivenessProbeExec</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerExec Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.LivenessProbeExec { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeExec; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeExec = value; }

        /// <summary>Internal Acessors for LivenessProbeHttpGet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerHttpGet Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.LivenessProbeHttpGet { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeHttpGet; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeHttpGet = value; }

        /// <summary>Internal Acessors for LivenessProbeHttpGetHttpHeader</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IHttpHeaders Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.LivenessProbeHttpGetHttpHeader { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeHttpGetHttpHeader; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).LivenessProbeHttpGetHttpHeader = value; }

        /// <summary>Internal Acessors for PreviouState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.PreviouState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouState = value; }

        /// <summary>Internal Acessors for PreviouStateDetailStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.PreviouStateDetailStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouStateDetailStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouStateDetailStatus = value; }

        /// <summary>Internal Acessors for PreviouStateExitCode</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.PreviouStateExitCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouStateExitCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouStateExitCode = value; }

        /// <summary>Internal Acessors for PreviouStateFinishTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.PreviouStateFinishTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouStateFinishTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouStateFinishTime = value; }

        /// <summary>Internal Acessors for PreviouStateStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.PreviouStateStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouStateStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouStateStartTime = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.ContainerProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ReadinessProbe</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerProbe Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.ReadinessProbe { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbe; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbe = value; }

        /// <summary>Internal Acessors for ReadinessProbeExec</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerExec Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.ReadinessProbeExec { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeExec; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeExec = value; }

        /// <summary>Internal Acessors for ReadinessProbeHttpGet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerHttpGet Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.ReadinessProbeHttpGet { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeHttpGet; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeHttpGet = value; }

        /// <summary>Internal Acessors for ReadinessProbeHttpGetHttpHeader</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IHttpHeaders Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.ReadinessProbeHttpGetHttpHeader { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeHttpGetHttpHeader; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeHttpGetHttpHeader = value; }

        /// <summary>Internal Acessors for RequestGpu</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IGpuResource Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.RequestGpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).RequestGpu; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).RequestGpu = value; }

        /// <summary>Internal Acessors for Resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IResourceRequirements Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.Resource { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).Resource = value; }

        /// <summary>Internal Acessors for ResourceLimit</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IResourceLimits Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.ResourceLimit { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ResourceLimit; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ResourceLimit = value; }

        /// <summary>Internal Acessors for ResourceRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IResourceRequests Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerInternal.ResourceRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ResourceRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ResourceRequest = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The user-provided name of the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>The exposed ports on the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPort[] Port { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).Port; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).Port = value ?? null /* arrayOf */; }

        /// <summary>The state of the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string PreviouState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouState; }

        /// <summary>The human-readable status of the container instance state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string PreviouStateDetailStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouStateDetailStatus; }

        /// <summary>
        /// The container instance exit codes correspond to those from the `docker run` command.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? PreviouStateExitCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouStateExitCode; }

        /// <summary>The date-time when the container instance state finished.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public global::System.DateTime? PreviouStateFinishTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouStateFinishTime; }

        /// <summary>The date-time when the container instance state started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public global::System.DateTime? PreviouStateStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).PreviouStateStartTime; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerProperties _property;

        /// <summary>The properties of the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.ContainerProperties()); set => this._property = value; }

        /// <summary>The commands to execute within the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string[] ReadinessProbeExecCommand { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeExecCommand; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeExecCommand = value ?? null /* arrayOf */; }

        /// <summary>The failure threshold.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? ReadinessProbeFailureThreshold { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeFailureThreshold; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeFailureThreshold = value ?? default(int); }

        /// <summary>The header name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string ReadinessProbeHttpGetHttpHeadersName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeHttpGetHttpHeadersName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeHttpGetHttpHeadersName = value ?? null; }

        /// <summary>The header value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string ReadinessProbeHttpGetHttpHeadersValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeHttpGetHttpHeadersValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeHttpGetHttpHeadersValue = value ?? null; }

        /// <summary>The path to probe.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public string ReadinessProbeHttpGetPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeHttpGetPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeHttpGetPath = value ?? null; }

        /// <summary>The port number to probe.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? ReadinessProbeHttpGetPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeHttpGetPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeHttpGetPort = value ?? default(int); }

        /// <summary>The scheme.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.Scheme? ReadinessProbeHttpGetScheme { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeHttpGetScheme; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeHttpGetScheme = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.Scheme)""); }

        /// <summary>The initial delay seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? ReadinessProbeInitialDelaySecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeInitialDelaySecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeInitialDelaySecond = value ?? default(int); }

        /// <summary>The period seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? ReadinessProbePeriodSecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbePeriodSecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbePeriodSecond = value ?? default(int); }

        /// <summary>The success threshold.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? ReadinessProbeSuccessThreshold { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeSuccessThreshold; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeSuccessThreshold = value ?? default(int); }

        /// <summary>The timeout seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? ReadinessProbeTimeoutSecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeTimeoutSecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).ReadinessProbeTimeoutSecond = value ?? default(int); }

        /// <summary>The CPU request of this container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public double RequestCpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).RequestCpu; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).RequestCpu = value ; }

        /// <summary>The memory request in GB of this container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public double RequestMemoryInGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).RequestMemoryInGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).RequestMemoryInGb = value ; }

        /// <summary>The count of the GPU resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public int? RequestsGpuCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).RequestsGpuCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).RequestsGpuCount = value ?? default(int); }

        /// <summary>The SKU of the GPU resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.GpuSku? RequestsGpuSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).RequestsGpuSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).RequestsGpuSku = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.GpuSku)""); }

        /// <summary>The volume mounts available to the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IVolumeMount[] VolumeMount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).VolumeMount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInternal)Property).VolumeMount = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="Container" /> instance.</summary>
        public Container()
        {

        }
    }
    /// A container instance.
    public partial interface IContainer :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.IJsonSerializable
    {
        /// <summary>The commands to execute within the container instance in exec form.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The commands to execute within the container instance in exec form.",
        SerializedName = @"command",
        PossibleTypes = new [] { typeof(string) })]
        string[] Command { get; set; }
        /// <summary>The state of the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the container instance.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentState { get;  }
        /// <summary>The human-readable status of the container instance state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The human-readable status of the container instance state.",
        SerializedName = @"detailStatus",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentStateDetailStatus { get;  }
        /// <summary>
        /// The container instance exit codes correspond to those from the `docker run` command.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The container instance exit codes correspond to those from the `docker run` command.",
        SerializedName = @"exitCode",
        PossibleTypes = new [] { typeof(int) })]
        int? CurrentStateExitCode { get;  }
        /// <summary>The date-time when the container instance state finished.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The date-time when the container instance state finished.",
        SerializedName = @"finishTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CurrentStateFinishTime { get;  }
        /// <summary>The date-time when the container instance state started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The date-time when the container instance state started.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CurrentStateStartTime { get;  }
        /// <summary>The environment variables to set in the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The environment variables to set in the container instance.",
        SerializedName = @"environmentVariables",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IEnvironmentVariable) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IEnvironmentVariable[] EnvironmentVariable { get; set; }
        /// <summary>The name of the image used to create the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the image used to create the container instance.",
        SerializedName = @"image",
        PossibleTypes = new [] { typeof(string) })]
        string Image { get; set; }
        /// <summary>The events of the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The events of the container instance.",
        SerializedName = @"events",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IEvent) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IEvent[] InstanceViewEvent { get;  }
        /// <summary>The number of times that the container instance has been restarted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The number of times that the container instance has been restarted.",
        SerializedName = @"restartCount",
        PossibleTypes = new [] { typeof(int) })]
        int? InstanceViewRestartCount { get;  }
        /// <summary>The CPU limit of this container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The CPU limit of this container instance.",
        SerializedName = @"cpu",
        PossibleTypes = new [] { typeof(double) })]
        double? LimitCpu { get; set; }
        /// <summary>The memory limit in GB of this container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The memory limit in GB of this container instance.",
        SerializedName = @"memoryInGB",
        PossibleTypes = new [] { typeof(double) })]
        double? LimitMemoryInGb { get; set; }
        /// <summary>The count of the GPU resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The count of the GPU resource.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(int) })]
        int? LimitsGpuCount { get; set; }
        /// <summary>The SKU of the GPU resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SKU of the GPU resource.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.GpuSku) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.GpuSku? LimitsGpuSku { get; set; }
        /// <summary>The commands to execute within the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The commands to execute within the container.",
        SerializedName = @"command",
        PossibleTypes = new [] { typeof(string) })]
        string[] LivenessProbeExecCommand { get; set; }
        /// <summary>The failure threshold.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The failure threshold.",
        SerializedName = @"failureThreshold",
        PossibleTypes = new [] { typeof(int) })]
        int? LivenessProbeFailureThreshold { get; set; }
        /// <summary>The header name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The header name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string LivenessProbeHttpGetHttpHeadersName { get; set; }
        /// <summary>The header value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The header value.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string LivenessProbeHttpGetHttpHeadersValue { get; set; }
        /// <summary>The path to probe.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The path to probe.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string LivenessProbeHttpGetPath { get; set; }
        /// <summary>The port number to probe.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The port number to probe.",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(int) })]
        int? LivenessProbeHttpGetPort { get; set; }
        /// <summary>The scheme.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scheme.",
        SerializedName = @"scheme",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.Scheme) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.Scheme? LivenessProbeHttpGetScheme { get; set; }
        /// <summary>The initial delay seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The initial delay seconds.",
        SerializedName = @"initialDelaySeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? LivenessProbeInitialDelaySecond { get; set; }
        /// <summary>The period seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The period seconds.",
        SerializedName = @"periodSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? LivenessProbePeriodSecond { get; set; }
        /// <summary>The success threshold.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The success threshold.",
        SerializedName = @"successThreshold",
        PossibleTypes = new [] { typeof(int) })]
        int? LivenessProbeSuccessThreshold { get; set; }
        /// <summary>The timeout seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timeout seconds.",
        SerializedName = @"timeoutSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? LivenessProbeTimeoutSecond { get; set; }
        /// <summary>The user-provided name of the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The user-provided name of the container instance.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The exposed ports on the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The exposed ports on the container instance.",
        SerializedName = @"ports",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPort) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPort[] Port { get; set; }
        /// <summary>The state of the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the container instance.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string PreviouState { get;  }
        /// <summary>The human-readable status of the container instance state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The human-readable status of the container instance state.",
        SerializedName = @"detailStatus",
        PossibleTypes = new [] { typeof(string) })]
        string PreviouStateDetailStatus { get;  }
        /// <summary>
        /// The container instance exit codes correspond to those from the `docker run` command.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The container instance exit codes correspond to those from the `docker run` command.",
        SerializedName = @"exitCode",
        PossibleTypes = new [] { typeof(int) })]
        int? PreviouStateExitCode { get;  }
        /// <summary>The date-time when the container instance state finished.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The date-time when the container instance state finished.",
        SerializedName = @"finishTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? PreviouStateFinishTime { get;  }
        /// <summary>The date-time when the container instance state started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The date-time when the container instance state started.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? PreviouStateStartTime { get;  }
        /// <summary>The commands to execute within the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The commands to execute within the container.",
        SerializedName = @"command",
        PossibleTypes = new [] { typeof(string) })]
        string[] ReadinessProbeExecCommand { get; set; }
        /// <summary>The failure threshold.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The failure threshold.",
        SerializedName = @"failureThreshold",
        PossibleTypes = new [] { typeof(int) })]
        int? ReadinessProbeFailureThreshold { get; set; }
        /// <summary>The header name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The header name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ReadinessProbeHttpGetHttpHeadersName { get; set; }
        /// <summary>The header value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The header value.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string ReadinessProbeHttpGetHttpHeadersValue { get; set; }
        /// <summary>The path to probe.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The path to probe.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string ReadinessProbeHttpGetPath { get; set; }
        /// <summary>The port number to probe.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The port number to probe.",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(int) })]
        int? ReadinessProbeHttpGetPort { get; set; }
        /// <summary>The scheme.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scheme.",
        SerializedName = @"scheme",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.Scheme) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.Scheme? ReadinessProbeHttpGetScheme { get; set; }
        /// <summary>The initial delay seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The initial delay seconds.",
        SerializedName = @"initialDelaySeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? ReadinessProbeInitialDelaySecond { get; set; }
        /// <summary>The period seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The period seconds.",
        SerializedName = @"periodSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? ReadinessProbePeriodSecond { get; set; }
        /// <summary>The success threshold.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The success threshold.",
        SerializedName = @"successThreshold",
        PossibleTypes = new [] { typeof(int) })]
        int? ReadinessProbeSuccessThreshold { get; set; }
        /// <summary>The timeout seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timeout seconds.",
        SerializedName = @"timeoutSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? ReadinessProbeTimeoutSecond { get; set; }
        /// <summary>The CPU request of this container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The CPU request of this container instance.",
        SerializedName = @"cpu",
        PossibleTypes = new [] { typeof(double) })]
        double RequestCpu { get; set; }
        /// <summary>The memory request in GB of this container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The memory request in GB of this container instance.",
        SerializedName = @"memoryInGB",
        PossibleTypes = new [] { typeof(double) })]
        double RequestMemoryInGb { get; set; }
        /// <summary>The count of the GPU resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The count of the GPU resource.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(int) })]
        int? RequestsGpuCount { get; set; }
        /// <summary>The SKU of the GPU resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SKU of the GPU resource.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.GpuSku) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.GpuSku? RequestsGpuSku { get; set; }
        /// <summary>The volume mounts available to the container instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The volume mounts available to the container instance.",
        SerializedName = @"volumeMounts",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IVolumeMount) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IVolumeMount[] VolumeMount { get; set; }

    }
    /// A container instance.
    internal partial interface IContainerInternal

    {
        /// <summary>The commands to execute within the container instance in exec form.</summary>
        string[] Command { get; set; }
        /// <summary>The state of the container instance.</summary>
        string CurrentState { get; set; }
        /// <summary>The human-readable status of the container instance state.</summary>
        string CurrentStateDetailStatus { get; set; }
        /// <summary>
        /// The container instance exit codes correspond to those from the `docker run` command.
        /// </summary>
        int? CurrentStateExitCode { get; set; }
        /// <summary>The date-time when the container instance state finished.</summary>
        global::System.DateTime? CurrentStateFinishTime { get; set; }
        /// <summary>The date-time when the container instance state started.</summary>
        global::System.DateTime? CurrentStateStartTime { get; set; }
        /// <summary>The environment variables to set in the container instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IEnvironmentVariable[] EnvironmentVariable { get; set; }
        /// <summary>The name of the image used to create the container instance.</summary>
        string Image { get; set; }
        /// <summary>The instance view of the container instance. Only valid in response.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPropertiesInstanceView InstanceView { get; set; }
        /// <summary>Current container instance state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerState InstanceViewCurrentState { get; set; }
        /// <summary>The events of the container instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IEvent[] InstanceViewEvent { get; set; }
        /// <summary>Previous container instance state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerState InstanceViewPreviousState { get; set; }
        /// <summary>The number of times that the container instance has been restarted.</summary>
        int? InstanceViewRestartCount { get; set; }
        /// <summary>The CPU limit of this container instance.</summary>
        double? LimitCpu { get; set; }
        /// <summary>The GPU limit of this container instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IGpuResource LimitGpu { get; set; }
        /// <summary>The memory limit in GB of this container instance.</summary>
        double? LimitMemoryInGb { get; set; }
        /// <summary>The count of the GPU resource.</summary>
        int? LimitsGpuCount { get; set; }
        /// <summary>The SKU of the GPU resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.GpuSku? LimitsGpuSku { get; set; }
        /// <summary>The liveness probe.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerProbe LivenessProbe { get; set; }
        /// <summary>The execution command to probe</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerExec LivenessProbeExec { get; set; }
        /// <summary>The commands to execute within the container.</summary>
        string[] LivenessProbeExecCommand { get; set; }
        /// <summary>The failure threshold.</summary>
        int? LivenessProbeFailureThreshold { get; set; }
        /// <summary>The Http Get settings to probe</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerHttpGet LivenessProbeHttpGet { get; set; }
        /// <summary>The HTTP headers.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IHttpHeaders LivenessProbeHttpGetHttpHeader { get; set; }
        /// <summary>The header name.</summary>
        string LivenessProbeHttpGetHttpHeadersName { get; set; }
        /// <summary>The header value.</summary>
        string LivenessProbeHttpGetHttpHeadersValue { get; set; }
        /// <summary>The path to probe.</summary>
        string LivenessProbeHttpGetPath { get; set; }
        /// <summary>The port number to probe.</summary>
        int? LivenessProbeHttpGetPort { get; set; }
        /// <summary>The scheme.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.Scheme? LivenessProbeHttpGetScheme { get; set; }
        /// <summary>The initial delay seconds.</summary>
        int? LivenessProbeInitialDelaySecond { get; set; }
        /// <summary>The period seconds.</summary>
        int? LivenessProbePeriodSecond { get; set; }
        /// <summary>The success threshold.</summary>
        int? LivenessProbeSuccessThreshold { get; set; }
        /// <summary>The timeout seconds.</summary>
        int? LivenessProbeTimeoutSecond { get; set; }
        /// <summary>The user-provided name of the container instance.</summary>
        string Name { get; set; }
        /// <summary>The exposed ports on the container instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerPort[] Port { get; set; }
        /// <summary>The state of the container instance.</summary>
        string PreviouState { get; set; }
        /// <summary>The human-readable status of the container instance state.</summary>
        string PreviouStateDetailStatus { get; set; }
        /// <summary>
        /// The container instance exit codes correspond to those from the `docker run` command.
        /// </summary>
        int? PreviouStateExitCode { get; set; }
        /// <summary>The date-time when the container instance state finished.</summary>
        global::System.DateTime? PreviouStateFinishTime { get; set; }
        /// <summary>The date-time when the container instance state started.</summary>
        global::System.DateTime? PreviouStateStartTime { get; set; }
        /// <summary>The properties of the container instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerProperties Property { get; set; }
        /// <summary>The readiness probe.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerProbe ReadinessProbe { get; set; }
        /// <summary>The execution command to probe</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerExec ReadinessProbeExec { get; set; }
        /// <summary>The commands to execute within the container.</summary>
        string[] ReadinessProbeExecCommand { get; set; }
        /// <summary>The failure threshold.</summary>
        int? ReadinessProbeFailureThreshold { get; set; }
        /// <summary>The Http Get settings to probe</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IContainerHttpGet ReadinessProbeHttpGet { get; set; }
        /// <summary>The HTTP headers.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IHttpHeaders ReadinessProbeHttpGetHttpHeader { get; set; }
        /// <summary>The header name.</summary>
        string ReadinessProbeHttpGetHttpHeadersName { get; set; }
        /// <summary>The header value.</summary>
        string ReadinessProbeHttpGetHttpHeadersValue { get; set; }
        /// <summary>The path to probe.</summary>
        string ReadinessProbeHttpGetPath { get; set; }
        /// <summary>The port number to probe.</summary>
        int? ReadinessProbeHttpGetPort { get; set; }
        /// <summary>The scheme.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.Scheme? ReadinessProbeHttpGetScheme { get; set; }
        /// <summary>The initial delay seconds.</summary>
        int? ReadinessProbeInitialDelaySecond { get; set; }
        /// <summary>The period seconds.</summary>
        int? ReadinessProbePeriodSecond { get; set; }
        /// <summary>The success threshold.</summary>
        int? ReadinessProbeSuccessThreshold { get; set; }
        /// <summary>The timeout seconds.</summary>
        int? ReadinessProbeTimeoutSecond { get; set; }
        /// <summary>The CPU request of this container instance.</summary>
        double RequestCpu { get; set; }
        /// <summary>The GPU request of this container instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IGpuResource RequestGpu { get; set; }
        /// <summary>The memory request in GB of this container instance.</summary>
        double RequestMemoryInGb { get; set; }
        /// <summary>The count of the GPU resource.</summary>
        int? RequestsGpuCount { get; set; }
        /// <summary>The SKU of the GPU resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Support.GpuSku? RequestsGpuSku { get; set; }
        /// <summary>The resource requirements of the container instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IResourceRequirements Resource { get; set; }
        /// <summary>The resource limits of this container instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IResourceLimits ResourceLimit { get; set; }
        /// <summary>The resource requests of this container instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IResourceRequests ResourceRequest { get; set; }
        /// <summary>The volume mounts available to the container instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20210301.IVolumeMount[] VolumeMount { get; set; }

    }
}