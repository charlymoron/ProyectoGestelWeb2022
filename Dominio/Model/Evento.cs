using System;
using System.Collections.Generic;

namespace Dominio.Model
{
    public partial class Evento : Entidad
    {
        public long Id { get; set; }
        public long ObjetoId { get; set; }
        public long TipoEvento { get; set; }
        public long? OperadorRegistroId { get; set; }
        public DateTime Fecha { get; set; }
        public string? Observaciones { get; set; }

        public virtual Objeto Objeto { get; set; } = null!;
        public virtual OperadorRegistro? OperadorRegistro { get; set; }
        public virtual TipoEvento TipoEventoNavigation { get; set; } = null!;
    }
}
