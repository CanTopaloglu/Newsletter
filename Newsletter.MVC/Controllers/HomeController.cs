using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Newsletter.MVC.Controllers;
public class HomeController : Controller
{

    //[Authorize(AuthenticationSchemes = "Cookies")]
    public IActionResult Index()
    {
        //var claims = HttpContext.User.Claims.ToList();
        return View();
    }

   
}
