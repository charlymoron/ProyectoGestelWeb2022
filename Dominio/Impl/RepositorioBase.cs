using System;
using System.Linq.Expressions;
using Contracts;
using Dominio.Model;
using Microsoft.EntityFrameworkCore;

namespace Dominio.Impl
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {

        protected GestelWeb2014Context _repositoryContext { get; set; }

        public RepositorioBase(GestelWeb2014Context repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void Create(T entity)
        {
            _repositoryContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _repositoryContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return _repositoryContext.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _repositoryContext.Set<T>().Where(expression);
        }

        public void Update(T entity)
        {
            _repositoryContext.Set<T>().Update(entity);
        }

        public virtual T FindById(long id)
        {
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return _repositoryContext.Set<T>().Find(id);
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
        }
    }
}

