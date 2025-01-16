using System;

public interface IHttpService

{
    public Task<HttpResponseMessage> PostAsync<T>(string requestUrl, T payload);
    public Task<HttpResponseMessage> GetAsync(string requestUrl);
    public Task<HttpResponseMessage> PutAsync<T>(string requestUrl, T payload);
    public Task<HttpResponseMessage> DeleteAsync(string request);
    
}
