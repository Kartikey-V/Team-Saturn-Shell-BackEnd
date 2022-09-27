using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosFS.Data.Entity
{
	public class UserEntity
	{
		[Key]
		public int UserId { get; set; }

		[StringLength(50)]
		public String UserName { get; set; }

		[StringLength(50)]
		public String UserEmail { get; set; }

		[StringLength(50)]
		public String UserPassword { get; set; }
	}
    public class StockEntity
    {
        [Key]
        public int StockId { get; set; }

		[StringLength(50)]
        public String StockName { get; set; }

		public float CurStockPrice { get; set; }
	}
    //<<<<<<< HEAD

    //=======

    //>>>>>>> b533f8080dec42cca355230ee8fe0b998c243ecd
    public class HoldingsEntity
    {
        [Key, Column(Order = 0)]
        public int StockId { get; set; }
        [Key, Column(Order = 1)]
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public float Buying_price { get; set; }
        public DateTime Date { get; set; }

    }

    public class TransactionsEntity
    {
        public int UserId { get; set; }
        public int StockId { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public DateTime Date { get; set; }
    }
}
