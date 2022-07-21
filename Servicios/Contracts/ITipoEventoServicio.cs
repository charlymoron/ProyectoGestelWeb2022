using System;
using Dominio.Model;
using Servicios.Contracts;

namespace Servicios.Contracts
{
    public interface ITipoEventoServicio : IServicio<TipoEvento>
    {
        string GetNameClase();
    }
}

