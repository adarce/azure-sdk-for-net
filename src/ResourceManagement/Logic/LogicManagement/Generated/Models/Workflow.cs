// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class Workflow : Resource
    {
        /// <summary>
        /// Gets the created time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets the changed time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.changedTime")]
        public DateTime? ChangedTime { get; private set; }

        /// <summary>
        /// Gets or sets the state. Possible values for this property include:
        /// 'NotSpecified', 'Enabled', 'Disabled', 'Deleted', 'Suspended'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public WorkflowState? State { get; set; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets the access endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessEndpoint")]
        public string AccessEndpoint { get; private set; }

        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the link to definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.definitionLink")]
        public ContentLink DefinitionLink { get; set; }

        /// <summary>
        /// Gets or sets the definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.definition")]
        public object Definition { get; set; }

        /// <summary>
        /// Gets or sets the link to parameters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parametersLink")]
        public ContentLink ParametersLink { get; set; }

        /// <summary>
        /// Gets or sets the parameters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, WorkflowParameter> Parameters { get; set; }

    }
}