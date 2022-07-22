using System;
using Dominio.Model;
using Servicios.Helpers;

namespace Servicios.Contracts
{
    public interface IDetalleEstadisticaServicio : IServicio<DetalleEstadistica>
    {

        IEnumerable<DetalleEstadistica> GetOwners(ParametersGrid params);

    }
}

