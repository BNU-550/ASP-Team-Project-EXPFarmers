using System;
using System.ComponentModel.DataAnnotations;

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
	/// Modified by Jason Huggins (20/11/2021)
	/// </summary>
	public class OrderItem
	{
		/// <summary>
		/// The price the order item is sold for.
		/// </summary>
		[Display(Name = "Sale Price"), Required]
		public decimal SalePrice { get; set; }

		/// <summary>
		/// The quantity of the item in the order.
		/// </summary>
		[Display(Name = "Quantity"), MaxLength(2), Required]
		public int ItemQuantity { get; set; }

		/// <summary>
		/// The customer's rating for the order item (out of 5).
		/// </summary>
		[Display(Name = "Customer Rating"), MaxLength(1)]
		public int CustomerRating { get; set; }

		/// <summary>
		/// The customer's review for the order item.
		/// </summary>
		[Display(Name = "Customer Review"), StringLength(500)]
		public string CustomerReview { get; set; }

		/// <summary>
		/// The date the customer created this review.
		/// </summary>
		[Display(Name = "Customer Review Date"), DataType(DataType.Date)]
		public DateTime CustomerReviewDate { get; set; }

		/// TODO: Link these in this class.
		/// private Order order;
		/// private VideoGame product;
	}
}
