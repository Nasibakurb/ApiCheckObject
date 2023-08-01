using Microsoft.AspNetCore.Mvc;
using ApiAppl.Controllers;

namespace ObjectsKJI.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        public IActionResult EditCategory()
        {
            return View();
        }

    }
}
