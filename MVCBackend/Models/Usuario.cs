using System.ComponentModel.DataAnnotations;

namespace MVCBackend.Models
{
    public class Usuario
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "La propiedad Nombre es requerida.")]
        public string Nombre { get; set; }



        [EmailAddress(ErrorMessage = "La propiedad Correo no tiene un formato válido.")]
        [Required(ErrorMessage = "La propiedad Correo es requerida.")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La propiedad Telefono es requerida.")]
        [StringLength(10, ErrorMessage = "La longitud máxima para la propiedad Nombre es de 10 caracteres.")]
        public string Telefono { get; set;}
        
        
        [Required(ErrorMessage = "El id es requerido.")]
        public int IdParticipacion { get; set; }

    }
}
