//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using GYMDBMS.Models;

//namespace GYMDBMS.Controllers
//{
//    public class ClientsController : Controller
//    {
//        private readonly GYMContext _context;

//        public ClientsController(GYMContext context)
//        {
//            _context = context;
//        }

//        // GET: Clients
//        public async Task<IActionResult> Index()
//        {
//            var gYMContext = _context.Clients.Include(c => c.Trainer);
//            return View(await gYMContext.ToListAsync());
//        }

//        // GET: Clients/Details/5
//        public async Task<IActionResult> Details(string id)
//        {
//            if (id == null || _context.Clients == null)
//            {
//                return NotFound();
//            }

//            var client = await _context.Clients
//                .Include(c => c.Trainer)
//                .FirstOrDefaultAsync(m => m.ClientId == id);
//            if (client == null)
//            {
//                return NotFound();
//            }

//            return View(client);
//        }

//        // GET: Clients/Create
//        public IActionResult Create()
//        {
//            ViewData["TrainerId"] = new SelectList(_context.Trainers, "TrainerId", "TrainerId");
//            return View();
//        }

//        // POST: Clients/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("ClientId,Name,ContactNumer,FitnessGoal,TrainerId")] Client client)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(client);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["TrainerId"] = new SelectList(_context.Trainers, "TrainerId", "TrainerId", client.TrainerId);
//            return View(client);
//        }

//        // GET: Clients/Edit/5
//        public async Task<IActionResult> Edit(string id)
//        {
//            if (id == null || _context.Clients == null)
//            {
//                return NotFound();
//            }

//            var client = await _context.Clients.FindAsync(id);
//            if (client == null)
//            {
//                return NotFound();
//            }
//            ViewData["TrainerId"] = new SelectList(_context.Trainers, "TrainerId", "TrainerId", client.TrainerId);
//            return View(client);
//        }

//        // POST: Clients/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(string id, [Bind("ClientId,Name,ContactNumer,FitnessGoal,TrainerId")] Client client)
//        {
//            if (id != client.ClientId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(client);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ClientExists(client.ClientId))
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
//            ViewData["TrainerId"] = new SelectList(_context.Trainers, "TrainerId", "TrainerId", client.TrainerId);
//            return View(client);
//        }

//        // GET: Clients/Delete/5
//        public async Task<IActionResult> Delete(string id)
//        {
//            if (id == null || _context.Clients == null)
//            {
//                return NotFound();
//            }

//            var client = await _context.Clients
//                .Include(c => c.Trainer)
//                .FirstOrDefaultAsync(m => m.ClientId == id);
//            if (client == null)
//            {
//                return NotFound();
//            }

//            return View(client);
//        }

//        // POST: Clients/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(string id)
//        {
//            if (_context.Clients == null)
//            {
//                return Problem("Entity set 'GYMContext.Clients'  is null.");
//            }
//            var client = await _context.Clients.FindAsync(id);
//            if (client != null)
//            {
//                _context.Clients.Remove(client);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ClientExists(string id)
//        {
//          return (_context.Clients?.Any(e => e.ClientId == id)).GetValueOrDefault();
//        }
//    }
//}

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
    public class ClientsController : Controller
    {
        private readonly GYMContext _context;

        public ClientsController(GYMContext context)
        {
            _context = context;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            var gYMContext = _context.Clients.Include(c => c.Trainer);
            return View(await gYMContext.ToListAsync());
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Clients == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .Include(c => c.Trainer)
                .FirstOrDefaultAsync(m => m.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Clients/Create
        public IActionResult Create()
        {
            ViewData["TrainerId"] = new SelectList(_context.Trainers, "TrainerId", "TrainerId");
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientId,Name,ContactNumer,FitnessGoal,TrainerId")] Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TrainerId"] = new SelectList(_context.Trainers, "TrainerId", "TrainerId", client.TrainerId);
            return View(client);
        }

        // GET: Clients/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Clients == null)
            {
                return NotFound();
            }

            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            ViewData["TrainerId"] = new SelectList(_context.Trainers, "TrainerId", "TrainerId", client.TrainerId);
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ClientId,Name,ContactNumer,FitnessGoal,TrainerId")] Client client)
        {
            if (id != client.ClientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.ClientId))
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
            ViewData["TrainerId"] = new SelectList(_context.Trainers, "TrainerId", "TrainerId", client.TrainerId);
            return View(client);
        }

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Clients == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .Include(c => c.Trainer)
                .FirstOrDefaultAsync(m => m.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Clients == null)
            {
                return Problem("Entity set 'GYMContext.Clients'  is null.");
            }
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(string id)
        {
            return (_context.Clients?.Any(e => e.ClientId == id)).GetValueOrDefault();
        }
    }
}
