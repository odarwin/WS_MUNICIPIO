using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WS_MUNICIPIO.Models
{
    public partial class Db_Context_Prevencion : DbContext
    {
        public Db_Context_Prevencion()
            : base("name=Db_Context_Prevencion")
        {
        }
        public virtual DbSet<OT_DOC_TRAMITE_MUN> OT_DOC_TRAMITE_MUN { get; set; }
        public virtual DbSet<OT_CONTRIBUYENTE> OT_CONTRIBUYENTE { get; set; }
        public virtual DbSet<OT_ESTABLECIMIENTO> OT_ESTABLECIMIENTO { get; set; }
        public virtual DbSet<OT_INFORME_OBSERVACION> OT_INFORME_OBSERVACION { get; set; }
        public virtual DbSet<OT_LISTADO_REV_OTPI> OT_LISTADO_REV_OTPI { get; set; }
        public virtual DbSet<OT_NOTA_INSPECCION> OT_NOTA_INSPECCION { get; set; }
        public virtual DbSet<OT_PARROQUIA> OT_PARROQUIA { get; set; }
        public virtual DbSet<OT_REGISTROESTABLECIMIENTO_WEB> OT_REGISTROESTABLECIMIENTO_WEB { get; set; }
        public virtual DbSet<OT_REQUISITO_TRAMITE_WEB> OT_REQUISITO_TRAMITE_WEB { get; set; }
        public virtual DbSet<OT_REVISION_TRAMITE_OTPI> OT_REVISION_TRAMITE_OTPI { get; set; }
        public virtual DbSet<OT_SECUENCIA> OT_SECUENCIA { get; set; }
        public virtual DbSet<OT_TIPO_TRAMITE_WEB> OT_TIPO_TRAMITE_WEB { get; set; }
        public virtual DbSet<OT_TRAMITEOTPI_WEB> OT_TRAMITEOTPI_WEB { get; set; }

        public virtual DbSet<OT_SECTOR> OT_SECTOR { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OT_DOC_TRAMITE_MUN>()
                .Property(e => e.DTM_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<OT_DOC_TRAMITE_MUN>()
                .Property(e => e.DTM_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<OT_DOC_TRAMITE_MUN>()
                .Property(e => e.DTM_TIPO_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<OT_DOC_TRAMITE_MUN>()
                .Property(e => e.DTM_USU_CRE)
                .IsUnicode(false);

            modelBuilder.Entity<OT_DOC_TRAMITE_MUN>()
                .Property(e => e.DTM_USU_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<OT_CONTRIBUYENTE>()
                .Property(e => e.CTB_CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OT_CONTRIBUYENTE>()
                .Property(e => e.CTB_TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OT_CONTRIBUYENTE>()
                .Property(e => e.CTB_RUC)
                .IsUnicode(false);

            modelBuilder.Entity<OT_CONTRIBUYENTE>()
                .Property(e => e.CTB_RAZON_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<OT_CONTRIBUYENTE>()
                .Property(e => e.CTB_REP_LEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<OT_CONTRIBUYENTE>()
                .Property(e => e.CTB_DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<OT_CONTRIBUYENTE>()
                .Property(e => e.CTB_TELEFONOS)
                .IsUnicode(false);

            modelBuilder.Entity<OT_CONTRIBUYENTE>()
                .Property(e => e.CTB_NOTA)
                .IsUnicode(false);

            modelBuilder.Entity<OT_CONTRIBUYENTE>()
                .Property(e => e.CTB_CORREO)
                .IsUnicode(false);

            modelBuilder.Entity<OT_CONTRIBUYENTE>()
                .Property(e => e.CTB_TELEF_CONVENC)
                .IsUnicode(false);

            modelBuilder.Entity<OT_CONTRIBUYENTE>()
                .Property(e => e.CTB_CEDULA_REP_LEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_CODIGO_SRI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_NOMBRE_COMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_REF_UBIC)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_TELEFONOS)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_NOTA)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_TIPO_DOC_BAJA)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_NUM_DOC_BAJA)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_ORDEN_BAJA)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_CATASTRO)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_CERTIF_SEGURIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_LATITUD)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_LONGITUD)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_REFER_SITIO)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_SERIEMEDIDORES)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_REFER_SITIO2)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_MOTIVOCESE)
                .IsUnicode(false);

            modelBuilder.Entity<OT_ESTABLECIMIENTO>()
                .Property(e => e.ETB_TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<OT_INFORME_OBSERVACION>()
                .Property(e => e.IOB_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<OT_INFORME_OBSERVACION>()
                .Property(e => e.IOB_ASUNTO_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<OT_INFORME_OBSERVACION>()
                .Property(e => e.IOB_MENSAJE)
                .IsUnicode(false);

            modelBuilder.Entity<OT_INFORME_OBSERVACION>()
                .Property(e => e.IOB_MENSAJE_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<OT_INFORME_OBSERVACION>()
                .Property(e => e.IOB_SISTEMA)
                .IsUnicode(false);

            modelBuilder.Entity<OT_INFORME_OBSERVACION>()
                .Property(e => e.IOB_TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<OT_INFORME_OBSERVACION>()
                .Property(e => e.IOB_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<OT_LISTADO_REV_OTPI>()
                .Property(e => e.LIS_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<OT_LISTADO_REV_OTPI>()
                .Property(e => e.LIS_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<OT_LISTADO_REV_OTPI>()
                .HasMany(e => e.OT_REVISION_TRAMITE_OTPI)
                .WithRequired(e => e.OT_LISTADO_REV_OTPI)
                .HasForeignKey(e => e.REV_LISTADO_REV_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OT_PARROQUIA>()
                .Property(e => e.PAR_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<OT_REGISTROESTABLECIMIENTO_WEB>()
                .Property(e => e.REST_CODIGO_SRI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OT_REGISTROESTABLECIMIENTO_WEB>()
                .Property(e => e.REST_NOMBRE_COMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<OT_REGISTROESTABLECIMIENTO_WEB>()
                .Property(e => e.REST_DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<OT_REGISTROESTABLECIMIENTO_WEB>()
                .Property(e => e.REST_REF_UBIC)
                .IsUnicode(false);

            modelBuilder.Entity<OT_REGISTROESTABLECIMIENTO_WEB>()
                .Property(e => e.REST_TELEFONOS)
                .IsUnicode(false);

            modelBuilder.Entity<OT_REGISTROESTABLECIMIENTO_WEB>()
                .Property(e => e.REST_NOTA)
                .IsUnicode(false);

            modelBuilder.Entity<OT_REGISTROESTABLECIMIENTO_WEB>()
                .Property(e => e.REST_LATITUD)
                .IsUnicode(false);

            modelBuilder.Entity<OT_REGISTROESTABLECIMIENTO_WEB>()
                .Property(e => e.REST_LONGITUD)
                .IsUnicode(false);

            modelBuilder.Entity<OT_REGISTROESTABLECIMIENTO_WEB>()
                .Property(e => e.REST_REFER_SITIO)
                .IsUnicode(false);

            modelBuilder.Entity<OT_REGISTROESTABLECIMIENTO_WEB>()
                .Property(e => e.REST_REFER_SITIO2)
                .IsUnicode(false);

            modelBuilder.Entity<OT_REGISTROESTABLECIMIENTO_WEB>()
                .HasMany(e => e.OT_TRAMITEOTPI_WEB)
                .WithRequired(e => e.OT_REGISTROESTABLECIMIENTO_WEB)
                .HasForeignKey(e => e.TRW_REG_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OT_REQUISITO_TRAMITE_WEB>()
                .Property(e => e.REQ_TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<OT_REQUISITO_TRAMITE_WEB>()
                .Property(e => e.REQ_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<OT_REQUISITO_TRAMITE_WEB>()
                .Property(e => e.REQ_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<OT_REQUISITO_TRAMITE_WEB>()
                .Property(e => e.REQ_TIPO_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<OT_REQUISITO_TRAMITE_WEB>()
                .Property(e => e.REQ_RUTA)
                .IsUnicode(false);

            modelBuilder.Entity<OT_SECUENCIA>()
                .Property(e => e.SEC_CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OT_SECUENCIA>()
                .Property(e => e.SEC_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<OT_TIPO_TRAMITE_WEB>()
                .Property(e => e.TTRA_NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<OT_TIPO_TRAMITE_WEB>()
                .Property(e => e.TTRA_DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<OT_TIPO_TRAMITE_WEB>()
                .HasMany(e => e.OT_TRAMITEOTPI_WEB)
                .WithRequired(e => e.OT_TIPO_TRAMITE_WEB)
                .HasForeignKey(e => e.TRW_TIPO_TRAMITE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OT_TRAMITEOTPI_WEB>()
                .Property(e => e.TRW_NUM_TRAMITE)
                .IsUnicode(false);

            modelBuilder.Entity<OT_TRAMITEOTPI_WEB>()
                .Property(e => e.TRW_ORIGEN)
                .IsUnicode(false);

            modelBuilder.Entity<OT_TRAMITEOTPI_WEB>()
                .HasMany(e => e.OT_REQUISITO_TRAMITE_WEB)
                .WithRequired(e => e.OT_TRAMITEOTPI_WEB)
                .HasForeignKey(e => e.REQ_TRAMITEID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OT_TRAMITEOTPI_WEB>()
                .HasMany(e => e.OT_REVISION_TRAMITE_OTPI)
                .WithRequired(e => e.OT_TRAMITEOTPI_WEB)
                .HasForeignKey(e => e.REV_TRAMITE_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
