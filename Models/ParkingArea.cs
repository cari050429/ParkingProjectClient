using System.ComponentModel.DataAnnotations;

namespace ParkingProjectClient.Models
{
    public class ParkingArea
    {
        [Key] 
        public int? Id { get; set; }

        [Required] 
        [StringLength(50)] 
        public string ParkingAreaName { get; set; }

        [Required] 
        [StringLength(50)] 
        public string ParkingAreaTypeDescription { get; set; }

        [Required] 
        public bool Inactive { get; set; }

        
        [Required]
        public double Longitude { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? DateCreated { get; set; }

        [Required]
        public int ParkingAreaTypeID { get; set; }}
}
