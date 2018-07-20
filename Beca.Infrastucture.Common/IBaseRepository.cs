using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Beca.Infrastructure.Common
{
    public interface IBaseRepository<TEntity, Tkey>
        where TEntity : class
    {
        IEnumerable<TEntity> Get(
           Expression<Func<TEntity, bool>> filter = null,
           string[] includePaths = null,
           int? page = 0,
           int? pageSize = null,
           params SortExpression<TEntity>[] sortExpressions);
    }
}
