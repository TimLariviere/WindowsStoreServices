using Newtonsoft.Json;
using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.IapAcquisitions
{
    public class IapAcquisitionsQuery : OrderedQuery<IapAcquisitionsOrderBy>
    {
        public override string Uri => "iapacquisitions";

        [JsonProperty("inAppProductId")]
        public string InAppProductId { get; set; }

        public override string GetUri()
        {
            var uri = base.GetUri();

            uri = $"{uri}&inAppProductId={InAppProductId}";

            return uri;
        }
    }
}
