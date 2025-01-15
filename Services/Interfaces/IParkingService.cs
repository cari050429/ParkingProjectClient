using ParkingProjectClient.Models;

namespace ParkingProjectClient.Services.Interfaces
{
    public interface IParkingService
    {
        Task<List<ParkingPermits>> GetAllParkingPermitsByArea();

        //ParkingPermits GetParkingPermitById(int parkingId);



    }
}
