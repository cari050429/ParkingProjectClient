using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public async Task<IActionResult> ParkingAreas()
        {
            List<ParkingArea> parkingAreas = await _parkingService.GetAllParkingAreas();

            return View(parkingAreas);
        }

        public async Task<IActionResult> ParkingPermitDetails(int id)

        {
            ParkingPermits parkingPermit = await _parkingService.GetParkingPermitById(id);


            return View(parkingPermit);
        }

        public async Task<IActionResult> ParkingPermits(string searchQuery)

        {
            List<ParkingPermits> parkingPermitsList = await _parkingService.GetAllParkingPermitsByArea();

            if(!string.IsNullOrEmpty(searchQuery) && parkingPermitsList.Count > 0)
            {
                parkingPermitsList = parkingPermitsList.Where(p => p.LicensePlate.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return View(parkingPermitsList);

        }

        public async Task<IActionResult> ParkingAreaTypes()

        {
            List<ParkingAreaTypes> parkingAreasTypesList = await _parkingService.GetAllParkingAreaTypes();

            return View(parkingAreasTypesList);

        }

        public async Task <ActionResult> CreateParkingPermit()
        {
            var parkingAreas = await _parkingService.GetAllParkingAreas();
    
            ViewBag.ParkingAreas = new SelectList(parkingAreas, "Id", "ParkingAreaName");
            
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateParkingPermit(ParkingPermits parkingPermitCreation)
        {
            bool isCreated = await _parkingService.CreateParkingPermit(parkingPermitCreation);

            if (isCreated)
            {
                return RedirectToAction("ParkingPermits"); 
            }
             ViewBag.ErrorMessage = "There was an issue creating the parking permit.";
            return View(parkingPermitCreation);
        }
        public async Task <ActionResult> CreateParkingArea()
        {
            var parkingAreaTypes = await _parkingService.GetAllParkingAreaTypes();
    
            ViewBag.ParkingAreas = new SelectList(parkingAreaTypes, "Id", "ParkingAreaTypeDescription");
            
            return View();
        }
        public async Task <ActionResult> CreateParkingAreaType()
        {
           
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> CreateParkingAreaType(ParkingAreaTypes parkingareatypecreation)
        {
            bool isCreated = await _parkingService.CreateParkingAreaType(parkingareatypecreation);

            if (isCreated)
            {
                return RedirectToAction("ParkingAreaTypes"); 
            }
             ViewBag.ErrorMessage = "There was an issue creating the parking permit.";
            return View(parkingareatypecreation);
        }
        [HttpPost]
        public async Task<ActionResult> CreateParkingArea(ParkingArea parkingareacreation)
        {
            bool isCreated = await _parkingService.CreateParkingArea(parkingareacreation);

            if (isCreated)
            {
                return RedirectToAction("ParkingAreas"); 
            }
             ViewBag.ErrorMessage = "There was an issue creating the parking area.";
            return View(parkingareacreation);
        }

        [HttpGet]
        public async Task<ActionResult> DeleteParkingPermit(int id)
        {
            bool isDeleted = await _parkingService.DeleteParkingPermit(id);
            if (isDeleted)
            {
                return RedirectToAction("ParkingPermits"); 
            }
            ViewBag.ErrorMessage = "There was an issue deleting the parking permit";
            return RedirectToAction("ParkingPermits"); 
        }

        [HttpGet]
        public async Task<ActionResult> DeleteParkingArea(int id)
        {
            bool isDeleted = await _parkingService.DeleteParkingArea(id);
             if (isDeleted)
            {
                return RedirectToAction("ParkingAreas"); 
            }
            ViewBag.ErrorMessage = "There was an issue deleting the parking area";
            return RedirectToAction("ParkingAreas");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteParkingAreaType(int id)
        {
            bool isDeleted = await _parkingService.DeleteParkingAreaType(id);
            if (isDeleted)
            {
                return RedirectToAction("ParkingAreaTypes"); 
            }
            ViewBag.ErrorMessage = "There was an issue deleting the parking area type";
            return RedirectToAction("ParkingAreaTypes");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public async Task <ActionResult> UpdateParkingPermit(int id)
        {
            var parkingAreas = await _parkingService.GetAllParkingAreas();
            ParkingPermits currentParkingPermit = await _parkingService.GetParkingPermitById(id);
            parkingAreas = parkingAreas.OrderByDescending(area => area.Id == currentParkingPermit.ParkingAreaId).ToList();

    
            ViewBag.ParkingAreas = new SelectList(parkingAreas, "Id", "ParkingAreaName");
            
            return View(currentParkingPermit);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateParkingPermit(ParkingPermits updateParkingPermit)
        {
            bool isCreated = await _parkingService.UpdateParkingPermit(updateParkingPermit);

            if (isCreated)
            {
                return RedirectToAction("ParkingPermits"); 
            }
             ViewBag.ErrorMessage = "There was an issue updating the parking permit.";
            return View(updateParkingPermit);
        }

        public async Task <ActionResult> UpdateParkingArea(int id)
        {
            var parkingAreaTypes = await _parkingService.GetAllParkingAreaTypes();
            ParkingArea currentParkingArea = await _parkingService.GetParkingAreaById(id);
            parkingAreaTypes = parkingAreaTypes.OrderByDescending(areaType => areaType.Id == currentParkingArea.ParkingAreaTypeID).ToList();

    
            ViewBag.ParkingAreaTypes = new SelectList(parkingAreaTypes, "Id", "ParkingAreaTypeDescription");
            
            return View(currentParkingArea);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateParkingArea(ParkingArea updateParkingArea)
        {
            bool isCreated = await _parkingService.UpdateParkingArea(updateParkingArea);

            if (isCreated)
            {
                return RedirectToAction("ParkingAreas"); 
            }
             ViewBag.ErrorMessage = "There was an issue updating the parking permit.";
            return View(updateParkingArea);
        }
    }
}
