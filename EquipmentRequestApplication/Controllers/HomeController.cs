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

    //home page
    public IActionResult Index()
    {
        return View();
    }

    //All Equipment page
    public IActionResult AllEquipment()
    {
        return View("EquipmentListing");
    }

    //available equipment page
    public IActionResult AvailableEquipment()
    {
        return View();
    }

    //request form
    public IActionResult RequestForm()
    {
        return View();
    }

    //Requests or admin page
    public IActionResult Requests()
    {
        return View("AdminPage", RequestRepository.GetComingRequests());
    }

    //saves response from user request form
    [HttpPost]
    public IActionResult SaveResponse(EquipmentRequestModel request)
    {
        //validation
        if (ModelState.IsValid)
        {
            //increment request ID
            RequestRepository.ID++;
            request.ID = RequestRepository.ID;

            // save to database
            RequestRepository.AddResponse(request);

            // show message to the user
            return View("Confirmation", request);
        }
        //return to form if form invalid
        return View("RequestForm");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
