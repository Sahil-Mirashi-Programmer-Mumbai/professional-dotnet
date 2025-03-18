using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductManagement.Models;

namespace ProductManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        private const int PageSize = 5;

        public ProductController(ApplicationDbContext context)
        {
            _db = context;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            // count the total number of products
            var totalProducts = await _db.Products.CountAsync();
            var products = await _db.Products
                .Include(p => p.Category)
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();

            var pagedList = new PagedList<Product>(products, totalProducts, page, PageSize);

            return View(pagedList);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_db.Categories, "CategoryId", "CategoryName");
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