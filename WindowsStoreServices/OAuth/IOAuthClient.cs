using System.Threading.Tasks;

namespace WindowsStoreServices.OAuth
{
    public interface IOAuthClient
    {
        Task<OAuthToken> GetTokenAsync(string tenantId, string clientId, string clientSecret);
    }
}
