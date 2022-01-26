using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_TeamEXPFarmers.Models
{
	/// <summary>
	/// Represents each person in the database, storing their details such as their name, 
	/// email address, date of birth (for age verification), links their home address
	/// from the Address class and indicates whether the individual is a customer or
	/// staff member.
	/// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (25/11/2021)
	/// </summary>
	public class Person
	{
		/// <summary>
		/// The person's ID, acting as the database's primary key.
		/// </summary>
		[Key]
		public int PersonID { get; set; }

		// Foreign keys
		public Nullable<int> AddressID { get; set; }
		public Nullable<int> PaymentID { get; set; }

		/// <summary>
		/// The person's first name.
		/// </summary>
		[Display(Name = "First Name"), StringLength(20), Required]
		public string FirstName { get; set; }

		/// <summary>
		/// The person's last name.
		/// </summary>
		[Display(Name = "Last Name"), StringLength(30), Required]
		public string LastName { get; set; }

		/// <summary>
		/// The person's email address.
		/// </summary>
		[Display(Name = "Email Address"), StringLength(128), Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		/// <summary>
		/// The person's contact number.
		/// </summary>
		[Display(Name = "Contact No."), StringLength(30), Required]
		[DataType(DataType.PhoneNumber)]
		public string ContactNumber { get; set; }

		/// <summary>
		/// The person's date of birth.
		/// </summary>
		[Display(Name = "Date of Birth"), DataType(DataType.Date), Required]
		public DateTime DateOfBirth { get; set; }

		/// <summary>
		/// True if the person is a customer and false otherwise.
		/// </summary>
		[Display(Name = "Customer?"), Required]
		public bool IsCustomer { get; set; }

		/// <summary>
		/// True if the person is a staff member and false otherwise.
		/// </summary>
		[Display(Name = "Staff?"), Required]
		public bool IsStaff { get; set; }

		/// <summary>
		/// Calculated property.
		/// The person's full name, concatenating FirstName and
		/// LastName.
		/// </summary>
		[Display(Name = "Full Name")]
		public string FullName
		{
			get { return FirstName + " " + LastName; }
		}

		// Navigation properties
		public virtual Address Address { get; set; }
		public virtual Payment Payment { get; set; }
		public virtual ICollection<Order> Orders { get; set; }
	}
}
