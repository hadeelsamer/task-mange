using Hadeelsamer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task = Hadeelsamer.Models.Task;

namespace Hadeelsamer.Controllers
{
    public class TasksController : Controller
    {
        private readonly context _context;

        public TasksController(context context)
        {
            _context = context;
        }

        public async Task< ActionResult> Index()
        {
            return View(await _context.Tasks.ToListAsync());
        }

        public async Task< ActionResult> Edit(int id)
        {

            var taske = await _context.Tasks.FindAsync(id);
            if (taske == null)
            {
                return NotFound();
            }
            return View(taske);
        }
        [HttpPost]      
        public  async Task< ActionResult> Edit(Task task)
        {
            _context.Update(task);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            return View(task);
        }
    }
}
