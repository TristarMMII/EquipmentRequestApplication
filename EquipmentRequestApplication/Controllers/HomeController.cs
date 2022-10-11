using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EquipmentRequestApplication.Models;

namespace EquipmentRequestApplication.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AllEquipment()
    {
        return View("EquipmentListing");
    }

    public IActionResult AvailableEquipment()
    {
        return View();
    }

    public IActionResult RequestForm()
    {
        return View();
    }

    public IActionResult Requests()
    {
        return View("AdminPage", RequestRepository.GetComingRequests());
    }

    [HttpPost]
    public IActionResult SaveResponse(EquipmentRequestModel request)
    {
        //validation
        if (ModelState.IsValid)
        {
            // save to database
            RequestRepository.ID++;
            request.ID = RequestRepository.ID;
            RequestRepository.AddResponse(request);

            // show message to the user
            return View("Confirmation", request);
        }

        return View("RequestForm");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
