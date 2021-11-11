using System;

namespace ASP_Razor_TeamEXPFarmers.Models
{
	/// <summary>
	/// Represents payments made by customers in the web application. This will
	/// securely store the customer's payment card details like their card number,
	/// start/end dates and the 3-digit CSV code. In the web application, the
	/// customer will be able to edit or delete their payment method.
	/// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (11/11/2021)
	/// 
	/// TODO: Set data annotations for properties based on ERD.
	/// </summary>
	public class Payment
	{
		/// <summary>
		/// The payment card number.
		/// </summary>
		public string PaymentCardNo { get; set; }

		/// <summary>
		/// The payment card's start month.
		/// </summary>
		public int CardStartMonth { get; set; }

		/// <summary>
		/// The payment card's start year.
		/// </summary>
		public int CardStartYear { get; set; }

		/// <summary>
		/// The payment card's expiry month.
		/// </summary>
		public int CardExpiryMonth { get; set; }

		/// <summary>
		/// The payment card's expiry year.
		/// </summary>
		public int CardExpiryYear { get; set; }

		/// <summary>
		/// The payment card's CSV number (three digits on the back).
		/// </summary>
		public int CardCSV { get; set; }

		/// TODO: Link these with this class.
		/// private Order order;
		/// private Person person;
	}
}
