using ParkingProjectClient.Models;
using ParkingProjectClient.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ParkingProjectClient.Services
{
    public class ParkingService : IParkingService
    {
        private readonly IParkingAPIService _parkingApiService;

        public ParkingService(IParkingAPIService parkingApiService)
        {
            _parkingApiService = parkingApiService;
        }

        public List<ParkingPermitsArea> GetAllParkingPermitsByArea()
        {
            return _parkingApiService.GetAllParkingPermitsByAreaApi();
        }

        public ParkingPermits GetParkingPermitById(int id)
        {
            return _parkingApiService.GetParkingPermitByIDApi(id);
        }
    }
}
