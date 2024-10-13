using System.ComponentModel.DataAnnotations;

namespace Biblioteca_Crud.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La descripcion del producto es obligatoria")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria.")]
        [DataType(DataType.Date, ErrorMessage = "Debe proporcionar una fecha válida.")]
        public DateTime Fecha { get; set; }
    }
}
