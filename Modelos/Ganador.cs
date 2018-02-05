namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table( "Ganadores")]
    public partial class Ganador
    {
        [Key, ForeignKey("Boleto")]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SorteoId { get; set; }

        [Key, ForeignKey( "Boleto" )]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParticipanteId { get; set; }

        [Key, ForeignKey( "Boleto" )]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BoletoElectronico { get; set; }

        public int SorteoReferenciaId { get; set; }

        [StringLength(50)]
        public string NumeroSorteoReferencia { get; set; }

        [StringLength(250)]
        public string LinkVerificacionSorteo { get; set; }

        public DateTime FechaModificado { get; set; } = DateTime.Now;

        public virtual Boleto Boleto { get; set; }

        public virtual SorteoReferencia SorteoReferencia { get; set; }
    }
}
