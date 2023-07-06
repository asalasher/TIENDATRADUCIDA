namespace TIENDA2.DataAccess
{
    public interface IHttpRequestService
    {
        Task<string?> Get(string url);
        Task<string?> Post(string url, object body);
    }
}