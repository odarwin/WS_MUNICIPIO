using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WS_MUNICIPIO.Models;

namespace WS_MUNICIPIO.Repositorios
{
    public class M_InformeObservacion
    {
        private Db_Context_Prevencion _context;

        public M_InformeObservacion()
        {
            this._context = new Db_Context_Prevencion();

        }

        public M_InformeObservacion(Db_Context_Prevencion _context)
        {
            this._context = _context;
        }
        public List<OT_INFORME_OBSERVACION> FindByInformeObservacionXTipoEstado(string tipo, string estado)
        {
            return this._context.OT_INFORME_OBSERVACION.Where(a => a.IOB_TIPO.Trim().Equals(tipo.Trim())
                                                        //&& a.REQ_ESTADO.Trim()== "A"
                                                        && a.IOB_ESTADO.Trim().Equals(estado.Trim())
                                                        && a.IOB_ELIMINADO == false
                                                        ).ToList();
        }
    }
}