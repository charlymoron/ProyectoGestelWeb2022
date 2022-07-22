using System;
using Dominio.DTO;
using Dominio.Model;

namespace Dominio.Profile
{
    public class DetalleEstadisticaPorEnlaceProfile: AutoMapper.Profile
    {
        public DetalleEstadisticaPorEnlaceProfile()
        {
            CreateMap<DetalleEstadisticaPorEnlaceDTO, DetalleEstadisticaPorEnlace>();
            CreateMap<DetalleEstadisticaPorEnlace, DetalleEstadisticaDTO>();
        }
    }
}

