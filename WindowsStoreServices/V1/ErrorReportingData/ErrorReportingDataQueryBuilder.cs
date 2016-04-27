using WindowsStoreServices.OAuth;
using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.ErrorReportingData
{
    public class ErrorReportingDataQueryBuilder
        : OrderedGroupedQueryBuilder<ErrorReportingDataQueryBuilder, ErrorReportingDataQuery, ErrorReportingDataItem, ErrorReportingDataOrderBy, ErrorReportingDataGroupBy>
    {
        public ErrorReportingDataQueryBuilder(OAuthToken oauthToken, string applicationId)
            : base(oauthToken, applicationId)
        {
        }
    }
}
