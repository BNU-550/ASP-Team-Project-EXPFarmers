using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_TeamEXPFarmers.Models
{
	/// <summary>
	/// Represents the addresses stored in the database, each associated with an
	/// address ID as the primary key and this class comprises the house number
	/// (and name if it exists), street, city and postcode. The address ID can
	/// be linked with numerous people in the database. 
	/// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (25/11/2021)
	/// </summary>
	public class Address
    {
		/// <summary>
		/// The ID of the address.
		/// </summary>
		[Key]
		public int AddressID { get; set; }

		/// <summary>
		/// The house number.
		/// </summary>
		[Display(Name = "House No."), StringLength(5), Required]
		public string HouseNo { get; set; }

		/// <summary>
		/// The name of the house but can be left blank if only a house number exists.
		/// </summary>
		[Display(Name = "House Name"), StringLength(50)]
		public string HouseName { get; set; }

		/// <summary>
		/// The street address.
		/// </summary>
		[StringLength(75), Required]
		public string Street { get; set; }

		/// <summary>
		/// The address' town/city.
		/// </summary>
		[StringLength(35), Required]
		public string City { get; set; }

		/// <summary>
		/// The address' postcode.
		/// </summary>
		[StringLength(15), Required]
		[DataType(DataType.PostalCode)]
		public string Postcode { get; set; }
	}
}
