using System;
using Contracts;
using Dominio.Contracts;
using Dominio.Model;
using Servicios.Contracts;

namespace Servicios.Implem
{
    public class DetalleEstadisticaPorEnlaceServicio : Servicio<DetalleEstadisticaPorEnlace>, IDetalleEstadisticaPorEnlaceServicio
    {
        private readonly IRepositorioBase<DetalleEstadisticaPorEnlace> _repositorio;

        public DetalleEstadisticaPorEnlaceServicio(IRepositorioBase<DetalleEstadisticaPorEnlace> repositorio, IUnitOfWork unitOfWork) : base(repositorio, unitOfWork)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<DetalleEstadisticaPorEnlace> GetDetalleEstadisticaPorEnlaceId(long Id)
        {
            var lista = _repositorio.FindByCondition(u => u.EnlaceId == Id).AsEnumerable();

            return lista;

        }
    }
}

