﻿using Microsoft.AspNetCore.Mvc;

namespace Inventory.UI.Controllers;

public class EmailController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult OTPVerify()
    {
        return View();
    }
    public IActionResult Verify()
    {
        return View();
    }
    public IActionResult TwoFactorAuth()
    {
        return View();
    }
}
