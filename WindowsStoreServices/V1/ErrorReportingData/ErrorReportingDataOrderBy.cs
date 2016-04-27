using Newtonsoft.Json;

namespace WindowsStoreServices.V1.ErrorReportingData
{
    public enum ErrorReportingDataOrderBy
    {
        [JsonProperty("date")]
        Date,

        [JsonProperty("failureName")]
        FailureName,

        [JsonProperty("failureHash")]
        FailureHash,

        [JsonProperty("symbol")]
        Symbol,

        [JsonProperty("osVersion")]
        OsVersion,

        [JsonProperty("eventType")]
        EventType,

        [JsonProperty("market")]
        Market,

        [JsonProperty("deviceType")]
        DeviceType,

        [JsonProperty("packageName")]
        PackageName,

        [JsonProperty("packageVersion")]
        PackageVersion
    }
}
