using System.ComponentModel.DataAnnotations;

namespace ParkingProjectClient.Models
{
    public class ParkingPermits
    {


        [Required]
        public string ParkingAreaName { get; set; }

        [Required]
        public int Id { get; set; }


        [Required]
        public bool Inactive { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime EffectiveDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }


        [Required]
        [StringLength(6, MinimumLength = 6)]
        public string LicensePlate { get; set; }




    }
}
