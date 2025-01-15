using System.ComponentModel.DataAnnotations;

namespace ParkingProjectClient.Models
{
    public class ParkingPermitDetails : ParkingPermits
    {

        [Required]
        public double Longitude { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [Required]
        public string ParkingAreaTypeDescription { get; set; }



    }
}
