using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WS_MUNICIPIO.Models;

namespace WS_MUNICIPIO.Repositorios
{
    public class M_Requisito_Tram
    {
        private Db_Context_Prevencion db_context;
        public M_Requisito_Tram()
        {
            this.db_context = new Db_Context_Prevencion();

        }
        public IdentityResult Create(OT_REQUISITO_TRAMITE_WEB entidad)
        {
            try
            {
                this.db_context.OT_REQUISITO_TRAMITE_WEB.Add(entidad);
                this.db_context.SaveChanges();

                return IdentityResult.Success;
            }
            catch (Exception e)
            {
                List<string> errors = new List<string>() { e.Message };
                return IdentityResult.Failed(errors.ToArray());
            }


        }

        public OT_REQUISITO_TRAMITE_WEB FindById(int id)
        {
            return this.db_context.OT_REQUISITO_TRAMITE_WEB.Find(id);
        }

        public IdentityResult Update(OT_REQUISITO_TRAMITE_WEB entidad)
        {

            try
            {
                this.db_context.Entry(entidad).State = System.Data.Entity.EntityState.Modified;
                this.db_context.SaveChanges();
                return IdentityResult.Success;
            }
            catch (Exception e)
            {
                List<string> errors = new List<string>() { e.Message };
                return IdentityResult.Failed(errors.ToArray());
            }
        }

        public IEnumerable<OT_REQUISITO_TRAMITE_WEB>  FindByIdTramite(int id_tramite)
        {
            return this.db_context.OT_REQUISITO_TRAMITE_WEB.Where(s=>s.REQ_TRAMITEID ==id_tramite).ToList();
        }
    }
}