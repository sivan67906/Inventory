using Inventory.UI.Areas.Ticket.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.UI.Areas.Inventory.Controllers;
[Area("Inventory")]
public class InventoryController : Controller
{
    public IActionResult POView()
    {
        ViewData["pTitle"] = "Purchase Order Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Inventory", Url = Url.Action("POView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Purchase Order", Url = Url.Action("POView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "PO View", Url = Url.Action("POView", "Inventory", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }

    public IActionResult CreatePO()
    {
        ViewData["pTitle"] = "Purchase Order Create";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Inventory", Url = Url.Action("POView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Purchase Order", Url = Url.Action("POView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Create", Url = Url.Action("CreatePO", "Inventory", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
}