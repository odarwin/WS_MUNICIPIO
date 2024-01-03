namespace WS_MUNICIPIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OT_ESTABLECIMIENTO
    {
        [Key]
        public int ETB_ID { get; set; }

        public int ETB_CONTRIBUYENTE { get; set; }

        [Required]
        [StringLength(15)]
        public string ETB_CODIGO { get; set; }

        [StringLength(10)]
        public string ETB_CODIGO_SRI { get; set; }

        [Required]
        [StringLength(150)]
        public string ETB_NOMBRE_COMERCIAL { get; set; }

        [Required]
        [StringLength(200)]
        public string ETB_DIRECCION { get; set; }

        public bool ETB_ACTIVO { get; set; }

        public DateTime ETB_FECHA_INICIO { get; set; }

        public DateTime? ETB_FECHA_FIN { get; set; }

        public int? ETB_RUTA { get; set; }

        public int? ETB_EDIFICIO { get; set; }

        [StringLength(200)]
        public string ETB_REF_UBIC { get; set; }

        [StringLength(200)]
        public string ETB_TELEFONOS { get; set; }

        [StringLength(4000)]
        public string ETB_NOTA { get; set; }

        public DateTime? ETB_FEC_INGRESO { get; set; }

        public int? ETB_NOTA_INSP_SECUENCIA { get; set; }

        [StringLength(50)]
        public string ETB_TIPO_DOC_BAJA { get; set; }

        [StringLength(50)]
        public string ETB_NUM_DOC_BAJA { get; set; }

        public DateTime? ETB_FECHA_BAJA { get; set; }

        [StringLength(200)]
        public string ETB_ORDEN_BAJA { get; set; }

        public int ETB_USU_CRE { get; set; }

        public int? ETB_USU_MOD { get; set; }

        public int? ETB_USU_ELI { get; set; }

        public DateTime ETB_FEC_CRE { get; set; }

        public DateTime? ETB_FEC_MOD { get; set; }

        public DateTime? ETB_FEC_ELI { get; set; }

        public int? ETB_CAJ_CRE { get; set; }

        public int? ETB_CAJ_MOD { get; set; }

        public int? ETB_CAJ_ELI { get; set; }

        public bool ETB_ELIMINADO { get; set; }

        [StringLength(400)]
        public string ETB_CATASTRO { get; set; }

        [StringLength(50)]
        public string ETB_CERTIF_SEGURIDAD { get; set; }

        [StringLength(30)]
        public string ETB_LATITUD { get; set; }

        [StringLength(30)]
        public string ETB_LONGITUD { get; set; }

        public decimal? ETB_AREA { get; set; }

        public int? ETB_EDIFICACION { get; set; }

        [StringLength(2000)]
        public string ETB_REFER_SITIO { get; set; }

        public int? ETB_ZONA { get; set; }

        public bool? ETB_PBAJA { get; set; }

        public bool? ETB_FACILACCESO { get; set; }

        [StringLength(50)]
        public string ETB_SERIEMEDIDORES { get; set; }

        public byte[] ETB_IMAGEN_LOCAL { get; set; }

        public int? ETB_PARROQUIA_ID { get; set; }

        public int? ETB_SECTOR { get; set; }

        [StringLength(50)]
        public string ETB_BARRIO_COOPERATIVA { get; set; }

        [StringLength(50)]
        public string ETB_VIA_PRINCIPAL { get; set; }

        [StringLength(50)]
        public string ETB_VIA_SECUNDARIA { get; set; }

        [StringLength(20)]
        public string ETB_VILLA { get; set; }

        [StringLength(2)]
        public string ETB_ESTADO { get; set; }

        public bool? ETB_ESTABLECIMIENTO_ACTUALIZADO { get; set; }

        [Required]
        [StringLength(150)]
        public string ETB_ACTIVIDAD_SRI { get; set; }

        public int? PI_ANT { get; set; }

        public DbGeometry ETB_ZONEPOINT { get; set; }

        public bool? ETB_PERMISO_VIGENTE { get; set; }

        [StringLength(600)]
        public string ETB_OBSERVACION { get; set; }

        [StringLength(2000)]
        public string ETB_REFER_SITIO2 { get; set; }

        public bool? ETB_FOR_SIS_ALARMAS { get; set; }

        public bool? ETB_FOR_SIS_HIDRAULICO { get; set; }

        public bool? ETB_FOR_ALARMAS_PRESENTADO { get; set; }

        public bool? ETB_FOR_HIDRAULICO_PRESENTADO { get; set; }

        public DateTime? ETB_PERMISO_FEC { get; set; }

        public int? ETB_PERMISO_ID { get; set; }

        [StringLength(50)]
        public string ETB_MOTIVOCESE { get; set; }

        [StringLength(10)]
        public string ETB_TIPO { get; set; }

        public bool? ETB_COMERCIAL { get; set; }

        public bool? ETB_DESBLOQ_ZONA { get; set; }
    }
}
