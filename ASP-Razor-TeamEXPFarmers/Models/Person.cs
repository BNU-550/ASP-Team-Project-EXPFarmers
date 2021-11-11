using System;

namespace ASP_Razor_TeamEXPFarmers.Models
{
	/// <summary>
	/// Represents each person in the database, storing their details such as their name, 
	/// email address, date of birth (for age verification), links their home address
	/// from the Address class and indicates whether the individual is a customer or
	/// staff member.
	/// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (11/11/2021)
	/// 
	/// TODO: Set data annotations for properties based on ERD.
	/// </summary>
	public class Person
	{
		/// <summary>
		/// The person's ID, acting as the database's primary key.
		/// </summary>
		public int PersonID { get; set; }

		/// <summary>
		/// The person's first name.
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// The person's last name.
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// The person's email address.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// The person's contact number.
		/// </summary>
		public string ContactNumber { get; set; }

		/// <summary>
		/// The person's date of birth.
		/// </summary>
		public DateTime DateOfBirth { get; set; }

		/// <summary>
		/// True if the person is a customer and false otherwise.
		/// </summary>
		public bool IsCustomer { get; set; }

		/// <summary>
		/// True if the person is a staff member and false otherwise.
		/// </summary>
		public bool IsStaff { get; set; }

		/// TODO: Not sure where these go yet, so commenting out for now.
		/// private Staff staff;
		/// private Payment transaction;
		/// private Address address;
	}
}
