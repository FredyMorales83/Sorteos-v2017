using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace Models
{
    [Table( "Sorteos" )]
    public partial class Sorteo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sorteo()
        {
            Boletos = new HashSet<Boleto>();
        }
        [Key]
        public int SorteoId { get; set; }

        [Required]
        [StringLength(150)]
        public string NombreSorteo { get; set; }

        //[Column(TypeName = "date")]
        public DateTime FechaSorteo { get; set; }

        public int TotalBoletos { get; set; }

        public DateTime FechaModificado { get; set; } = DateTime.Now;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleto> Boletos { get; set; }
    }
}
