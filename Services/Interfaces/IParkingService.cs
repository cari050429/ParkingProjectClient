using ParkingProjectClient.Models;

namespace ParkingProjectClient.Services.Interfaces
{
    public interface IParkingService
    {
        Task<List<ParkingPermits>> GetAllParkingPermits();

        Task<ParkingPermitDetails> GetParkingPermitById(int parkingId);
        Task<ParkingArea> GetParkingAreaById(int id);

        Task<ParkingAreaTypes> GetParkingAreaTypeById(int id);


        Task<List<ParkingArea>> GetAllParkingAreas();

        Task<List<ParkingAreaTypes>> GetAllParkingAreaTypes();

        Task<bool> CreateParkingPermit(ParkingPermits parkingpermitcreation);

        Task<bool> CreateParkingArea(ParkingArea parkingpermitcreation);
        Task<bool> CreateParkingAreaType(ParkingAreaTypes parkingareatypecreate);

        Task<bool>DeleteParkingPermit(int id);
        Task<bool>DeleteParkingArea(int id);

        Task<bool>DeleteParkingAreaType(int id);

        Task<bool>UpdateParkingPermit(ParkingPermits parkingPermitUpdate); 
        Task<bool>UpdateParkingArea(ParkingArea parkingAreaUpdate); 
        Task<bool>UpdateParkingAreaType(ParkingAreaTypes parkingAreaTypesUpdate); 





    }
}
