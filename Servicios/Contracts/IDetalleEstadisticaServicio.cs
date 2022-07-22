using System;
using Dominio.Model;
using Servicios.Helpers;

namespace Servicios.Contracts
{
    public interface IDetalleEstadisticaServicio : IServicio<DetalleEstadistica>
    {

        IEnumerable<DetalleEstadistica> GetPage(ParametersGrid parametros);

        IEnumerable<DetalleEstadistica> GetDetalleEstadisticaPorEstadisticaId(long Id);

    }
}

