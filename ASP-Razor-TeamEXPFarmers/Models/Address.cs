using System;

namespace ASP_Razor_TeamEXPFarmers.Models
{
	/// <summary>
	/// Represents the addresses stored in the database, each associated with an
	/// address ID as the primary key and this class comprises the house number
	/// (and name if it exists), street, city and postcode. The address ID can
	/// be linked with numerous people in the database. 
	/// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (11/11/2021)
	/// 
	/// TODO: Set data annotations for properties based on ERD.
	/// </summary>
	public class Address
    {
		/// <summary>
		/// The ID of the address.
		/// </summary>
		public int AddressID { get; set; }

		/// <summary>
		/// The house number.
		/// </summary>
		public string HouseNo { get; set; }

		/// <summary>
		/// The name of the house but can be left blank if only a house number exists.
		/// </summary>
		public string HouseName { get; set; }

		/// <summary>
		/// The street address.
		/// </summary>
		public string Street { get; set; }

		/// <summary>
		/// The address' town/city.
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// The address' postcode.
		/// </summary>
		public String Postcode { get; set; }

		/// TODO: Not sure about this one so commenting out for now.
		/// private Person[] person;
	}
}
