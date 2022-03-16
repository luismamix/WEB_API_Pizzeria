using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_API_Pizzeria.Models
{
        [Table("TAMANIO_ES")]
        public class Tamanio
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Column("id_tamanio")]
            public int id_tamanio { get; set; }
            [Column("tamanio")]
            public String tamanio { get; set; }
            [Column("importe")]
            public double importe { get; set; }
        }
}
