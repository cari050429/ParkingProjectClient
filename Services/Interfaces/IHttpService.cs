using System;

public interface IHttpService

{
    public Task<bool> PostAsync<T>(string requestUrl, T payload);
    public Task<string> GetAsync(string requestUrl);
    public Task<bool> PutAsync<T>(string requestUrl, T payload);
    public Task<bool> DeleteAsync(string request);
    
}
