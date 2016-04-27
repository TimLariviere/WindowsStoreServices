using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.ErrorReportingData
{
    public class ErrorReportingDataQuery : OrderedGroupedQuery<ErrorReportingDataOrderBy, ErrorReportingDataGroupBy>
    {
        public override string Uri => "failurehits";
    }
}
