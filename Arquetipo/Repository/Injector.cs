using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Mop.Repository.Interface;

namespace Mop.Repository
{
    public static class Injector
    {
        public static void Inject(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IExampleRepository, ExampleRepository>();
        }
    }
}
