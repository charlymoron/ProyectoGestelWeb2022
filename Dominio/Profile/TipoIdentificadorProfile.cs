using System;
using Dominio.DTO;
using Dominio.Model;

namespace Dominio.Profile
{
    public class TipoIdentificadorProfile : AutoMapper.Profile
    {
        public TipoIdentificadorProfile()
        {
            CreateMap<TipoIdentificadorDTO, TipoIdentificador>();

            CreateMap<TipoIdentificador, TipoIdentificadorDTO>();

        }
    }
}

