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
                .ForMember(dest => dest.DisponibilidadConRespaldo, cfg => cfg.MapFrom(s => s.DisponibilidadConRespaldo))
                .ForMember(dest => dest.EstadisticaId, cfg => cfg.MapFrom(s => s.EstadisticaId))
                .ForMember(dest => dest.Tdf, cfg => cfg.MapFrom(s => s.Tdf))
                .ForMember(dest => dest.TdfconRespaldo, cfg => cfg.MapFrom(s => s.TdfconRespaldo))
                .ForMember(dest => dest.Tmef, cfg => cfg.MapFrom(s => s.Tmef));

        }
    }
}

