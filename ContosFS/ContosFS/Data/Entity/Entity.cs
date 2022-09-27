using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
		public String StockId;

		[StringLength(50)]
		public String StockName;

		public float CurStockPrice;
	}
}
