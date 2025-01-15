using ParkingProjectClient.Models;

namespace ParkingProjectClient.Services.Interfaces
{
    public interface IParkingAPIService
    {
        // ParkingPermits GetParkingPermitByIDApi(int parkingId);
        Task<List<ParkingPermits>> GetAllParkingPermitsByAreaApi();


    }
}
