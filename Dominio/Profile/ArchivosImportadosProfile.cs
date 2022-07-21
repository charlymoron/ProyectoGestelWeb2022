using System;
using Dominio.DTO;
using Dominio.Model;

namespace Dominio.Profile
{
    public class ArchivosImportadosProfile: AutoMapper.Profile
    {
        public ArchivosImportadosProfile()
        {

            CreateMap<ArchivosImportadosDTO, ArchivosImportado>();

            CreateMap<ArchivosImportado, ArchivosImportadosDTO>();
        }
    }
}

