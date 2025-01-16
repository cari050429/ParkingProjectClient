using ParkingProjectClient.Models;

namespace ParkingProjectClient.Services.Interfaces
{
    public interface IParkingAPIService
    {
        Task<List<ParkingPermits>> GetAllParkingPermitsByAreaApi();
        Task<ParkingPermitDetails> GetParkingPermitById(int id);
        Task<ParkingArea> GetParkingAreaById(int id);
        Task<ParkingAreaTypes> GetParkingAreaTypeById(int id);



        Task<List<ParkingArea>> GetAllParkingAreas();
        Task<List<ParkingAreaTypes>> GetAllParkingAreaTypes();

        Task<bool> CreateParkingPermit(ParkingPermits parkingpermitcreation);
        Task<bool> CreateParkingArea(ParkingArea parkingareacreate);
        Task<bool> CreateParkingAreaType(ParkingAreaTypes parkingareatypecreate);

        Task<bool>DeleteParkingPermit(int id);
        Task<bool>DeleteParkingArea(int id);

        Task<bool>DeleteParkingAreaType(int id);

        Task<bool>UpdateParkingPermit(ParkingPermits parkingPermitUpdate); 
        Task<bool>UpdateParkingArea(ParkingArea parkingAreaUpdate); 
        Task<bool>UpdateParkingAreaType(ParkingAreaTypes parkingAreaTypesUpdate); 









    }
}
