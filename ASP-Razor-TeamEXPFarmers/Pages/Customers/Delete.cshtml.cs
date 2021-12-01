using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_Razor_TeamEXPFarmers.Data;
using ASP_Razor_TeamEXPFarmers.Models;

namespace ASP_Razor_TeamEXPFarmers.Pages.Customers
{
    public class DeleteModel : PageModel
    {
        private readonly ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext _context;

        public DeleteModel(ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.Customers
                .Include(p => p.Address)
                .Include(p => p.Payment).FirstOrDefaultAsync(m => m.PersonID == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.Customers.FindAsync(id);

            if (Person != null)
            {
                _context.Customers.Remove(Person);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
