using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_TeamEXPFarmers.Models
{
	/// <summary>
	/// Represents the difficulty level associated to each video game
	/// stored in the database to make it easier for customers to see
	/// how difficult each game is.
	/// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (20/11/2021)
	/// </summary>
	public enum DifficultyLevel
    {
		[Display(Name = "Very Easy")]
		VeryEasy,
		[Display(Name = "Easy")]
		Easy,
		[Display(Name = "Moderate")]
		Moderate,
		[Display(Name = "Hard")]
		Hard,
		[Display(Name = "Very Hard")]
		VeryHard
    }
}
