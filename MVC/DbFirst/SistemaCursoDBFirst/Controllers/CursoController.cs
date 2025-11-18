using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaCursoDBFirst.Data;
using SistemaCursoDBFirst.Models;

namespace SistemaCursoDBFirst.Controllers
{
    public class CursoController : Controller
    {
        private readonly AppDbContext _context;

        public CursoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Curso
        public async Task<IActionResult> Index()
        {
            return View(await _context.TabelaCursos.ToListAsync());
        }

        // GET: Curso/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabelaCurso = await _context.TabelaCursos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabelaCurso == null)
            {
                return NotFound();
            }

            return View(tabelaCurso);
        }

        // GET: Curso/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Curso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Horas,Preco,Tipo")] TabelaCurso tabelaCurso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabelaCurso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tabelaCurso);
        }

        // GET: Curso/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabelaCurso = await _context.TabelaCursos.FindAsync(id);
            if (tabelaCurso == null)
            {
                return NotFound();
            }
            return View(tabelaCurso);
        }

        // POST: Curso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Horas,Preco,Tipo")] TabelaCurso tabelaCurso)
        {
            if (id != tabelaCurso.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabelaCurso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabelaCursoExists(tabelaCurso.Id))
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
            return View(tabelaCurso);
        }

        // GET: Curso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabelaCurso = await _context.TabelaCursos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabelaCurso == null)
            {
                return NotFound();
            }

            return View(tabelaCurso);
        }

        // POST: Curso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tabelaCurso = await _context.TabelaCursos.FindAsync(id);
            if (tabelaCurso != null)
            {
                _context.TabelaCursos.Remove(tabelaCurso);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabelaCursoExists(int id)
        {
            return _context.TabelaCursos.Any(e => e.Id == id);
        }
    }
}
