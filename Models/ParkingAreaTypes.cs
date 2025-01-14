using System.ComponentModel.DataAnnotations;

namespace ParkingProjectClient.Models
{
    public class ParkingAreaTypes
    {
        [Key] 
        public int Id { get; set; }

        [Required] 
        [StringLength(100)] 
        public string ParkingAreaTypeDescription { get; set; }

        [Required] 
        public bool Inactive { get; set; }
    }
}
