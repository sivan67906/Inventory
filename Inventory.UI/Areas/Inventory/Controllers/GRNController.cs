using Inventory.UI.Areas.Ticket.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GRN.UI.Areas.GRN.Controllers;
[Area("Inventory")]
public class GRNController : Controller
{
    public IActionResult ViewGRN()
    {
        ViewData["pTitle"] = "GRN Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("ViewPurchaseOrder", "GRN", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "GRN", Url = Url.Action("ViewGRN", "GRN", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "View", Url = Url.Action("ViewGRN", "GRN", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult ViewGRNDetails()
    {
        ViewData["pTitle"] = "GRN Details Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("ViewPurchaseOrder", "GRN", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "GRN", Url = Url.Action("ViewGRN", "GRN", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Details", Url = Url.Action("ViewGRNDetails", "GRN", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult CreateGRN()
    {
        ViewData["pTitle"] = "GRN Creation";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("ViewPurchaseOrder", "GRN", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "GRN", Url = Url.Action("ViewGRN", "GRN", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "CreateGRN", Url = Url.Action("CreateGRN", "GRN", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult ApproveGRN()
    {
        ViewData["pTitle"] = "GRN Creation";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("ViewPurchaseOrder", "GRN", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "GRN", Url = Url.Action("ViewGRN", "GRN", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "CreateGRN", Url = Url.Action("CreateGRN", "GRN", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
}