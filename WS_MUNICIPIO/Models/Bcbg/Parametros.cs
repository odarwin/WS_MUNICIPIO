namespace WS_MUNICIPIO.Models.Bcbg
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Parametros
    {
        public string Id { get; set; }

        [StringLength(150)]
        public string NombreParametro { get; set; }

        [StringLength(150)]
        public string ValorParametro { get; set; }

        [StringLength(150)]
        public string DescripcionParametro { get; set; }

        public bool EsEditable { get; set; }

        public bool EsEliminable { get; set; }
    }
}
