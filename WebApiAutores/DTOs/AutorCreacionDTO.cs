using System.ComponentModel.DataAnnotations;
using WebApiAutores.Validaciones;

namespace WebApiAutores.DTOs
{
    public class AutorCreacionDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(5, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
       
        public string Nombre { get; set; }
    }
}
