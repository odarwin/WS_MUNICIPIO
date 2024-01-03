namespace WS_MUNICIPIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OT_CONTRIBUYENTE
    {
        [Key]
        public int CTB_ID { get; set; }

        [Required]
        [StringLength(15)]
        public string CTB_CODIGO { get; set; }

        [Required]
        [StringLength(1)]
        public string CTB_TIPO { get; set; }

        [Required]
        [StringLength(20)]
        public string CTB_RUC { get; set; }

        [Required]
        [StringLength(100)]
        public string CTB_RAZON_SOCIAL { get; set; }

        [Required]
        [StringLength(100)]
        public string CTB_REP_LEGAL { get; set; }

        [StringLength(200)]
        public string CTB_DIRECCION { get; set; }

        [StringLength(100)]
        public string CTB_TELEFONOS { get; set; }

        public DateTime? CTB_ANT_FEC_CRE { get; set; }

        public int? CTB_ANT_ANO_CRE { get; set; }

        [Column(TypeName = "text")]
        public string CTB_NOTA { get; set; }

        public int CTB_USU_CRE { get; set; }

        public int? CTB_USU_MOD { get; set; }

        public int? CTB_USU_ELI { get; set; }

        public DateTime CTB_FEC_CRE { get; set; }

        public DateTime? CTB_FEC_MOD { get; set; }

        public DateTime? CTB_FEC_ELI { get; set; }

        public int? CTB_CAJ_CRE { get; set; }

        public int? CTB_CAJ_MOD { get; set; }

        public int? CTB_CAJ_ELI { get; set; }

        public bool CTB_ELIMINADO { get; set; }

        [StringLength(255)]
        public string CTB_CORREO { get; set; }

        [StringLength(50)]
        public string CTB_TELEF_CONVENC { get; set; }

        [StringLength(10)]
        public string CTB_CEDULA_REP_LEGAL { get; set; }

        [StringLength(50)]
        public string CTB_PRIMER_NOMBRE { get; set; }

        [StringLength(50)]
        public string CTB_SEGUNDO_NOMBRE { get; set; }

        [StringLength(50)]
        public string CTB_PRIMER_APELLIDO { get; set; }

        [StringLength(50)]
        public string CTB_SEGUNDO_APELLIDO { get; set; }

        [StringLength(50)]
        public string CTB_SITIO_WEB { get; set; }

        [StringLength(50)]
        public string CTB_REP_LEGAL_NOMBRES { get; set; }

        [StringLength(50)]
        public string CTB_REP_LEGAL_APELLIDOS { get; set; }

        public bool? CTB_CONTRIBUYENTE_ACTUALIZADO { get; set; }

        public int? PI_ANT { get; set; }
    }
}
