using WindowsStoreServices.OAuth;
using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.ApplicationList
{
    public class ApplicationListQueryBuilder : QueryBuilder<ApplicationListQueryBuilder, ApplicationListQuery, Application>
    {
        public ApplicationListQueryBuilder(OAuthToken oauthToken)
            : base(oauthToken)
        {
        }
    }
}
