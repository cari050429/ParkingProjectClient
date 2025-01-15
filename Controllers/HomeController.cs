using Microsoft.AspNetCore.Mvc;
using ParkingProjectClient.Models;
using ParkingProjectClient.Services;
using ParkingProjectClient.Services.Interfaces;
using System.Diagnostics;
using System.Threading.Tasks;

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
            // ParkingPermits parkingPermit = _parkingService.GetParkingPermitById(id);


            //return View(parkingPermit);
            return View();

        }

        public async Task<IActionResult> ParkingPermits()

        {
            List<ParkingPermits> parkingAreasList = await _parkingService.GetAllParkingPermitsByArea();

            return View(parkingAreasList);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
