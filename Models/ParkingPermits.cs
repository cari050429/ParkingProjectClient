using System.ComponentModel.DataAnnotations;

namespace ParkingProjectClient.Models
{
    public class ParkingPermits
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public int ParkingAreaTypeId {get; set; }

        [Required]
        public string ParkingAreaName { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [Required]
        public bool Inactive { get; set; }


        [Required]
        public int ParkingAreaID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EffectiveDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }


        [Required]
        [StringLength(6, MinimumLength = 6)]
        public string LicensePlate { get; set; }




    }
}
