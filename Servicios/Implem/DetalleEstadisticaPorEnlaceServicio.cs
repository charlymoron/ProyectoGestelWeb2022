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
            IEnumerable<DetalleEstadisticaPorEnlace>? lista = GetAllItems(u => u.EnlaceId == Id).ToList();

            return lista;

        }
    }
}

