using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_TeamEXPFarmers.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class GameImage
    {
        /// <summary>
        /// 
        /// </summary>
        public int GameImageID { get; set; }

        /// <summary>
        /// Foreign key
        /// </summary>
        public int VideoGameID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        public string Caption { get; set; }

        // Navigation properties
        public virtual VideoGame VideoGame { get; set; }
    }
}
