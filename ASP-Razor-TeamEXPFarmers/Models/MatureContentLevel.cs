namespace ASP_Razor_TeamEXPFarmers.Models
{
	/// <summary>
	/// Represents the mature content level associated to each video game
	/// stored in the database to make it easier for customers to see
	/// how mature each game is, especially useful for parents 
	/// browsing games for their child.
	/// 
	/// This will take all factors into account like violence, profanity,
	/// adult themes and more, but the content will be described in 
	/// detail in the content descriptions for each game.
	/// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (20/11/2021)
	/// </summary>
	public enum MatureContentLevel
    {
		None,
		Mild,
		Moderate,
		Mature
    }
}
