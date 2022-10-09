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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
