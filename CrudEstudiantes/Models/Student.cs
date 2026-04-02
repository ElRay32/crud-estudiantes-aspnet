using System.ComponentModel.DataAnnotations;

namespace CrudEstudiantes.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Range(1, 100, ErrorMessage = "La edad debe estar entre 1 y 100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Correo no válido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La carrera es obligatoria")]
        [StringLength(100)]
        public string Major { get; set; } = string.Empty;
    }
}