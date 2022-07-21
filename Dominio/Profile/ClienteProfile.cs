using System;
using Dominio.DTO;
using Dominio.Model;
using AutoMapper;

namespace Dominio.Profile
{
    public class ClienteProfile : AutoMapper.Profile
    {
        public ClienteProfile()
        {


            CreateMap<ClienteDTO, Cliente>();

            CreateMap<Cliente, ClienteDTO>()
                .ForMember(dest => dest.Id, cfg => cfg.MapFrom (s => s.Id.ToString()))
                .ForMember(dest => dest.RazonSocial, cfg => cfg.MapFrom(s => s.RazonSocial))
                .ForMember(dest => dest.Activo, cfg => cfg.MapFrom(s => s.Activo == 1 ? "SI" : "NO"))
                .ForMember(dest => dest.FechaDeAlta, cfg => cfg.MapFrom(c => c.FechaDeAlta.ToString("dd/MM/yyyy")))
                .ForMember(dest => dest.FechaDeBaja, cfg => cfg.Ignore())

                //.ForMember(dest => dest.ArchivosImportados, cfg => cfg.Ignore())

                //.ForMember(dest => dest.Edificios, cfg => cfg.Ignore())
                //.ForMember(dest => dest.Estadisticas, cfg => cfg.Ignore())

                //.ForMember(dest => dest.TipoEstadisticas, cfg => cfg.Ignore())
                ;
        }
    }
}

