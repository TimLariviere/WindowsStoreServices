using System.Collections.Generic;
using WindowsStoreServices.OAuth;

namespace WindowsStoreServices.V1.Common
{
    public class OrderedGroupedQueryBuilder<TQueryBuilder, TQuery, TResult, TOrderBy, TGroupBy> : OrderedQueryBuilder<TQueryBuilder, TQuery, TResult, TOrderBy>
        where TQueryBuilder : OrderedQueryBuilder<TQueryBuilder, TQuery, TResult, TOrderBy>
        where TQuery : OrderedGroupedQuery<TOrderBy, TGroupBy>, new()
    {
        public OrderedGroupedQueryBuilder(OAuthToken oauthToken, string applicationId)
            : base(oauthToken, applicationId)
        {
            Query.GroupBy = new List<TGroupBy>();
        }        

        public TQueryBuilder GroupBy(TGroupBy groupByValue)
        {
            Query.GroupBy = new List<TGroupBy>()
            {
                groupByValue
            };
            return this as TQueryBuilder;
        }

        public TQueryBuilder ThenGroupBy(TGroupBy groupByValue)
        {
            Query.GroupBy.Add(groupByValue);
            return this as TQueryBuilder;
        }
    }
}
