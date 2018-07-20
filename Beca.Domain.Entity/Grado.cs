using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beca.Domain.Entity
{
    public class Grado
    {
        [Key]
        public int id { get; set; }
        public string Nombre { get; set; }
        public decimal MontoBeca { get; set; }
        
    }
}
