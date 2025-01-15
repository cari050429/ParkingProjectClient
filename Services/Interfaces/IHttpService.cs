using System;

public interface IHttpService

{
    public Task<string> PostAsync<T>(string requestUrl, T payload);
    public Task<string> GetAsync(string requestUrl);
    // public Task<string> PutAsync<T>(string requestUrl, T payload);
    // public Task<string> DeleteAsync<T>(string request, T payload);
    
}
