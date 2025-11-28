using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AurumLab.Data;
using AurumLab.Models;
using Microsoft.AspNetCore.Mvc;
using AurumLab.Services;

namespace AurumLab.Controllers
{
    public class PerfilController : Controller
    {
        private readonly AppDbContext _context;

        public PerfilController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");
            if (usuarioId == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.IdUsuario == usuarioId);

            var viewModel = new PerfilViewModel
            {
                IdUsuario = usuario.IdUsuario,
                NomeCompleto = usuario.NomeCompleto,
                NomeUsuario = usuario?.NomeUsuario?? "Usuario",
                Email = usuario.Email,
                RegraId = usuario.RegraId,
                //* Listando as regras dentro da tabela RegraPerfil para mostrar dentro do select
                Regras = _context.RegraPerfils.ToList(),
                FotoBase64 = usuario.Foto != null ? Convert.ToBase64String(usuario.Foto) : null
            };

            return View(viewModel);
        }

        [HttpPost]
        //* Alterar as informacoes do perfil
        public IActionResult Index(PerfilViewModel model)
        {
            var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.IdUsuario == model.IdUsuario);

            if (usuario == null)
            {
                return RedirectToAction("Index", "Login");
            }

            if (!string.IsNullOrWhiteSpace(model.NovaSenha))
            {
                if (model.ConfirmarSenha != model.NovaSenha)
                {
                    ViewBag.Erro = "As senhas não são iguais";

                    //* quando o POST( a atualizacao que estamos fazendo)da erro e volta para a View, a lista de regras não vem preenchido. pq ela é um select com a lista de regras que estamos puxando para o banco.
                    model.Regras = _context.RegraPerfils.ToList();
                    return View(model);
                }

                usuario.Senha = HashService.GerarHashBytes(model.NovaSenha);
            }

            //* Atualizar o restante dos dados
            usuario.NomeCompleto = model.NomeCompleto;
            usuario.NomeUsuario = model.NomeUsuario;
            usuario.Email = model.Email;
            usuario.RegraId = model.RegraId;

            _context.SaveChangesAsync();

            //! A DIFERENCA entre ViewBag e TempData, eh que a ViewBag morre no redirect, TempData sobrevive ao redirect pelo menos uma vez
            TempData["Sucesso"] = "Perfil atualizado com sucesso";
            return RedirectToAction("Index");
        }

        //* POST - Atualizar a foto de perfil
        [HttpPost]
        public IActionResult AtualizarFoto(int idUsuario, IFormFile foto)
        {
            //* Iformfile representa um arquivo enciado pelo formato HTML

            if (foto == null || foto.Length == 0)
            {
                return RedirectToAction("Index");
            }

            var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.IdUsuario == idUsuario);

            if (usuario == null)
            {
                RedirectToAction("Index", "Login");
            }

            //* MemoryStream eh um memoria temporaria
            using(var ms = new MemoryStream())
            {
                foto.CopyTo(ms);
                usuario.Foto = ms.ToArray(); //* Salva como VARBYNARY(MAX) - Até 2 dias dentro do banco
            }
            _context.SaveChanges();

            TempData["Sucesso"] = "Foto atualizada com sucesso!";
            return RedirectToAction("Index");
        }
    }
}