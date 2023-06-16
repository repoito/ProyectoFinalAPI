using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalAPI.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }
        [Required]
        [StringLength(50)]
        public string TipoProducto { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }

    }

}
