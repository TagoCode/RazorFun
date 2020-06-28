using Microsoft.AspNetCore.Mvc;
namespace HelloASP.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects.";
        }
        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }
    }
}