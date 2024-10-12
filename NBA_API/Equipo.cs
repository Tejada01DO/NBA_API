using System.ComponentModel.DataAnnotations;

namespace NBA_API
{
    public class Equipo
    {
        [Key]
        public int EquipoId { get; set; }
        public string Nombre { get; set; }
        public string Conferencia { get; set; }
        public string? Imagen { get; set; }
    }
}
