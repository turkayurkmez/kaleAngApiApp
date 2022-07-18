using ProjectTracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Business
{
    public interface IProjectService
    {
        Task<IList<Project>> GetProjects();

    }
}
