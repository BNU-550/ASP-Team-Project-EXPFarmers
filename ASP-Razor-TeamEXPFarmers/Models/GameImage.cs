using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_TeamEXPFarmers.Models
{
    /// <summary>
    /// Represents an image for a specific video game, containing its file path,
    /// caption and a link to the video game it's related to.
    /// 
    /// Created by Jason Huggins
	/// Modified by Jason Huggins (15/12/2021)
    /// </summary>
    public class GameImage
    {
        /// <summary>
        /// The image's ID; primary key.
        /// </summary>
        [Key]
        public int GameImageID { get; set; }

        /// <summary>
        /// The video game associated with this image; foreign key
        /// </summary>
        public int VideoGameID { get; set; }

        /// <summary>
        /// The image's file path/URL.
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// The image's caption.
        /// </summary>
        [StringLength(50)]
        public string Caption { get; set; }

        // Navigation properties
        public virtual VideoGame VideoGame { get; set; }
    }
}
