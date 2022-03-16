using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_API_Pizzeria.Models
{
        [Table("MASA_ES")]
        public class Masa
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Column("id_masa")]
            public int id_masa { get; set; }
            [Column("masa")]
            public String masa { get; set; }
            [Column("importe")]
            public double importe { get; set; }
        }
}
