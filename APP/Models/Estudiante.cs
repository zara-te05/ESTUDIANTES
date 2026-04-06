using System.ComponentModel.DataAnnotations;

namespace APP.Models
{
    public partial class Estudiante
    {
        [Key]
        public int id_estudiante { get; set; }
        public string nombre_estudiante { get; set; } = string.Empty;
        public string nombre_escuela { get; set;  } = string.Empty;
        public int edad { get; set; }

    }
}
