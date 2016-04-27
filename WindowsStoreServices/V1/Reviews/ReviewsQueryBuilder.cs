using WindowsStoreServices.OAuth;
using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.Reviews
{
    public class ReviewsQueryBuilder : OrderedQueryBuilder<ReviewsQueryBuilder, ReviewsQuery, Review, ReviewsOrderBy>
    {
        public ReviewsQueryBuilder(OAuthToken oauthToken, string applicationId)
            : base(oauthToken, applicationId)
        {
        }
    }
}
