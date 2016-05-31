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
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A pool in the Azure Batch service to add.
    /// </summary>
    public partial class PoolAddParameter
    {
        /// <summary>
        /// Initializes a new instance of the PoolAddParameter class.
        /// </summary>
        public PoolAddParameter() { }

        /// <summary>
        /// Initializes a new instance of the PoolAddParameter class.
        /// </summary>
        public PoolAddParameter(string id, string vmSize, string displayName = default(string), CloudServiceConfiguration cloudServiceConfiguration = default(CloudServiceConfiguration), VirtualMachineConfiguration virtualMachineConfiguration = default(VirtualMachineConfiguration), TimeSpan? resizeTimeout = default(TimeSpan?), int? targetDedicated = default(int?), bool? enableAutoScale = default(bool?), string autoScaleFormula = default(string), TimeSpan? autoScaleEvaluationInterval = default(TimeSpan?), bool? enableInterNodeCommunication = default(bool?), StartTask startTask = default(StartTask), IList<CertificateReference> certificateReferences = default(IList<CertificateReference>), IList<ApplicationPackageReference> applicationPackageReferences = default(IList<ApplicationPackageReference>), int? maxTasksPerNode = default(int?), TaskSchedulingPolicy taskSchedulingPolicy = default(TaskSchedulingPolicy), IList<MetadataItem> metadata = default(IList<MetadataItem>))
        {
            Id = id;
            DisplayName = displayName;
            VmSize = vmSize;
            CloudServiceConfiguration = cloudServiceConfiguration;
            VirtualMachineConfiguration = virtualMachineConfiguration;
            ResizeTimeout = resizeTimeout;
            TargetDedicated = targetDedicated;
            EnableAutoScale = enableAutoScale;
            AutoScaleFormula = autoScaleFormula;
            AutoScaleEvaluationInterval = autoScaleEvaluationInterval;
            EnableInterNodeCommunication = enableInterNodeCommunication;
            StartTask = startTask;
            CertificateReferences = certificateReferences;
            ApplicationPackageReferences = applicationPackageReferences;
            MaxTasksPerNode = maxTasksPerNode;
            TaskSchedulingPolicy = taskSchedulingPolicy;
            Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the pool within the
        /// account. The id can contain any combination of alphanumeric
        /// characters including hyphens and underscores, and cannot contain
        /// more than 64 characters.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the pool.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the size of virtual machines in the pool.  All VMs in
        /// a pool are the same size.
        /// </summary>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets the cloud service configuration for the pool. This
        /// property and VirtualMachineConfiguration are mutually exclusive
        /// and one of the properties must be specified.
        /// </summary>
        [JsonProperty(PropertyName = "cloudServiceConfiguration")]
        public CloudServiceConfiguration CloudServiceConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine configuration for the pool. This
        /// property and CloudServiceConfiguration are mutually exclusive and
        /// one of the properties must be specified.
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachineConfiguration")]
        public VirtualMachineConfiguration VirtualMachineConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the timeout for allocation of compute nodes to the
        /// pool. In a Get Pool operation, this is the timeout for the most
        /// recent resize operation. The default value is 10 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "resizeTimeout")]
        public TimeSpan? ResizeTimeout { get; set; }

        /// <summary>
        /// Gets or sets the desired number of compute nodes in the pool. This
        /// property must have the default value if EnableAutoScale is true.
        /// It is required if EnableAutoScale is false.
        /// </summary>
        [JsonProperty(PropertyName = "targetDedicated")]
        public int? TargetDedicated { get; set; }

        /// <summary>
        /// Gets or sets whether the pool size should automatically adjust
        /// over time. If true, the AutoScaleFormula property must be set. If
        /// false, the TargetDedicated property must be set.
        /// </summary>
        [JsonProperty(PropertyName = "enableAutoScale")]
        public bool? EnableAutoScale { get; set; }

        /// <summary>
        /// Gets or sets a formula for the desired number of compute nodes in
        /// the pool.
        /// </summary>
        [JsonProperty(PropertyName = "autoScaleFormula")]
        public string AutoScaleFormula { get; set; }

        /// <summary>
        /// Gets or sets a time interval for the desired autoscale evaluation
        /// period in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "autoScaleEvaluationInterval")]
        public TimeSpan? AutoScaleEvaluationInterval { get; set; }

        /// <summary>
        /// Gets or sets whether the pool permits direct communication between
        /// nodes.
        /// </summary>
        [JsonProperty(PropertyName = "enableInterNodeCommunication")]
        public bool? EnableInterNodeCommunication { get; set; }

        /// <summary>
        /// Gets or sets a task specified to run on each compute node as it
        /// joins the pool.
        /// </summary>
        [JsonProperty(PropertyName = "startTask")]
        public StartTask StartTask { get; set; }

        /// <summary>
        /// Gets or sets the list of certificates to be installed on each
        /// compute node in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "certificateReferences")]
        public IList<CertificateReference> CertificateReferences { get; set; }

        /// <summary>
        /// Gets or sets the list of application packages to be installed on
        /// each compute node in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "applicationPackageReferences")]
        public IList<ApplicationPackageReference> ApplicationPackageReferences { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of tasks that can run concurrently
        /// on a single compute node in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "maxTasksPerNode")]
        public int? MaxTasksPerNode { get; set; }

        /// <summary>
        /// Gets or sets how the Batch service distributes tasks between
        /// compute nodes in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "taskSchedulingPolicy")]
        public TaskSchedulingPolicy TaskSchedulingPolicy { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the pool
        /// as metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (VmSize == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VmSize");
            }
            if (this.CloudServiceConfiguration != null)
            {
                this.CloudServiceConfiguration.Validate();
            }
            if (this.VirtualMachineConfiguration != null)
            {
                this.VirtualMachineConfiguration.Validate();
            }
            if (this.CertificateReferences != null)
            {
                foreach (var element in this.CertificateReferences)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.ApplicationPackageReferences != null)
            {
                foreach (var element1 in this.ApplicationPackageReferences)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.TaskSchedulingPolicy != null)
            {
                this.TaskSchedulingPolicy.Validate();
            }
        }
    }
}