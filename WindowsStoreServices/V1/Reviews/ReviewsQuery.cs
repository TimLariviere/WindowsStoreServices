using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.Reviews
{
    public class ReviewsQuery : OrderedQuery<ReviewsOrderBy>
    {
        public override string Uri => "reviews";
    }
}
