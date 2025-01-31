using Microsoft.AspNetCore.Mvc;

namespace Inventory.UI.Controllers;

public class SignupController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Signup()
    {
        return View();
    }
}
