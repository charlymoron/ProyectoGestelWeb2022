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
           
            CreateMap<DetalleEstadisticaPorEnlace, DetalleEstadisticaPorEnlaceDTO>()
                .ForMember(dest => dest.Id, cfg => cfg.MapFrom(s => s.Id))
                .ForMember(dest => dest.EnlaceId, cfg => cfg.MapFrom(s => s.EnlaceId))
                .ForMember(dest => dest.CantidadDeFallas, cfg => cfg.MapFrom(s => s.CantidadDeFallas))
                .ForMember(dest => dest.Disponibilidad, cfg => cfg.MapFrom(s => s.Disponibilidad))



                ;

        }
    }
}

