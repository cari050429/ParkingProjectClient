using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ParkingProjectClient.Models;
using ParkingProjectClient.Services.Interfaces;

namespace ParkingProjectClient.Services
{
    public class ParkingAPIService : IParkingAPIService
    {
        private readonly IHttpService _httpservice;

        public ParkingAPIService(IHttpService httpservice)
        {
            _httpservice = httpservice;
        }

        public async Task<List<ParkingPermits>> GetAllParkingPermitsByAreaApi()
        {
            return await CallApiAsync(
                () => _httpservice.GetAsync("http://localhost:5180/api/Parking/getParkingPermits"),
                new List<ParkingPermits>()
            );
        }

        public async Task<ParkingPermitDetails> GetParkingPermitById(int id)
        {
            return await CallApiAsync(
                () => _httpservice.GetAsync($"http://localhost:5180/api/Parking/getParkingPermitById/{id}"),
                new ParkingPermitDetails()
            );
        }

        public async Task<ParkingArea> GetParkingAreaById(int id)
        {
            return await CallApiAsync(
                () => _httpservice.GetAsync($"http://localhost:5180/api/Parking/getParkingAreaById/{id}"),
                new ParkingArea()
            );
        }

        public async Task<ParkingAreaTypes> GetParkingAreaTypeById(int id)
        {
            return await CallApiAsync(
                () => _httpservice.GetAsync($"http://localhost:5180/api/Parking/getParkingAreaTypeById/{id}"),
                new ParkingAreaTypes()
            );
        }

        public async Task<List<ParkingArea>> GetAllParkingAreas()
        {
            return await CallApiAsync(
                () => _httpservice.GetAsync("http://localhost:5180/api/Parking/getParkingAreas"),
                new List<ParkingArea>()
            );
        }

        public async Task<bool> CreateParkingPermit(ParkingPermits parkingPermitCreation)
        {
            return await CallApiAsync(
                () => _httpservice.PostAsync("http://localhost:5180/api/Parking/createParkingPermit", parkingPermitCreation),
                default(bool)
            );
        }

        public async Task<bool> CreateParkingArea(ParkingArea parkingareacreate)
        {
            return await CallApiAsync(
                () => _httpservice.PostAsync("http://localhost:5180/api/Parking/CreateParkingArea", parkingareacreate),
                default(bool)
            );
        }

        public async Task<List<ParkingAreaTypes>> GetAllParkingAreaTypes()
        {
            return await CallApiAsync(
                () => _httpservice.GetAsync("http://localhost:5180/api/Parking/getParkingTypes"),
                new List<ParkingAreaTypes>()
            );
        }

        public async Task<bool> CreateParkingAreaType(ParkingAreaTypes parkingareatypecreation)
        {
            return await CallApiAsync(
                () => _httpservice.PostAsync("http://localhost:5180/api/Parking/createParkingAreaType", parkingareatypecreation),
                false
            );
        }

        public async Task<bool> DeleteParkingPermit(int id)
        {
            return await CallApiAsync(
                () => _httpservice.DeleteAsync($"http://localhost:5180/api/Parking/deleteParkingPermit/{id}"),
                false
            );
        }

        public async Task<bool> DeleteParkingArea(int id)
        {
            return await CallApiAsync(
                () => _httpservice.DeleteAsync($"http://localhost:5180/api/Parking/deleteParkingArea/{id}"),
                false
            );
        }

        public async Task<bool> DeleteParkingAreaType(int id)
        {
            return await CallApiAsync(
                () => _httpservice.DeleteAsync($"http://localhost:5180/api/Parking/deleteParkingAreaType/{id}"),
                false
            );
        }

        public async Task<bool> UpdateParkingPermit(ParkingPermits updateParkingPermit)
        {
            return await CallApiAsync(
                () => _httpservice.PutAsync($"http://localhost:5180/api/Parking/UpdateParkingPermit/{updateParkingPermit.Id.Value}", updateParkingPermit),
                false
            );
        }

        public async Task<bool> UpdateParkingArea(ParkingArea updateParkingArea)
        {
            return await CallApiAsync(
                () => _httpservice.PutAsync($"http://localhost:5180/api/Parking/UpdateParkingArea/{updateParkingArea.Id}", updateParkingArea),
                false
            );
        }

        public async Task<bool> UpdateParkingAreaType(ParkingAreaTypes updateParkingAreaType)
        {
            return await CallApiAsync(
                () => _httpservice.PutAsync($"http://localhost:5180/api/Parking/UpdateParkingAreaType/{updateParkingAreaType.Id}", updateParkingAreaType),
                false
            );
        }

        private async Task<T> CallApiAsync<T>(Func<Task<HttpResponseMessage>> apiCall, T defaultValue)
        {
            try
            {
                var response = await apiCall();
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadFromJsonAsync<T>();
                return data  != null ? data : defaultValue;
            }
            catch (HttpRequestException ex)
            {
                Console.Error.WriteLine($"Request failed: {ex.Message}");
                return defaultValue; 
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"An unexpected error occurred: {ex.Message}");
                return defaultValue; 
            }
        }
    }
}
