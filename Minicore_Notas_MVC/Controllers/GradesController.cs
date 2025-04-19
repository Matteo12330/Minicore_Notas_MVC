using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Minicore_Notas_MVC.Data;
using Minicore_Notas_MVC.Models;

namespace Minicore_Notas_MVC.Controllers
{
    public class GradesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GradesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Grades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var grade = await _context.Grades.FindAsync(id);
            if (grade == null)
                return NotFound();

            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Name", grade.StudentId);
            return View(grade);
        }

        // POST: Grades/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,GradeValue,Date,StudentId")] Grade grade)
        {
            if (id != grade.Id)
                return NotFound();

            try
            {
                _context.Update(grade);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GradeExists(grade.Id))
                    return NotFound();
                else
                    throw;
            }

            return RedirectToAction("Index", "Home");
        }

        // POST: Grades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var grade = await _context.Grades.FindAsync(id);
            if (grade != null)
            {
                _context.Grades.Remove(grade);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Home");
        }

        private bool GradeExists(int id)
        {
            return _context.Grades.Any(e => e.Id == id);
        }
    }
}
