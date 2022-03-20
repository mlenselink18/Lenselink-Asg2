using Microsoft.AspNetCore.Mvc;

namespace Lenselink_Asg2.Controllers 
{ 
    public class HomeController : Controller 
    { 
        public IActionResult Index() 
        { 
            ViewBag.Name = "Mary"; 
            ViewBag.FV = 99999.99; 
            return View(); 
        } 
    } 
}