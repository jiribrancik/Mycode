using Microsoft.AspNetCore.Mvc;
using FoxClub.Model;
using FoxClub.Services;
using FoxClub.ViewModels;

namespace FoxClub.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        public FoxServices FoxServ { get; set; }
        public HomeController(FoxServices fox)
        {
            FoxServ = fox;
        }

        [HttpGet("index")]
        public IActionResult Index()
        {
            var vm = new IndexViewModel()
            {
                MyFoxService = FoxServ
            };
            return View(vm);
        }
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("login")]
        public IActionResult Login(string name)
        {

            FoxServ.SetCurrent(name);
            return RedirectToAction("index");
        }
    }
}
