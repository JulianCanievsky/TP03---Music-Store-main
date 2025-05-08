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
    Catalogo.InicializarCatalogo();
    if (Catalogo.Discos.ContainsKey(Id))
{
    ViewBag.Disco = Catalogo.Discos[Id];
    return View();
}
else{
    return NotFound();
}
}
}
