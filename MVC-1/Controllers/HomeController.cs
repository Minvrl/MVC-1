using Microsoft.AspNetCore.Mvc;
using MVC_1.Models;

namespace MVC_1.Controllers
{
    public class HomeController:Controller
    {
        private List<Product> _products { get; set; }

        public HomeController()
        {
            _products = new List<Product> { new Product { Id = 1, Name = "Milk", Price = 3.4F, Category = "Dairy" }, new Product { Id = 2, Name = "Tomato", Price = 8, Category = "Vegetable" }, new Product { Id = 3, Name = "Cake", Price = 13, Category = "Dessert" }, new Product { Id = 4, Name = "Dried Mint", Price = 5, Category = "Herbs" } };
        }

        public ViewResult Index()
        {
            ViewBag.Products = _products;   
            return View();
        }

        public ViewResult Detail(int id)
        {
            Product product = _products.FirstOrDefault(p => p.Id == id);
            ViewBag.Product = product;

            return View("details");

        }
	}
}
