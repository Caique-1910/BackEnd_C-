


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
                );
            
        }
       
    }
}