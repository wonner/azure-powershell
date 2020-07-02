#
# Module manifest for module 'Az.Synapse'
#
# Generated by: Microsoft Corporation
#
# Generated on: 7/9/2020
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '0.1.2'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = '89eceb4f-9916-4ec5-8499-d5cca97a9cae'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Azure Synapse Analytics in Windows PowerShell and PowerShell Core.

For more information on Azure Synapse Analytics, please visit the following: https://azure.microsoft.com/en-us/services/synapse-analytics/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '1.9.1'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = 'Microsoft.Azure.Management.Synapse.dll', 
               'Azure.Analytics.Synapse.Spark.dll', 
               'Azure.Analytics.Synapse.AccessControl.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = 'Synapse.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('Microsoft.Azure.PowerShell.Cmdlets.Synapse.dll')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Get-AzSynapseSparkJob', 'Stop-AzSynapseSparkJob', 
               'Submit-AzSynapseSparkJob', 'Wait-AzSynapseSparkJob', 
               'Get-AzSynapseSparkSession', 'Reset-AzSynapseSparkSessionTimeout', 
               'Start-AzSynapseSparkSession', 'Stop-AzSynapseSparkSession', 
               'Get-AzSynapseSparkStatement', 'Invoke-AzSynapseSparkStatement', 
               'Stop-AzSynapseSparkStatement', 'Get-AzSynapseSparkPool', 
               'New-AzSynapseSparkPool', 'Remove-AzSynapseSparkPool', 
               'Update-AzSynapseSparkPool', 'Get-AzSynapseWorkspace', 
               'New-AzSynapseWorkspace', 'Remove-AzSynapseWorkspace', 
               'Update-AzSynapseWorkspace', 'Get-AzSynapseSqlPool', 
               'New-AzSynapseSqlPool', 'Remove-AzSynapseSqlPool', 
               'Update-AzSynapseSqlPool', 'Test-AzSynapseWorkspace', 
               'Test-AzSynapseSparkPool', 'Test-AzSynapseSqlPool', 
               'New-AzSynapseFirewallRule', 'Remove-AzSynapseFirewallRule', 
               'Get-AzSynapseFirewallRule', 'Update-AzSynapseFirewallRule',
               'Get-AzSynapseRoleAssignment','New-AzSynapseRoleAssignment',
               'Remove-AzSynapseRoleAssignment','Get-AzSynapseRoleDefinition'

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ResourceManager','ARM','Synapse','Analytics'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '* Changed some property names and types of output for the following cmdlets
    - For ''Get-AzSynapseSparkJob'', ''Submit-AzSynapseSparkJob'', '' Get-AzSynapseSparkSession'' and ''Start-AzSynapseSparkSession'' cmdlet
        - Change JobType''s type from ''string'' to ''SparkJobType?''
        - Change AppInfo''s type from ''IDictionary<string, string>'' to ''IReadOnlyDictionary<string, string>''
        - Change ErrorInfo''s type from ''IList<ErrorInformation>'' to ''IReadOnlyList<SparkServiceError>''
        - Change Log''s type from ''IList<string>'' to ''IReadOnlyList<string>''
        - Change ''Scheduler'' to ''Scheduler''
        - Change ''PluginInfo'' to ''Plugin''
        - Change ''ErrorInfo'' to ''Errors''
        - Change ''Log'' to ''LogLines''
* Added support for operation of Synapse access control
    - Add ''Get-AzSynapseRoleDefinition'' cmdlet
    - Add ''New-AzSynapseRoleAssignment'' cmdlet
    - Add ''Remove-AzSynapseRoleAssignment'' cmdlet
    - Add ''Get-AzSynapseRoleAssignment'' cmdlet'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

