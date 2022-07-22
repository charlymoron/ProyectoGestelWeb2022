using System;
using Contracts;
using Dominio.Contracts;
using Dominio.Model;
using Servicios.Contracts;
using Servicios.Helpers;

namespace Servicios.Implem
{
    public class DetalleEstadisticaServicio : Servicio<DetalleEstadistica>, IDetalleEstadisticaServicio
    {
        private readonly IRepositorioBase<DetalleEstadistica> _repositorio;

        public DetalleEstadisticaServicio(IRepositorioBase<DetalleEstadistica> repositorio, IUnitOfWork unitOfWork ): base (repositorio, unitOfWork)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<DetalleEstadistica> GetDetalleEstadisticaPorEstadisticaId(long Id)
        {
            var lista = _repositorio.FindByCondition(u => u.EstadisticaId == Id);

            return lista.ToList();

        }

        public IEnumerable<DetalleEstadistica> GetPage(ParametersGrid parametros)
        {
            return  GetAll()
                    .OrderBy(on => on.EstadisticaId)
                    .Skip((parametros.PageNumber - 1) * parametros.PageSize)
                    .Take(parametros.PageSize)
                    .ToList();
        }
    }
}

