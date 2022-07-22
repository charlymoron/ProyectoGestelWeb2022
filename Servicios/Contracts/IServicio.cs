using System;
using System.Linq.Expressions;
using Dominio.Model;

namespace Servicios.Contracts
{
    public interface IServicio<T> where T : Entidad
    {
        T Get(long id);
        IList<T> GetAll();
       // IList<T> GetAllItems(Expression<Func<T, bool>> predicate);
        void Create(T item);
        void Update(T item);
        void Delete(long id);

    }
}

