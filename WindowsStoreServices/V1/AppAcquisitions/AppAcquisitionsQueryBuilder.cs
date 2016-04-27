using WindowsStoreServices.OAuth;
using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.AppAcquisitions
{
    public class AppAcquisitionsQueryBuilder : OrderedQueryBuilder<AppAcquisitionsQueryBuilder, AppAcquisitionsQuery, AppAcquisition, AppAcquisitionsOrderBy>
    {
        public AppAcquisitionsQueryBuilder(OAuthToken oauthToken, string applicationId)
            : base(oauthToken, applicationId)
        {
        }
    }
}
