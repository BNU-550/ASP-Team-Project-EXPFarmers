using System;

namespace ASP_Razor_TeamEXPFarmers.Models
{
	/// <summary>
	/// Represents each order item within an order in the web application's database.
	/// 
	/// In this class, the order item's sale price, quantity within the order, as well
	/// as a customer's rating, review and review date should they provide one 
	/// are stored. This will link to the Order and VideoGame classes, effectively
	/// acting as an item in the customer's basket. 
	/// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (11/11/2021)
	/// 
	/// TODO: Set data annotations for properties based on ERD.
	/// </summary>
	public class OrderItem
	{
		/// <summary>
		/// The price the order item is sold for.
		/// </summary>
		public decimal SalePrice { get; set; }

		/// <summary>
		/// The quantity of the item in the order.
		/// </summary>
		public int ItemQuantity { get; set; }

		/// <summary>
		/// The customer's rating for the order item (out of 5).
		/// </summary>
		public int CustomerRating { get; set; }

		/// <summary>
		/// The customer's review for the order item.
		/// </summary>
		public string CustomerReview { get; set; }

		/// <summary>
		/// The date the customer created this review.
		/// </summary>
		public DateTime CustomerReviewDate { get; set; }

		/// TODO: Link these in this class.
		/// private Order order;
		/// private VideoGame product;
	}
}
