using ContosFS.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosFS.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<UserEntity> UserEntities { get; set; }
    }

    public class AssetDbContext : DbContext
    {
        public AssetDbContext(DbContextOptions<AssetDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<AssetEntity> AssetEntities { get; set; }
    }
}
