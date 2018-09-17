using System.Collections.Generic;
using System.Threading.Tasks;

namespace Swizkon.Patterns
{
    public interface IRepository<T> where T: class
    {
        Task Add(T t);

        Task<T> Remove(T t);

        Task<IEnumerable<T>> GetAll();
    }
}