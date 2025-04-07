using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BeyleqanSebeti.Models;

namespace BeyleqanSebeti.Controllers;
/// <summary>
///  Burda ne var
/// </summary>
public class DenemeController : Controller
{
   

    public IActionResult Deneme()
    {
        return View();
    }


    public IActionResult OtherPage()
    {
        // Redirect to the OtherPage action
        return RedirectToAction("OtherPage");
    }
}
