using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.WebEncoders.Testing;

public class HttpService : IHttpService
{
    private readonly HttpClient _httpClient;

    public HttpService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<HttpResponseMessage> PostAsync<T>(string requestUrl, T payload)
    {
        string jsonPayLoad = JsonSerializer.Serialize(payload);
        var content = new StringContent(jsonPayLoad, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(requestUrl, content);

        response.EnsureSuccessStatusCode();

        return response;
    }

    public async Task<HttpResponseMessage> GetAsync(string requestUrl)
    {
        var response = await _httpClient.GetAsync(requestUrl);

        response.EnsureSuccessStatusCode();

        return response;
    }

    public async Task<HttpResponseMessage> PutAsync<T>(string requestUrl, T payload)
    {
        string jsonPayload = JsonSerializer.Serialize(payload);
        var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
        var response = await _httpClient.PutAsync(requestUrl, content);

        response.EnsureSuccessStatusCode();

        return response;
    }

    public async Task<HttpResponseMessage> DeleteAsync(string requestUrl)
    {
        var response = await _httpClient.DeleteAsync(requestUrl);

        response.EnsureSuccessStatusCode();

        return response;
    }
}
