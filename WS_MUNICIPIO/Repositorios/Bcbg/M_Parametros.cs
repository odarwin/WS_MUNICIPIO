using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS_MUNICIPIO.Models.Bcbg;

namespace WS_MUNICIPIO.Repositorios.Bcbg
{
    public class M_Parametros
    {
        private Db_Context_Bcbg db_context;

        public M_Parametros()
        {
            this.db_context = new Db_Context_Bcbg();

        }

        public M_Parametros(Db_Context_Bcbg db_context)
        {
            this.db_context = db_context;
        }
        public Parametros FindByName(string name)
        {
            Parametros parametro = new Parametros();
            var data = this.db_context.Parametros.Where(p => p.NombreParametro.Equals(name)).ToList();
            if (data.Count() > 0)
                parametro = data.FirstOrDefault();
            else
            {
                parametro.Id = "-1";
            }
            return parametro;
        }

    }
}