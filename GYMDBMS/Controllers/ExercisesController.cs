//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using GYMDBMS.Models;

//namespace GYMDBMS.Controllers
//{
//    public class ExercisesController : Controller
//    {
//        private readonly GYMContext _context;

//        public ExercisesController(GYMContext context)
//        {
//            _context = context;
//        }

//        // GET: Exercises

//        //    public async Task<IActionResult> Index()
//        //    {


//        //        return View(await _context.Exercises.ToListAsync());
//        //    }


//        //// GET: Exercises/Details/5
//        //public async Task<IActionResult> Details(string id)
//        //{
//        //    if (id == null || _context.Exercises == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    var exercise = await _context.Exercises
//        //        .FirstOrDefaultAsync(m => m.ExerciseId == id);
//        //    if (exercise == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    return View(exercise);
//        //}

//        //// GET: Exercises/Create
//        //public IActionResult Create()
//        //{
//        //    return View();
//        //}

//        //// POST: Exercises/Create
//        //// To protect from overposting attacks, enable the specific properties you want to bind to.
//        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> Create([Bind("ExerciseId,Name,Instruction")] Exercise exercise)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        _context.Add(exercise);
//        //        await _context.SaveChangesAsync();
//        //        return RedirectToAction(nameof(Index));
//        //    }
//        //    return View(exercise);
//        //}

//        //// GET: Exercises/Edit/5
//        //public async Task<IActionResult> Edit(string id)
//        //{
//        //    if (id == null || _context.Exercises == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    var exercise = await _context.Exercises.FindAsync(id);
//        //    if (exercise == null)
//        //    {
//        //        return NotFound();
//        //    }
//        //    return View(exercise);
//        //}

//        //// POST: Exercises/Edit/5
//        //// To protect from overposting attacks, enable the specific properties you want to bind to.
//        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> Edit(string id, [Bind("ExerciseId,Name,Instruction")] Exercise exercise)
//        //{
//        //    if (id != exercise.ExerciseId)
//        //    {
//        //        return NotFound();
//        //    }

//        //    if (ModelState.IsValid)
//        //    {
//        //        try
//        //        {
//        //            _context.Update(exercise);
//        //            await _context.SaveChangesAsync();
//        //        }
//        //        catch (DbUpdateConcurrencyException)
//        //        {
//        //            if (!ExerciseExists(exercise.ExerciseId))
//        //            {
//        //                return NotFound();
//        //            }
//        //            else
//        //            {
//        //                throw;
//        //            }
//        //        }
//        //        return RedirectToAction(nameof(Index));
//        //    }
//        //    return View(exercise);
//        //}

//        //// GET: Exercises/Delete/5
//        //public async Task<IActionResult> Delete(string id)
//        //{
//        //    if (id == null || _context.Exercises == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    var exercise = await _context.Exercises
//        //        .FirstOrDefaultAsync(m => m.ExerciseId == id);
//        //    if (exercise == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    return View(exercise);
//        //}

//        //// POST: Exercises/Delete/5
//        //[HttpPost, ActionName("Delete")]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> DeleteConfirmed(string id)
//        //{
//        //    if (_context.Exercises == null)
//        //    {
//        //        return Problem("Entity set 'GYMContext.Exercises'  is null.");
//        //    }
//        //    var exercise = await _context.Exercises.FindAsync(id);
//        //    if (exercise != null)
//        //    {
//        //        _context.Exercises.Remove(exercise);
//        //    }

//        //    await _context.SaveChangesAsync();
//        //    return RedirectToAction(nameof(Index));
//        //}

//        //private bool ExerciseExists(string id)
//        //{
//        //  return (_context.Exercises?.Any(e => e.ExerciseId == id)).GetValueOrDefault();
//        //}
//        //public IActionResult Upload(int id)
//        //{
//        //    var exercise = _context.Exercises.Find(id);

//        //    if (exercise == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    return View(exercise);
//        //}

//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> Upload(int id, IFormFile image)
//        //{
//        //    if (image != null && image.Length > 0)
//        //    {
//        //        var exercise = await _context.Exercises.FindAsync(id);
//        //        var imagePath = Path.Combine("Images", $"{id}_{exercise.Name}.jpg");
//        //        using (var fileStream = new FileStream(imagePath, FileMode.Create))
//        //        {
//        //            await image.CopyToAsync(fileStream);
//        //        }
//        //    }

//        //    return RedirectToAction(nameof(Index));
//        //}
//        private readonly GYMContext _context;

//        public ExercisesController(GYMContext context)
//        {
//            _context = context;
//        }

//        // GET: Exercises
//        public async Task<IActionResult> Index()
//        {
//            var exercises = await _context.Exercises.ToListAsync();
//            return View(exercises);
//        }

//        // GET: Exercises/Details/5
//        public async Task<IActionResult> Details(string id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var exercise = await _context.Exercises
//                .FirstOrDefaultAsync(m => m.ExerciseId == id);
//            if (exercise == null)
//            {
//                return NotFound();
//            }

//            return View(exercise);
//        }

//        // GET: Exercises/Edit/5
//        public async Task<IActionResult> Edit(string id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var exercise = await _context.Exercises.FindAsync(id);
//            if (exercise == null)
//            {
//                return NotFound();
//            }
//            return View(exercise);
//        }

//        // POST: Exercises/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(string id, [Bind("ExerciseId,Name,Instruction")] Exercise exercise)
//        {
//            if (id != exercise.ExerciseId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(exercise);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ExerciseExists(exercise.ExerciseId))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(exercise);
//        }

//        // GET: Exercises/Delete/5
//        public async Task<IActionResult> Delete(string id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var exercise = await _context.Exercises
//                .FirstOrDefaultAsync(m => m.ExerciseId == id);
//            if (exercise == null)
//            {
//                return NotFound();
//            }

//            return View(exercise);
//        }

//        // POST: Exercises/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(string id)
//        {
//            var exercise = await _context.Exercises.FindAsync(id);
//            _context.Exercises.Remove(exercise);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ExerciseExists(string id)
//        {
//            return _context.Exercises.Any(e => e.ExerciseId == id);
//        }

//        public async Task<IActionResult> Index()
//        {
//            var exercises = await _context.Exercises.ToListAsync();
//            return View(exercises);
//        }
//    }
//}
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using GYMDBMS.Models;

//namespace GYMDBMS.Controllers
//{
//    public class ExercisesController : Controller
//    {
//        private readonly GYMContext _context;

//        public ExercisesController(GYMContext context)
//        {
//            _context = context;
//        }

//        // GET: Exercises
//        public async Task<IActionResult> Index()
//        {
//            var exercises = await _context.Exercises.ToListAsync();
//            return View(exercises);
//        }

//        // GET: Exercises/Details/5
//        public async Task<IActionResult> Details(string id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var exercise = await _context.Exercises
//                .FirstOrDefaultAsync(m => m.ExerciseId == id);
//            if (exercise == null)
//            {
//                return NotFound();
//            }

//            return View(exercise);
//        }

//        // GET: Exercises/Edit/5
//        public async Task<IActionResult> Edit(string id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var exercise = await _context.Exercises.FindAsync(id);
//            if (exercise == null)
//            {
//                return NotFound();
//            }
//            return View(exercise);
//        }

//        // POST: Exercises/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(string id, [Bind("ExerciseId,Name,Instruction")] Exercise exercise)
//        {
//            if (id != exercise.ExerciseId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(exercise);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ExerciseExists(exercise.ExerciseId))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(exercise);
//        }

//        // GET: Exercises/Delete/5
//        public async Task<IActionResult> Delete(string id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var exercise = await _context.Exercises
//                .FirstOrDefaultAsync(m => m.ExerciseId == id);
//            if (exercise == null)
//            {
//                return NotFound();
//            }

//            return View(exercise);
//        }

//        // POST: Exercises/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(string id)
//        {
//            var exercise = await _context.Exercises.FindAsync(id);
//            _context.Exercises.Remove(exercise);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ExerciseExists(string id)
//        {
//            return _context.Exercises.Any(e => e.ExerciseId == id);
//        }
//    }
//}

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GYMDBMS.Models;

namespace GYMDBMS.Controllers
{
    public class ExercisesController : Controller
    {
        private readonly GYMContext _context;

        public ExercisesController(GYMContext context)
        {
            _context = context;
        }

        // GET: Exercises
        public async Task<IActionResult> Index()
        {
            var exercises = await _context.Exercises.ToListAsync();
            return View(exercises);
        }

        // GET: Exercises/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercise = await _context.Exercises.FirstOrDefaultAsync(m => m.ExerciseId == id);
            if (exercise == null)
            {
                return NotFound();
            }

            return View(exercise);
        }

        // GET: Exercises/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercise = await _context.Exercises.FindAsync(id);
            if (exercise == null)
            {
                return NotFound();
            }
            return View(exercise);
        }

        // POST: Exercises/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ExerciseId,Name,Instruction")] Exercise exercise)
        {
            if (id != exercise.ExerciseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exercise);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExerciseExists(exercise.ExerciseId))
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
            return View(exercise);
        }

        // GET: Exercises/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercise = await _context.Exercises.FirstOrDefaultAsync(m => m.ExerciseId == id);
            if (exercise == null)
            {
                return NotFound();
            }

            return View(exercise);
        }

        // POST: Exercises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var exercise = await _context.Exercises.FindAsync(id);
            _context.Exercises.Remove(exercise);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExerciseExists(string id)
        {
            return _context.Exercises.Any(e => e.ExerciseId == id);
        }
    }
}






