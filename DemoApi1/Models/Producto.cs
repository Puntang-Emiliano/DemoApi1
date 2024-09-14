using System.ComponentModel.DataAnnotations;

namespace DemoApi1.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public DateTime FechaAlta { get; set; }
        public int Stock { get; set; }
    }
}
