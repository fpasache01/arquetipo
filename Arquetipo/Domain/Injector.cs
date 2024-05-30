using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Mop.Services.Interface;


namespace Mop.Services
{
    public static class Injector
    {
        public static void Inject(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IExampleService, ExampleService>();
        }
    }
}
