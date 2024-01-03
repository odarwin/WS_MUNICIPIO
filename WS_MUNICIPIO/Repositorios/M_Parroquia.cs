using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS_MUNICIPIO.Models;
using WS_MUNICIPIO.Clases;
namespace WS_MUNICIPIO.Repositorios
{
    public class M_Parroquia
    {
        private Db_Context_Prevencion db_context;

        public M_Parroquia()
        {
            this.db_context = new Db_Context_Prevencion();

        }

        public M_Parroquia(Db_Context_Prevencion db_context)
        {
            this.db_context = db_context;
        }
        public int ObtenerIDParroquiaXNombre(string nombre)
        {
            var resul = this.db_context.OT_PARROQUIA.FirstOrDefault(s => s.PAR_NOMBRE.Contains(nombre));
            return resul != null ? resul.PAR_ID : 0;
        }

        public List<ParroquiaEntidad> GetListadoParroquias()
        {
            var lista= this.db_context.OT_PARROQUIA.Where(a => a.PAR_ELIMINADO == false);
            List<ParroquiaEntidad> lista_r = new List<ParroquiaEntidad>();
            foreach (var elem in lista)
            {
                lista_r.Add(new ParroquiaEntidad { id_parroquia=elem.PAR_ID, nombre_parroquia=elem.PAR_NOMBRE });
            }
            return lista_r;
        }

    }
}