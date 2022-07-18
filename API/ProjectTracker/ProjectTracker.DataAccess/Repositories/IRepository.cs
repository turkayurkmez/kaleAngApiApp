using ProjectTracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DataAccess.Repositories
{
    public interface IRepository<T> where T: class, IEntity, new()
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task Delete(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);

    }
}
