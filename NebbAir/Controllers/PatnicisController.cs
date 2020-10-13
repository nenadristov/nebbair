using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NebbAir.Data;
using NebbAir.Models;

namespace NebbAir.Controllers
{
    public class PatnicisController : Controller
    {
        private readonly NebbAirContext _context;

        public PatnicisController(NebbAirContext context)
        {
            _context = context;
        }

        // GET: Patnicis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Patnici.ToListAsync());
        }

        // GET: Patnicis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patnici = await _context.Patnici
                .FirstOrDefaultAsync(m => m.PatnikID == id);
            if (patnici == null)
            {
                return NotFound();
            }

            return View(patnici);
        }

        // GET: Patnicis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Patnicis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PatnikID,Ime,Prezime,DataNaRagjanje,PassporNo,FlightNo,Origin,Destination,Departure,Return,CarryOn,Trolley,CheckIn")] Patnici patnici)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patnici);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patnici);
        }

        // GET: Patnicis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patnici = await _context.Patnici.FindAsync(id);
            if (patnici == null)
            {
                return NotFound();
            }
            return View(patnici);
        }

        // POST: Patnicis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PatnikID,Ime,Prezime,DataNaRagjanje,PassporNo,FlightNo,Origin,Destination,Departure,Return,CarryOn,Trolley,CheckIn")] Patnici patnici)
        {
            if (id != patnici.PatnikID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patnici);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatniciExists(patnici.PatnikID))
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
            return View(patnici);
        }

        // GET: Patnicis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patnici = await _context.Patnici
                .FirstOrDefaultAsync(m => m.PatnikID == id);
            if (patnici == null)
            {
                return NotFound();
            }

            return View(patnici);
        }

        // POST: Patnicis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var patnici = await _context.Patnici.FindAsync(id);
            _context.Patnici.Remove(patnici);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatniciExists(int id)
        {
            return _context.Patnici.Any(e => e.PatnikID == id);
        }

        [Route("GetPasos/{Pasos}")]
        [HttpGet]
        public ActionResult GetPasos(string Pasos)
        {
            return View("hello");
        }

        [Route("GetFlight/{Flight}")]
        public async Task<IActionResult> GetFLight(string Flight)
        {
            if (Flight == null)
            {
                return NotFound();
            }

            var patnici = await _context.Patnici
            .FirstOrDefaultAsync(m => m.FlightNo == Flight);
            if (patnici == null)
            {
                return NotFound();
            }

            return View(patnici);
        }
    }

        
}
