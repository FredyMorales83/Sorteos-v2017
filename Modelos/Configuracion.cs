
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Models
{
    [Table( "Configuraciones" )]
    public partial class Configuracion
    {
        [Key]
        public int ConfiguracionId { get; set; }

        [Required]
        [StringLength(150)]
        public string RazonSocial { get; set; }

        [StringLength(13)]
        public string RFC { get; set; }

        [StringLength(250)]
        public string Direccion { get; set; }

        [StringLength(10)]
        public string Telefono { get; set; }

        [StringLength(50)]
        public string Correo { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public DateTime FechaModificado { get; set; } = DateTime.Now;
    }
}
