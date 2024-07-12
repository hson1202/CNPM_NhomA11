﻿namespace Shopping.Models
{
	public class OrderDetails
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public int OrderCode { get; set; }
		public int ProductId { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }

    }
}
