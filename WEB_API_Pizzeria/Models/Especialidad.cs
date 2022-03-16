using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_API_Pizzeria.Models
{   [Table ("ESPECIALIDAD_ES")]
    public class Especialidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("id_tipo")]
        public int id_tipo { get; set; }
        [Column("tipo")]
        public String tipo { get; set; }
        [Column("importe")]
        public double importe { get; set; }
    }
}
