using System;
using Dominio.Model;

namespace Servicios.Contracts
{
    public interface IServicio<T> where T : Entidad
    {
        T Get(long id);
        IList<T> GetAll();

        void Create(T item);
        void Update(T item);
        void Delete(long id);

    }
}

