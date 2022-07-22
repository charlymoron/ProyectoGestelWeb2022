using System;
using Dominio.DTO;
using Dominio.Model;

namespace Dominio.Profile
{
    public class DetalleEstadisticaProfile: AutoMapper.Profile
    {
        public DetalleEstadisticaProfile()
        {
            CreateMap<DetalleEstadisticaDTO, DetalleEstadistica>();

            CreateMap<DetalleEstadistica, DetalleEstadisticaDTO>();
        }
    }
}

