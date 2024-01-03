namespace WS_MUNICIPIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OT_SECTOR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEC_ID { get; set; }

        public int SEC_PARROQUIA_ID { get; set; }

        [StringLength(50)]
        public string SEC_NOMBRE { get; set; }

        [StringLength(30)]
        public string SEC_LATITUD { get; set; }

        [StringLength(30)]
        public string SEC_LONGITUD { get; set; }

        [StringLength(5)]
        public string SEC_ZOOM { get; set; }

        public DateTime? SEC_FECHA_CRE { get; set; }

        public DateTime? SEC_FECHA_MOD { get; set; }

        public bool? SEC_ELIMINADO { get; set; }
    }
}
