using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS_MUNICIPIO.Models;

namespace WS_MUNICIPIO.Repositorios
{
    public class M_Establecimiento
    {
        private Db_Context_Prevencion db_context;

        public M_Establecimiento()
        {
            this.db_context = new Db_Context_Prevencion();

        }

        public M_Establecimiento(Db_Context_Prevencion db_context)
        {
            this.db_context = db_context;
        }
        public IdentityResult Create(OT_REGISTROESTABLECIMIENTO_WEB regEstablecimeinto)
        {
            try
            {
                this.db_context.OT_REGISTROESTABLECIMIENTO_WEB.Add(regEstablecimeinto);
                this.db_context.SaveChanges();

                return IdentityResult.Success;
            }
            catch (Exception e)
            {
                List<string> errors = new List<string>() { e.Message };
                return IdentityResult.Failed(errors.ToArray());
            }


        }

        public OT_REGISTROESTABLECIMIENTO_WEB FindRegEstablecimientoWebById(int id)
        {
            return this.db_context.OT_REGISTROESTABLECIMIENTO_WEB.Find(id);
        }

        public IdentityResult UpdateRegistroEstablecimiento(OT_REGISTROESTABLECIMIENTO_WEB regEstablecimeinto)
        {
            try
            {
                this.db_context.Entry(regEstablecimeinto).State = System.Data.Entity.EntityState.Modified;
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