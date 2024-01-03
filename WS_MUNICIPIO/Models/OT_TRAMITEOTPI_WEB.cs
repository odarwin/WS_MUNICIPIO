namespace WS_MUNICIPIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OT_TRAMITEOTPI_WEB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OT_TRAMITEOTPI_WEB()
        {
            OT_REQUISITO_TRAMITE_WEB = new HashSet<OT_REQUISITO_TRAMITE_WEB>();
            OT_REVISION_TRAMITE_OTPI = new HashSet<OT_REVISION_TRAMITE_OTPI>();
        }

        [Key]
        public int TRW_ID { get; set; }

        public int TRW_ESTADO_TRAMITE_ID { get; set; }

        public int TRW_TIPO_TRAMITE_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TRW_NUM_TRAMITE { get; set; }

        public int TRW_REG_ID { get; set; }

        public DateTime TRW_FECHA_INICIO { get; set; }

        public DateTime TRW_FEC_FIN { get; set; }

        public bool TRW_ELIMINADO { get; set; }

        public int TRW_USUARIO_CREACION { get; set; }

        public DateTime TRW_FEC_CREACION { get; set; }

        public DateTime? TRW_FEC_MOD { get; set; }
        public string TRW_USUARIO_ATENCION { get; set; }
        public string TRW_USUARIO_ATENCION_ANT { get; set; }
        public int? TRW_USUARIO_MOD { get; set; }

        [StringLength(20)]
        public string TRW_ORIGEN { get; set; }

        public virtual OT_REGISTROESTABLECIMIENTO_WEB OT_REGISTROESTABLECIMIENTO_WEB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OT_REQUISITO_TRAMITE_WEB> OT_REQUISITO_TRAMITE_WEB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OT_REVISION_TRAMITE_OTPI> OT_REVISION_TRAMITE_OTPI { get; set; }

        public virtual OT_TIPO_TRAMITE_WEB OT_TIPO_TRAMITE_WEB { get; set; }
    }
}
