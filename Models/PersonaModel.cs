using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9._0.Models
{
    public class PersonaModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(13, ErrorMessage = "El campo {0} no puede contener mas de {1} caracteres)")]
        [Required(ErrorMessage ="La {0} es requerida.")]
        public string Cedula { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} no puede contener mas de {1} caracteres)")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public string Nombre { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} no puede contener mas de {1} caracteres)")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public string Apellido { get; set; }

        [MaxLength(10, ErrorMessage = "El campo {0} no puede contener mas de {1} caracteres)")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public string Telefono { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} no puede contener mas de {1} caracteres)")]
        [Required(ErrorMessage = "El {0} es requerido.")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La {0} es requerida.")]
        public DateTime FechaNacimiento { get; set; }
        public int IdSangre { get; set; }
        [ForeignKey("IdSangre")]
        public SangreModel Sangre { get; set; }
        public int IdProvincia { get; set; }

        [ForeignKey("IdProvincia")]
        public ProvinciaModel Provincia { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} no puede contener mas de {1} caracteres)")]
        [Required(ErrorMessage = "La {0} es requerida.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La {0} es requerida.")]
        public decimal Latitud { get; set; }

        [Required(ErrorMessage = "La {0} es requerida.")]
        public decimal Longitud { get; set; }

        [Required(ErrorMessage = "El {0} es requerido.")]
        public bool HistorialCovid { get; set; }

        [Required(ErrorMessage = "La {0} es requerida.")]
        [MaxLength(150,ErrorMessage ="El campo {0} no puede contener mas de {1} caracteres")]
        public string Justificacion { get; set; }

    }
}
