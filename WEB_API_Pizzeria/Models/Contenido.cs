using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_API_Pizzeria.Models
{
   
        [Table("CONTENIDO")]
        public class Contenido
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Column("id_contenido")]
            public String id_contenido { get; set; }
            [Column("fecha")]
            public String fecha { get; set; }
            [Column("hora")]
            public String hora { get; set; }
            [Column("nombre")]
            public String nombre { get; set; }
            [Column("tamanio")]
            public String tamanio { get; set; }
            [Column("masa")]
            public String masa { get; set; }
            [Column("tipo")]
            public String tipo { get; set; }
            [Column("anadir")]
            public String anadir { get; set; }
            [Column("pedido")]
            public String pedido { get; set; }
            [Column("ver")]
            public String ver{ get; set; }

    }
}
