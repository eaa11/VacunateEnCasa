using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tarea9._0.Models
{
    public class Provincia
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} no puede contener mas de {1} caracteres)")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public string Nombre { get; set; }
        [ForeignKey("IdProvincia")]
        public ICollection<Persona> Personas { get; set; }

    }
}