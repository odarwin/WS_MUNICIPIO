using System;
using System.Collections.Generic;
using System.Linq; 
using System.Web;
using WS_MUNICIPIO.Models;

namespace WS_MUNICIPIO.Repositorios
{
    public class M_Contribuyente
    {
        private readonly Db_Context_Prevencion db_context;

        public M_Contribuyente()
        {
            this.db_context = new Db_Context_Prevencion();
        }

        public M_Contribuyente(Db_Context_Prevencion db_context)
        {
            this.db_context = db_context;

        }
        public int ObtenerIDXRuc(string ruc)
        {
            var result = this.db_context.OT_CONTRIBUYENTE.FirstOrDefault(s => s.CTB_RUC == ruc);
            return result != null ? result.CTB_ID : 0;
        }
    }
}