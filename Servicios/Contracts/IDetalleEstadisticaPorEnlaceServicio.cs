using System;
using Dominio.Model;

namespace Servicios.Contracts
{
    public interface IDetalleEstadisticaPorEnlaceServicio : IServicio<DetalleEstadisticaPorEnlace>
    {



        IEnumerable<DetalleEstadisticaPorEnlace> GetDetalleEstadisticaPorEnlaceId(long Id);

    }
}

