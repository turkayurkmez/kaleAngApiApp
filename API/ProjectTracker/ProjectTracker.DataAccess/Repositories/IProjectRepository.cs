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
        IEnumerable<Project> SearchProjectsByName(string name);
        IEnumerable<Project> SearchProjectsByCategoryId(int id);
        IEnumerable<Project> SearchProjectsByCategoryName(string name);


    }
}
