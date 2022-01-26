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

namespace ASP_Razor_TeamEXPFarmers.Pages.OrderItems
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext _context;

        public DetailsModel(ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public OrderItem OrderItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderItem = await _context.OrderItems
                .Include(o => o.Order)
                .Include(o => o.VideoGame).FirstOrDefaultAsync(m => m.OrderItemID == id);

            if (OrderItem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
