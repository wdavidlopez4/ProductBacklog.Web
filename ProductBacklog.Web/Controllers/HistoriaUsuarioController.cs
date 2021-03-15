using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductBacklog.Web.Data;
using ProductBacklog.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductBacklog.Web.Controllers
{
    public class HistoriaUsuarioController : Controller
    {
        private readonly ProductBackLogContext productBackLogContext;

        public HistoriaUsuarioController(ProductBackLogContext productBackLogContext)
        {
            this.productBackLogContext = productBackLogContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //obtenermos el listado de historias 
            List<HistoriaUsuario> historias = await this.productBackLogContext.HistoriasUsuarios.ToListAsync();

            //retornar el listado de h
            return View(historias);
        }

        [HttpGet]
        public IActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Guardar([Bind()]HistoriaUsuario historiaUsuario)
        {
            //adicionar en la db el hu
            await productBackLogContext.HistoriasUsuarios.AddAsync(historiaUsuario);
            await productBackLogContext.SaveChangesAsync();

            //redirecionamos el index
            return RedirectToAction("Index");
        }
    }
}
