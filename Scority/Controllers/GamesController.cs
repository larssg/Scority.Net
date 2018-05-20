using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scority.Models;

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

        public async Task<IActionResult> Show(int id)
        {
            return View(await _context.Games.FindAsync(id));
        }
    }
}
