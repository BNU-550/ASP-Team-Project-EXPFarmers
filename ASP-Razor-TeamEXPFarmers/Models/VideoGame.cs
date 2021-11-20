using System;
using System.ComponentModel.DataAnnotations;

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
	/// Modified by Jason Huggins (20/11/2021)
	/// </summary>
	public class VideoGame
	{
		/// <summary>
		/// The video game's ID, marked as the primary key.
		/// </summary>
		[Key]
		public int VideoGameID { get; set; }

		/// <summary>
		/// The video game's title.
		/// </summary>
		[StringLength(40), Required]
		public string Title { get; set; }

		/// <summary>
		/// The video game's description.
		/// </summary>
		[StringLength(1000), Required]
		public string Description { get; set; }

		/// <summary>
		/// An image of the video game (string will be the image's filepath).
		/// </summary>
		[StringLength(255), Required]
		public string Image { get; set; }

		/// <summary>
		/// The video game's genre.
		/// </summary>
		[Required]
		public Genre Genre { get; set; }

		/// <summary>
		/// The video game's age rating according to PEGI [3, 7, 12, 16 or 18].
		/// </summary>
		[Required]
		public PEGI PEGI { get; set; }

		/// <summary>
		/// The video game's difficulty level from very easy to very hard.
		/// </summary>
		[Display(Name = "Difficulty Level"), Required]
		public DifficultyLevel DifficultyLevel { get; set; }

		/// <summary>
		/// The video game's mature content level from having no mature
		/// content to being mature.
		/// </summary>
		[Display(Name = "Mature Content Level"), Required]
		public MatureContentLevel MatureContentLevel { get; set; }

		/// <summary>
		/// The video game's mature content description, expanding on the
		/// above mature content level by describing what kind of mature 
		/// content is present in it. 
		/// </summary>
		[Display(Name = "Mature Content Description"), StringLength(300), 
			Required]
		public string MatureContentDescription { get; set; }

		/// <summary>
		/// The video game's release date.
		/// </summary>
		[Display(Name = "Release Date"), DataType(DataType.Date), 
			Required]
		public DateTime ReleaseDate { get; set; }

		/// <summary>
		/// The video game's price.
		/// </summary>
		[Required]
		public decimal Price { get; set; }

		/// <summary>
		/// The quantity of the video game currently in stock.
		/// </summary>
		[Display(Name = "Quantity In Stock"), Required]
		public int InStockQuantity { get; set; }

		/// TODO: Work out how to link these to this class.
		/// private OrderItem[] orderItem;
		/// private Platform[] platform;
	}
}
