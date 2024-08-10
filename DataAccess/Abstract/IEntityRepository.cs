using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // T tipini sınırladık
    // generic constraint
    // T : referans tip olmalı ve IEntity veya implemet edeb nesne
    // new(): new lenebilir olmalı , interface newlenmez
    public interface IEntityRepository<T> where T : class, IEntitiy, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); 

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Delete(T entity);
        void Update(T entity);

       
    }
}
