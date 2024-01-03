using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_MUNICIPIO.Clases
{
    public class TramiteNuevoEst
    {
        public string catastro { get; set; }
        public string direccion { get; set; }
        public string ruc_contribuyente { get; set; }
        public string codigo_sri { get; set; }
        
        public string nombre_comercial { get; set; }
        public string actividad_sri { get; set; }
        //public string parroquia { get; set; }
        public int sector_id { get; set; }
        public string ubicacion_referencia { get; set; }
        public int area { get; set; }
        public string img_fachada { get; set; }
        public string f_ced_vota { get; set; }
        public string f_predio { get; set; }
        public string f_calf_artesanal { get; set; }
        public string f_ruc { get; set; }
        public string img_interna_local { get; set; }
        public string img_extintor { get; set; }
        public string img_sticket_fecha_recarga { get; set; }
        public string img_fact_extintor_recarga { get; set; }
    }
    public class ParroquiaEntidad
    {
        public int id_parroquia { get; set; }
        public string nombre_parroquia { get; set; }
    }
    public class SectorEntidad
    {
        public int id_sector { get; set; }
        public string nombre_sector { get; set; }
    }
}