﻿using eTicketsApplication.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicketsApplication.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
          
        }
        public async Task<IActionResult> Index()
        {
            var allcinemas = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
