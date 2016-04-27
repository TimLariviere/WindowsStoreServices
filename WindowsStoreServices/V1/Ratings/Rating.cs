using System;
using Newtonsoft.Json;

namespace WindowsStoreServices.V1.Ratings
{
    public class Rating
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

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

        [JsonProperty("oneStar")]
        public int OneStar { get; set; }

        [JsonProperty("twoStar")]
        public int TwoStars { get; set; }

        [JsonProperty("threeStars")]
        public int ThreeStars { get; set; }

        [JsonProperty("fourStars")]
        public int FourStars { get; set; }

        [JsonProperty("fiveStars")]
        public int FiveStars { get; set; }
    }
}
