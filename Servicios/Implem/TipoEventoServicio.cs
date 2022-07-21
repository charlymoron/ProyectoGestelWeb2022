using System;
using Contracts;
using Dominio.Contracts;
using Dominio.Model;
using Servicios.Contracts;


namespace Servicios.Implem
{
    public class TipoEventoServicio : Servicio<TipoEvento>, ITipoEventoServicio
    {
        public TipoEventoServicio(IRepositorioBase<TipoEvento> repositorio, IUnitOfWork unitOfWork)
            : base (repositorio, unitOfWork)
        {
        }

        public string GetNameClase()
        {
            return "TipoEventoServicio";
        }
    }
}

