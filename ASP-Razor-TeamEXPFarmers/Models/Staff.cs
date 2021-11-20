using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_TeamEXPFarmers.Models
{
	/// <summary>
	/// Represents staff members in the database. Their details and address
	/// are taken from the Person class with its primary key being linked
	/// to this class, and some other information is contained here such
	/// as the staff member's job position and salary.
	/// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (20/11/2021)
	/// </summary>
	public class Staff
    {
		/// <summary>
		/// The staff member's current job position.
		/// </summary>
		[Display(Name = "Job Position"), StringLength(50), Required]
		public string JobPosition { get; set; }

		/// <summary>
		/// The staff member's salary.
		/// </summary>
		[Required]
		public decimal Salary { get; set; }

		/// TODO: Work out where this goes.
		/// private Person person;
	}
}
