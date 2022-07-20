using ProjectTracker.DataAccess.Repositories;
using ProjectTracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Business
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<User> ValidateUser(string userName, string password)
        {
            return await userRepository.Validate(userName, password);
        }
    }
}
