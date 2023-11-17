namespace Logic.Shared.Interfaces
{
    public interface IHttpClient
    {
        Task<T> GetAsync<T>(
            string url,
            List<KeyValuePair<string, object>>? urlParameters = null,
            List<KeyValuePair<string, object>>? headers = null);
    }
}
