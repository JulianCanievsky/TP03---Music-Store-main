using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03_MusicStore.Models;

namespace TP03_MusicStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Catalogo.InicializarCatalogo();
        ViewBag.Discos = Catalogo.Discos;
        return View();
    }

    public IActionResult Detalle(int Id)
    {
        if (Catalogo.Discos.ContainsKey(Id))
        {
            Console.WriteLine(Id);
            ViewBag.Disco = Catalogo.Discos[Id];
            return View();
        }
        else
        {
            Console.WriteLine("ID incorrecto " + Id);
            return NotFound();
        }
    }
}
