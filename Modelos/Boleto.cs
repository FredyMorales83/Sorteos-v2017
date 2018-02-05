namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Boletos")]
    public partial class Boleto
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SorteoId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParticipanteId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BoletoElectronico { get; set; }

        public Guid CodigoValidacion { get; set; }

        public DateTime FechaOtorgado { get; set; } = DateTime.Now;

        public virtual Ganador Ganador { get; set; }

        public virtual Participante Participante { get; set; }

        public virtual Sorteo Sorteo { get; set; }
    }
}
