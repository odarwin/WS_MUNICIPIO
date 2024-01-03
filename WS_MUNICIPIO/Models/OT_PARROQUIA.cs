namespace WS_MUNICIPIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OT_PARROQUIA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PAR_ID { get; set; }

        [StringLength(50)]
        public string PAR_NOMBRE { get; set; }

        public int? PAR_USU_CRE { get; set; }

        public int? PAR_USU_MOD { get; set; }

        public DateTime? PAR_FECHA_CRE { get; set; }

        public DateTime? PAR_FECHA_MOD { get; set; }

        public bool? PAR_ELIMINADO { get; set; }
    }
}
