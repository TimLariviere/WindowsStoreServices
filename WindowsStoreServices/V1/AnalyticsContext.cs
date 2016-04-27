using WindowsStoreServices.OAuth;
using WindowsStoreServices.V1.AppAcquisitions;
using WindowsStoreServices.V1.ApplicationList;
using WindowsStoreServices.V1.ErrorReportingData;
using WindowsStoreServices.V1.IapAcquisitions;
using WindowsStoreServices.V1.Ratings;
using WindowsStoreServices.V1.Reviews;

namespace WindowsStoreServices.V1
{
    public class AnalyticsContext
    {
        private OAuthToken _token;

        public AnalyticsContext(OAuthToken token)
        {
            _token = token;
        }

        public void SetOAuthToken(OAuthToken token)
        {
            _token = token;
        }

        public AppAcquisitionsQueryBuilder AppAcquisitions(string applicationId)
        {
            return new AppAcquisitionsQueryBuilder(_token, applicationId);
        }

        public ApplicationListQueryBuilder Applications()
        {
            return new ApplicationListQueryBuilder(_token);
        }

        public ErrorReportingDataQueryBuilder ErrorReportingData(string applicationId)
        {
            return new ErrorReportingDataQueryBuilder(_token, applicationId);
        }

        public IapAcquisitionsQueryBuilder IapAcquisitions(string applicationId, string inAppProductId)
        {
            return new IapAcquisitionsQueryBuilder(_token, applicationId, inAppProductId);
        }

        public RatingsQueryBuilder Ratings(string applicationId)
        {
            return new RatingsQueryBuilder(_token, applicationId);
        }

        public ReviewsQueryBuilder Reviews(string applicationId)
        {
            return new ReviewsQueryBuilder(_token, applicationId);
        }
    }
}
