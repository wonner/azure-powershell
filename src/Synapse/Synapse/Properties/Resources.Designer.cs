﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Synapse.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.Synapse.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove Synapse workspace &apos;{0}&apos;?.
        /// </summary>
        internal static string ConfirmToRemoveSynapseWorkspace {
            get {
                return ResourceManager.GetString("ConfirmToRemoveSynapseWorkspace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to stop Spark job with Id: &apos;{0}&apos;?.
        /// </summary>
        internal static string ConfirmToStopSparkJob {
            get {
                return ResourceManager.GetString("ConfirmToStopSparkJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to stop Spark statement with Id: &apos;{0}&apos;?.
        /// </summary>
        internal static string ConfirmToStopSparkStatement {
            get {
                return ResourceManager.GetString("ConfirmToStopSparkStatement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified firewall rule &apos;{0}&apos; already exists. Please use Set-AzSynapseFirewallRule to modify a firewall rule with these properties..
        /// </summary>
        internal static string ConflictFirewallRuleName {
            get {
                return ResourceManager.GetString("ConflictFirewallRuleName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a new firewall rule in workspace &apos;{0}&apos; with name &apos;{1}&apos;..
        /// </summary>
        internal static string CreatingFirewallRule {
            get {
                return ResourceManager.GetString("CreatingFirewallRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a run of a pipeline in workspace &apos;{0}&apos; with name &apos;{1}&apos;..
        /// </summary>
        internal static string CreatingSynapsePipelineRun {
            get {
                return ResourceManager.GetString("CreatingSynapsePipelineRun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a new role assignment in workspace &apos;{0}&apos; with RoleDefinitionId &apos;{1}&apos; and ObjectId &apos;{2}&apos;..
        /// </summary>
        internal static string CreatingSynapseRoleAssignment {
            get {
                return ResourceManager.GetString("CreatingSynapseRoleAssignment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a new Spark pool in resource group &apos;{0}&apos; under parent Workspace &apos;{1}&apos; with name &apos;{2}&apos;..
        /// </summary>
        internal static string CreatingSynapseSparkPool {
            get {
                return ResourceManager.GetString("CreatingSynapseSparkPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a new SQL pool in resource group &apos;{0}&apos; under parent Workspace &apos;{1}&apos; with name &apos;{2}&apos;..
        /// </summary>
        internal static string CreatingSynapseSqlPool {
            get {
                return ResourceManager.GetString("CreatingSynapseSqlPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a new workspace in resource group &apos;{0}&apos; with name &apos;{1}&apos;..
        /// </summary>
        internal static string CreatingSynapseWorkspace {
            get {
                return ResourceManager.GetString("CreatingSynapseWorkspace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disabling Auto-pause for spark pool &apos;{0}&apos; in resource group &apos;{1}&apos; under parent workspace &apos;{2}&apos;..
        /// </summary>
        internal static string DisablingSynapseSparkPoolAutoPause {
            get {
                return ResourceManager.GetString("DisablingSynapseSparkPoolAutoPause", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disabling Auto-scale for spark pool &apos;{0}&apos; in resource group &apos;{1}&apos; under parent workspace &apos;{2}&apos;..
        /// </summary>
        internal static string DisablingSynapseSparkPoolAutoScale {
            get {
                return ResourceManager.GetString("DisablingSynapseSparkPoolAutoScale", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enabling Auto-pause for spark pool &apos;{0}&apos; in resource group &apos;{1}&apos; under parent workspace &apos;{2}&apos;..
        /// </summary>
        internal static string EnablingSynapseSparkPoolAutoPause {
            get {
                return ResourceManager.GetString("EnablingSynapseSparkPoolAutoPause", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enabling Auto-scale for spark pool &apos;{0}&apos; in resource group &apos;{1}&apos; under parent workspace &apos;{2}&apos;..
        /// </summary>
        internal static string EnablingSynapseSparkPoolAutoScale {
            get {
                return ResourceManager.GetString("EnablingSynapseSparkPoolAutoScale", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to assign MSI for {0} to the {1} role on {2}. Error message: {3}..
        /// </summary>
        internal static string FailedToAssignWorkspaceAccess {
            get {
                return ResourceManager.GetString("FailedToAssignWorkspaceAccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot perform the requested operation because Auto-pause for spark pool &apos;{0}&apos; in resource group &apos;{1}&apos; under workspace &apos;{2}&apos; is not enabled..
        /// </summary>
        internal static string FailedToDisableSparkPoolAutoPause {
            get {
                return ResourceManager.GetString("FailedToDisableSparkPoolAutoPause", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot perform the requested operation because Auto-scale for spark pool &apos;{0}&apos; in resource group &apos;{1}&apos; under workspace &apos;{2}&apos; is not enabled..
        /// </summary>
        internal static string FailedToDisableSparkPoolAutoScale {
            get {
                return ResourceManager.GetString("FailedToDisableSparkPoolAutoScale", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified firewall rule &apos;{0}&apos; does not exist. Please use Add-AzSynapseFirewallRule to create a firewall rule with these properties..
        /// </summary>
        internal static string FailedToDiscoverFirewallRuleByWorkspace {
            get {
                return ResourceManager.GetString("FailedToDiscoverFirewallRuleByWorkspace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find workspace: &apos;{0}&apos; in any resource group in the currently selected subscription: {1}. Please ensure this workspace exists and that the current user has access to it..
        /// </summary>
        internal static string FailedToDiscoverResourceGroup {
            get {
                return ResourceManager.GetString("FailedToDiscoverResourceGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find SQL server: &apos;{0}&apos; in any resource group in the currently selected subscription: {1}. Please ensure this server exists and that the current user has access to it..
        /// </summary>
        internal static string FailedToDiscoverResourceGroupBySqlServer {
            get {
                return ResourceManager.GetString("FailedToDiscoverResourceGroupBySqlServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Spark pool with name &apos;{0}&apos; in resource group &apos;{1}&apos; under parent workspace &apos;{2}&apos; does not exist. Please use New-AzSynapseSparkPool to create a Spark pool with these properties..
        /// </summary>
        internal static string FailedToDiscoverSparkPool {
            get {
                return ResourceManager.GetString("FailedToDiscoverSparkPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find Spark statement: &apos;{0}&apos; in any resource group in the currently selected workspace: &apos;{1}&apos; Spark pool: &apos;{2}&apos;. Please specifiy the session identifier explicitly..
        /// </summary>
        internal static string FailedToDiscoverSparkStatement {
            get {
                return ResourceManager.GetString("FailedToDiscoverSparkStatement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to discover restore points for SQL database with name &apos;{0}&apos; in resource group &apos;{1}&apos; under workspace &apos;{2}&apos; does not exist..
        /// </summary>
        internal static string FailedToDiscoverSqlDatabaseRestorePoints {
            get {
                return ResourceManager.GetString("FailedToDiscoverSqlDatabaseRestorePoints", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A SQL pool with name &apos;{0}&apos; in resource group &apos;{1}&apos; under workspace &apos;{2}&apos; does not exist. Please use New-AzSynapseSqlPool to create a SQL pool with these properties..
        /// </summary>
        internal static string FailedToDiscoverSqlPool {
            get {
                return ResourceManager.GetString("FailedToDiscoverSqlPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to discover restore points for SQL pool with name &apos;{0}&apos; in resource group &apos;{1}&apos; under workspace &apos;{2}&apos; does not exist..
        /// </summary>
        internal static string FailedToDiscoverSqlPoolRestorePoints {
            get {
                return ResourceManager.GetString("FailedToDiscoverSqlPoolRestorePoints", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A workspace with name &apos;{0}&apos; in resource group &apos;{1}&apos; does not exist. Please use New-AzSynapseWorkspace to create a workspace with these properties..
        /// </summary>
        internal static string FailedToDiscoverWorkspace {
            get {
                return ResourceManager.GetString("FailedToDiscoverWorkspace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to start session..
        /// </summary>
        internal static string FailedToStartSession {
            get {
                return ResourceManager.GetString("FailedToStartSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to submit Spark job..
        /// </summary>
        internal static string FailedToSubmitSparkJob {
            get {
                return ResourceManager.GetString("FailedToSubmitSparkJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file at path &apos;{0}&apos; does not exist or the current user does not have permission to it. Please ensure the path exists and is accessible..
        /// </summary>
        internal static string FilePathDoesNotExist {
            get {
                return ResourceManager.GetString("FilePathDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot perform the requested operation because the specified firewall rule &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string FirewallRuleDoesNotExist {
            get {
                return ResourceManager.GetString("FirewallRuleDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to InteractiveSparkSessionTips.
        /// </summary>
        internal static string InteractiveSparkSessionTips {
            get {
                return ResourceManager.GetString("InteractiveSparkSessionTips", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All keys in the parameters hashtable must be of type string since they represent pipeline parameter names..
        /// </summary>
        internal static string InvalidCastParameterKeyExceptionMessage {
            get {
                return ResourceManager.GetString("InvalidCastParameterKeyExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No default subscription has been designated. Use Select-AzSubscription -Default &lt;subscriptionName&gt; to set the default subscription..
        /// </summary>
        internal static string InvalidDefaultSubscription {
            get {
                return ResourceManager.GetString("InvalidDefaultSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid job type selected..
        /// </summary>
        internal static string InvalidJobType {
            get {
                return ResourceManager.GetString("InvalidJobType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid parameter set {0} selected. Please contact support..
        /// </summary>
        internal static string InvalidParameterSet {
            get {
                return ResourceManager.GetString("InvalidParameterSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid storage URI: {0}. Allowed URI example: abfss://fileSystem@storageAccountName.dfs.core.windows.net/samples/java/wordcount/wordcount.jar.
        /// </summary>
        internal static string InvalidStorageUri {
            get {
                return ResourceManager.GetString("InvalidStorageUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot perform the requested operation because main class name or main executable file is not provided. Please specify -MainClassName for Spark job or -MainExecutableFile for .NET Spark job..
        /// </summary>
        internal static string MissingMainClassName {
            get {
                return ResourceManager.GetString("MissingMainClassName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No subscription found in the context.  Please ensure that the credentials you provided are authorized to access an Azure subscription, then run Connect-AzAccount to login..
        /// </summary>
        internal static string NoSubscriptionInContext {
            get {
                return ResourceManager.GetString("NoSubscriptionInContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find principal using the specified object id.
        /// </summary>
        internal static string PrincipalNotFound {
            get {
                return ResourceManager.GetString("PrincipalNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting firewall rule &apos;{0}&apos; in workspace &apos;{1}&apos;.
        /// </summary>
        internal static string RemovingFirewallRule {
            get {
                return ResourceManager.GetString("RemovingFirewallRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting pipeline &apos;{0}&apos; in workspace &apos;{1}&apos;..
        /// </summary>
        internal static string RemovingSynapsePipeline {
            get {
                return ResourceManager.GetString("RemovingSynapsePipeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting role assignment with RoleDefinitionId &apos;{0}&apos; and ObjectId &apos;{1}&apos; in workspace &apos;{2}&apos;..
        /// </summary>
        internal static string RemovingSynapseRoleAssignment {
            get {
                return ResourceManager.GetString("RemovingSynapseRoleAssignment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting role assignment with RoleAssignmentId &apos;{0}&apos; in workspace &apos;{1}&apos;..
        /// </summary>
        internal static string RemovingSynapseRoleAssignmentById {
            get {
                return ResourceManager.GetString("RemovingSynapseRoleAssignmentById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting Spark pool &apos;{0}&apos; in resource group &apos;{1}&apos; under workspace &apos;{2}&apos;..
        /// </summary>
        internal static string RemovingSynapseSparkPool {
            get {
                return ResourceManager.GetString("RemovingSynapseSparkPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting SQL pool &apos;{0}&apos; in resource group &apos;{1}&apos; under workspace &apos;{2}&apos;..
        /// </summary>
        internal static string RemovingSynapseSqlPool {
            get {
                return ResourceManager.GetString("RemovingSynapseSqlPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting workspace &apos;{0}&apos; in resource group &apos;{1}&apos;.
        /// </summary>
        internal static string RemovingSynapseWorkspace {
            get {
                return ResourceManager.GetString("RemovingSynapseWorkspace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resetting timeout for Spark session with Id: &apos;{0}&apos; ....
        /// </summary>
        internal static string ResettingSynapseSparkSessionTimeout {
            get {
                return ResourceManager.GetString("ResettingSynapseSparkSessionTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resuming SQL pool &apos;{0}&apos; in resource group &apos;{1}&apos; under workspace &apos;{2}&apos;..
        /// </summary>
        internal static string ResumingSynapseSqlPool {
            get {
                return ResourceManager.GetString("ResumingSynapseSqlPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Role Definition Name &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string RoleDefinitionNameDoesNotExist {
            get {
                return ResourceManager.GetString("RoleDefinitionNameDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service principal with Name &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string ServicePrincipalNameDoesNotExist {
            get {
                return ResourceManager.GetString("ServicePrincipalNameDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting pipeline &apos;{1}&apos; in workspace &apos;{0}&apos;..
        /// </summary>
        internal static string SettingSynapsePipeline {
            get {
                return ResourceManager.GetString("SettingSynapsePipeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot perform the requested operation because the specified Spark pool &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string SparkPoolDoesNotExist {
            get {
                return ResourceManager.GetString("SparkPoolDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot perform the requested operation because the specified SQL database &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string SqlDatabaseDoesNotExist {
            get {
                return ResourceManager.GetString("SqlDatabaseDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot perform the requested operation because the specified SQL pool &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string SqlPoolDoesNotExist {
            get {
                return ResourceManager.GetString("SqlPoolDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must be issued in interactive mode..
        /// </summary>
        internal static string StartSparkSessionNonInteractiveMessage {
            get {
                return ResourceManager.GetString("StartSparkSessionNonInteractiveMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping Pipeline with Id: &apos;{0}&apos; ....
        /// </summary>
        internal static string StoppingPipelineRun {
            get {
                return ResourceManager.GetString("StoppingPipelineRun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping Spark job with Id: &apos;{0}&apos; ....
        /// </summary>
        internal static string StoppingSparkJob {
            get {
                return ResourceManager.GetString("StoppingSparkJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping Spark statement with Id: &apos;{0}&apos; ....
        /// </summary>
        internal static string StoppingSparkStatement {
            get {
                return ResourceManager.GetString("StoppingSparkStatement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping Spark session with Id: &apos;{0}&apos; ....
        /// </summary>
        internal static string StoppingSynapseSparkSession {
            get {
                return ResourceManager.GetString("StoppingSynapseSparkSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pausing SQL pool &apos;{0}&apos; in resource group &apos;{1}&apos; under workspace &apos;{2}&apos;..
        /// </summary>
        internal static string SuspendingSynapseSqlPool {
            get {
                return ResourceManager.GetString("SuspendingSynapseSqlPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Spark pool with name &apos;{0}&apos; in resource group &apos;{1}&apos; under workspace &apos;{2}&apos; already exists. Please use Set-AzSynapseSparkPool to update an existing Spark pool..
        /// </summary>
        internal static string SynapseSparkPoolExists {
            get {
                return ResourceManager.GetString("SynapseSparkPoolExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A SQL pool with name &apos;{0}&apos; in resource group &apos;{1}&apos; under workspace &apos;{2}&apos; already exists. Please use Set-AzSynapseSqlPool to update an existing SQL pool..
        /// </summary>
        internal static string SynapseSqlPoolExists {
            get {
                return ResourceManager.GetString("SynapseSqlPoolExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A workspace with name &apos;{0}&apos; in resource group &apos;{1}&apos; already exists. Please use Set-AzSynapseWorkspace to update an existing workspace..
        /// </summary>
        internal static string SynapseWorkspaceExists {
            get {
                return ResourceManager.GetString("SynapseWorkspaceExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating Spark pool &apos;{0}&apos; in resource group &apos;{1}&apos; under workspace &apos;{2}&apos;..
        /// </summary>
        internal static string UpdatingSynapseSparkPool {
            get {
                return ResourceManager.GetString("UpdatingSynapseSparkPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating SQL pool &apos;{0}&apos; in resource group &apos;{1}&apos; under Workspace &apos;{2}&apos;..
        /// </summary>
        internal static string UpdatingSynapseSqlPool {
            get {
                return ResourceManager.GetString("UpdatingSynapseSqlPool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating workspace &apos;{0}&apos; in resource group &apos;{1}&apos;.
        /// </summary>
        internal static string UpdatingSynapseWorkspace {
            get {
                return ResourceManager.GetString("UpdatingSynapseWorkspace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User with Name &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string UserNameDoesNotExist {
            get {
                return ResourceManager.GetString("UserNameDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job is not yet done. Current job state: &apos;{0}&apos;.
        /// </summary>
        internal static string WaitJobState {
            get {
                return ResourceManager.GetString("WaitJobState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Spark Job with id &apos;{0}&apos; has not completed in {1} seconds. Check job runtime or increase the value of -TimeoutInSeconds.
        /// </summary>
        internal static string WaitJobTimeoutExceeded {
            get {
                return ResourceManager.GetString("WaitJobTimeoutExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot perform the requested operation because the specified workspace &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string WorkspaceDoesNotExist {
            get {
                return ResourceManager.GetString("WorkspaceDoesNotExist", resourceCulture);
            }
        }
    }
}
