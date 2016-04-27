namespace WindowsStoreServices.V1.Common
{
    public abstract class Query
    {
        public abstract string Uri { get; }

        public virtual string GetUri()
        {
            return Uri;
        }
    }
}
