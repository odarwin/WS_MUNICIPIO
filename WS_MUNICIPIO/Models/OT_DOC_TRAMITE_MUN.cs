namespace WS_MUNICIPIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OT_DOC_TRAMITE_MUN
    {
        [Key]
        public int DTM_ID { get; set; }

        public int DTM_TIPO { get; set; }

        [Required]
        [StringLength(600)]
        public string DTM_NOMBRE { get; set; }

        [Required]
        [StringLength(10)]
        public string DTM_ESTADO { get; set; }

        [StringLength(10)]
        public string DTM_TIPO_DOC { get; set; }

        public DateTime? DTM_FECHA_CRE { get; set; }

        [StringLength(20)]
        public string DTM_USU_CRE { get; set; }

        public DateTime? DTM_FECHA_MOD { get; set; }

        [StringLength(20)]
        public string DTM_USU_MOD { get; set; }

        public int DTM_TRAMITE_WEB { get; set; }
    }
}
