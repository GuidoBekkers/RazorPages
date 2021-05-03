﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using Test.Data;

namespace Test.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Test.Data.TestContext _context;

        public IndexModel(Test.Data.TestContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
           Movie = await _context.Movie.ToListAsync();
        }
    }
}
