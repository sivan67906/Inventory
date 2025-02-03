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

    public IActionResult SOView()
    {
        ViewData["pTitle"] = "Sales Order Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("SOView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Sales Order", Url = Url.Action("SOView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "SO View", Url = Url.Action("SOView", "Inventory", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }

    public IActionResult POViewDetails()
    {
        ViewData["pTitle"] = "Purchase Order View Details";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Inventory", Url = Url.Action("POView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Purchase Order", Url = Url.Action("POView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Details", Url = Url.Action("POViewDetails", "Inventory", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult POEditDetails()
    {
        ViewData["pTitle"] = "Edit Purchase Order Details";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Inventory", Url = Url.Action("POView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Purchase Order", Url = Url.Action("POView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Edit", Url = Url.Action("POViewDetails", "Inventory", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult POCreatedSalesOrderEditDetails()
    {
        ViewData["pTitle"] = "Update Purchase Order Status";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Inventory", Url = Url.Action("POView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Purchase Order", Url = Url.Action("POView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Status Update", Url = Url.Action("POViewDetails", "Inventory", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult POInTransitEditDetails()
    {
        ViewData["pTitle"] = "Update Purchase Order Status";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Inventory", Url = Url.Action("POView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Purchase Order", Url = Url.Action("POView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Status Update", Url = Url.Action("POViewDetails", "Inventory", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult SOViewDetails()
    {
        ViewData["pTitle"] = "Sales Order Details";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("SOView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Sales Order", Url = Url.Action("SOView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Details", Url = Url.Action("SOViewDetails", "Inventory", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult SOOpenStatusUpdate()
    {
        ViewData["pTitle"] = "Update Sales Order";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("SOView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Sales Order", Url = Url.Action("SOView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Update", Url = Url.Action("SOViewDetails", "Inventory", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult SOInTransitStatusUpdate()
    {
        ViewData["pTitle"] = "Update Sales Order";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("SOView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Sales Order", Url = Url.Action("SOView", "Inventory", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Update", Url = Url.Action("SOInTransitStatusUpdate", "Inventory", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
}