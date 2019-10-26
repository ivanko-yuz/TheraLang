using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.UnitOfWork
{
    public interface IUnitOfWork
    {
        IQueryable<TEntity> Queryable<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
    }
}