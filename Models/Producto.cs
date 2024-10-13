using System.ComponentModel.DataAnnotations;

namespace Biblioteca_Crud.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre Es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener mas de 100 Caracteres")]
        public string Nombre { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser un valor positivo o cero")]
        [Required(ErrorMessage = "Es necesaria Un Precio")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "Es necesaria Una cantidad")]
        public int Cantidad { get; set; }
       
    }
}
