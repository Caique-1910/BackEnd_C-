using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sistema_Login.Models;

namespace Sistema_Login.Controllers;

public class HomeController : Controller
{
   public IActionResult Index()
    {
        if (HttpContext.Session.GetString("UsuarioNome") == null)
        {
            return RedirectToAction("Index", "Login");
        }

        // mochila zika que carrega as informacoes para view "ViewBag"
        ViewBag.Usuario = HttpContext.Session.GetString("UsuarioNome");
        return View();
    }
}
