using Newtonsoft.Json;

namespace WindowsStoreServices.V1.ApplicationList
{
    public class Application
    {
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("applicationName")]
        public string ApplicationName { get; set; }

        [JsonProperty("publisherId")]
        public string PublisherId { get; set; }

        [JsonProperty("iconURLList")]
        public string IconURLList { get; set; }
        
        [JsonProperty("publisherName")]
        public string PublisherName { get; set; }

        [JsonProperty("packageFamilyName")]
        public string PackageFamilyName { get; set; }

        [JsonProperty("packageIdentityName")]
        public string PackageIdentityName { get; set; }
    }
}
