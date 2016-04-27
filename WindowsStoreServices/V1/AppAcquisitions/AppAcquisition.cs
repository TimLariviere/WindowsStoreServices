using Newtonsoft.Json;

namespace WindowsStoreServices.V1.AppAcquisitions
{
    public class AppAcquisition
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("applicationName")]
        public string ApplicationName { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("orderName")]
        public string OrderName { get; set; }

        [JsonProperty("storeClient")]
        public string StoreClient { get; set; }

        [JsonProperty("osVersion")]
        public string OsVersion { get; set; }

        [JsonProperty("market")]
        public string Market { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("ageGroup")]
        public string AgeGroup { get; set; }

        [JsonProperty("acquisitionType")]
        public string AcquisitionType { get; set; }

        [JsonProperty("acquisitionQuantity")]
        public int AcquisitionQuantity { get; set; }
    }
}
