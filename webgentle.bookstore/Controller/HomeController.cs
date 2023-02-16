using Microsoft.AspNetCore.Mvc;

namespace webgentle.bookstore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "welcome to core app";
        }
    }
}
