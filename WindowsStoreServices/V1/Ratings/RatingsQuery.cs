using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.Ratings
{
    public class RatingsQuery : OrderedQuery<RatingsOrderBy>
    {
        public override string Uri => "ratings";
    }
}