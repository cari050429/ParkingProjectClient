using ParkingProjectClient.Models;
using ParkingProjectClient.Services.Interfaces;

namespace ParkingProjectClient.Services
{
    public class ParkingAPIService : IParkingAPIService
    {

        public List<ParkingPermitsArea> GetAllParkingPermitsByAreaApi()
        {
            List<ParkingPermitsArea> parkingAreasList = new List<ParkingPermitsArea>();


            var newParkingArea1 = new ParkingPermitsArea
            {
                ID = 1,
                ParkingAreaID = 101,
                EffectiveDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddMonths(6),
                LicensePlate = "ABC123",
                ParkingAreaName = "Flamingo",
                CreateDate = DateTime.Now,
                Inactive = false
            };

            var newParkingArea2 = new ParkingPermitsArea
            {
                ID = 2,
                ParkingAreaID = 2,
                EffectiveDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddMonths(6),
                LicensePlate = "ABD123",
                ParkingAreaName = "Flamingo",
                CreateDate = DateTime.Now,
                Inactive = false
            };
            var newParkingArea3 = new ParkingPermitsArea
            {
                ID = 3,
                ParkingAreaID = 2,
                EffectiveDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddMonths(6),
                LicensePlate = "AND123",
                ParkingAreaName = "Flamingo",
                CreateDate = DateTime.Now,
                Inactive = false
            };

            parkingAreasList.Add(newParkingArea1);
            parkingAreasList.Add(newParkingArea2);
            parkingAreasList.Add(newParkingArea3);

            return parkingAreasList;
        }

        public ParkingPermits GetParkingPermitByIDApi(int parkingId)
        {
            List<ParkingPermits> parkingPermits = new List<ParkingPermits>();

            var parkingpermit1 = new ParkingPermits
            {
                Id = 1,
                ParkingAreaID = 101,
                EffectiveDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddMonths(6),
                LicensePlate = "ABC123",
                ParkingAreaName = "Flamingo",
                CreateDate = DateTime.Now,
                Inactive = false,
                ParkingAreaTypeId = 2,
                Longitude = -29.99493,
                Latitude = -49.003830,
                DateCreated = DateTime.Now,


            };
            var parkingpermit2 = new ParkingPermits
            {
                Id = 2,
                ParkingAreaID = 2,
                EffectiveDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddMonths(6),
                LicensePlate = "ABC123",
                ParkingAreaName = "Flamingo",
                CreateDate = DateTime.Now,
                Inactive = false,
                ParkingAreaTypeId = 2,
                Longitude = -29.99493,
                Latitude = -49.003830,
                DateCreated = DateTime.Now,


            };
            var parkingpermit3 = new ParkingPermits
            {
                Id = 3,
                ParkingAreaID = 2,
                EffectiveDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddMonths(6),
                LicensePlate = "ABC123",
                ParkingAreaName = "Flamingo",
                CreateDate = DateTime.Now,
                Inactive = false,
                ParkingAreaTypeId = 2,
                Longitude = -29.99493,
                Latitude = -49.003830,
                DateCreated = DateTime.Now,


            };

            parkingPermits.Add(parkingpermit1);
            parkingPermits.Add(parkingpermit2);
            parkingPermits.Add(parkingpermit3);

            var parkingPermit = parkingPermits.FirstOrDefault(item => item.Id == parkingId);


            return parkingPermit;

        }
    }
}
