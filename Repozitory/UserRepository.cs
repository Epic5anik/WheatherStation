using Bogus;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitory
{
    public class UserRepository : IUserRepository
    {
        private readonly MyApplycationContekst _dbContext;

        public UserRepository(MyApplycationContekst dbContext)
        {   
            _dbContext = dbContext;
        }

        public User? GetUser(int id)   
        {
            return _dbContext.Set<User>().FirstOrDefault(x => x.Id == id);
        }
    }
}
