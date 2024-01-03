namespace WS_MUNICIPIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OT_INFORME_OBSERVACION
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IOB_ID { get; set; }

        [StringLength(100)]
        public string IOB_DESCRIPCION { get; set; }

        public int? IOB_ADDUSER { get; set; }

        public DateTime? IOB_ADDOPERAR { get; set; }

        public int? IOB_EDITUSER { get; set; }

        public DateTime? IOB_EDITOPERAR { get; set; }

        public bool? IOB_ELIMINADO { get; set; }

        public bool? IOB_EMAIL { get; set; }

        public bool? IOB_FLUJO { get; set; }

        [StringLength(100)]
        public string IOB_ASUNTO_MAIL { get; set; }

        [StringLength(3000)]
        public string IOB_MENSAJE { get; set; }

        [StringLength(3000)]
        public string IOB_MENSAJE_MAIL { get; set; }

        [StringLength(10)]
        public string IOB_SISTEMA { get; set; }

        [StringLength(10)]
        public string IOB_TIPO { get; set; }

        [StringLength(10)]
        public string IOB_ESTADO { get; set; }

        public bool? IOB_VERFOTOS { get; set; }
    }
}
