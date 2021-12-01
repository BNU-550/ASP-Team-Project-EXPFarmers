using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_Razor_TeamEXPFarmers.Models
{
	/// <summary>
	/// Represents the video game platforms in the database, for example:
	/// PlayStation 4, Xbox One, Xbox Series X/S, Nintendo Switch, PC
	/// This will be linked with the video games from the VideoGame class
	/// and a video game can be on many platforms.
	/// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (22/11/2021)
	/// </summary>
	public class Platform
	{
		/// <summary>
		/// The platform ID which is its name (e.g. PlayStation 4, Xbox One, Nintendo Switch).
		/// </summary>
		[Key, StringLength(20), ]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public string PlatformID { get; set; }

		/// <summary>
		/// Navigation property.
		/// The video games associated with this platform.
		/// </summary>
		[Display(Name = "Associated Games")]
		public virtual ICollection<VideoGame> VideoGames { get; set; }
	}
}
