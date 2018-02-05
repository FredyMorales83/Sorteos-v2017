namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table( "SorteoReferencias" )]
    public partial class SorteoReferencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SorteoReferencia()
        {
            Ganadores = new HashSet<Ganador>();
        }
        [Key]
        public int SorteoReferenciaId { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreSorteo { get; set; }

        public DateTime FechaModificado { get; set; } = DateTime.Now;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ganador> Ganadores { get; set; }
    }
}
