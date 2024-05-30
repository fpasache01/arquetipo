using Microsoft.AspNetCore.Mvc;
using Mop.Services.Interface;

namespace Mop.WebApp.Controllers
{
    public class ExampleController : Controller
    {
        private readonly IExampleService exampleService;
        public ExampleController(IExampleService exampleService) {
            this.exampleService = exampleService;
        }

        public IActionResult Test() 
        {
            return Ok(exampleService.TestService());
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
