using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9._0.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(13)]
        [Required]
        public string Cedula { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }
        [MaxLength(50)]
        [Required]
        public string Apellido { get; set; }
        [MaxLength(10)]
        [Required]
        public string Telefono { get; set; }
        [MaxLength(50)]
        [Required]
        public string Correo { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        public Sangre Sangre { get; set; }
        public Provincia Provincia { get; set; }
        [MaxLength(100)]
        [Required]
        public string Direccion { get; set; }
        [Required]
        public decimal Latitud { get; set; }
        [Required]
        public decimal Longitud { get; set; }
        [Required]
        public bool HistorialCovid { get; set; }
        [Required]
        [MaxLength(100)]
        public string Justificacion { get; set; }

    }
}
