﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MS.IoT.Simulator.WPF.Models
{
    /// <summary>
    /// CosmosDBMessage
    /// Contains a mapping of the message collection, including the dynamic objects generated by the templates
    /// </summary>
    public class CosmosDBMessage
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }
        [JsonProperty(PropertyName = "demoId")]
        public int DemoId { get; set; }
        [JsonProperty(PropertyName = "demoInstanceId")]
        public Guid DemoInstanceId { get; set; }
        [JsonProperty(PropertyName = "templateId")]
        public string TemplateId { get; set; }
        [JsonProperty(PropertyName = "properties")]
        public Dictionary<string, object> Properties { get; set; }
        [JsonProperty(PropertyName = "EventProcessedUtcTime")]
        public DateTime EventProcessedUtcTime { get; set; }
        [JsonProperty(PropertyName = "EventEnqueuedUtcTime")]
        public DateTime EventEnqueuedUtcTime { get; set; }
        [JsonProperty(PropertyName = "PartitionId")]
        public int PartitionId { get; set; }
        [JsonProperty(PropertyName = "IoTHub")]
        public CosmosDBIoTHub IoTHub { get; set; }

        public string DeviceId { get { return IoTHub.ConnectionDeviceId; } }
    }
}