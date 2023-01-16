using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStore.Models;
using BOL;


namespace EStore.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }
    //Get All products from BLL
    //bind all products to viewdata
    //send viewData to View

    public IActionResult Index()
    {
        List<Product> allProducts=new List<Product>();
         this.ViewData["products"]=allProducts;
        return View();
    }

    public IActionResult Details(int id)
    {   
       
        return View();
    }

    public IActionResult Insert()
    {
        return View();
    }

    public IActionResult Delete(int id)
    {
        //return View();
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
