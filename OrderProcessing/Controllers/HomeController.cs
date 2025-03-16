using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OrderProccessing.Models;

namespace OrderProccessing.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(new Order());
    }

    public IActionResult ProcessOrder(Order order)
    {
        if (ModelState.IsValid)
        {
            order.CalculateDiscount();
            return View("Result", order);
        }
        return View(order);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
