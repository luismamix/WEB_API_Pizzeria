using System;
using WEB_API_Pizzeria.Data;
using WEB_API_Pizzeria.Models;
using System.Linq;
using System.Collections.Generic;

namespace WEB_API_Pizzeria.Repositories
{
    public class RepositoryContenido
    {
        ComunContext contexto;

        public RepositoryContenido(ComunContext context)
        {
            this.contexto = context;
        }

        public Contenido GetContenido(String id)
        {
            return contexto.Contenidos.SingleOrDefault(x => x.id_contenido == id);
        }

        public List<Contenido> GetContenidos()
        {
            return contexto.Contenidos.ToList();
        }

        public void InsertarContenido(String id, String fecha, String hora, String nombre, String tamanio, String masa, String tipo, String anadir, String pedido, String ver)
        {
            Contenido contenido = new Contenido();
            contenido.id_contenido = id;
            contenido.fecha = fecha;
            contenido.hora = hora;
            contenido.nombre = nombre;
            contenido.tamanio = tamanio;
            contenido.masa = masa;
            contenido.tipo = tipo;
            contenido.anadir = anadir;
            contenido.pedido = pedido;
            contenido.ver = ver;
            this.contexto.Contenidos.Add(contenido);
            this.contexto.SaveChanges();
        }

        public void ModificarContenido(String id, String fecha, String hora, String nombre, String tamanio, String masa, String tipo, String anadir, String pedido, String ver)
        {
            Contenido contenido = this.GetContenido(id);
            contenido.id_contenido = id;
            contenido.fecha = fecha;
            contenido.hora = hora;
            contenido.nombre = nombre;
            contenido.tamanio = tamanio;
            contenido.masa = masa;
            contenido.tipo = tipo;
            contenido.anadir = anadir;
            contenido.pedido = pedido;
            contenido.ver = ver;
            this.contexto.SaveChanges();
        }

        public void EliminarContenido(String id)
        {
            Contenido contenido = this.GetContenido(id);
            this.contexto.Contenidos.Remove(contenido);
            this.contexto.SaveChanges();
        }
    }
}
