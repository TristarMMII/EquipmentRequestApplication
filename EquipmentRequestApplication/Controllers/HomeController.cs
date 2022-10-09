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

    public IActionResult EquipmentListing()
    {
        return View();
    }

    public IActionResult AvailableEquipment()
    {
        return View();
    }

    public IActionResult RequestForm()
    {
        return View();
    }

    public IActionResult AdminPage()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SaveResponse(EquipmentRequestModel request)
    {
        // TODO validation
        if (ModelState.IsValid)
        {
            // if (RequestRepository.IsDurationPositive(request.Duration) == true)
            // {
            // TODO save to database
            RequestRepository.ID++;
            request.ID = RequestRepository.ID;
            RequestRepository.AddResponse(request);

            // TODO show message to the user
            return View("Confirmation", request);
            // }


        }

        return View("RequestForm");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
