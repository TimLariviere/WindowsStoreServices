using Newtonsoft.Json;

namespace WindowsStoreServices.V1.ErrorReportingData
{
    public class ErrorReportingDataItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("applicationName")]
        public string ApplicationName { get; set; }

        [JsonProperty("failureName")]
        public string FailureName { get; set; }

        [JsonProperty("failureHash")]
        public string FailureHash { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("osVersion")]
        public string OsVersion { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("market")]
        public string Market { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("packageName")]
        public string PackageName { get; set; }

        [JsonProperty("packageVersion")]
        public string PackageVersion { get; set; }

        [JsonProperty("deviceCount")]
        public float DeviceCount { get; set; }

        [JsonProperty("eventCount")]
        public float EventCount { get; set; }
    }
}
