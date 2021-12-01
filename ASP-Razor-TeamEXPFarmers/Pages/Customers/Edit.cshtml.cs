using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_Razor_TeamEXPFarmers.Data;
using ASP_Razor_TeamEXPFarmers.Models;

namespace ASP_Razor_TeamEXPFarmers.Pages.Customers
{
    public class EditModel : PageModel
    {
        private readonly ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext _context;

        public EditModel(ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext context)
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
           ViewData["AddressID"] = new SelectList(_context.Address, "AddressID", "City");
           ViewData["PaymentID"] = new SelectList(_context.Payment, "PersonID", "PaymentCardNo");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(Person.PersonID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PersonExists(int id)
        {
            return _context.Customers.Any(e => e.PersonID == id);
        }
    }
}
