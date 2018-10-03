using System.Collections.Generic;
using System.Threading.Tasks;

namespace Swizkon.Infrastructure.Patters.Repository
{
    public interface IRepository<T> where T: class
    {
        Task Add(T t);

        Task<T> Remove(T t);

        Task<T> Find(object id);

        Task<IEnumerable<T>> GetAll();
    }
}