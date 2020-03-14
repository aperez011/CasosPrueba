using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CP.Core
{
    public interface IServiceBase<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> condition);
        TEntity GetByGID(Guid guid);
        void Insert(TEntity entity);
        void Delete(TEntity entity);
    }
}
