// using System.ComponentModel;
// using System.ComponentModel.DataAnnotations;
// using System.Diagnostics.Eventing.Reader;

// namespace ParkingProjectClient.Models
// {
//     public class ParkingPermitsArea
//     {
//         [Key]
//         [Required]
//         public int ID { get; set; }

//         [Required]
//         public int ParkingAreaID { get; set; }

//         [Required]
//         public string ParkingAreaName { get; set; }

//         [Required]
//         [DataType(DataType.Date)] 
//         public DateTime EffectiveDate { get; set; }

//         [Required]
//         [DataType(DataType.Date)]
//         public DateTime ExpirationDate { get; set; }

//         [Required]
//         [DataType(DataType.Date)]
//         public DateTime CreateDate { get; set; }


//         [Required]
//         [StringLength(6, MinimumLength = 6)]
//         public string LicensePlate { get; set; }

//         [Required]
//         public bool Inactive { get; set; }  


//     }
// }
