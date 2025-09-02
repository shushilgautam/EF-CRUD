
using EF_CRUD.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EF_CRUD.Models;

namespace EF_CRUD.Controllers;

public class TeacherController : Controller
{
    private readonly AppDbContext _context;

    public TeacherController(AppDbContext context)
    {
        _context = context;
    }

    // READ: List all teachers
    public async Task<IActionResult> Index()
    {
        return View(await _context.Teachers.ToListAsync());
    }
    
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Teacher teacher)
    {
        if (ModelState.IsValid)
        {
            _context.Add(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(teacher);
    }


    public async Task<IActionResult> Edit(int id)
    {
        var teacher = await _context.Teachers.FindAsync(id);
        if (teacher == null) return NotFound();
        return View(teacher);
    }
    
    
    // POST: Edit
    [HttpPost]
    public async Task<IActionResult> Edit(int id, Teacher teacher)
    {
        if (id != teacher.Id) return NotFound();

        if (ModelState.IsValid)
        {
            _context.Update(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(teacher);
    }

   

    public async Task<IActionResult> Delete(int id)
    {
        var teacher = await _context.Teachers.FindAsync(id);
        if (teacher == null) return NotFound();
        return View(teacher);
    }
    
    



    [HttpPost, ActionName("DeleteConfirmed")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var teacher = await _context.Teachers.FindAsync(id);
        if (teacher != null)
        {
            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Index));
    }

    
}
