using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mop.Repository.Interface
{
    public interface IExampleRepository
    {
        Task<int> TestRepository();
    }
}
