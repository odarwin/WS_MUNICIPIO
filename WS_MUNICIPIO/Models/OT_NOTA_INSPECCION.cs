namespace WS_MUNICIPIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OT_NOTA_INSPECCION
    {
        [Key]
        public int NTI_ID { get; set; }

        public int? NTI_ESTABLECIMIENTO { get; set; }

        public int NTI_SECUENCIAL { get; set; }

        [Required]
        [StringLength(4000)]
        public string NTI_DESCRIPCION { get; set; }

        public int? NTI_INSPECTOR { get; set; }

        public int? NTI_OBSERVACION { get; set; }

        public DateTime NTI_FECHA_CRE { get; set; }

        public DateTime NTI_FECHA_MOD { get; set; }

        public int NTI_USU_CRE { get; set; }

        public int? NTI_USU_MOD { get; set; }

        public int? NTI_USU_ELI { get; set; }

        public DateTime NTI_FEC_CRE { get; set; }

        public DateTime? NTI_FEC_MOD { get; set; }

        public DateTime? NTI_FEC_ELI { get; set; }

        public bool NTI_ELIMINADO { get; set; }

        public bool? NTI_AUTOMATICO { get; set; }

        public int? NTI_PAGO { get; set; }

        public int? NTI_ORDEN { get; set; }

        public int? NTI_INSPECCION { get; set; }

        public int? NTI_TRAMITE { get; set; }

        public int? NTI_CERTIFICADO { get; set; }
    }
}
