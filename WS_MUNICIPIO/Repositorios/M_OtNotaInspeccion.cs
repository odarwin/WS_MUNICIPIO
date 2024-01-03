using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WS_MUNICIPIO.Models;
namespace WS_MUNICIPIO.Repositorios
{
    public class M_OtNotaInspeccion
    {
        private Db_Context_Prevencion db_context;

        public M_OtNotaInspeccion()
        {
            this.db_context = new Db_Context_Prevencion();

        }

        public M_OtNotaInspeccion(Db_Context_Prevencion db_context)
        {
            this.db_context = db_context;
        }
        public IdentityResult Create(OT_NOTA_INSPECCION nota)
        {
            try
            {
                this.db_context.OT_NOTA_INSPECCION.Add(nota);
                this.db_context.SaveChanges();
                return IdentityResult.Success;
            }
            catch (Exception e)
            {
                List<string> errors = new List<string>() { e.Message };
                return IdentityResult.Failed(errors.ToArray());
            }
        }

        public OT_NOTA_INSPECCION FindXIDTramite(int numero_tramite)
        {
            return this.db_context.OT_NOTA_INSPECCION.Where(s=>s.NTI_TRAMITE==numero_tramite).FirstOrDefault();
            
        }

        public OT_NOTA_INSPECCION BuscaUltimaObservacionXTramite(int numero_tramite)
        {
            return this.db_context.OT_NOTA_INSPECCION.Where(s => s.NTI_TRAMITE == numero_tramite).OrderByDescending(s=>s.NTI_SECUENCIAL).FirstOrDefault();
        }
    }
}