using System;
using Microsoft.EntityFrameworkCore;
using WEB_API_Pizzeria.Models;

namespace WEB_API_Pizzeria.Data
{
    public class ComunContext :DbContext
    {

        public ComunContext(DbContextOptions options) : base(options){}

            
         public DbSet<Especialidad> Especialidades { get; set; }
         public DbSet<Masa> Masas { get; set; }
         public DbSet<Tamanio> Tamanios { get; set; }
         public DbSet<Contenido> Contenidos { get; set; }

    }

}
