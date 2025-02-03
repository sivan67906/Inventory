using Inventory.UI.Areas.Ticket.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace PurchaseOrder.UI.Areas.PurchaseOrder.Controllers;
[Area("Inventory")]
public class PurchaseOrderController : Controller
{
    public IActionResult ViewPurchaseOrder()
    {
        ViewData["pTitle"] = "Purchase Order Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("ViewPurchaseOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Purchase Order", Url = Url.Action("ViewPurchaseOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "PO View", Url = Url.Action("ViewPurchaseOrder", "PurchaseOrder", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }

    public IActionResult CreatePurchaseOrder()
    {
        ViewData["pTitle"] = "Purchase Order Create";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("ViewPurchaseOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Purchase Order", Url = Url.Action("ViewPurchaseOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Create", Url = Url.Action("CreatePurchaseOrder", "PurchaseOrder", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }

    public IActionResult ViewPurchaseOrderDetails()
    {
        ViewData["pTitle"] = "Purchase Order View Details";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("ViewPurchaseOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Purchase Order", Url = Url.Action("ViewPurchaseOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Details", Url = Url.Action("ViewPurchaseOrderDetails", "PurchaseOrder", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult PurchaseOrderEditDetails()
    {
        ViewData["pTitle"] = "Edit Purchase Order Details";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("ViewPurchaseOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Purchase Order", Url = Url.Action("ViewPurchaseOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Edit", Url = Url.Action("ViewPurchaseOrderDetails", "PurchaseOrder", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult PurchaseOrderCreatedSalesOrderEditDetails()
    {
        ViewData["pTitle"] = "Update Purchase Order Status";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("ViewPurchaseOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Purchase Order", Url = Url.Action("ViewPurchaseOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Status Update", Url = Url.Action("ViewPurchaseOrderDetails", "PurchaseOrder", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult PurchaseOrderInTransitEditDetails()
    {
        ViewData["pTitle"] = "Update Purchase Order Status";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("ViewPurchaseOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Purchase Order", Url = Url.Action("ViewPurchaseOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Status Update", Url = Url.Action("ViewPurchaseOrderDetails", "PurchaseOrder", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
}