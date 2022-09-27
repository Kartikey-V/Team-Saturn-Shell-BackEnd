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

         public IEnumerable<UserEntity> GetUser()
        {
            return _UserDbContext.UserEntities;
        }
    }

    /*public class StockRepository
    {
        public StockDbContext _StockDbContext;
        public IEnumerable<StockEntity> StockEntities { get; set; }

        public StockRepository(StockDbContext dbContext)
        {
            _StockDbContext = dbContext;
        }
    }
    
    public class HoldingsRepository
    {
        public HoldingsDbContext _HoldingsDbContext;
        public IEnumerable<HoldingsEntity> HoldingsEntities { get; set; }

        public HoldingsRepository(HoldingsDbContext dbContext)
        {
            _HoldingsDbContext = dbContext;
        }
    }

    public class TransactionsRepository
    {
        public TransactionsDbContext _TransactionsDbContext;
        public IEnumerable<TransactionsEntity> TransactionsEntities { get; set; }

        public TransactionsRepository(TransactionsDbContext dbContext)
        {
            _TransactionsDbContext = dbContext;
        }
    }*/
}
