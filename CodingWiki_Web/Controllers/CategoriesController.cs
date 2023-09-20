using CodingWiki_DataAccess.Data;
using CodingWiki_Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingWiki_Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context) 
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            List<Category> objList = _context.Categories.ToList();
            return View(objList);
        }
    }
}
