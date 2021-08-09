using System.ComponentModel.DataAnnotations;

namespace Tarea9._0.Models
{
    public class Provincia
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

    }
}