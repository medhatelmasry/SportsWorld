using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportsWorld.Data;
using SportsWorld.Models;

namespace SportsWorld.Pages_TeamPages
{
    public class IndexModel : PageModel
    {
        private readonly SportsWorld.Data.ApplicationDbContext _context;

        public IndexModel(SportsWorld.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Team> Team { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Teams != null)
            {
                Team = await _context.Teams.ToListAsync();
            }
        }
    }
}
