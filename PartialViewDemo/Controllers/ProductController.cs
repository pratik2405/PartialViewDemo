using Microsoft.AspNetCore.Mvc;
using PartialViewDemo.Data;

namespace PartialViewDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProductController(ApplicationDbContext db)
        {
            this.db = db;   
        }
        public IActionResult Index()
        {
            var model=db.Products.ToList();
            return View(model);
        }
    }
}
