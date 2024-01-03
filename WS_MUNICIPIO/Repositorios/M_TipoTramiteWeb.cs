using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WS_MUNICIPIO.Models;
namespace WS_MUNICIPIO.Repositorios
{
    public class M_TipoTramiteWeb
    {
        private Db_Context_Prevencion db_context;

        public M_TipoTramiteWeb()
        {
            this.db_context = new Db_Context_Prevencion();

        }

        public M_TipoTramiteWeb(Db_Context_Prevencion db_context)
        {
            this.db_context = db_context;
        }

        public OT_TIPO_TRAMITE_WEB FindById(int id)
        {
            return this.db_context.OT_TIPO_TRAMITE_WEB.Find(id);
        }
    }
}