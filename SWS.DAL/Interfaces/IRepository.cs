using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity,bool>> filter = null,
            Func<IQueryable<TEntity>,
            IOrderedQueryable<TEntity>> orderBy = null);

        TEntity GetByID(object id);

        TEntity GetByID(object year, object org, object dept, object soft_id);
        
       //BD03:取得某筆使用者資料
        TEntity GetByUserInfo(object org, object dept, object user_id);

        void Update(TEntity entity);

        void Delete(object id);

        void Delete(TEntity entity);

        void Insert(TEntity entity);
    }
}
