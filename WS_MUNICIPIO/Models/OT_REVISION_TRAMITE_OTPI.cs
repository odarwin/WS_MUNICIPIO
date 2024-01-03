namespace WS_MUNICIPIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OT_REVISION_TRAMITE_OTPI
    {
        [Key]
        public int REV_ID { get; set; }

        public int REV_TRAMITE_ID { get; set; }

        public int REV_LISTADO_REV_ID { get; set; }

        public bool REV_LISTADO_REV_VALOR { get; set; }

        public bool REV_ESTADO { get; set; }

        public DateTime REV_FEC_CREACION { get; set; }

        public DateTime? REV_FEC_MOD { get; set; }

        public bool? REV_ELIMINADO { get; set; }

        public DateTime? REV_FEC_ELIMINADO { get; set; }

        public int REV_USUARIO_CRE { get; set; }

        public int? REV_USUARIO_MOD { get; set; }

        public virtual OT_LISTADO_REV_OTPI OT_LISTADO_REV_OTPI { get; set; }

        public virtual OT_TRAMITEOTPI_WEB OT_TRAMITEOTPI_WEB { get; set; }
    }
}
