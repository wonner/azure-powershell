﻿using Azure.Analytics.Synapse.Artifacts.Models;
using Microsoft.Azure.Commands.Common.Compute.Version_2018_04.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Microsoft.Azure.Commands.Synapse.Models
{
    [Rest.Serialization.JsonTransformation]
    public class PSPipelineResource : PSSubResource
    {
        public PSPipelineResource(PipelineResource pipelineResource, string workspaceName)
            : base(pipelineResource?.Id,
                pipelineResource?.Name,
                pipelineResource?.Type,
                pipelineResource?.Etag)
        {
            this.WorkspaceName = workspaceName;
            this.Description = pipelineResource?.Description;
            this.Activities = pipelineResource?.Activities?.Select(element => new PSActivity(element)).ToList();
            this.Values = pipelineResource?.Values;
            this.Variables = pipelineResource?.Variables?
                .Select(element => new KeyValuePair<string, PSVariableSpecification>(element.Key, new PSVariableSpecification(element.Value)))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            this.Concurrency = pipelineResource?.Concurrency;
            this.Annotations = pipelineResource?.Annotations;
            this.RunDimensions = pipelineResource?.RunDimensions;
            this.Folder = new PSPipelineFolder(pipelineResource?.Folder);
            this.Keys = pipelineResource?.Keys;
            this.Parameters = pipelineResource?.Parameters?
                .Select(element => new KeyValuePair<string, PSParameterSpecification>(element.Key, new PSParameterSpecification(element.Value)))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }

        public PSPipelineResource() { }

        public string WorkspaceName { get; set; }

        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "properties.activities")]
        public IList<PSActivity> Activities { get; set; }

        [JsonProperty(PropertyName = "properties.values")]
        public ICollection<object> Values { get; set; }

        [JsonProperty(PropertyName = "properties.variables")]
        public IDictionary<string, PSVariableSpecification> Variables { get; set; }

        [JsonProperty(PropertyName = "properties.concurrency")]
        public int? Concurrency { get; set; }

        [JsonProperty(PropertyName = "properties.annotations")]
        public IList<object> Annotations { get; set; }

        [JsonProperty(PropertyName = "properties.runDimensions")]
        public IDictionary<string, object> RunDimensions { get; set; }

        [JsonProperty(PropertyName = "properties.folder")]
        public PSPipelineFolder Folder { get; set; }

        [JsonProperty(PropertyName = "properties.keys")]
        public ICollection<string> Keys { get; set; }

        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, PSParameterSpecification> Parameters { get; set; }

        public PipelineResource ToSdkObject()
        {
            PipelineResource pipeline = new PipelineResource
            {
                Description = this.Description,
                Concurrency = this.Concurrency,
                Folder = this.Folder?.ToSdkObject()
            };

            return pipeline;
        }
    }
}
