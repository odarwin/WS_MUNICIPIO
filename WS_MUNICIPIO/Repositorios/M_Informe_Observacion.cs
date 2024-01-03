using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS_MUNICIPIO.Models;

namespace WS_MUNICIPIO.Repositorios
{
    public class M_Informe_Observacion
    {
        private Db_Context_Prevencion db_context;
        public M_Informe_Observacion()
        {
            this.db_context = new Db_Context_Prevencion();

        }
        public OT_INFORME_OBSERVACION FindById(int? id)
        {
            return this.db_context.OT_INFORME_OBSERVACION.Find(id);
        }
    }
}