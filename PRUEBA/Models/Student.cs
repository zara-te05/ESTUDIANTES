using System.ComponentModel.DataAnnotations;

namespace PRUEBA.Models
{
    // Notas: [Required] sirve para afirmar que algo es necesario
    public class Student
    {
        [Key]
        public int id_alumno {  get; set; }
        [Required]
        public string ? name { get; set; } = string.Empty;
        [Required]
        public string ? school_name { get; set; } = string.Empty;
        [Required]
        public int age { get; set; }
    }
}
