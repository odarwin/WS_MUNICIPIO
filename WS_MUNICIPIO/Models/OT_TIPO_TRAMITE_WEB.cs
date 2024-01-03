namespace WS_MUNICIPIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OT_TIPO_TRAMITE_WEB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OT_TIPO_TRAMITE_WEB()
        {
            OT_TRAMITEOTPI_WEB = new HashSet<OT_TRAMITEOTPI_WEB>();
        }

        [Key]
        public int TTRA_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TTRA_NOMBRE { get; set; }

        [StringLength(200)]
        public string TTRA_DESCRIPCION { get; set; }

        public bool TTRA_ESTADO { get; set; }

        public bool TTRA_ELIMINADO { get; set; }

        public int TTRA_USUARIO_CREACION { get; set; }

        public DateTime TTRA_FEC_CREACION { get; set; }

        public int? TTRA_USUARIO_MOD { get; set; }

        public DateTime? TTRA_FEC_MOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OT_TRAMITEOTPI_WEB> OT_TRAMITEOTPI_WEB { get; set; }
    }
}
