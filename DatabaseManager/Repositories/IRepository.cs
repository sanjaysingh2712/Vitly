using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DatabaseManager.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //Get
        TEntity Get(int id);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //Add
        void Add(TEntity entity);
        void Add(IEnumerable<TEntity> entities);

        //Remove
        void Remove(TEntity entity);
        void Remove(IEnumerable<TEntity> entities);
    }
}