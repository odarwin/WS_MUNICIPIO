using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WS_MUNICIPIO.Models;
using WS_MUNICIPIO.Repositorios.Servicios;

namespace WS_MUNICIPIO.Repositorios
{
    public class M_TramiteotpiWeb
    {
        private Db_Context_Prevencion db_context;
        public M_TramiteotpiWeb()
        {
            this.db_context = new Db_Context_Prevencion();

        }
        public M_TramiteotpiWeb(Db_Context_Prevencion db_context)
        {
            this.db_context = db_context;
        }

        internal IdentityResult Create(OT_TRAMITEOTPI_WEB tramiteNew)
        {
            try
            {
                this.db_context.OT_TRAMITEOTPI_WEB.Add(tramiteNew);
                this.db_context.SaveChanges();
                return IdentityResult.Success;
            }
            catch (Exception e)
            {
                List<string> errors = new List<string>() { e.Message };
                return IdentityResult.Failed(errors.ToArray());
            }
        }

        internal OT_TRAMITEOTPI_WEB FindById(int tRW_ID)
        {
            return this.db_context.OT_TRAMITEOTPI_WEB.Find(tRW_ID);
        }

        public async Task<IdentityResult> SendMail(string correo, string asunto, string contenido, string cc)
        {
            try
            {
                //this._context.OT_DECLARACION.Add(entidad);
                var manager = new EmailService();
                //cc= correoBomberos
                await manager.Enviar(correo, asunto, contenido, null, null, cc);
                return IdentityResult.Success;
            }
            catch (Exception e)
            {
                List<string> errors = new List<string>() { e.Message };
                return IdentityResult.Failed(errors.ToArray());
            }
        }

        public OT_TRAMITEOTPI_WEB FindXNumeroTram(string numero_tramite)
        {
            return this.db_context.OT_TRAMITEOTPI_WEB.FirstOrDefault(s=>s.TRW_NUM_TRAMITE==numero_tramite && s.TRW_ELIMINADO==false);
        }

        public IdentityResult Update(OT_TRAMITEOTPI_WEB entidad)
        {
            try
            {
                this.db_context.Entry(entidad).State = System.Data.Entity.EntityState.Modified;
                this.db_context.SaveChangesAsync();
                return IdentityResult.Success;
            }
            catch (Exception e)
            {
                List<string> errors = new List<string>() { e.Message };
                return IdentityResult.Failed(errors.ToArray());
            }
        }
    }
}