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
    public class TamaniosController : Controller
    {
        RepositoryTamanios repo;
        public TamaniosController(RepositoryTamanios repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Tamanio>> GetTamanios()
        {
            return this.repo.GetTamanios();
        }

        [HttpGet("{id}")]
        public ActionResult<Tamanio> GetTamanio(int id)
        {
            return this.repo.GetTamanio(id);
        }
        //api/Departamentos --> POST
        [HttpPost]
        public void InsertarTamanio(Tamanio Tamanio)
        {
            this.repo.InsertarTamanio(Tamanio.id_tamanio, Tamanio.tamanio, Tamanio.importe);
        }

        [HttpPut]
        public void ModificarTamanio(Tamanio Tamanio)
        {
            this.repo.ModificarTamanio(Tamanio.id_tamanio, Tamanio.tamanio, Tamanio.importe);
        }

        //api/Departamentos/{id}
        [HttpDelete("{id}")]
        public void EliminarTamanio(int id)
        {
            this.repo.EliminarTamanio(id);
        }
    }
}
