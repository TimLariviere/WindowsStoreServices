using WindowsStoreServices.OAuth;
using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.IapAcquisitions
{
    public class IapAcquisitionsQueryBuilder : OrderedQueryBuilder<IapAcquisitionsQueryBuilder, IapAcquisitionsQuery, IapAcquisition, IapAcquisitionsOrderBy>
    {
        public IapAcquisitionsQueryBuilder(OAuthToken oauthToken, string applicationId, string inAppProductId)
            : base(oauthToken, applicationId)
        {
            Query = new IapAcquisitionsQuery()
            {
                ApplicationId = applicationId,
                InAppProductId = inAppProductId
            };
        }
    }
}
