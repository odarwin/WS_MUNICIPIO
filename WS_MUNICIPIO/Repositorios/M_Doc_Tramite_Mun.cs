using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS_MUNICIPIO.Models;

namespace WS_MUNICIPIO.Repositorios
{
    public class M_Doc_Tramite_Mun
    {
        private Db_Context_Prevencion db_context;
        public M_Doc_Tramite_Mun()
        {
            this.db_context = new Db_Context_Prevencion();
        }
        public IdentityResult CreateAsync(OT_DOC_TRAMITE_MUN foto)
        {
            try
            {
                this.db_context.OT_DOC_TRAMITE_MUN.Add(foto);
                this.db_context.SaveChanges();
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