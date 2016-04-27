using Newtonsoft.Json;

namespace WindowsStoreServices.V1.AppAcquisitions
{
    public enum AppAcquisitionsOrderBy
    {
        [JsonProperty("date")]
        Date,

        [JsonProperty("acquisitionType")]
        AcquisitionType,

        [JsonProperty("ageGroup")]
        AgeGroup,

        [JsonProperty("storeClient")]
        StoreClient,

        [JsonProperty("gender")]
        Gender,

        [JsonProperty("market")]
        Market,

        [JsonProperty("osVersion")]
        OsVersion,

        [JsonProperty("deviceType")]
        DeviceType,

        [JsonProperty("orderName")]
        OrderName
    }
}
