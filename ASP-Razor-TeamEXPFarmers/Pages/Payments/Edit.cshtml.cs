﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_Razor_TeamEXPFarmers.Data;
using ASP_Razor_TeamEXPFarmers.Models;
using Microsoft.AspNetCore.Authorization;

namespace ASP_Razor_TeamEXPFarmers.Pages.Payments
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext _context;

        public EditModel(ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Payment Payment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Payment = await _context.Payment.FirstOrDefaultAsync(m => m.PaymentID == id);

            if (Payment == null)
            {
                return NotFound();
            }
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

            _context.Attach(Payment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentExists(Payment.PaymentID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            if (HomePage.Name == HomePage.CUSTOMERS)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                return RedirectToPage("/MyAccount");
            }
        }

        private bool PaymentExists(int id)
        {
            return _context.Payment.Any(e => e.PaymentID == id);
        }
    }
}
