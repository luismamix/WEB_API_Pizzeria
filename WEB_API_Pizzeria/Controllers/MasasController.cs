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
    public class MasasController : Controller
    {
        RepositoryMasas repo;
        public MasasController(RepositoryMasas repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Masa>> GetMasas()
        {
            return this.repo.GetMasas();
        }

        [HttpGet("{id}")]
        public ActionResult<Masa> GetMasa(int id)
        {
            return this.repo.GetMasa(id);
        }
        //api/Departamentos --> POST
        [HttpPost]
        public void InsertarMasa(Masa Masa)
        {
            //this.repo.InsertarMasa(Masa.id_masa,Masa.masa,Masa.importe);
        }

        [HttpPut]
        public void ModificarMasa(Masa Masa)
        {
            //this.repo.ModificarMasa(Masa.id_masa, Masa.masa, Masa.importe);
        }

        //api/Departamentos/{id}
        [HttpDelete("{id}")]
        public void EliminarMasa(int id)
        {
            //this.repo.EliminarMasa(id);
        }
    }
}
