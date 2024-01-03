using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS_MUNICIPIO.Models;
using WS_MUNICIPIO.Clases;
namespace WS_MUNICIPIO.Repositorios
{
    public class M_Sector
    {
        private Db_Context_Prevencion db_context;
        public M_Sector()
        {
            this.db_context = new Db_Context_Prevencion();
        }
        public List<SectorEntidad> GetListadoSectorXParroquia(int id_parroquia)
        {
            var lista = this.db_context.OT_SECTOR.Where(s=>s.SEC_PARROQUIA_ID==id_parroquia && s.SEC_ELIMINADO==false);
            List<SectorEntidad> lista_r = new List<SectorEntidad>();
            foreach (var elem in lista)
            {
                lista_r.Add(new SectorEntidad { id_sector = elem.SEC_ID, nombre_sector = elem.SEC_NOMBRE });
            }
            return lista_r;
        }

        public int ObtenerParroquiaXSector(int sector_id)
        {
            var r= this.db_context.OT_SECTOR.FirstOrDefault(s=>s.SEC_ID==sector_id && s.SEC_ELIMINADO==false);
            return r.SEC_PARROQUIA_ID;
        }
    }
}