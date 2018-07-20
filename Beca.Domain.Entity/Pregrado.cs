using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beca.Domain.Entity
{
    public class Pregrado
    {
        [Key]
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public Grado grado { get; set; }
    }
}
