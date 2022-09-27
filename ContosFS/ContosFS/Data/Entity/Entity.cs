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
		public int UserId;

		[StringLength(50)]
		public String UserName;

		[StringLength(50)]
		public String UserEmail;

		[StringLength(50)]
		public String UserPassword;
	}
	public class StockEntity
    {
		[Key]
		public int StockId;

		[StringLength(50)]
		public String StockName;

		public float CurStockPrice;
	}
<<<<<<< HEAD

=======
	
>>>>>>> b533f8080dec42cca355230ee8fe0b998c243ecd
	public class HoldingsEntity
	{
		[Key, Column(Order = 0)]
		public int StockId;
		[Key, Column(Order = 1)]
		public int UserId;
		public int Quantity;
		public float Buying_price;
		public DateTime Date;

	}

	public class TransactionsEntity
    {
		public int UserId;
		public int StockId;
		public string Type;
		public int Quantity;
		public float Price;
		public DateTime Date;
    }
}
