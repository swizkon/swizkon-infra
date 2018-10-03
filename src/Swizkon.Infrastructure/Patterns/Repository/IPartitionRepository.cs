using System.Collections.Generic;
using System.Threading.Tasks;

namespace Swizkon.Infrastructure.Patters.Repository
{
    public interface IPartitionRepository<T> where T: class
    {
        Task Add(object partition, T t);

        Task<T> Find(object partition, object row);

        Task<IEnumerable<T>> All(object partition);
    }
}