using FrankenWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrankenWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexViewModel{
                Title = "Hallo DDF2018",
                Message = "Super tolle beschreibung"
            };

            return View(model);
        }
    }
}