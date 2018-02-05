namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table( "Participantes" )]
    public partial class Participante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Participante()
        {
            Boletos = new HashSet<Boleto>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ParticipanteId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string ApellidoPaterno { get; set; }

        [StringLength(50)]
        public string ApellidoMaterno { get; set; }

        [StringLength(10)]
        public string Telefono { get; set; }

        [StringLength(10)]
        public string Celular { get; set; }

        [StringLength(250)]
        public string Direccion { get; set; }

        [StringLength(50)]
        public string CorreoElectronico { get; set; }

        public DateTime FechaModificado { get; set; } = DateTime.Now;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleto> Boletos { get; set; }

        public override string ToString()
        {
            return string.Format( $"{Nombre} {ApellidoPaterno} {ApellidoMaterno}" );
        }
    }
}
