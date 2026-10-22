using Microsoft.AspNetCore.Mvc;
using ClinicaVida.Web.Models;

namespace ClinicaVida.Web.Controllers;

public class EspecialidadesController : Controller
{
   public IActionResult Index()
{
    ViewData["Titulo"] = "Especialidades da Clínica Vida+";

    var especialidades = ClinicaEmMemoria.Especialidades;

    ViewBag.QuantidadeMedicos = ClinicaEmMemoria.Medicos
        .GroupBy(m => m.EspecialidadeId)
        .ToDictionary(g => g.Key, g => g.Count());

    return View(especialidades);
}

    public IActionResult Details(int id, string nome)
    {
        if (id < 1 || id > 3)
        {
            return NotFound();
        }

        ViewData["Id"] = id;
        ViewData["Nome"] = nome;

        return View();
    }

}