using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Drawing;
using WebApplication2_db.Models;

namespace WebApplication2_db.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult AddProducts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProductItem(string productName, string description, decimal price, string color)
        {
            var newProduct = new Products
            {
                ProductName = productName,
                Description = description,
                Price = price,
                Color = color
            };
            _context.Products.Add(newProduct);
            _context.SaveChanges();

            return RedirectToAction("DashBoard", "Home");
        }

        public IActionResult DeleteAProduct(int productid)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productid);
            if(product == null)
            {
                return View();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("DashBoard", "Home");
        }

        public IActionResult UpdateProduct(int productid)
        {
            var data = _context.Products.FirstOrDefault(p => p.ProductId == productid);
            return View(data);
            
        }

        [HttpPost]
        public IActionResult UpdateProductItem(int productId, string productName, string description, decimal price, string color)
        {
            var data = _context.Products.FirstOrDefault(p => p.ProductId == productId);

            if (data == null) return NotFound();

            data.ProductName = productName;
            data.Description = description;
            data.Price = price;
            data.Color = color;

            _context.Products.Update(data);
            _context.SaveChanges();

            return RedirectToAction("DashBoard", "Home");
        }
        
    }
}
