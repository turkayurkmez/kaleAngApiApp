using ProjectTracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DataAccess.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> Validate(string userName, string password);
    }
}
