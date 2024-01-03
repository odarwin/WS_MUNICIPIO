namespace WS_MUNICIPIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OT_SECUENCIA
    {
        [Key]
        [StringLength(20)]
        public string SEC_CODIGO { get; set; }

        [StringLength(50)]
        public string SEC_DESCRIPCION { get; set; }

        public int SEC_VALOR { get; set; }
    }
}
