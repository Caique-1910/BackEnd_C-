using AurumLab.Data;
using AurumLab.Models;
using AurumLab.Services;
using Microsoft.AspNetCore.Mvc;

namespace AurumLab.Controllers
{
    public class CadastroController : Controller
    {
        private readonly AppDbContext _context;
        public CadastroController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(string nome, string email, string senha, string confirmar )
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(confirmar))
            {
                ViewBag.Erro = "Preencha todos os campos.";
                return View("Index");
            }

            if (senha != confirmar)
            {
                ViewBag.Erro = "As senhas não conferem.";
                return View("Index");
            }

            if (_context.Usuarios.Any(usuario => usuario.Email == email)) //Any verifica se o email ja existe no banco, e semelhante com o FirstOrDefault, a diferença é que o FirstOrDefault retorna o objeto completo, e o Any retorna se existe ou não.
            {
                ViewBag.Erro = "Email já está cadastrado.";
                return View("Index");
            }

            byte[] hash = HashService.GerarHashBytes(senha);
            
            Usuario usuario = new Usuario
            {
                NomeCompleto = nome,
                Email = email,
                Senha = hash,
                Foto = null,
                RegraId = 1 //aluno por padrão
            };

            _context.Usuarios.Add(usuario); // Add = insert
            _context.SaveChanges();



            return RedirectToAction("Index", "Login");
        }
    }

}