using Digital_Marketing_Agency.Data;    
using Digital_Marketing_Agency.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System.Diagnostics;

namespace Digital_Marketing_Agency.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbcontext _appDbcontext;

        public HomeController(ILogger<HomeController> logger, AppDbcontext appDbcontext)
        {
            _logger = logger;
            _appDbcontext = appDbcontext;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveData(Form form)
        {

            if (ModelState.IsValid)
            
            {
                try
                {
                    _appDbcontext.Add(form);
                    _appDbcontext.SaveChanges();
                    TempData["Message "] = "Your Response has been recorded.";
                }
                catch (Exception ex)
                {
                    TempData["Message "] = "Something Wrong!";
                }


            }
            return View("Form");
        }
        public IActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string fname, string password)
        {
            if (fname == "Ali" && password == "123")
            {
                ViewBag.data = _appDbcontext.Form.ToList();
                TempData["Data"] = "login successful";

                return View("ViewData");
            }
            else
            {
                TempData["Data"] = "Invalid username or password!";
				return View("Admin");
			}
			
		}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
