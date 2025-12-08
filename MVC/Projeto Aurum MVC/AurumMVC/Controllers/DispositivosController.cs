using AurumLab.Data;
using AurumLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AurumLab.Controllers
{

    public class DispositivosController : Controller
    {
        private readonly AppDbContext _context;

        public DispositivosController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string? busca = null, int? tipoId = null, int? localId = null)
        {
            int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");

            if (usuarioId == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var usuario = _context.Usuarios.FirstOrDefault(u => u.IdUsuario == usuarioId);

            if (usuario.RegraId != 2)
            {
                TempData["Erro"] = "Acesso permitido apenas para professores.";
                return RedirectToAction("Index", "Home");
            }

            var selectBusca = _context.Dispositivos.Include(dispositivo => dispositivo.IdTipoDispositivoNavigation)
            .Include(dispositivo => dispositivo.IdLocalNavigation).AsQueryable();

            if (!string.IsNullOrWhiteSpace(busca))
            {
                selectBusca = selectBusca.Where(dispositivo => dispositivo.Nome.Contains(busca));
            }

            if (tipoId.HasValue)
            {
                selectBusca = selectBusca.Where(dispositivo => dispositivo.IdTipoDispositivo == tipoId.Value);
            }

            if (localId.HasValue)
            {
                selectBusca = selectBusca.Where(dispositivo => dispositivo.IdLocal == localId.Value);
            }

            DispositivosViewModel viewModel = new DispositivosViewModel
            {
                NomeUsuario = usuario.NomeUsuario ?? "Usuário",
                FotoUsuario = usuario.Foto != null ? $"data:image/*;base64,{Convert.ToBase64String(usuario.Foto)}" : "/assets/images/img-perfil.png",
                Dispositivos = selectBusca.ToList(),
                Tipos = _context.TipoDispositivos.ToList(),
                Locais = _context.LocalDispositivos.ToList(),
                Busca = busca,
                TipoIdSelecionado = tipoId,
                LocalIdSelecionado = localId
            };

            return View(viewModel);

        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");

            if (usuarioId == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var dispositivo = _context.Dispositivos.FirstOrDefault(d => d.IdDispositivo == id);

            if (dispositivo == null)
            {
                return NotFound();
            }

            EditarDispositivoViewModel viewModel = new EditarDispositivoViewModel
            {
                IdDispositivo = dispositivo.IdDispositivo,
                Nome = dispositivo.Nome,
                IdTipoDispositivo = dispositivo.IdTipoDispositivo,
                IdLocal = dispositivo.IdLocal,
                DataUltimaManutencao = dispositivo.DataUltimaManutencao,

                Tipos = _context.TipoDispositivos.ToList(),
                Locais = _context.LocalDispositivos.ToList()
            };

            return View("Editar", viewModel);
        }

        [HttpPost]
        public IActionResult Editar(EditarDispositivoViewModel vm)
        {
            int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");

            if (usuarioId == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var dispositivo = _context.Dispositivos.FirstOrDefault(d => d.IdDispositivo == vm.IdDispositivo);

            if (dispositivo == null)
            {
                return NotFound();
            }

            dispositivo.Nome = vm.Nome;
            dispositivo.IdTipoDispositivo = vm.IdTipoDispositivo;
            dispositivo.IdLocal = vm.IdLocal;
            dispositivo.DataUltimaManutencao = vm.DataUltimaManutencao;

            _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var dispositivo = _context.Dispositivos.FirstOrDefault(d => d.IdDispositivo == id);

            if (dispositivo == null)
            {
                return NotFound();
            }

            _context.Dispositivos.Remove(dispositivo);
            _context.SaveChangesAsync();
            TempData["Sucesso"] = "Dispositivo excluído com sucesso.";
            return RedirectToAction("Index");
        }


    }
}