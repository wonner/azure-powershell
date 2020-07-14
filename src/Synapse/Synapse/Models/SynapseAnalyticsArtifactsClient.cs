﻿using Azure;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Analytics.Synapse.Artifacts.Models;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Synapse.Common;
using Microsoft.Azure.Commands.Synapse.Models.Exceptions;
using Microsoft.Azure.Commands.Synapse.Properties;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Microsoft.Azure.Commands.Synapse.Models
{
    public class SynapseAnalyticsArtifactsClient
    {
        private readonly JsonSerializerSettings Settings;
        private readonly PipelineClient _pipelineClient;
        private readonly PipelineRunClient _pipelineRunClient;
        private readonly LinkedServiceClient _linkedServiceClient;
        private readonly NotebookClient _notebookClient;
        private readonly TriggerClient _triggerClient;
        private readonly TriggerRunClient _triggerRunClient;

        public SynapseAnalyticsArtifactsClient(string workspaceName, IAzureContext context)
        {
            if (context == null)
            {
                throw new SynapseException(Resources.InvalidDefaultSubscription);
            }

            Settings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            Settings.Converters.Add(new TransformationJsonConverter());
            Settings.Converters.Add(new PolymorphicDeserializeJsonConverter<PSActivity>("type"));
            Settings.Converters.Add(new PolymorphicDeserializeJsonConverter<PSLinkedService>("type"));
            Settings.Converters.Add(new PolymorphicDeserializeJsonConverter<PSTrigger>("type"));

            string suffix = context.Environment.GetEndpoint(AzureEnvironment.ExtendedEndpoint.AzureSynapseAnalyticsEndpointSuffix);
            Uri uri = new Uri("https://" + workspaceName + "." + suffix);
            _pipelineClient = new PipelineClient(uri, new AzureSessionCredential(context));
            _pipelineRunClient = new PipelineRunClient(uri, new AzureSessionCredential(context));
            _linkedServiceClient = new LinkedServiceClient(uri, new AzureSessionCredential(context));
            _notebookClient = new NotebookClient(uri, new AzureSessionCredential(context));
            _triggerClient = new TriggerClient(uri, new AzureSessionCredential(context));
            _triggerRunClient = new TriggerRunClient(uri, new AzureSessionCredential(context));
        }

        #region pipeline

        public PipelineResource CreateOrUpdatePipeline(string pipelineName, string rawJsonContent)
        {
            PSPipelineResource psPipeline = JsonConvert.DeserializeObject<PSPipelineResource>(rawJsonContent,Settings);
            PipelineResource pipeline = psPipeline.ToSdkObject();
            return _pipelineClient.CreateOrUpdatePipeline(pipelineName, pipeline).Value;
        }

        public PipelineResource GetPipeline(string pipelineName)
        {
            return _pipelineClient.GetPipeline(pipelineName).Value;
        }

        public Pageable<PipelineResource> GetPipelinesByWorkspace()
        {
            return _pipelineClient.GetPipelinesByWorkspace();
        }

        public void DeletePipeline(string pipelineName)
        {
            _pipelineClient.DeletePipeline(pipelineName);
        }

        public CreateRunResponse CreatePipelineRun(string pipelineName, string referencePipelineRunId, bool? isRecovery, string startActivityName, IDictionary<string, object> parameters)
        {
            return _pipelineClient.CreatePipelineRun(pipelineName, referencePipelineRunId, isRecovery, startActivityName, parameters).Value;
        }

        #endregion

        #region pipeline run

        public PipelineRun GetPipelineRun(string runId)
        {
            return _pipelineRunClient.GetPipelineRun(runId).Value;
        }

        public IReadOnlyList<PipelineRun> QueryPipelineRunsByWorkspace(RunFilterParameters filterParameters)
        {
            return _pipelineRunClient.QueryPipelineRunsByWorkspace(filterParameters).Value.Value;
        }

        public void CancelPipelineRun(string runId)
        {
            _pipelineRunClient.CancelPipelineRun(runId);
        }

        public ActivityRunsQueryResponse GetActivityRuns(string pipelineName, string runId, RunFilterParameters filterParameters)
        {
            return _pipelineRunClient.QueryActivityRuns(pipelineName, runId, filterParameters).Value;
        }

        #endregion

        #region LinkedService

        public LinkedServiceResource GetLinkedService(string linkedServiceName)
        {
            return _linkedServiceClient.GetLinkedService(linkedServiceName);
        }

        public Pageable<LinkedServiceResource> GetLinkedServicesByWorkspace()
        {
            return _linkedServiceClient.GetLinkedServicesByWorkspace();
        }

        public LinkedServiceResource CreateOrUpdateLinkedService(string linkedServiceName, string rawJsonContent)
        {
            PSLinkedServiceResource psLinkedService = JsonConvert.DeserializeObject<PSLinkedServiceResource>(rawJsonContent, Settings);
            LinkedServiceResource linkedService = psLinkedService.ToSdkObject();
            return _linkedServiceClient.CreateOrUpdateLinkedService(linkedServiceName, linkedService);
        }

        public void DeleteLinkedService(string linkedServiceName)
        {
            _linkedServiceClient.DeleteLinkedService(linkedServiceName);
        }

        #endregion

        #region Notebook

        public NotebookResource CreateOrUpdateNotebook(string notebookName, NotebookResource notebook)
        {
            return _notebookClient.CreateOrUpdateNotebook(notebookName, notebook);
        }

        public void DeleteNotebook(string notebookName)
        {
            _notebookClient.DeleteNotebook(notebookName);
        }

        public NotebookResource GetNotebook(string notebookName)
        {
            return _notebookClient.GetNotebook(notebookName);
        }

        public Pageable<NotebookResource> GetNotebooksByWorkspace()
        {
            return _notebookClient.GetNotebooksByWorkspace();
        }

        #endregion

        #region Trigger

        public TriggerResource CreateOrUpdateTrigger(string triggerName, string rawJsonContent)
        {
            PSTriggerResource pSTrigger = JsonConvert.DeserializeObject<PSTriggerResource>(rawJsonContent, Settings);
            TriggerResource trigger = pSTrigger.ToSdkObject();
            return _triggerClient.CreateOrUpdateTrigger(triggerName, trigger);
        }

        public TriggerResource GetTrigger(string triggerName)
        {
            return _triggerClient.GetTrigger(triggerName);
        }

        public Pageable<TriggerResource> GetTriggersByWorkspace()
        {
            return _triggerClient.GetTriggersByWorkspace();
        }

        public void DeleteTrigger(string triggerName)
        {
            _triggerClient.DeleteTrigger(triggerName);
        }

        public TriggerSubscriptionOperationStatus GetEventSubscriptionStatus(string triggerName)
        {
            return _triggerClient.GetEventSubscriptionStatus(triggerName);
        }

        public TriggerSubscribeTriggerToEventsOperation StartSubscribeTriggerToEvents(string triggerName)
        {
            return _triggerClient.StartSubscribeTriggerToEvents(triggerName);
        }

        public void StartUnsubscribeTriggerFromEvents(string triggerName)
        {
            _triggerClient.StartUnsubscribeTriggerFromEvents(triggerName);
        }

        public void StartStartTrigger(string triggerName)
        {
            _triggerClient.StartStartTrigger(triggerName);
        }

        public void StartStopTrigger(string triggerName)
        {
            _triggerClient.StartStopTrigger(triggerName);
        }

        public IReadOnlyList<TriggerRun> QueryTriggerRunsByWorkspace(RunFilterParameters filterParameters)
        {
            return _triggerRunClient.QueryTriggerRunsByWorkspace(filterParameters).Value.Value;
        }

        #endregion

        #region helpers

        public virtual string ReadJsonFileContent(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException(path);
            }

            using (TextReader reader = new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
        }

        #endregion
    }
}