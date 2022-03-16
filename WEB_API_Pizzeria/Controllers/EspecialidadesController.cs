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
    public class EspecialidadesController : Controller
    {
        RepositoryEspecialidades repo;
        public EspecialidadesController(RepositoryEspecialidades repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Especialidad>> GetEspecialidades()
        {
            return this.repo.GetEspecialidades();
        }

        [HttpGet("{id}")]
        public ActionResult<Especialidad> GetEspecialidad(int id)
        {
            return this.repo.GetEspecialidad(id);
        }
        //api/Departamentos --> POST
        [HttpPost]
        public void InsertarEspecialidad(Especialidad Especialidad)
        {
            this.repo.InsertarEspecialidad(Especialidad.id_tipo, Especialidad.tipo, Especialidad.importe);
        }

        [HttpPut]
        public void ModificarEspecialidad(Especialidad Especialidad)
        {
            this.repo.ModificarEspecialidad(Especialidad.id_tipo, Especialidad.tipo, Especialidad.importe);
        }

        //api/Departamentos/{id}
        [HttpDelete("{id}")]
        public void EliminarEspecialidad(int id)
        {
            this.repo.EliminarEspecialidad(id);
        }
    }
}
