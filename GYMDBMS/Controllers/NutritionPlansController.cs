using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GYMDBMS.Models;

namespace GYMDBMS.Controllers
{
    public class NutritionPlansController : Controller
    {
        private readonly GYMContext _context;

        public NutritionPlansController(GYMContext context)
        {
            _context = context;
        }

        // GET: NutritionPlans
        public async Task<IActionResult> Index()
        {
              return _context.NutritionPlans != null ? 
                          View(await _context.NutritionPlans.ToListAsync()) :
                          Problem("Entity set 'GYMContext.NutritionPlans'  is null.");
        }

        // GET: NutritionPlans/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NutritionPlans == null)
            {
                return NotFound();
            }

            var nutritionPlan = await _context.NutritionPlans
                .FirstOrDefaultAsync(m => m.PlanId == id);
            if (nutritionPlan == null)
            {
                return NotFound();
            }

            return View(nutritionPlan);
        }

        // GET: NutritionPlans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NutritionPlans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlanId,Name,Description")] NutritionPlan nutritionPlan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nutritionPlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nutritionPlan);
        }

        // GET: NutritionPlans/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NutritionPlans == null)
            {
                return NotFound();
            }

            var nutritionPlan = await _context.NutritionPlans.FindAsync(id);
            if (nutritionPlan == null)
            {
                return NotFound();
            }
            return View(nutritionPlan);
        }

        // POST: NutritionPlans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PlanId,Name,Description")] NutritionPlan nutritionPlan)
        {
            if (id != nutritionPlan.PlanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nutritionPlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NutritionPlanExists(nutritionPlan.PlanId))
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
            return View(nutritionPlan);
        }

        // GET: NutritionPlans/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NutritionPlans == null)
            {
                return NotFound();
            }

            var nutritionPlan = await _context.NutritionPlans
                .FirstOrDefaultAsync(m => m.PlanId == id);
            if (nutritionPlan == null)
            {
                return NotFound();
            }

            return View(nutritionPlan);
        }

        // POST: NutritionPlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NutritionPlans == null)
            {
                return Problem("Entity set 'GYMContext.NutritionPlans'  is null.");
            }
            var nutritionPlan = await _context.NutritionPlans.FindAsync(id);
            if (nutritionPlan != null)
            {
                _context.NutritionPlans.Remove(nutritionPlan);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NutritionPlanExists(string id)
        {
          return (_context.NutritionPlans?.Any(e => e.PlanId == id)).GetValueOrDefault();
        }
    }
}
