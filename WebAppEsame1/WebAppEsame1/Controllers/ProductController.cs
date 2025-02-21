using WebAppEsame1.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAppEsame1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
