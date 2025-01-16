using ParkingProjectClient.Models;
using ParkingProjectClient.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingProjectClient.Services
{
    public class ParkingService : IParkingService
    {
        private readonly IParkingAPIService _parkingApiService;

        public ParkingService(IParkingAPIService parkingApiService)
        {
            _parkingApiService = parkingApiService;
        }

        public async Task<List<ParkingPermits>> GetAllParkingPermits()
        {
            return await _parkingApiService.GetAllParkingPermitsByAreaApi();
        }

        public async Task<ParkingPermitDetails> GetParkingPermitById(int id)
        {
            return await _parkingApiService.GetParkingPermitById(id);
        }

        public async Task<ParkingArea> GetParkingAreaById(int id)
        {
            return await _parkingApiService.GetParkingAreaById(id);
        }

        public async Task<ParkingAreaTypes> GetParkingAreaTypeById(int id)
        {
            return await _parkingApiService.GetParkingAreaTypeById(id);
        }

        public async Task<List<ParkingArea>> GetAllParkingAreas()
        {
            return await _parkingApiService.GetAllParkingAreas();

        }

        public async Task<List<ParkingAreaTypes>> GetAllParkingAreaTypes()
        {
            return await _parkingApiService.GetAllParkingAreaTypes();

        }

        public async Task<bool> CreateParkingPermit(ParkingPermits parkingpermitcreation)
        {
            return await _parkingApiService.CreateParkingPermit(parkingpermitcreation);

        }
        public async Task<bool> CreateParkingArea(ParkingArea parkingareacreation)
        {
            return await _parkingApiService.CreateParkingArea(parkingareacreation);

        }
        public async Task<bool> CreateParkingAreaType(ParkingAreaTypes parkingareatypecreation)
        {
            return await _parkingApiService.CreateParkingAreaType(parkingareatypecreation);

        }
        public async Task<bool> DeleteParkingPermit(int id)
        {
            return await _parkingApiService.DeleteParkingPermit(id);

        }    
        public async Task<bool> DeleteParkingArea(int id)
        {
            return await _parkingApiService.DeleteParkingArea(id);

        }    

        public async Task<bool> DeleteParkingAreaType(int id)
        {
            return await _parkingApiService.DeleteParkingAreaType(id);

        }    

        public async Task<bool>UpdateParkingPermit(ParkingPermits parkingPermitUpdate)
        {
            return await _parkingApiService.UpdateParkingPermit(parkingPermitUpdate);
        }
        public async Task<bool>UpdateParkingArea(ParkingArea parkingAreaUpdate)
        {
            return await _parkingApiService.UpdateParkingArea(parkingAreaUpdate);
        }

        public async Task<bool>UpdateParkingAreaType(ParkingAreaTypes parkingAreaTypesUpdate)
        {
            return await _parkingApiService.UpdateParkingAreaType(parkingAreaTypesUpdate);
        }
    }
}
