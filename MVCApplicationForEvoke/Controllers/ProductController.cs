using Microsoft.AspNetCore.Mvc;
using MVCApplicationForEvoke.Models;

namespace MVCApplicationForEvoke.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductModel productModel = new ProductModel();            

            productModel.Id = 10;
            productModel.ProductName = "Apple";
            productModel.Price = 120;

            return View(productModel);
        }
    }
}
