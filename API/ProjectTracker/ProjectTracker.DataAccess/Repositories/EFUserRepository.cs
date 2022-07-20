using Microsoft.EntityFrameworkCore;
using ProjectTracker.DataAccess.Data;
using ProjectTracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DataAccess.Repositories
{
    public class EFUserRepository : IUserRepository
    {
        private readonly ProjectTrackerDbContext context;

        public EFUserRepository(ProjectTrackerDbContext context)
        {
            this.context = context;
        }

        public Task Add(User entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Validate(string userName, string password)
        {
            return await context.Users.FirstOrDefaultAsync(user => user.UserName == userName && user.Password == password);
        }
    }
}
