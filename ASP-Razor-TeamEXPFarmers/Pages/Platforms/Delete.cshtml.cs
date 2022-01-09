using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_Razor_TeamEXPFarmers.Data;
using ASP_Razor_TeamEXPFarmers.Models;
using Microsoft.AspNetCore.Authorization;

namespace ASP_Razor_TeamEXPFarmers.Pages.Platforms
{
    [Authorize(Policy = "RequireStaffRole")]
    public class DeleteModel : PageModel
    {
        private readonly ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext _context;

        public DeleteModel(ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Platform Platform { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Platform = await _context.Platforms.FirstOrDefaultAsync(m => m.PlatformID == id);

            if (Platform == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Platform = await _context.Platforms.FindAsync(id);

            if (Platform != null)
            {
                _context.Platforms.Remove(Platform);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
