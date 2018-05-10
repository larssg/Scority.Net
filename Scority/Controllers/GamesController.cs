using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scority.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scority.Controllers
{
    public class GamesController : Controller
    {
        private ScorityContext _context;

        public GamesController(ScorityContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Games.ToListAsync());
        }
    }
}
