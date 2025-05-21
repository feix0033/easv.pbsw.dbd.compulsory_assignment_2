using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Presetation.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}