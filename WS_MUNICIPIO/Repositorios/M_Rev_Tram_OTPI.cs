using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS_MUNICIPIO.Models;

namespace WS_MUNICIPIO.Repositorios
{
    public class M_Rev_Tram_OTPI
    {
        private readonly Db_Context_Prevencion _context;
        public M_Rev_Tram_OTPI()
        {
            this._context = new Db_Context_Prevencion();

        }
        public M_Rev_Tram_OTPI(Db_Context_Prevencion _context)
        {
            this._context = _context;
        }
        public IdentityResult Create(OT_REVISION_TRAMITE_OTPI entidad)
        {
            try
            {
                this._context.OT_REVISION_TRAMITE_OTPI.Add(entidad);
                this._context.SaveChanges();
                return IdentityResult.Success;
            }
            catch (Exception e)
            {
                List<string> errors = new List<string>() { e.Message };
                return IdentityResult.Failed(errors.ToArray());
            }
        }

        public IEnumerable<OT_REVISION_TRAMITE_OTPI> FindByIdTramite(int id_tramite)
        {
            return this._context.OT_REVISION_TRAMITE_OTPI.Where(s=>s.REV_TRAMITE_ID==id_tramite).ToList();
        }

        public IdentityResult Update(OT_REVISION_TRAMITE_OTPI elem)
        {
            try
            {
                this._context.Entry(elem).State = System.Data.Entity.EntityState.Modified;
                this._context.SaveChanges();
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