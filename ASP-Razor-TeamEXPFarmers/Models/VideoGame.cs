using System;

namespace ASP_Razor_TeamEXPFarmers.Models
{
	/// <summary>
	/// Represents a digital video game stored in the web application's database.
	/// 
	/// Here, each video game has an ID associated with it and this class stores
	/// the video game's title, description, image, genre and PEGI rating (taken
	/// from the relevant enumerations), release date, price, information about
	/// its mature content and difficulty levels, as well as how many codes for
	/// each video game are in stock.
	/// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (11/11/2021)
	/// 
	/// TODO: Set data annotations for properties based on ERD.
	/// </summary>
	public class VideoGame
	{
		/// <summary>
		/// The video game's ID, marked as the primary key.
		/// </summary>
		public int VideoGameID { get; set; }

		/// <summary>
		/// The video game's title.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// The video game's description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// An image of the video game.
		/// </summary>
		public string Image { get; set; }

		/// <summary>
		/// The video game's genre.
		/// </summary>
		public Genre Genre { get; set; }

		/// <summary>
		/// The video game's age rating according to PEGI [3, 7, 12, 16 or 18].
		/// </summary>
		public PEGI PEGI { get; set; }

		/// <summary>
		/// The video game's difficulty level from 1 (very easy) to 5 (very hard).
		/// </summary>
		public int DifficultyLevel { get; set; }

		/// <summary>
		/// The video game's mature content level from 1 (very mild) to 5 (very mature).
		/// </summary>
		public int MatureContentLevel { get; set; }

		/// <summary>
		/// The video game's release date.
		/// </summary>
		public DateTime ReleaseDate { get; set; }

		/// <summary>
		/// The video game's price.
		/// </summary>
		public decimal Price { get; set; }

		/// <summary>
		/// The quantity of the video game currently in stock.
		/// </summary>
		public int InStockQuantity { get; set; }

		/// TODO: Work out how to link these to this class.
		/// private OrderItem[] orderItem;
		/// private Platform[] platform;
	}
}
