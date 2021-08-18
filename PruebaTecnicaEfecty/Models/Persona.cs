using System;
using System.Collections.Generic;

#nullable disable

namespace PruebaTecnicaEfecty.Models
{
    public partial class Persona
    {
        public int RowId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public decimal? ValorGanar { get; set; }
        public string EstadoCivil { get; set; }
    }
}
