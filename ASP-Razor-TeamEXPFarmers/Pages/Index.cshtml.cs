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
        private readonly ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext _context;

        public IndexModel(ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<VideoGame> VideoGame { get; set; }
        public string CurrentFilter { get; set; }

        public async Task OnGetAsync(string searchString)
        {
            CurrentFilter = searchString;
            IQueryable<VideoGame> videoGameIQ = from v
                                                in _context.VideoGames
                                                select v;
            IQueryable<Platform> platformIQ = from p
                                              in _context.Platforms
                                              select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                videoGameIQ = videoGameIQ.Where(v => v.Title.Contains(searchString));
                platformIQ = platformIQ.Where(p => p.PlatformID.Contains(searchString));
            }

            VideoGame = await _context.VideoGames.ToListAsync();
        }
    }
}