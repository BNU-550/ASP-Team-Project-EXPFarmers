using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_Razor_TeamEXPFarmers.Data;
using ASP_Razor_TeamEXPFarmers.Models;

namespace ASP_Razor_TeamEXPFarmers.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<VideoGame> VideoGames { get; set; }

        public async Task OnGetAsync(string filter)
        {
             if(!String.IsNullOrEmpty(filter))
            {
                ViewData["Platform"] = filter;
            }

            VideoGames = await _context.VideoGames
                .Include(g => g.Platforms)
                .ToListAsync();
        }
    }
}