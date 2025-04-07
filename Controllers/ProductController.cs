using Microsoft.AspNetCore.Mvc;

namespace BeyleqanSebeti.Controllers;

public class ProductController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
}