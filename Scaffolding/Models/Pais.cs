using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffolding.Models
{
    [Table("PAIS")]
    public class Pais
    {
        [Key]
        [Column("idpais")]
        public int IdPais { get; set; }
        [Column("nombre")]
        public String Nombre { get; set; }
        [Column("capital")]
        public String Capital { get; set; }
        [Column("idioma")]
        public String Idioma { get; set; }
    }
}
