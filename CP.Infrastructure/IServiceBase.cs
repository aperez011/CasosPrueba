using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CP.Core
{
    public interface IServiceBase<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> condition);
        TEntity GetByGID(Guid gid);
        Task Insert(TEntity entity);
        Task Delete(Guid gid);
    }
}
