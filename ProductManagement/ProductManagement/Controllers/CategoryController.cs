using Microsoft.AspNetCore.Mvc;
using ProductManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductManagement.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        private const int PageSize = 5;

        public CategoryController(ApplicationDbContext context)
        {
            _db = context;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var totalCategories = await _db.Categories.CountAsync();
            var categories = await _db.Categories
               .OrderBy(p => p.CategoryId)
               .Skip((page - 1) * PageSize)
               .Take(PageSize)
               .ToListAsync();

            var pagedList = new PagedList<Category>(categories, totalCategories, page, PageSize);
            return View(pagedList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Edit(int id)
        {
            var category = _db.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {

            if (ModelState.IsValid)
            {
                var existingCategory = _db.Categories.Find(category.CategoryId);
                if (existingCategory != null)
                {
                    existingCategory.CategoryName = category.CategoryName;
                    _db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(category);
        }

        public IActionResult Delete(int id)
        {
            var category = _db.Categories.Find(id);
            if (category != null)
            {
                if (category == null)
                {
                    return NotFound();
                }
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var category = _db.Categories.Find(id);
            if (category != null)
            {
                _db.Categories.Remove(category);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}