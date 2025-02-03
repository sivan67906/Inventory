using Inventory.UI.Areas.Ticket.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace SalesOrder.UI.Areas.SalesOrder.Controllers;
[Area("Inventory")]
public class SalesOrderController : Controller
{
    public IActionResult ViewSalesOrder()
    {
        ViewData["pTitle"] = "Sales Order Index";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("ViewSalesOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Sales Order", Url = Url.Action("ViewSalesOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "SO View", Url = Url.Action("ViewSalesOrder", "PurchaseOrder", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult ViewSalesOrderDetails()
    {
        ViewData["pTitle"] = "Sales Order Details";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("ViewSalesOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Sales Order", Url = Url.Action("ViewSalesOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Details", Url = Url.Action("ViewSalesOrderDetails", "PurchaseOrder", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult SalesOrderOpenStatusUpdate()
    {
        ViewData["pTitle"] = "Update Sales Order";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("ViewSalesOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Sales Order", Url = Url.Action("ViewSalesOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Update", Url = Url.Action("ViewSalesOrderDetails", "PurchaseOrder", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
    public IActionResult SalesOrderInTransitStatusUpdate()
    {
        ViewData["pTitle"] = "Update Sales Order";

        List<BreadcrumbItem> breadcrumbs =
        [
            new BreadcrumbItem { Name = "Home", Url = Url.Action("ViewSalesOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Sales Order", Url = Url.Action("ViewSalesOrder", "PurchaseOrder", new { area = "Inventory" }) },
            new BreadcrumbItem { Name = "Update", Url = Url.Action("SalesOrderInTransitStatusUpdate", "PurchaseOrder", new { area = "Inventory" }) }
        ];
        ViewBag.Breadcrumbs = breadcrumbs;

        return View();
    }
}