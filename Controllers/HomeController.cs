using Microsoft.AspNetCore.Mvc;
using ParkingProjectClient.Models;
using ParkingProjectClient.Services;
using ParkingProjectClient.Services.Interfaces;
using System.Diagnostics;

namespace ParkingProjectClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IParkingService _parkingService;

        public HomeController(ILogger<HomeController> logger, IParkingService parkingService)
        {
            _logger = logger;
            _parkingService = parkingService;
        }

        public IActionResult ParkingAreaTypes()
        {
            return View();
        }

        public IActionResult ParkingPermitsAreaDetail(int id)

        {
            ParkingPermits parkingPermit = _parkingService.GetParkingPermitById(id);


            return View(parkingPermit);

        }

        public IActionResult ParkingPermitsArea()

        {
            List<ParkingPermitsArea> parkingAreasList = _parkingService.GetAllParkingPermitsByArea();

            return View(parkingAreasList);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
