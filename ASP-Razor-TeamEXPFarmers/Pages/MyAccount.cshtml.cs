using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_Razor_TeamEXPFarmers.Data;
using ASP_Razor_TeamEXPFarmers.Models;
using Microsoft.AspNetCore.Authorization;

namespace ASP_Razor_TeamEXPFarmers.Pages
{
    [Authorize]
    public class MyAccountModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public MyAccountModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            string name = User.Identity.Name;
            HomePage.Name = HomePage.MY_ACCOUNT;

            Person = await _context.Customers
                .Include(p => p.Address)
                .Include(p => p.Payment)
                .FirstOrDefaultAsync(m => m.Email == name);

            if (Person == null)
            {
                //todo: goto Customer Create
                return NotFound();
            }

            return Page();
        }
    }
}
