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

            // Deserialize the JSON response into a List of ParkingPermitsArea
            return JsonSerializer.Deserialize<List<ParkingPermits>>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Handles JSON with different casing
            });
        }

        // public ParkingPermits GetParkingPermitByIDApi(int parkingId)
        // {
        //     List<ParkingPermits> parkingPermits = new List<ParkingPermits>();

        //     var parkingpermit1 = new ParkingPermits
        //     {
        //         Id = 1,
        //         ParkingAreaID = 101,
        //         EffectiveDate = DateTime.Now,
        //         ExpirationDate = DateTime.Now.AddMonths(6),
        //         LicensePlate = "ABC123",
        //         ParkingAreaName = "Flamingo",
        //         CreateDate = DateTime.Now,
        //         Inactive = false,
        //         ParkingAreaTypeId = 2,
        //         Longitude = -29.99493,
        //         Latitude = -49.003830,
        //         DateCreated = DateTime.Now,


        //     };
        //     var parkingpermit2 = new ParkingPermits
        //     {
        //         Id = 2,
        //         ParkingAreaID = 2,
        //         EffectiveDate = DateTime.Now,
        //         ExpirationDate = DateTime.Now.AddMonths(6),
        //         LicensePlate = "ABC123",
        //         ParkingAreaName = "Flamingo",
        //         CreateDate = DateTime.Now,
        //         Inactive = false,
        //         ParkingAreaTypeId = 2,
        //         Longitude = -29.99493,
        //         Latitude = -49.003830,
        //         DateCreated = DateTime.Now,


        //     };
        //     var parkingpermit3 = new ParkingPermits
        //     {
        //         Id = 3,
        //         ParkingAreaID = 2,
        //         EffectiveDate = DateTime.Now,
        //         ExpirationDate = DateTime.Now.AddMonths(6),
        //         LicensePlate = "ABC123",
        //         ParkingAreaName = "Flamingo",
        //         CreateDate = DateTime.Now,
        //         Inactive = false,
        //         ParkingAreaTypeId = 2,
        //         Longitude = -29.99493,
        //         Latitude = -49.003830,
        //         DateCreated = DateTime.Now,


        //     };

        //     parkingPermits.Add(parkingpermit1);
        //     parkingPermits.Add(parkingpermit2);
        //     parkingPermits.Add(parkingpermit3);

        //     var parkingPermit = parkingPermits.FirstOrDefault(item => item.Id == parkingId);


        //     return parkingPermit;

        // }
    }
}
