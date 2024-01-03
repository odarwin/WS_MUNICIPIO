using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS_MUNICIPIO.Models;

namespace WS_MUNICIPIO.Repositorios
{
    public class M_Secuencia
    {
        private Db_Context_Prevencion db_context;
        public M_Secuencia(Db_Context_Prevencion db_context)
        {
            this.db_context = db_context;
        }

        public M_Secuencia()
        {
            this.db_context = new Db_Context_Prevencion();

        }

        public OT_SECUENCIA GetSecuenciaOrden(string name)
        {
            OT_SECUENCIA secuencia = new OT_SECUENCIA();
            var data = this.db_context.OT_SECUENCIA.Where(a => a.SEC_CODIGO.Trim() == name);

            if (data.Count() > 0)
            {
                secuencia = data.FirstOrDefault();
                secuencia.SEC_VALOR = secuencia.SEC_VALOR + 1;
                this.db_context.Entry(secuencia);
                db_context.SaveChanges();
            }
            else
            {
                secuencia.SEC_CODIGO = "";
                secuencia.SEC_DESCRIPCION = "";
                secuencia.SEC_VALOR = -1;
            }
            return secuencia;
        }

        public IdentityResult Create(OT_SECUENCIA secuencia)
        {
            try
            {
                this.db_context.OT_SECUENCIA.Add(secuencia);
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