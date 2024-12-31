using Hadeelsamer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hadeelsamer.Controllers
{
    public class TeamMemberController : Controller
    {
        private readonly context _context;

        public TeamMemberController(context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Edit(int id)
        {

            var taske = await _context.Tasks.FindAsync(id);
            if (taske == null)
            {
                return NotFound();
            } 
            return View(taske);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(TeamMamber teamMamber)
        {
            _context.Update(teamMamber);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            return View(teamMamber);
        }
    }
}
