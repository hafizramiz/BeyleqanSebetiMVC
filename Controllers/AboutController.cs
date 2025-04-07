using Microsoft.AspNetCore.Mvc;

namespace BeyleqanSebeti.Controllers;

public class AboutController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
}