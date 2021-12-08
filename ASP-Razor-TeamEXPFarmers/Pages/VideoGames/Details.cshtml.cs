﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_Razor_TeamEXPFarmers.Data;
using ASP_Razor_TeamEXPFarmers.Models;

namespace ASP_Razor_TeamEXPFarmers.Pages.VideoGames
{
    public class DetailsModel : PageModel
    {
        private readonly ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext _context;

        public DetailsModel(ASP_Razor_TeamEXPFarmers.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public VideoGame VideoGame { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VideoGame = await _context.VideoGames.FirstOrDefaultAsync(m => m.VideoGameID == id);

            if (VideoGame == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
