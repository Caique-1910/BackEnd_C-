using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using SistemaAnimalMVC.Models;
using SistemaAnimalMVC.Data;





namespace SistemaAnimalMVC.Controllers
{
    public class AnimalController : Controller
    {
         private readonly AppDbContext _context;

        public AnimalController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaAnimal.ToListAsync();

            return View(lista);
        }

        [HttpGet] 
        public IActionResult Criar() => View();

        [HttpPost]
        public async Task<IActionResult> Criar(string nomeConstrutor)
        {
            Animal? novoAnimal = null;

            if (nomeConstrutor == "Leao")
            {
                novoAnimal= new Leao(nomeConstrutor);
            }
            else if (nomeConstrutor == "Elefante")
            {
                novoAnimal = new Elefante(nomeConstrutor);
            }
            else
            {
                return BadRequest("Animal Invalido.");
            }
            _context.TabelaAnimal.Add(novoAnimal);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        //Excluir

        public async Task<IActionResult> Deletar(int id)
        {
          
            var animal = await _context.TabelaAnimal.FindAsync(id);

            if (animal == null) return NotFound();

            _context.TabelaAnimal.Remove(animal);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}