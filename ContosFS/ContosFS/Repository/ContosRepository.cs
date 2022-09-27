using ContosFS.Data;
using ContosFS.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosFS.Repository
{
    public class UserRepository
    {
        public UserDbContext _UserDbContext;
        public IEnumerable<UserEntity> UserEntities { get; set; }

        public UserRepository(UserDbContext dbContext)
        {
            _UserDbContext = dbContext;
        }
    }
}
