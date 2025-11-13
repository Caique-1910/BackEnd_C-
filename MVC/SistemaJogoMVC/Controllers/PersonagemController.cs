using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using SistemaJogoMVC.Data;
using Microsoft.EntityFrameworkCore;
using SistemaJogoMVC.Models;


namespace SistemaVeiculoMVC.Controllers
{
    public class PersonagemController : Controller
    {
        private readonly AppDbContext _context;

        public PersonagemController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaPersonagem.ToListAsync();

            return View(lista);
        }

        [HttpGet]
        public IActionResult Criar() => View();

        [HttpPost]
        public async Task<IActionResult> Criar(string nomeConstrutor, int nivelConstrutor, string tipoConstrutor)
        {
            Personagem? novoPersonagem = null;

            if (tipoConstrutor == "Guerreiro")
            {
                novoPersonagem = new Guerreiro(nomeConstrutor, nivelConstrutor, tipoConstrutor);
            }
            else if (tipoConstrutor == "Mago")
            {
                novoPersonagem = new Mago(nomeConstrutor, nivelConstrutor, tipoConstrutor);
            }
            else
            {
                return BadRequest("Personagem Invalido.");
            }
            _context.TabelaPersonagem.Add(novoPersonagem);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        //Excluir

        public async Task<IActionResult> Deletar(int id)
        {

            var personagem = await _context.TabelaPersonagem.FindAsync(id);

            if (personagem == null) return NotFound();

            _context.TabelaPersonagem.Remove(personagem);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }

}
