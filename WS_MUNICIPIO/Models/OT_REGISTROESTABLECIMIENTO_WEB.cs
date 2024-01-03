namespace WS_MUNICIPIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OT_REGISTROESTABLECIMIENTO_WEB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OT_REGISTROESTABLECIMIENTO_WEB()
        {
            OT_TRAMITEOTPI_WEB = new HashSet<OT_TRAMITEOTPI_WEB>();
        }

        [Key]
        public int REST_ID { get; set; }

        public int REST_ESTABLECIMIENTO { get; set; }

        public int REST_CONTRIBUYENTE { get; set; }

        [StringLength(10)]
        public string REST_CODIGO_SRI { get; set; }

        [Required]
        [StringLength(150)]
        public string REST_NOMBRE_COMERCIAL { get; set; }

        [Required]
        [StringLength(150)]
        public string REST_ACTIVIDAD_SRI { get; set; }

        [Required]
        [StringLength(200)]
        public string REST_DIRECCION { get; set; }

        public int? REST_PARROQUIA_ID { get; set; }

        public int? REST_SECTOR { get; set; }

        [StringLength(50)]
        public string REST_BARRIO_COOPERATIVA { get; set; }

        [StringLength(50)]
        public string REST_VIA_PRINCIPAL { get; set; }

        [StringLength(50)]
        public string REST_VIA_SECUNDARIA { get; set; }

        [StringLength(20)]
        public string REST_VILLA { get; set; }

        public decimal? REST_AREA { get; set; }

        [StringLength(200)]
        public string REST_REF_UBIC { get; set; }

        [StringLength(200)]
        public string REST_TELEFONOS { get; set; }

        [StringLength(4000)]
        public string REST_NOTA { get; set; }

        public int REST_USU_CRE { get; set; }

        public int? REST_USU_MOD { get; set; }

        public DateTime REST_FEC_CRE { get; set; }

        public DateTime? REST_FEC_MOD { get; set; }

        public bool REST_ACTIVO { get; set; }

        public bool REST_ELIMINADO { get; set; }

        [StringLength(30)]
        public string REST_LATITUD { get; set; }

        [StringLength(30)]
        public string REST_LONGITUD { get; set; }

        [StringLength(2000)]
        public string REST_REFER_SITIO { get; set; }

        public int? REST_ZONA { get; set; }

        public bool? REST_PBAJA { get; set; }

        public bool? REST_FACILACCESO { get; set; }

        public byte[] REST_IMAGEN_LOCAL { get; set; }

        public DbGeometry REST_ZONEPOINT { get; set; }

        [StringLength(600)]
        public string REST_OBSERVACION { get; set; }

        [StringLength(2000)]
        public string REST_REFER_SITIO2 { get; set; }
        [StringLength(400)]
        public string REST_CATASTRO_MUN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OT_TRAMITEOTPI_WEB> OT_TRAMITEOTPI_WEB { get; set; }
    }
}
