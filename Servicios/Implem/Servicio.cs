using System;
using System.Linq;
using System.Linq.Expressions;
using Contracts;
using Dominio.Contracts;
using Dominio.Model;
using Servicios.Contracts;

namespace Servicios.Implem
{
    public class Servicio<T> : IServicio<T> where T : Entidad
    {
        private readonly IRepositorioBase<T> _repositorio;
        private readonly IUnitOfWork _unitOfWork;

        public Servicio(IRepositorioBase<T> repositorio, IUnitOfWork unitOfWork)
        {
            _repositorio = repositorio;
            _unitOfWork = unitOfWork;
        }

        public virtual void Create(T item)
        {
            try
            {
                _repositorio.Create(item);
                _unitOfWork.SaveChanges();
            }
            catch { }
        }

        public virtual void Delete(long id)
        {
            try
            {
                var item = _repositorio.FindById(id);
                _repositorio.Delete(item);
                _unitOfWork.SaveChanges();
            }
            catch { }
        }

        public T Get(long id)
        {
            var entity = GetAllItems().SingleOrDefault(x => x.Id == id);
            #pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return entity;
            #pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo

        }

        public IList<T> GetAll()
        {
            return GetAllItems().ToList();
        }


        


        
        

        public void Update(T item)
        {
            try
            {
                _repositorio.Update(item);
                _unitOfWork.SaveChanges();

            }
            catch { }

        }

        protected IQueryable<T> GetAllItems()
        {
            #pragma warning disable CS8625 // No se puede convertir un literal NULL en un tipo de referencia que no acepta valores NULL.
            return GetAllItems(null);
            #pragma warning restore CS8625 // No se puede convertir un literal NULL en un tipo de referencia que no acepta valores NULL.
        }

        protected IQueryable<T> GetAllItems(Expression<Func<T, bool>> predicate)
        {
            var query = _repositorio.FindAll();
           
            return predicate != null ? query.Where(predicate) : query;         
        }

        
    }
}

