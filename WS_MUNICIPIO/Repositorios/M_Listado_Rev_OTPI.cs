using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS_MUNICIPIO.Models;

namespace WS_MUNICIPIO.Repositorios
{
    public class M_Listado_Rev_OTPI
    {
        private Db_Context_Prevencion db_context;

        public M_Listado_Rev_OTPI(Db_Context_Prevencion db_context)
        {
            this.db_context = db_context;

        }
        public M_Listado_Rev_OTPI()
        {
            this.db_context = new Db_Context_Prevencion();

        }
        public OT_LISTADO_REV_OTPI FindById(int key)
        {
            return this.db_context.OT_LISTADO_REV_OTPI.Find(key);
        }
    }
}