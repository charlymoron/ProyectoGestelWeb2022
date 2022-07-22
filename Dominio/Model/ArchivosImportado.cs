using System;
using System.Collections.Generic;

namespace Dominio.Model
{
    public partial class ArchivosImportado 
    {
        public long Id { get; set; }
        public long ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public string Operador { get; set; } = null!;
        public string FileName { get; set; } = null!;

        public virtual Cliente Cliente { get; set; } = null!;
    }
}
