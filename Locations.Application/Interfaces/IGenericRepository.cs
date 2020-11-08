using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Locations.Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetData(Object o);
    }
}
