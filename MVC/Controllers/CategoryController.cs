using Microsoft.AspNetCore.Mvc;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly Context _context;
        public CategoryController(Context context)
        {
            _context = context;
        }
        
        // GET: /Category/Index
        [HttpGet("Index")]
        public IActionResult Index()
        {
            var categories = _context.Category.ToList();
            return View(categories);
        }

        // GET: /Category/Insert
        [HttpGet("Insert")]
        public IActionResult Insert()
        {
            return View();
        }

        // POST: /Category/Insert
        [HttpPost("Insert")]
        public IActionResult Insert(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Category.Add(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }
        
        // GET: /Category/Update/{id}
        [HttpGet("Update/{id}")]
        public IActionResult Update(int id)
        {
            var category = _context.Category.FirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: /Category/Update
        [HttpPost("Update/{id}")]
        public IActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {
                var existingCategory = _context.Category.FirstOrDefault(x => x.Id == category.Id);
                if (existingCategory != null)
                {
                    existingCategory.CategoryName = category.CategoryName;
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return NotFound();
            }
            return View(category);
        }
        
        // GET: /Category/Delete/{id}
        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var category = _context.Category.FirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);            
        }

        // POST: /Category/Delete/{id}
        [HttpPost("Delete/{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var category = _context.Category.FirstOrDefault(x => x.Id == id);
            if (category != null)
            {
                _context.Category.Remove(category);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
