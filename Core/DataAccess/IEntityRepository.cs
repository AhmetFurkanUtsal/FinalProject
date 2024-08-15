
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // **Core katmanları diğer katmanları referance almaz 
    // T tipini sınırladık
    // generic constraint
    // T : referans tip olmalı ve IEntity veya implemet edeb nesne
    // new(): new lenebilir olmalı , interface newlenmeza
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); 

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Delete(T entity);
        void Update(T entity);

       
    }
}
