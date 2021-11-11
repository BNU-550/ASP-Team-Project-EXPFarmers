using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_TeamEXPFarmers.Models
{
    /// <summary>
    /// Represents the video game genres in the database.
    /// 
	/// Created by Jason Huggins
	/// Modified by Jason Huggins (11/11/2021)
    /// </summary>
    public enum Genre
    {
        [Display(Name = "Action")]
        Action,
        [Display(Name = "Action-adventure")]
        Action_Adventure,
        [Display(Name = "Role-playing")]
        Role_Playing,
        [Display(Name = "Simulation")]
        Simulation,
        [Display(Name = "Sports")]
        Sports,
        [Display(Name = "Strategy")]
        Strategy
    }
}
