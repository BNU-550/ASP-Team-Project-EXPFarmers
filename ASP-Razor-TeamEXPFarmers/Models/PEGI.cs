using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_TeamEXPFarmers.Models
{
	/// <summary>
	/// Represents the PEGI age ratings in the database.
	/// 
	/// Created  by Jason Huggins
	/// Modified by Jason Huggins (11/11/2021)
	/// </summary>
	public enum PEGI
	{
		[Display(Name = "PEGI 3")]
		PEGI_3,
		[Display(Name = "PEGI 7")]
		PEGI_7,
		[Display(Name = "PEGI 12")]
		PEGI_12,
		[Display(Name = "PEGI 16")]
		PEGI_16,
		[Display(Name = "PEGI 18")]
		PEGI_18
	}
}
