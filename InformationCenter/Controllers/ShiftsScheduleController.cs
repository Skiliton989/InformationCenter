using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InformationCenter.Models;
using InformationCenter.Models.Data;

namespace InformationCenter.Controllers
{
    public class ShiftsScheduleController : Controller
    {
        private readonly AppCtx _context;

        public ShiftsScheduleController(AppCtx context)
        {
            _context = context;
        }

        // GET: ShiftsSchedule
        public async Task<IActionResult> Index()
        {
            var appCtx = _context.ShiftsSchedule.Include(s => s.User);
            return View(await appCtx.ToListAsync());
        }

        // GET: ShiftsSchedule/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shiftSchedule = await _context.ShiftsSchedule
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shiftSchedule == null)
            {
                return NotFound();
            }

            return View(shiftSchedule);
        }

        // GET: ShiftsSchedule/Create
        public IActionResult Create()
        {
            ViewData["IdUser"] = new SelectList(_context.Users, "FirstName", "FirstName");
            return View();
        }

        // POST: ShiftsSchedule/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDate,EndDate,ExitMark,FullChange,IdUser")] ShiftSchedule shiftSchedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shiftSchedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdUser"] = new SelectList(_context.Users, "Id", "Id", shiftSchedule.IdUser);
            return View(shiftSchedule);
        }

        // GET: ShiftsSchedule/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shiftSchedule = await _context.ShiftsSchedule.FindAsync(id);
            if (shiftSchedule == null)
            {
                return NotFound();
            }
            ViewData["IdUser"] = new SelectList(_context.Users, "FirstName", "FirstName", shiftSchedule.IdUser);
            return View(shiftSchedule);
        }

        // POST: ShiftsSchedule/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("Id,StartDate,EndDate,ExitMark,FullChange,IdUser")] ShiftSchedule shiftSchedule)
        {
            if (id != shiftSchedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shiftSchedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShiftScheduleExists(shiftSchedule.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdUser"] = new SelectList(_context.Users, "Id", "Id", shiftSchedule.IdUser);
            return View(shiftSchedule);
        }

        // GET: ShiftsSchedule/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shiftSchedule = await _context.ShiftsSchedule
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shiftSchedule == null)
            {
                return NotFound();
            }

            return View(shiftSchedule);
        }

        // POST: ShiftsSchedule/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            var shiftSchedule = await _context.ShiftsSchedule.FindAsync(id);
            _context.ShiftsSchedule.Remove(shiftSchedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShiftScheduleExists(short id)
        {
            return _context.ShiftsSchedule.Any(e => e.Id == id);
        }
    }
}
