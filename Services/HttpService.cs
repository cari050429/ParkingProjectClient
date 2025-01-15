using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;

public class HttpService : IHttpService
{
    private readonly HttpClient _httpClient;

    public HttpService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

	public async Task<string> PostAsync<T>(string requestUrl, T payload)
    {
        string jsonPayLoad = JsonSerializer.Serialize(payload);
        var content = new StringContent(jsonPayLoad, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(requestUrl, content);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
    public async Task<string> GetAsync(string requestUrl )
    {

        var response= await _httpClient.GetAsync(requestUrl);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
     }
    // public async Task<string> PutAsync<T>(string requestUrl, T payload)
    // {



    // }
    // public async Task<string> DeleteAsync<T>(string request, T payload)
    // {

    // }
}
