using System;
using WEB_API_Pizzeria.Data;
using System.Linq;
using WEB_API_Pizzeria.Models;
using System.Collections.Generic;

namespace WEB_API_Pizzeria.Repositories
{
    public class RepositoryEspecialidades
    {
        ComunContext contexto;

        public RepositoryEspecialidades(ComunContext context)
        {
            this.contexto = context;
        }

        public List<Especialidad> GetEspecialidades()
        {
            return contexto.Especialidades.ToList();
        }

        public Especialidad GetEspecialidad(int id)
        {
            return contexto.Especialidades.SingleOrDefault(x => x.id_tipo == id);
        }

        public void InsertarEspecialidad(int id, String tipo, double importe)
        {
            Especialidad especialidad = new Especialidad();
            especialidad.id_tipo = id;
            especialidad.tipo = tipo;
            especialidad.importe = importe;
            this.contexto.Especialidades.Add(especialidad);
            this.contexto.SaveChanges();
        }

        public void ModificarEspecialidad(int id, String tipo, double importe)
        {
            Especialidad especialidad = this.GetEspecialidad(id);
            especialidad.id_tipo = id;
            especialidad.tipo = tipo;
            especialidad.importe = importe;
            this.contexto.SaveChanges();
        }

        public void EliminarEspecialidad(int id)
        {
            Especialidad especialidad = this.GetEspecialidad(id);
            this.contexto.Especialidades.Remove(especialidad);
            this.contexto.SaveChanges();
        }
    }
}
