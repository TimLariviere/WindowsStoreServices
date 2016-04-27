using Newtonsoft.Json;
using System;

namespace WindowsStoreServices.V1.Reviews
{
    public class Review
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("applicationName")]
        public string ApplicationName { get; set; }

        [JsonProperty("market")]
        public string Market { get; set; }

        [JsonProperty("osVersion")]
        public string OsVersion { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("isRevised")]
        public bool IsRevised { get; set; }

        [JsonProperty("packageVersion")]
        public string PackageVersion { get; set; }

        [JsonProperty("deviceModel")]
        public string DeviceModel { get; set; }

        [JsonProperty("productFamily")]
        public string ProductFamily { get; set; }

        [JsonProperty("deviceRAM")]
        public int DeviceRAM { get; set; }

        [JsonProperty("deviceScreenResolution")]
        public string DeviceScreenResolution { get; set; }

        [JsonProperty("deviceStorageCapacity")]
        public int DeviceStorageCapacity { get; set; }

        [JsonProperty("isTouchEnabled")]
        public bool IsTouchEnabled { get; set; }

        [JsonProperty("reviewerName")]
        public string ReviewerName { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("reviewTitle")]
        public string ReviewTitle { get; set; }

        [JsonProperty("reviewText")]
        public string ReviewText { get; set; }

        [JsonProperty("helpfulCount")]
        public int HelpfulCount { get; set; }

        [JsonProperty("notHelpfulCount")]
        public int NotHelpfulCount { get; set; }

        [JsonProperty("responseDate")]
        public DateTime? ResponseDate { get; set; }

        [JsonProperty("responseText")]
        public string ResponseText { get; set; }
    }
}
