using Mop.Repository.Interface;
using Mop.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mop.Services
{
    public class ExampleService : IExampleService
    {
        private readonly IExampleRepository exampleRepository;
        public ExampleService(IExampleRepository exampleRepository)
        {
            this.exampleRepository = exampleRepository;
        }

        public async Task<int> TestService()
        {
            return await exampleRepository.TestRepository();
        }

    }
}
