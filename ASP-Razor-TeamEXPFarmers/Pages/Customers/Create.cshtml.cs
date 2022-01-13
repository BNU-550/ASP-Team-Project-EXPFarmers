using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASP_Razor_TeamEXPFarmers.Data;
using ASP_Razor_TeamEXPFarmers.Models;
using Microsoft.AspNetCore.Authorization;

namespace ASP_Razor_TeamEXPFarmers.Pages.Customers
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext _context;

        public CreateModel(ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        //ViewData["AddressID"] = new SelectList(_context.Address, "AddressID", "City");
        //ViewData["PaymentID"] = new SelectList(_context.Payment, "PaymentID", "PaymentCardNo");
        
            return Page();
        }

        [BindProperty]
        public Person Person { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (HomePage.Name == HomePage.MY_ACCOUNT)
            {
                Person.IsCustomer = true;
                Person.IsStaff = false;
            }
            else
            {
                Person.IsCustomer = false;
                Person.IsStaff = true;
            }

            _context.Customers.Add(Person);
            await _context.SaveChangesAsync();

            if (HomePage.Name == HomePage.CUSTOMERS)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                return RedirectToPage("/MyAccount");
            }
        }
    }
}
