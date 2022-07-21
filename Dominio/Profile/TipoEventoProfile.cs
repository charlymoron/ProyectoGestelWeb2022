using System;
using Dominio.DTO;
using Dominio.Model;

namespace Dominio.Profile
{
    public class TipoEventoProfile : AutoMapper.Profile
    {
        public TipoEventoProfile()
        {
            CreateMap<TipoEventoDTO, TipoEvento>();
            CreateMap<TipoEvento, TipoEventoDTO>();

        }
    }
}

