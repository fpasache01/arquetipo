using Mop.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mop.Repository
{
    public class ExampleRepository : IExampleRepository
    {
        public async Task<int> TestRepository()
        {
            return 999999;
        }
    }
}
