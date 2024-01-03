using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WS_MUNICIPIO.Models.Bcbg
{
    public partial class Db_Context_Bcbg : DbContext
    {
        public Db_Context_Bcbg()
            : base("name=Db_Context_Bcbg")
        {
        }

        public virtual DbSet<Parametros> Parametros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
