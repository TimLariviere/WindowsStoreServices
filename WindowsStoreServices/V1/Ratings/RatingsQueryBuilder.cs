using WindowsStoreServices.OAuth;
using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.Ratings
{
    public class RatingsQueryBuilder : OrderedQueryBuilder<RatingsQueryBuilder, RatingsQuery, Rating, RatingsOrderBy>
    {
        public RatingsQueryBuilder(OAuthToken oauthToken, string applicationId)
            : base(oauthToken, applicationId)
        {
        }
    }
}
