using System;

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
	/// Modified by Jason Huggins (11/11/2021)
	/// 
	/// TODO: Set data annotations for properties based on ERD.
	/// </summary>
	public class Order
	{
		/// <summary>
		/// The order's ID, marked as the primary key.
		/// </summary>
		public int OrderID { get; set; }

		/// <summary>
		/// The order's creation date.
		/// </summary>
		public DateTime DateCreated { get; set; }

		/// <summary>
		/// The order's dispatch date.
		/// </summary>
		public DateTime DispatchDate { get; set; }

		/// <summary>
		/// False if the order hasn't been paid for yet (e.g. the customer is still browsing for products) and true if it has.
		/// </summary>
		public bool IsPaid { get; set; }

		/// TODO: Foreign keys and objects to link.
		/// private int personID;
		///
		/// private OrderItem[] orderItem;
		/// private Payment payment;
	}
}
