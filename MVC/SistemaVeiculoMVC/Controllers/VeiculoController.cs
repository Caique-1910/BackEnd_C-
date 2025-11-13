using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using SistemaVeiculoMVC.Data;
using Microsoft.EntityFrameworkCore;
using SistemaVeiculoMVC.Models;


namespace SistemaVeiculoMVC.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly AppDbContext _context;

        public VeiculoController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaVeiculo.ToListAsync();

            return View(lista);
        }

        [HttpGet] 
        public IActionResult Criar() => View();

        [HttpPost]
        public async Task<IActionResult> Criar(string modeloConstrutor, string anoConstrutor, string tipoConstrutor)
        {
            Veiculo? novoVeiculo = null;

            if (tipoConstrutor == "Carro")
            {
                novoVeiculo = new Carro(modeloConstrutor, anoConstrutor, tipoConstrutor);
            }
            else if (tipoConstrutor == "Moto")
            {
                novoVeiculo = new Moto(modeloConstrutor, anoConstrutor, tipoConstrutor);
            }
            else
            {
                return BadRequest("Veiculo Invalido.");
            }
            _context.TabelaVeiculo.Add(novoVeiculo);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        //Excluir

        public async Task<IActionResult> Deletar(int id)
        {
          
            var veiculo = await _context.TabelaVeiculo.FindAsync(id);

            if (veiculo == null) return NotFound();

            _context.TabelaVeiculo.Remove(veiculo);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }

}