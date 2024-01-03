namespace WS_MUNICIPIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OT_LISTADO_REV_OTPI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OT_LISTADO_REV_OTPI()
        {
            OT_REVISION_TRAMITE_OTPI = new HashSet<OT_REVISION_TRAMITE_OTPI>();
        }

        [Key]
        public int LIS_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string LIS_NOMBRE { get; set; }

        [Required]
        [StringLength(200)]
        public string LIS_DESCRIPCION { get; set; }

        public bool LIS_ESTADO { get; set; }

        public bool LIS_FIJO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OT_REVISION_TRAMITE_OTPI> OT_REVISION_TRAMITE_OTPI { get; set; }
    }
}
