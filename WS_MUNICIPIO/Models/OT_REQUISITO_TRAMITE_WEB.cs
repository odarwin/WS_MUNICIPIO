namespace WS_MUNICIPIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OT_REQUISITO_TRAMITE_WEB
    {
        [Key]
        public int REQ_ID { get; set; }

        public int REQ_TRAMITEID { get; set; }

        [Required]
        [StringLength(30)]
        public string REQ_TIPO { get; set; }

        [Required]
        [StringLength(300)]
        public string REQ_NOMBRE { get; set; }

        [StringLength(10)]
        public string REQ_ESTADO { get; set; }

        [StringLength(10)]
        public string REQ_TIPO_DOC { get; set; }

        public DateTime REQ_FEC_CRE { get; set; }

        public int REQ_USU_CRE { get; set; }

        public DateTime? REQ_FEC_MOD { get; set; }

        public int? REQ_USU_MOD { get; set; }

        public bool REQ_ELIMINADO { get; set; }

        [Required]
        [StringLength(300)]
        public string REQ_RUTA { get; set; }

        public bool? REQ_REVISION { get; set; }

        public virtual OT_TRAMITEOTPI_WEB OT_TRAMITEOTPI_WEB { get; set; }
    }
}
