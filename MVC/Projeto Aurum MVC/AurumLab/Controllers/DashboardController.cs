


using AurumLab.Data;
using AurumLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace AurumLab.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetInt32("UsuarioId") == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var usuarioId = HttpContext.Session.GetInt32("UsuarioId");

            var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.IdUsuario == usuarioId);

            var dispositivosPorTipo = _context.Dispositivos.Join(
                    _context.TipoDispositivos,
                    dispositvo => dispositvo.IdTipoDispositivo,
                    tipoDispositivo => tipoDispositivo.IdTipoDispositivo,
                    (dispositivo, tipoDispositivo) => new { dispositivo, tipoDispositivo.Nome }
                ).GroupBy(item => item.Nome).Select(grupo => new ItemAgrupado
                {
                    Nome = grupo.Key,
                    Quantidade = grupo.Count()
                }).ToList();
            
            var locais = _context.LocalDispositivos.OrderBy(local => local.Nome).ToList();

            DashboardViewModel viewModel = new DashboardViewModel
            {
              NomeUsuario = usuario?.NomeUsuario ?? "Usuário",
              FotoUsuario = "/assets/img/img-perfil.png",

              TotalDispositivos = _context.Dispositivos.Count(),
              TotalAtivos = _context.Dispositivos.Count(dispositivos => dispositivos.SituacaoOperacional == "Operando"),
              TotalEmManutencao = _context.Dispositivos.Count(dispositivos => dispositivos.SituacaoOperacional == "Em Manutenção"),
              TotalInoperantes = _context.Dispositivos.Count(dispositivos => dispositivos.SituacaoOperacional == "Inoperante"),

              DispotivosPorTipo = dispositivosPorTipo,
              Locais = locais              
            };

            return View(viewModel);
        }
       
    }
}