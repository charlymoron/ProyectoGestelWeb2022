using System;
using System.Collections.Generic;

namespace Dominio.Model
{
    public partial class IdentificadorObjeto 
    {
        public long Id { get; set; }
        public long ObjetoId { get; set; }
        public long TipoIdentificadorId { get; set; }
        public string ValorIdentificador { get; set; } = null!;

        public virtual Objeto Objeto { get; set; } = null!;
        public virtual TipoIdentificador TipoIdentificador { get; set; } = null!;
    }
}
