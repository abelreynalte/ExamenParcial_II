using Beca.Domain.Entity;
using Beca.Domain.Entity.Dtos;
using Beca.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Beca.Domain.Repository
{
    public interface IBecaEstudianteRepository: IBaseRepository<Pregrado, string>
    {
        PageOfPregradoDto GetEstudiante(Expression<Func<Pregrado, bool>> filter, string[] includePaths, int page, int pageSize, params SortExpression<Pregrado>[] sortExpressions);
    }
}
