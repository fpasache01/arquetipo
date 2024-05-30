using Microsoft.AspNetCore.Mvc;
using Mop.Services.Interface;

namespace Mop.Api.Controllers
{
    public class ExampleController : Controller
    {
        private readonly IExampleService exampleService;
        public ExampleController(IExampleService exampleService)
        {
            this.exampleService = exampleService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> TestController()
        {
            return Ok(await exampleService.TestService());
        }
    }
}
