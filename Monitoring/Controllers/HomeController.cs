using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Monitoring.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //public IActionResult Index()
        //{
        //    var pathBase = _configuration["PATH_BASE"];
        //    return Redirect($"{pathBase}/hc-ui");
        //}
    }
}