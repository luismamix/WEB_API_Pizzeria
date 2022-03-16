using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEB_API_Pizzeria.Models;
using WEB_API_Pizzeria.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_API_Pizzeria.Controllers
{
    [Route("[controller]")]
    public class ContenidosController : Controller
    {
        RepositoryContenido repo;
        public ContenidosController(RepositoryContenido repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Contenido>> GetContenidos()
        {
            return this.repo.GetContenidos();
        }

        [HttpGet("{id}")]
        public ActionResult<Contenido> GetContenido(String id)
        {
            return this.repo.GetContenido(id);
        }
        //api/Departamentos --> POST
        [HttpPost]
        public void InsertarContenido(Contenido contenido)
        {
            this.repo.InsertarContenido(contenido.id_contenido,contenido.fecha,contenido.hora,contenido.nombre,contenido.tamanio,contenido.masa,contenido.tipo,contenido.anadir,contenido.pedido,contenido.ver);
        }

        [HttpPut]
        public void ModificarContenido(Contenido contenido)
        {
            this.repo.ModificarContenido(contenido.id_contenido, contenido.fecha, contenido.hora, contenido.nombre, contenido.tamanio, contenido.masa, contenido.tipo, contenido.anadir, contenido.pedido, contenido.ver);
        }

        //api/Departamentos/{id}
        [HttpDelete("{id}")]
        public void EliminarContenido(string id)
        {
            this.repo.EliminarContenido(id);
        }
    }
}
