using WindowsStoreServices.V1.Common;

namespace WindowsStoreServices.V1.AppAcquisitions
{
    public class AppAcquisitionsQuery : OrderedQuery<AppAcquisitionsOrderBy>
    {
        public override string Uri => "appacquisitions";
    }
}
