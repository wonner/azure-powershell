﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Hyak.Common;
using Microsoft.Azure.Commands.Sql.Properties;

namespace Microsoft.Azure.Commands.Sql.FirewallRule.Cmdlet
{
    /// <summary>
    /// Defines the Get-AzureSqlDatabaseServerFirewallRule cmdlet
    /// </summary>
    [Cmdlet(VerbsCommon.New, "AzureSqlDatabaseServerFirewallRule", ConfirmImpact = ConfirmImpact.Medium)]
    public class NewAzureSqlDatabaseServerFirewallRule : AzureSqlDatabaseServerFirewallRuleCmdletBase
    {
        private const string AzureIpRuleSet = "AzureIpRuleSet";
        private const string UserSpecifiedRuleSet = "UserSpecifiedRuleSet";
        private const string AzureRuleIp = "0.0.0.0";
        private const string AzureRuleName = "AllowAllAzureIPs";

        [Parameter(Mandatory = true, 
            ValueFromPipelineByPropertyName = true, 
            HelpMessage = "Azure Sql Database Server Firewall Rule Name.",
            ParameterSetName = UserSpecifiedRuleSet)]
        [ValidateNotNullOrEmpty]
        public string FirewallRuleName { get; set; }

        [Parameter(Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The start IP address for the firewall rule",
            ParameterSetName = UserSpecifiedRuleSet)]
        [ValidateNotNull]
        public string StartIpAddress { get; set; }

        [Parameter(Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The end IP address for the firewall rule",
            ParameterSetName = UserSpecifiedRuleSet)]
        [ValidateNotNullOrEmpty]
        public string EndIpAddress { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Creates a special firewall rule that permits all Azure IPs to have access",
            ParameterSetName = AzureIpRuleSet)]
        public SwitchParameter AllowAllAzureIPs { get; set; }

        /// <summary>
        /// Check to see if the FirewallRule already exists for this server
        /// </summary>
        /// <returns>Null if the FirewallRule doesn't exist.  Otherwise throws exception</returns>
        protected override IEnumerable<Model.AzureSqlDatabaseServerFirewallRuleModel> GetEntity()
        {
            try
            {
                if (ParameterSetName == UserSpecifiedRuleSet)
                {

                    ModelAdapter.GetFirewallRule(this.ResourceGroupName, this.ServerName, this.FirewallRuleName);
                }
                else
                {
                    ModelAdapter.GetFirewallRule(this.ResourceGroupName, this.ServerName, AzureRuleName);
                }
            }
            catch(CloudException ex)
            {
                if(ex.Response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    // This is what we want.  We looked and there is no server with this name.
                    return null;
                }

                // Unexpected exception encountered
                throw;
            }

            // The server already exists
            throw new PSArgumentException(
                string.Format(Resources.ServerFirewallRuleNameExists, this.FirewallRuleName, this.ServerName),
                "FirewallRule");
        }

        /// <summary>
        /// Generates the model from user input.
        /// </summary>
        /// <param name="model">This is null since the FirewallRule doesn't exist yet</param>
        /// <returns>The generated model from user input</returns>
        protected override IEnumerable<Model.AzureSqlDatabaseServerFirewallRuleModel> ApplyUserInputToModel(IEnumerable<Model.AzureSqlDatabaseServerFirewallRuleModel> model)
        {
            List<Model.AzureSqlDatabaseServerFirewallRuleModel> newEntity = new List<Model.AzureSqlDatabaseServerFirewallRuleModel>();

            if(ParameterSetName == UserSpecifiedRuleSet)
            {
                newEntity.Add(new Model.AzureSqlDatabaseServerFirewallRuleModel()
                {
                    FirewallRuleName = this.FirewallRuleName,
                    StartIpAddress = this.StartIpAddress,
                    EndIpAddress = this.EndIpAddress,
                });
            }
            else
            {
                newEntity.Add(new Model.AzureSqlDatabaseServerFirewallRuleModel()
                {
                    FirewallRuleName = AzureRuleName,
                    StartIpAddress = AzureRuleIp,
                    EndIpAddress = AzureRuleIp,
                });
            }

            return newEntity;
        }

        /// <summary>
        /// Sends the changes to the service -> Creates the Firewall Rule
        /// </summary>
        /// <param name="entity">The FirewallRule to create</param>
        /// <returns>The created FirewallRule</returns>
        protected override IEnumerable<Model.AzureSqlDatabaseServerFirewallRuleModel> PersistChanges(IEnumerable<Model.AzureSqlDatabaseServerFirewallRuleModel> entity)
        {
            return new List<Model.AzureSqlDatabaseServerFirewallRuleModel>() { 
                ModelAdapter.UpsertFirewallRule(this.ResourceGroupName, this.ServerName, entity.First()) 
            };
        }
    }
}
