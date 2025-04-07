using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BeyleqanSebeti.Models;

namespace BeyleqanSebeti.Controllers;
/// <summary>
///  Burda ne var
/// </summary>
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogWarning("Index action method called.");
        return View();
    }

    public IActionResult Privacy()
    {
        /// 
        _logger.LogInformation("Privacy action method called.");
         return View();
         /// Burda baska action belirterek oraya gitmesini saglayabiliriz
        // Redirect to the OtherPage action
        //return RedirectToAction("Index");
    }



    
    public IActionResult Deneme()
    {
        _logger.LogInformation("Deneme action method called.");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
