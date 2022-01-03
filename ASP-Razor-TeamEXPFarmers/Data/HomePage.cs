namespace ASP_Razor_TeamEXPFarmers.Data
{
    /// <summary>
    /// TODO: Finish redirect constants.
    /// This class handles the redirecting of pages in the web application, so users
    /// can keep track of their position and not get redirected to a page they
    /// shouldn't be on.
    /// 
    /// Created by Jason Huggins
	/// Modified by Jason Huggins (03/01/2022)
    /// </summary>
    public static class HomePage
    {
        // Constants
        public const string MY_ACCOUNT = "MyAccount";
        public const string CUSTOMERS = "Customers/Index";
        public const string CUSTOMER_CREATE = "Customers/Create";

        // Properties
        public static string Name { get; set; }
    }
}
