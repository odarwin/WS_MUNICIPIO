using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_MUNICIPIO.Clases
{
    public class TramiteActualiza
    {
        public string catastro { get; set; }
        public string direccion { get; set; }
        public string ruc_contribuyente { get; set; }
        public string codigo_sri { get; set; }
        public string nombre_comercial { get; set; }
        public string actividad_sri { get; set; }
        public int sector_id { get; set; }
        public string ubicacion_referencia { get; set; }
        public decimal area { get; set; }
        public string f_ced_vota { get; set; }
        public string f_predio { get; set; }
        public string f_calf_artesanal { get; set; }
        public string f_ruc { get; set; }
}
}