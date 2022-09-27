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

  /*  public class StockDbContext : DbContext
    {
        public StockDbContext(DbContextOptions<StockDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<StockEntity> StockEntities { get; set; }
    }*/
//<<<<<<< HEAD

//=======
    
//>>>>>>> b533f8080dec42cca355230ee8fe0b998c243ecd
   /* public class HoldingsDbContext : DbContext
    {
        public HoldingsDbContext(DbContextOptions<HoldingsDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<HoldingsEntity> HoldingsEntities { get; set; }
    }

    public class TransactionsDbContext : DbContext
    {
        public TransactionsDbContext(DbContextOptions<TransactionsDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<TransactionsEntity> TransactionsEntities { get; set; }
   */ //}
}
