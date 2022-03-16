using System;
using System.Collections.Generic;
using System.Linq;
using WEB_API_Pizzeria.Data;
using WEB_API_Pizzeria.Models;

namespace WEB_API_Pizzeria.Repositories
{
    public class RepositoryTamanios
    {
        ComunContext contexto;

        public RepositoryTamanios(ComunContext context)
        {
            this.contexto = context;
        }

        public List<Tamanio> GetTamanios()
        {
            return contexto.Tamanios.ToList();
        }

        public Tamanio GetTamanio(int id)
        {
            return contexto.Tamanios.SingleOrDefault(x => x.id_tamanio == id);
        }

        public void InsertarTamanio(int id, String tamanio, double importe)
        {
            Tamanio Tamanio = new Tamanio();
            Tamanio.id_tamanio = id;
            Tamanio.tamanio = tamanio;
            Tamanio.importe = importe;
            this.contexto.Tamanios.Add(Tamanio);
            this.contexto.SaveChanges();
        }

        public void ModificarTamanio(int id, String tamanio, double importe)
        {
            Tamanio Tamanio = this.GetTamanio(id);
            Tamanio.id_tamanio = id;
            Tamanio.tamanio = tamanio;
            Tamanio.importe = importe;
            this.contexto.SaveChanges();
        }

        public void EliminarTamanio(int id)
        {
            Tamanio Tamanio = this.GetTamanio(id);
            this.contexto.Tamanios.Remove(Tamanio);
            this.contexto.SaveChanges();
        }
    }
}
