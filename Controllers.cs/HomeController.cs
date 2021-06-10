using Microsoft.AspNetCore.Mvc;

namespace PortfolioI
{
    public class HomeController : Controller
    {
        //Requests
        //localhost:5000
        [HttpGet("")]
        public string Index()
        {
            return ("This is my Index!");
        }

        [HttpGet("projects")]
        public string Project()
        {
            return ("These are my projects");
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return ("This is my Contact!");
        }
    }
}