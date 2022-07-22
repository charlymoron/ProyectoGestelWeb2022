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
        public DetalleEstadisticaServicio(IRepositorioBase<DetalleEstadistica> repositorio, IUnitOfWork unitOfWork ): base (repositorio, unitOfWork)
        {

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

