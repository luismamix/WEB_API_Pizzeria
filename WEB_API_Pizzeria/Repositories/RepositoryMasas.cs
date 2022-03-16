using System;
using System.Collections.Generic;
using System.Linq;
using WEB_API_Pizzeria.Data;
using WEB_API_Pizzeria.Models;

namespace WEB_API_Pizzeria.Repositories
{
    public class RepositoryMasas
    {
        ComunContext contexto;

        public RepositoryMasas(ComunContext context)
        {
            this.contexto = context;
        }
        public List<Masa> GetMasas()
        {
            return contexto.Masas.ToList();
        }

        public Masa GetMasa(int id)
        {
            return contexto.Masas.SingleOrDefault(x => x.id_masa == id);
        }

      public void InsertarMasa(int id, String masa, double importe)
        {
            Masa Masa = new Masa();
            Masa.id_masa = id;
            Masa.masa = masa;
            Masa.importe = importe;
            this.contexto.Masas.Add(Masa);
            this.contexto.SaveChanges();
        }

        public void ModificarMasa(int id, String masa, double importe)
        {
            Masa Masa = this.GetMasa(id);
            Masa.id_masa = id;
            Masa.masa = masa;
            Masa.importe = importe;
            this.contexto.SaveChanges();
        }

        public void EliminarMasa(int id)
        {
            Masa Masa = this.GetMasa(id);
            this.contexto.Masas.Remove(Masa);
            this.contexto.SaveChanges();
        }

    }
}