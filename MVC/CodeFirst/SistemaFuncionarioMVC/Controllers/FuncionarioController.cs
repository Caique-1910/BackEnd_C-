using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using SistemaFuncionarioMVC.Data;
using Microsoft.EntityFrameworkCore;
using SistemaFuncionarioMVC.Models;

namespace SistemaFuncionarioMVC.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly AppDbContext _context;

        public FuncionarioController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        //Listar
        //async / await -> executa a funcao de listar dentro do banco mas permite que o sistema rode enquanto isso acontece
        public async Task<IActionResult> Index()
        {
            // To list - lista as informacoes dentro da tabela funcionario
            var lista = await _context.TabelaFuncionario.ToListAsync();

            // retorna view com a lista de funcionarios no index
            return View(lista);
        }

        //Formulario de criacao - retonar vazio
        [HttpGet] // GET - Listar ("Select")
        public IActionResult Criar() => View();

        // Cadastrar as informacoes do formulario no DB
        [HttpPost]
        public async Task<IActionResult> Criar(string NomeConstrutor, double SalarioBaseConstrutor, string CargoConstrutor)
        {
            Funcionario? novoFuncionario = null;

            if (CargoConstrutor == "Gerente")
            {
                novoFuncionario = new Gerente(NomeConstrutor, SalarioBaseConstrutor);
            }
            else if (CargoConstrutor == "Vendedor")
            {
                novoFuncionario = new Vendedor(NomeConstrutor, SalarioBaseConstrutor);
            }
            else
            {
                return BadRequest("Cargo Invalido.");
            }
            _context.TabelaFuncionario.Add(novoFuncionario);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        //Excluir

        public async Task<IActionResult> Deletar(int id)
        {
            // Variavel que vai armazenar o registro de funcionario encontrado pelo id
            // find(id) -> busca o registro pelo id
            var funcionario = await _context.TabelaFuncionario.FindAsync(id);

            if (funcionario == null) return NotFound();

            //Remove() -> remove o registro do banco
            _context.TabelaFuncionario.Remove(funcionario);

            //Salva as alteracoes
            await _context.SaveChangesAsync();
            
            //Retorna para action: index -> mostra a lista atualizada de funcionarios
            return RedirectToAction("Index");
        }

    }
}