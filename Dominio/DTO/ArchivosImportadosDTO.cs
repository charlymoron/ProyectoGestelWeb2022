using System;
namespace Dominio.DTO
{
    public class ArchivosImportadosDTO
    {
        public long Id { get; set; }
        public long ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public string Operador { get; set; } = null!;
        public string FileName { get; set; } = null!;
    }
}

