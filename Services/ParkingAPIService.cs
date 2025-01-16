using System.Net.Http.Json;
using System.Text.Json;
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
            var response = await _httpservice.GetAsync("http://localhost:5180/api/Parking/getParkingPermits");

            // Deserialize the JSON response into a List of ParkingPermits
            return JsonSerializer.Deserialize<List<ParkingPermits>>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Handles JSON with different casing
            });
        }

        public async Task<ParkingPermitDetails> GetParkingPermitById(int id)
        {
            var response = await _httpservice.GetAsync($"http://localhost:5180/api/Parking/getParkingPermitById/{id}");

            // Deserialize the JSON response into ParkingPermitDetails
            return JsonSerializer.Deserialize<ParkingPermitDetails>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Handles JSON with different casing
            });
        }

        public async Task<ParkingArea> GetParkingAreaById(int id)
        {
            var response = await _httpservice.GetAsync($"http://localhost:5180/api/Parking/getParkingAreaById/{id}");

            // Deserialize the JSON response into ParkingPermitDetails
            return JsonSerializer.Deserialize<ParkingArea>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Handles JSON with different casing
            });
        }

        public async Task<ParkingAreaTypes> GetParkingAreaTypeById(int id)
        {
            var response = await _httpservice.GetAsync($"http://localhost:5180/api/Parking/getParkingAreaTypeById/{id}");

            // Deserialize the JSON response into ParkingPermitDetails
            return JsonSerializer.Deserialize<ParkingAreaTypes>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Handles JSON with different casing
            });
        }

        public async Task<List<ParkingArea>> GetAllParkingAreas()
        {
            var response = await _httpservice.GetAsync("http://localhost:5180/api/Parking/getParkingAreas");

            // Deserialize the JSON response into a List of ParkingArea
            return JsonSerializer.Deserialize<List<ParkingArea>>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Handles JSON with different casing
            });
        }

        public async Task<bool> CreateParkingPermit(ParkingPermits parkingPermitCreation)
        {
            var response = await _httpservice.PostAsync(
                "http://localhost:5180/api/Parking/createParkingPermit",
                parkingPermitCreation
            );

            return response;
        }

        public async Task<bool> CreateParkingArea(ParkingArea parkingareacreate)
        {
            var response = await _httpservice.PostAsync(
                "http://localhost:5180/api/Parking/CreateParkingArea",
                parkingareacreate
            );

            return response;
        }

        public async Task<List<ParkingAreaTypes>> GetAllParkingAreaTypes()
        {
            var response = await _httpservice.GetAsync("http://localhost:5180/api/Parking/getParkingTypes");

            // Deserialize the JSON response into a List of ParkingAreaTypes
            return JsonSerializer.Deserialize<List<ParkingAreaTypes>>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Handles JSON with different casing
            });
        }

        public async Task<bool> CreateParkingAreaType(ParkingAreaTypes parkingareatypecreation)
        {
            var response = await _httpservice.PostAsync(
                "http://localhost:5180/api/Parking/createParkingAreaType",
                parkingareatypecreation
            );

            return response;
        }

        public async Task<bool> DeleteParkingPermit(int id)
        {
            var response = await _httpservice.DeleteAsync($"http://localhost:5180/api/Parking/deleteParkingPermit/{id}");
            return response;
        }

        public async Task<bool> DeleteParkingArea(int id)
        {
            var response = await _httpservice.DeleteAsync($"http://localhost:5180/api/Parking/deleteParkingArea/{id}");
            return response;
        }

        public async Task<bool> DeleteParkingAreaType(int id)
        {
            var response = await _httpservice.DeleteAsync($"http://localhost:5180/api/Parking/deleteParkingAreaType/{id}");
            return response;
        }

        public async Task<bool> UpdateParkingPermit(ParkingPermits updateParkingPermit)
        {
            var response = await _httpservice.PutAsync($"http://localhost:5180/api/Parking/UpdateParkingPermit/{updateParkingPermit.Id.Value}", updateParkingPermit );
            return response;
        }

        public async Task<bool> UpdateParkingArea(ParkingArea updateParkingArea)
        {
            var response = await _httpservice.PutAsync($"http://localhost:5180/api/Parking/UpdateParkingArea/{updateParkingArea.Id}", updateParkingArea);
            return response;
        }

        public async Task<bool> UpdateParkingAreaType(ParkingAreaTypes updateParkingAreaType)
        {
            var response = await _httpservice.PutAsync($"http://localhost:5180/api/Parking/UpdateParkingAreaType/{updateParkingAreaType.Id}", updateParkingAreaType);
            return response;
        }
    }
}
