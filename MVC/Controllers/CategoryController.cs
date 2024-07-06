using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly Context context;

        public CategoryController(Context _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            List<Category> category = context.Category.ToList();
            return View(category);
        }
    }
}