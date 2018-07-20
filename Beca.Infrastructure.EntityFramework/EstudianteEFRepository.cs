using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beca.Infrastructure.Common;
using Beca.Domain.Repository;
using Beca.Domain.Entity;
using Beca.Domain.Entity.Dtos;
using System.Linq.Expressions;

namespace Beca.Infrastructure.EntityFramework
{
    public class EstudianteEFRepository : BaseEFRepository<Pregrado, string>, IBecaEstudianteRepository
    {
        public EstudianteEFRepository(BecaContext context): base(context)
        {

        }

        public PageOfPregradoDto GetEstudiante(Expression<Func<Pregrado, bool>> filter, string[] includePaths, int page, int pageSize, params SortExpression<Pregrado>[] sortExpressions)
        {
            IEnumerable<Pregrado> estudiantes = this.Get(
                filter,
                includePaths,
                page,
                pageSize,
                sortExpressions);

            return new PageOfPregradoDto() { Alumnos = estudiantes, TotalCount = pageSize };
        }

        public BecaContext BecaContext
        {
            get { return Context as BecaContext; }
        }
    }
}
