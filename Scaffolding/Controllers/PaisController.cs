using Microsoft.AspNetCore.Mvc;
using Scaffolding.Models;
using Scaffolding.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffolding.Controllers
{
    public class PaisController : Controller
    {
        private RepositoryPaises repo;

        public PaisController(RepositoryPaises repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Pais> paises = this.repo.GetPaises();
            return View(paises);
        }

        public IActionResult EliminarPais(int idpais)
        {
            this.repo.EliminarPais(idpais);
            return RedirectToAction("Index");
        }

        public IActionResult InsertarPais()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertarPais(int idpais, String nombre, String capital, String idioma)
        {
            this.repo.InsertarPais(idpais, nombre, capital, idioma);
            return RedirectToAction("Index");
        }

        public IActionResult ModificarPais(int idpais)
        {
            Pais pais = this.repo.GetPais(idpais);
            return View(pais);
        }

        [HttpPost]

        public IActionResult ModificarPais(Pais pais)
        {
            this.repo.ModificarPais(pais.IdPais, pais.Nombre, pais.Capital, pais.Idioma);
            return RedirectToAction("Index");
        }

    }
}
