using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_TeamEXPFarmers.Models
{
	/// <summary>
	/// Represents payments made by customers in the web application. This will
	/// securely store the customer's payment card details like their card number,
	/// start/end dates and the 3-digit CSV code. In the web application, the
	/// customer will be able to edit or delete their payment method.
	/// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (22/11/2021)
	/// </summary>
	public class Payment
	{
		// Primary key
		// TODO: Might fail
		[Key]
		public int PersonID { get; set; }

		/// <summary>
		/// The payment card number.
		/// </summary>
		[Display(Name = "Card No."), StringLength(16), Required]
		public string PaymentCardNo { get; set; }

		/// <summary>
		/// The payment card's start month.
		/// </summary>
		[Display(Name = "Card Start Month"), MaxLength(2)]
		public int CardStartMonth { get; set; }

		/// <summary>
		/// The payment card's start year.
		/// </summary>
		[Display (Name = "Card Start Year"), MaxLength(4)]
		public int CardStartYear { get; set; }

		/// <summary>
		/// The payment card's expiry month.
		/// </summary>
		[Display(Name = "Card Expiry Month"), MaxLength(2), Required]
		public int CardExpiryMonth { get; set; }

		/// <summary>
		/// The payment card's expiry year.
		/// </summary>
		[Display(Name = "Card Expiry Year"), MaxLength(4), Required]
		public int CardExpiryYear { get; set; }

		/// <summary>
		/// The payment card's CSV number (three digits on the back).
		/// </summary>
		[Display(Name = "Card CSV No."), MaxLength(3), Required]
		public int CardCSV { get; set; }

		// Navigation property
		public virtual Person Person { get; set; }
	}
}
