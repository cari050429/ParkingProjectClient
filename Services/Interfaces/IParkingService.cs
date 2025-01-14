using ParkingProjectClient.Models;

namespace ParkingProjectClient.Services.Interfaces
{
    public interface IParkingService
    {
        List<ParkingPermitsArea> GetAllParkingPermitsByArea();

        ParkingPermits GetParkingPermitById(int parkingId);



    }
}
