using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductManagement.Models;

namespace ProductManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext context)
        {
            _db = context;
        }
        public ActionResult Index(int page = 1, int pageSize = 5)
        {
            var products = _db.Products.Select(p => new
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryId = p.CategoryId,
                CategoryName = p.Category.CategoryName
            }).ToList<dynamic>();

            ViewBag.Page = page;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalCount = _db.Products.Count();

            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_db.Categories, "CategoryId", "CategoryName");
            //ViewBag.Categories = _db.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            Console.WriteLine($"ProductName: {product.ProductName}, CategoryId: {product.CategoryId}");
            if (ModelState.IsValid)
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(_db.Categories, "CategoryId", "CategoryName");

                return View(product);
            }
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var error in errors)
            {
                Console.WriteLine(error.ErrorMessage); // Print errors to console/log
            }

            ViewBag.Categories = _db.Categories.ToList();
            return View(product);
        }

        public IActionResult Edit(int id)
        {
            var product = _db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            ViewBag.Categories = _db.Categories.ToList();
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                var existingProduct = _db.Products.Find(product.ProductId);
                if (existingProduct != null)
                {
                    existingProduct.ProductName = product.ProductName;
                    existingProduct.CategoryId = product.CategoryId;

                    _db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
            }

            ViewBag.Categories = _db.Categories.ToList();
            return View(product);
        }

        public IActionResult Delete(int id)
        {
            var product = _db.Products
                     .Include(p => p.Category)
                     .FirstOrDefault(p => p.ProductId == id);
            //var product = _db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _db.Products.Find(id);
            if (product != null)
            {
                _db.Products.Remove(product);
                _db.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
