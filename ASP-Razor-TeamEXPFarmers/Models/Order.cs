using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_TeamEXPFarmers.Models
{
	/// <summary>
	/// Represents orders in the web application's database, comprising an
	/// order ID, the creation date, dispatch date if one exists, the 
	/// person associated with this order and whether it has been paid yet.
	/// This class will also act as the customer's basket when shopping
	/// on the storefront.
	/// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (25/11/2021)
	/// </summary>
	public class Order
	{
		/// <summary>
		/// The order's ID, marked as the primary key.
		/// </summary>
		[Key]
		public int OrderID { get; set; }

		// Foreign key
		public int PersonID { get; set; }

		/// <summary>
		/// The order's creation date.
		/// </summary>
		[Display(Name = "Date Created"), DataType(DataType.Date), Required]
		public DateTime DateCreated { get; set; }

		/// <summary>
		/// The order's dispatch date.
		/// </summary>
		[Display(Name = "Dispatch Date"), DataType(DataType.Date)]
		public DateTime DispatchDate { get; set; }

		/// <summary>
		/// False if the order hasn't been paid for yet (e.g. the customer is still browsing for products) and true if it has.
		/// </summary>
		[Display(Name = "Paid?"), Required]
		public bool IsPaid { get; set; }

		// Navigation properties
		public virtual ICollection<OrderItem> OrderItems { get; set; }
		public virtual Person Person { get; set; }	
	}
}
