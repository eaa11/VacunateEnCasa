using System.ComponentModel.DataAnnotations;

namespace Tarea9._0.Models
{
    public class Sangre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(5)]
        public string Tipo { get; set; }

    }
}