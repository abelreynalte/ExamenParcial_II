using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beca.Domain.Entity.Dtos
{
    public class PageOfPregradoDto
    {
        public IEnumerable<Pregrado> Alumnos { get; set; }
        public int TotalCount { get; set; }
    }
}
