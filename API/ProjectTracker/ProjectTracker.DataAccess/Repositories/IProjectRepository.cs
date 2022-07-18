using ProjectTracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DataAccess.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<IEnumerable<Project>> SearchProjectsByName(string name);
        Task<IEnumerable<Project>> SearchProjectsByCategoryId(int id);
        Task<IEnumerable<Project>> SearchProjectsByCategoryName(string name);


    }
}
