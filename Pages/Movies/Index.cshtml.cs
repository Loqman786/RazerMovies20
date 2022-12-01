using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazerMovies20.Data;
using RazorMovies20.Models;

namespace RazerMovies20.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazerMovies20.Data.ApplicationDbContext _context;

        public IndexModel(RazerMovies20.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
