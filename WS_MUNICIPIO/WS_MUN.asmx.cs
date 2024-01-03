using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Services;
using System.Web.Services;
using WS_MUNICIPIO.Clases;
using WS_MUNICIPIO.Models;
using WS_MUNICIPIO.Models.Bcbg;
using WS_MUNICIPIO.Repositorios;
using WS_MUNICIPIO.Repositorios.Bcbg;
using WS_MUNICIPIO.Web_Services_BCBG;

namespace WS_MUNICIPIO
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    public class WS_MUN : System.Web.Services.WebService
    {
        private const int UsuarioWeb = 82;
        Web_Services_BCBG.WebServiceEmptySoapClient proxy = null;
        M_Requisito_Tram m_Requisito_Tram = null;
        IdentityResult resultadoRequisitoWeb = null;
        
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public ResponseConsultaTramite ConsultaTramite(string num_tramite)
        {
            M_OtNotaInspeccion m_OtNotaInspeccion = new M_OtNotaInspeccion();
            M_Informe_Observacion m_Informe_Observacion = new M_Informe_Observacion();
            M_TramiteotpiWeb m_TramiteotpiWeb = new M_TramiteotpiWeb();
            //busca nota inspeccion x id tramite
            OT_NOTA_INSPECCION nti = new OT_NOTA_INSPECCION();
            OT_INFORME_OBSERVACION nto = new OT_INFORME_OBSERVACION();
            ResponseConsultaTramite resul = new ResponseConsultaTramite();
            var tramite = m_TramiteotpiWeb.FindXNumeroTram(num_tramite);
            nti = m_OtNotaInspeccion.BuscaUltimaObservacionXTramite(tramite.TRW_ID);
            //nti = m_OtNotaInspeccion.FindXIDTramite(tramite.TRW_ID);
            LoggerFile.WriteLogger("CONSULTA. TRAMITE WEB ID: " + tramite.TRW_ID + " NUMERO:" + num_tramite);
            if (nti != null)
            {
                nto = m_Informe_Observacion.FindById(nti.NTI_OBSERVACION);
                if (nto != null)
                {
                    resul.estado = nto.IOB_DESCRIPCION;
                    resul.observacion = nti.NTI_DESCRIPCION.ToUpper();
                    resul.mensaje = "Consulta OK";
                    LoggerFile.WriteLogger("CONSULTA. TRAMITE WEB : " + tramite.TRW_ID + ". CONSULTA OK. ESTADO:" + nto.IOB_DESCRIPCION + "\n\n");

                }
                else
                {
                    resul.estado = "";
                    resul.mensaje = "Falló Consulta";
                    LoggerFile.WriteLogger("CONSULTA. TRAMITE WEB : " + tramite.TRW_ID + ". FALLO EN LA CONSULTA, NO SE ENCONTRO OT_INFORME_OBSERVACION \n\n");

                }
            }
            else
            {
                resul.estado = "";
                resul.mensaje = "Falló Consulta";
                LoggerFile.WriteLogger("CONSULTA. TRAMITE WEB : " + tramite.TRW_ID + ". FALLO EN LA CONSULTA ERROR INTERNO \n\n");

            }
            return resul;
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public List<ParroquiaEntidad> ObtenerParroquias()
        {
            List<ParroquiaEntidad> lista_r = new List<ParroquiaEntidad>();
            M_Parroquia m_Parroquia = new M_Parroquia();    
            lista_r = m_Parroquia.GetListadoParroquias();
            return lista_r;
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public List<SectorEntidad> ObtenerSectorxParroquia(int id_parroquia)
        {
            List<SectorEntidad> lista_r = new List<SectorEntidad>();
            M_Sector m_Sector = new M_Sector();
            lista_r = m_Sector.GetListadoSectorXParroquia(id_parroquia);
            return lista_r;
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public ResponseTramiteNuevo ActualizarTramite(TramiteActualiza modelo, string numero_tramite)
        {
            proxy = new WebServiceEmptySoapClient();

            ResponseTramiteNuevo resul = new ResponseTramiteNuevo();
            M_TramiteotpiWeb m_TramiteotpiWeb = new M_TramiteotpiWeb();
            M_Contribuyente m_Contribuyente = new M_Contribuyente();
            M_Establecimiento m_Establecimiento = new M_Establecimiento();
            M_Rev_Tram_OTPI m_Rev_Tram_OTPI = new M_Rev_Tram_OTPI();
            M_Requisito_Tram m_Requisito = new M_Requisito_Tram();
            M_Parametros m_Parametros = new M_Parametros();
            M_Parametros m_Parametros1 = new M_Parametros();
            M_Parametros m_Parametros2 = new M_Parametros();
            M_Parametros m_Parametros3 = new M_Parametros();
            M_Parametros m_Parametros4 = new M_Parametros();
            M_InformeObservacion m_InformeObservacion = new M_InformeObservacion();
            M_OtNotaInspeccion n_OtNotaInspeccion = new M_OtNotaInspeccion();

            string parametroUrl = "";
            string texto_desc = "";
            string contenido_mensaje_tramiteAprobada = "";
            string asunto_mail = "";

            M_Sector m_Sector = new M_Sector();
            string correoBomberos = "";

            var tramite = m_TramiteotpiWeb.FindXNumeroTram(numero_tramite);
            if (tramite != null && tramite.TRW_ESTADO_TRAMITE_ID!=2)
            {
                LoggerFile.WriteLogger("SE BUSCO CORRECTAMENTE EL TRAMITE CON NUMERO: "+numero_tramite+".");

                string direccion_completa = "";
                direccion_completa = modelo.direccion;
                //busca id_contribuyente
                var id_ctb = m_Contribuyente.ObtenerIDXRuc(modelo.ruc_contribuyente);
                if (id_ctb == 0)
                {
                    resul.codigo = "101";
                    resul.mensaje = "Ocurrio un problema con el RUC del contribuyente, por favor verifique.";
                    return resul;
                }
                var id_parroquia = m_Sector.ObtenerParroquiaXSector(modelo.sector_id);
                correoBomberos = ConfigurationManager.AppSettings["ERP_MAIL"].ToString();
                var RegEstablecimeinto = m_Establecimiento.FindRegEstablecimientoWebById(tramite.TRW_REG_ID);
                RegEstablecimeinto.REST_CONTRIBUYENTE = id_ctb;
                RegEstablecimeinto.REST_CODIGO_SRI = modelo.codigo_sri;
                RegEstablecimeinto.REST_NOMBRE_COMERCIAL = string.IsNullOrEmpty(modelo.nombre_comercial) == true ? "" : modelo.nombre_comercial.ToUpper();
                RegEstablecimeinto.REST_ACTIVIDAD_SRI = string.IsNullOrEmpty(modelo.actividad_sri) == true ? "" : modelo.actividad_sri.ToUpper();
                RegEstablecimeinto.REST_DIRECCION = direccion_completa.ToUpper();
                RegEstablecimeinto.REST_PARROQUIA_ID = id_parroquia;
                RegEstablecimeinto.REST_SECTOR = modelo.sector_id;
                RegEstablecimeinto.REST_AREA = modelo.area;
                RegEstablecimeinto.REST_REF_UBIC = string.IsNullOrEmpty(modelo.ubicacion_referencia) == true ? "" : modelo.ubicacion_referencia.ToUpper();
                RegEstablecimeinto.REST_USU_MOD = UsuarioWeb;
                RegEstablecimeinto.REST_FEC_MOD = DateTime.Now;
                RegEstablecimeinto.REST_ACTIVO = true;
                RegEstablecimeinto.REST_ELIMINADO = false;
                RegEstablecimeinto.REST_LATITUD = "";
                RegEstablecimeinto.REST_LONGITUD = "";
                RegEstablecimeinto.REST_CATASTRO_MUN = modelo.catastro;
                var ActualizaRegEstablecimiento = m_Establecimiento.UpdateRegistroEstablecimiento(RegEstablecimeinto);
                if (!ActualizaRegEstablecimiento.Succeeded)
                {
                    LoggerFile.WriteLogger("OCURRIO UN ERROR AL ACTUALIZAR EL REGISTRO ESTABLECIMIENTO WEB. NUMERO TRAMITE: " + numero_tramite + "\n");
                    resul.codigo = "-1";
                    resul.mensaje = "OCURRIO UN ERROR AL ACTUALIZAR EL REGISTRO ESTABLECIMIENTO.";
                    return resul;
                }
                //actualiza OT_REVISION_TRAMITE_OTPI
                var list_revision_tramite = m_Rev_Tram_OTPI.FindByIdTramite(tramite.TRW_ID);
                foreach(var elem in list_revision_tramite)
                {
                    elem.REV_LISTADO_REV_VALOR = true;
                    elem.REV_FEC_MOD = DateTime.Now;
                    elem.REV_USUARIO_MOD = UsuarioWeb;
                    m_Rev_Tram_OTPI.Update(elem);
                }
                //actualiza OT_REQUISITO_TRAMITE_WEB eliminando los documentos
                var list_requiisito_tram = m_Requisito.FindByIdTramite(tramite.TRW_ID);
                foreach (var elem in list_requiisito_tram)
                {
                    elem.REQ_ESTADO = "I";
                    elem.REQ_REVISION = false;
                    elem.REQ_FEC_MOD = DateTime.Now;
                    elem.REQ_USU_MOD = UsuarioWeb;
                    elem.REQ_ELIMINADO = true;
                    m_Requisito.Update(elem);
                }
                tramite.TRW_ESTADO_TRAMITE_ID = 2;//Ingresado
                tramite.TRW_FEC_MOD = DateTime.Now;
                tramite.TRW_USUARIO_MOD = UsuarioWeb;
                //actualiza Tramite
                var ActualizaTramiteWeb = m_TramiteotpiWeb.Update(tramite);
                if (!ActualizaTramiteWeb.Succeeded)
                {
                    LoggerFile.WriteLogger("OCURRIO UN ERROR AL ACTUALIZAR EL REGISTRO ESTABLECIMIENTO WEB. NUMERO TRAMITE: " + numero_tramite + "\n");
                    resul.codigo = "-1";
                    resul.mensaje = "OCURRIO UN ERROR AL ACTUALIZAR EL REGISTRO ESTABLECIMIENTO.";
                    return resul;
                }
                //actualiza documentos

                int result_archivos = 0;
                string root = ConfigurationManager.AppSettings["DocumentosOTPI"].ToString();
                root = root + "/" + Convert.ToString(DateTime.Now.Year);
                // Guardamos los documentos                    
                if (modelo.f_ced_vota != null)
                {
                    result_archivos = GuardarArchivos(tramite.TRW_ID, "CED_VOTACION", modelo.f_ced_vota, root);//CEDULA y papel de votacion
                    if (result_archivos == -1)
                    {
                        resul.codigo = "110";
                        resul.mensaje = "Ocurrio un problema con el envio de la CEDULA y PAPEL DE VOTACION.";
                        return resul;
                    }
                    LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + tramite.TRW_ID + ". GUARDANDO CEDULA Y PAPEL DE VOTACION");

                }
                if (modelo.f_ruc != null)
                {
                    result_archivos = GuardarArchivos(tramite.TRW_ID, "RUC", modelo.f_ruc, root);//Guarda RUC
                    if (result_archivos == -1)
                    {
                        resul.codigo = "110";
                        resul.mensaje = "Ocurrio un problema con el envio del RUC.";
                        return resul;
                    }
                    LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + tramite.TRW_ID + ". GUARDANDO RUC");

                }
                if (modelo.f_calf_artesanal != null)
                {
                    result_archivos = GuardarArchivos(tramite.TRW_ID, "CALIFICACION_ARTESANAL", modelo.f_calf_artesanal, root);//Guarda cal artesanal
                    if (result_archivos == -1)
                    {
                        resul.codigo = "110";
                        resul.mensaje = "Ocurrio un problema con el envio de la CALIFICACION ARTESANAL.";
                        return resul;
                    }
                    LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + tramite.TRW_ID + ". GUARDANDO CALIFICACION ARTESANAL");

                }
                if (modelo.f_predio != null)
                {
                    result_archivos = GuardarArchivos(tramite.TRW_ID, "PREDIO", modelo.f_predio, root);//Guarda predio
                    if (result_archivos == -1)
                    {
                        resul.codigo = "110";
                        resul.mensaje = "Ocurrio un problema con el envio del PREDIO.";
                        return resul;
                    }
                    LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + tramite.TRW_ID + ". GUARDANDO PREDIO");

                }
                string etb_id = RegEstablecimeinto.REST_ESTABLECIMIENTO.ToString();
                string codigo_sri = RegEstablecimeinto.REST_CODIGO_SRI;
                string actividad_sri = RegEstablecimeinto.REST_ACTIVIDAD_SRI;

                string mensaje_revisor = "";
                string num_orden = "";
                string ipc_numero_valor = "0";
                string idTramiteWeb = tramite.TRW_ID.ToString();
                if (ActualizaTramiteWeb.Succeeded)
                {
                    string codigoSri = "", actividad = "";
                    codigoSri = RegEstablecimeinto.REST_CODIGO_SRI;
                    actividad = string.IsNullOrEmpty(RegEstablecimeinto.REST_ACTIVIDAD_SRI) == true ? RegEstablecimeinto.REST_ACTIVIDAD_SRI : RegEstablecimeinto.REST_ACTIVIDAD_SRI;

                    Parametros server = new Parametros();
                    server = m_Parametros.FindByName("ServerWebApp2");

                    if (server != null)
                        parametroUrl = server.ValorParametro;

                    OT_INFORME_OBSERVACION informeObser = new OT_INFORME_OBSERVACION();
                    var lis_informeObser = m_InformeObservacion.FindByInformeObservacionXTipoEstado("NUEVO", "MODIFICADO");
                    if (lis_informeObser.Count() > 0)
                        informeObser = lis_informeObser.FirstOrDefault();

                    texto_desc = ReemplazarTextoVariable(informeObser.IOB_MENSAJE, "ETB_CODIGO_SRI", "ETB_ACTIVIDAD_SRI", "TRW_ID", "ETB_ID",
                    "RETW_MENSAJE_REVISOR", "ORC_NUMERO", "URL_BASE", "IPC_NUMERO", codigo_sri, actividad_sri, idTramiteWeb, etb_id, mensaje_revisor, num_orden, parametroUrl, ipc_numero_valor);


                    contenido_mensaje_tramiteAprobada = ReemplazarTextoVariable(informeObser.IOB_MENSAJE_MAIL, "ETB_CODIGO_SRI", "ETB_ACTIVIDAD_SRI", "TRW_ID", "ETB_ID",
                        "RETW_MENSAJE_REVISOR", "ORC_NUMERO", "URL_BASE", "IPC_NUMERO", codigo_sri, actividad_sri, idTramiteWeb, etb_id, mensaje_revisor, num_orden, parametroUrl, ipc_numero_valor);

                    asunto_mail = informeObser.IOB_ASUNTO_MAIL;
                    OT_NOTA_INSPECCION nota = new OT_NOTA_INSPECCION();
                    nota.NTI_DESCRIPCION = texto_desc;
                    nota.NTI_ESTABLECIMIENTO = 0;
                    nota.NTI_FECHA_CRE = DateTime.Now;
                    nota.NTI_FECHA_MOD = DateTime.Now;
                    nota.NTI_OBSERVACION = informeObser.IOB_ID; //RENOVACION SIN CAMBIOS APROBADA
                    nota.NTI_AUTOMATICO = true;
                    nota.NTI_USU_CRE = 82;
                    nota.NTI_ELIMINADO = false;
                    nota.NTI_SECUENCIAL = 0;
                    nota.NTI_TRAMITE = Convert.ToInt32(idTramiteWeb);
                    nota.NTI_FEC_CRE = DateTime.Now;

                    n_OtNotaInspeccion.Create(nota);
                    LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + ". CREANDO NOTA DE INSPECCION");


                    //await m_TramiteotpiWeb.
                    //SendMail(
                    //    "oscar_guaman@bomberosguayaquil.gob.ec"
                    //           //string.IsNullOrEmpty(contri.CTB_CORREO) ? "desarrollo@bomberosguayaquil.gob.ec" : contri.CTB_CORREO
                    //           , asunto_mail
                    //           , contenido_mensaje_tramiteAprobada, null);//correbomberos

                    LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + ". ENVIANDO MAIL" + "\n\n");

                    resul.codigo = "001";
                    resul.mensaje = "La actualizacion del tramite para el establecimiento fue un exito.";
                    resul.num_tramite = tramite.TRW_NUM_TRAMITE;
                }


            }
            else
            {
                LoggerFile.WriteLogger("SE ESCOGIO LA OPCION DE ACTUALIZAR EL TRAMITE PERO EL NUMERO DE TRAMITE NO ES CORRECTO. NUMERO TRAMITE: " + numero_tramite + "\n");
                resul.codigo = "-1";
                resul.mensaje = "EL NUMERO DE TRAMITE NO ES EL CORRECTO.";
                return resul;
            }
            return resul;

        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public ResponseTramiteNuevo TramiteNuevoMun(TramiteNuevoEst modelo)
        {
            //Comprobar si ya existe un tramite 
            
            proxy = new WebServiceEmptySoapClient();

            //var modelo = JsonConvert.DeserializeObject<TramiteNuevoEst>(json_Tramite_Nuevo);
            ResponseTramiteNuevo resul = new ResponseTramiteNuevo();
            M_Contribuyente m_Contribuyente = new M_Contribuyente();
            M_Parroquia m_Parroquia = new M_Parroquia();
            M_Establecimiento m_Establecimiento = new M_Establecimiento();
            M_Secuencia m_Secuencia = new M_Secuencia();
            M_TipoTramiteWeb m_TipoTramiteWeb = new M_TipoTramiteWeb();
            M_TramiteotpiWeb m_TramiteotpiWeb = new M_TramiteotpiWeb();
            M_InformeObservacion m_InformeObservacion = new M_InformeObservacion();
            M_OtNotaInspeccion n_OtNotaInspeccion = new M_OtNotaInspeccion();
            M_Listado_Rev_OTPI m_Listado_Rev_OTPI = new M_Listado_Rev_OTPI();
            M_Doc_Tramite_Mun m_Doc_Tramite_Mun = new M_Doc_Tramite_Mun();
            M_Rev_Tram_OTPI m_Rev_Tram_OTPI = new M_Rev_Tram_OTPI();
            M_Sector m_Sector = new M_Sector();
            //M_Requisito_Tram m_Requisito_Tram = new M_Requisito_Tram();
            M_Parametros m_Parametros = new M_Parametros();
            string correoBomberos = "";
            IdentityResult resultadoRegistroEstablecimiento = new IdentityResult();
            OT_SECUENCIA secuencia = new OT_SECUENCIA();
            IdentityResult resultadoTramiteWeb = new IdentityResult();
            //IdentityResult resultadoRequisitoWeb = new IdentityResult();
            var id_reg_estab = 0;
            string contenido_mensaje_tramiteAprobada = "";
            string asunto_mail = "";
            OT_CONTRIBUYENTE contri = new OT_CONTRIBUYENTE();
            //var correoBomberos = Configuration["Configuration_Mail"].ToString();
            int idUsuario = 100; //MUN
            OT_TRAMITEOTPI_WEB nuevoTra = new OT_TRAMITEOTPI_WEB();

            string direccion_completa = "";
            direccion_completa = modelo.direccion;
            //busca id_contribuyente
            var id_ctb = m_Contribuyente.ObtenerIDXRuc(modelo.ruc_contribuyente);
            if (id_ctb == 0)
            {
                resul.codigo = "101";
                resul.mensaje = "Ocurrio un problema con el RUC del contribuyente, por favor verifique.";
                return resul;
            }
            //var id_parroquia = m_Parroquia.ObtenerIDParroquiaXNombre(modelo.parroquia.ToUpper());
            var id_parroquia = m_Sector.ObtenerParroquiaXSector(modelo.sector_id);
            correoBomberos = ConfigurationManager.AppSettings["ERP_MAIL"].ToString();

            string idTramiteWeb = "0";

            byte[] etb_imagen_local = null;
            if (modelo.img_fachada != null)
            {
                byte[] imagenData = null;
                imagenData = Convert.FromBase64String(modelo.img_fachada);
                //modelo.ETB_IMAGEN_LOCAL = imagenData;
                etb_imagen_local = imagenData;
            }

            try
            {
                var RegEstablecimeinto = new OT_REGISTROESTABLECIMIENTO_WEB
                {
                    REST_ESTABLECIMIENTO = -1,
                    REST_CONTRIBUYENTE = id_ctb,
                    REST_CODIGO_SRI = modelo.codigo_sri,
                    REST_NOMBRE_COMERCIAL = string.IsNullOrEmpty(modelo.nombre_comercial) == true ? "" : modelo.nombre_comercial.ToUpper(),
                    REST_ACTIVIDAD_SRI = string.IsNullOrEmpty(modelo.actividad_sri) == true ? "" : modelo.actividad_sri.ToUpper(),
                    REST_DIRECCION = direccion_completa.ToUpper(),
                    REST_PARROQUIA_ID = id_parroquia,
                    REST_SECTOR = modelo.sector_id,
                    REST_BARRIO_COOPERATIVA = "",
                    REST_VIA_PRINCIPAL = "",
                    REST_VIA_SECUNDARIA = "",
                    REST_VILLA = "",
                    REST_AREA = modelo.area,
                    REST_REF_UBIC = string.IsNullOrEmpty(modelo.ubicacion_referencia) == true ? "" : modelo.ubicacion_referencia.ToUpper(),
                    REST_TELEFONOS = "",
                    REST_NOTA = "",
                    REST_USU_CRE = UsuarioWeb,
                    REST_FEC_CRE = DateTime.Now,
                    REST_ACTIVO = true,
                    REST_ELIMINADO = false,
                    REST_LATITUD = "",
                    REST_LONGITUD = "",
                    REST_IMAGEN_LOCAL = etb_imagen_local
                    //REST_ZONEPOINT = System.Data.Entity.Spatial.DbGeography.PointFromText(String.Format("POINT({0}{1})", model.ETB_LATITUD, model.ETB_LONGITUD), 4326),
                    //RestZona = System.Data.Entity.Spatial.DbGeometry.PointFromText(string.Format("POINT({0} {1})", model.ETB_LATITUD, model.ETB_LONGITUD), 4326)
                    ,
                    REST_CATASTRO_MUN = modelo.catastro
                };
                resultadoRegistroEstablecimiento = m_Establecimiento.Create(RegEstablecimeinto);
                id_reg_estab = RegEstablecimeinto.REST_ID;
                LoggerFile.WriteLogger("Creando OT_REGISTROESTABLECIMIENTO_WEB ID: " + RegEstablecimeinto.REST_ID + "\n");
                var tipoTram = m_TipoTramiteWeb.FindById(3);

                //Generamos u obtenemos la secuencia del tramite
                var COD_SECUENCIA = "TRAMITES_WEB_" + DateTime.Now.Year;
                secuencia = m_Secuencia.GetSecuenciaOrden(COD_SECUENCIA);
                if (secuencia.SEC_VALOR == -1)
                {
                    secuencia.SEC_CODIGO = COD_SECUENCIA;
                    secuencia.SEC_DESCRIPCION = "TRAMITES WEB " + DateTime.Now.Year;
                    secuencia.SEC_VALOR = ((DateTime.Now.Year) * 100000) + 1;
                    m_Secuencia.Create(secuencia);
                }

                var TramiteNew = new OT_TRAMITEOTPI_WEB
                {
                    TRW_ESTADO_TRAMITE_ID = 2,
                    TRW_TIPO_TRAMITE_ID = tipoTram.TTRA_ID, // TRÁMITE POR PRIMERA VEZ
                    TRW_NUM_TRAMITE = tipoTram.TTRA_NOMBRE + "-" + Convert.ToString(secuencia.SEC_VALOR),
                    TRW_REG_ID = RegEstablecimeinto.REST_ID,
                    TRW_FECHA_INICIO = DateTime.Now,
                    TRW_FEC_FIN = DateTime.Now,
                    TRW_ELIMINADO = false,
                    TRW_USUARIO_CREACION = UsuarioWeb,
                    TRW_FEC_CREACION = DateTime.Now,
                    TRW_ORIGEN = "MUN"
                };
                resultadoTramiteWeb = m_TramiteotpiWeb.Create(TramiteNew);
               
                idTramiteWeb = TramiteNew.TRW_ID.ToString();
                LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb);
                LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + ". NUMERO: " + TramiteNew.TRW_NUM_TRAMITE);

                //imagenes que se usaran previas a la creacion de la declaracion.
                OT_DOC_TRAMITE_MUN foto = new OT_DOC_TRAMITE_MUN();
                string anio_vigente = DateTime.Now.Year.ToString();
                string mes_vigente = DateTime.Now.Month.ToString();
                string dia_vigente = DateTime.Now.Day.ToString();

                #region guarda imagenes

                if (modelo.img_fachada != null && modelo.img_fachada.Length > 1)
                {
                    //foto fachada
                    var namefile = Guid.NewGuid();
                    var url = anio_vigente + "/" + mes_vigente + "/" + dia_vigente + "/" + "TRAMITE_WEB_" + TramiteNew.TRW_ID + "/" + TramiteNew.TRW_ID + "/" + namefile + ".jpeg";

                    foto.DTM_TRAMITE_WEB = TramiteNew.TRW_ID;
                    foto.DTM_NOMBRE = url;
                    foto.DTM_TIPO = 4;
                    foto.DTM_ESTADO = "A";
                    foto.DTM_FECHA_CRE = DateTime.Now;
                    foto.DTM_USU_CRE = idUsuario.ToString();
                    var result2 = m_Doc_Tramite_Mun.CreateAsync(foto);
                    var r = proxy.GuardarImagen(modelo.img_fachada, namefile.ToString(), ".jpeg", "TRAM_MUN", TramiteNew.TRW_ID, 0);
                    LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + " SE GUARDO LA IMAGEN DE LA FACHADA");

                }

                if (modelo.img_interna_local != null && modelo.img_interna_local.Length > 1)
                {
                    //foto interna local
                    var namefile = Guid.NewGuid();
                    var url = anio_vigente + "/" + mes_vigente + "/" + dia_vigente + "/" + "TRAMITE_WEB_" + TramiteNew.TRW_ID + "/" + TramiteNew.TRW_ID + "/" + namefile + ".jpeg";

                    foto.DTM_TRAMITE_WEB = TramiteNew.TRW_ID;
                    foto.DTM_NOMBRE = url;
                    foto.DTM_TIPO = 4;
                    foto.DTM_ESTADO = "A";
                    foto.DTM_FECHA_CRE = DateTime.Now;
                    foto.DTM_USU_CRE = idUsuario.ToString();
                    var result2 = m_Doc_Tramite_Mun.CreateAsync(foto);
                    var r = proxy.GuardarImagen(modelo.img_interna_local, namefile.ToString(), ".jpeg", "TRAM_MUN", TramiteNew.TRW_ID, 0);
                    LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + " SE GUARDO LA IMAGEN INTERNA DEL LOCAL");

                }

                if (modelo.img_extintor != null && modelo.img_extintor.Length > 1)
                {
                    //foto interna local
                    var namefile = Guid.NewGuid();
                    var url = anio_vigente + "/" + mes_vigente + "/" + dia_vigente + "/" + "TRAMITE_WEB_" + TramiteNew.TRW_ID + "/" + TramiteNew.TRW_ID + "/" + namefile + ".jpeg";

                    foto.DTM_TRAMITE_WEB = TramiteNew.TRW_ID;
                    foto.DTM_NOMBRE = url;
                    foto.DTM_TIPO = 4;
                    foto.DTM_ESTADO = "A";
                    foto.DTM_FECHA_CRE = DateTime.Now;
                    foto.DTM_USU_CRE = idUsuario.ToString();
                    var result2 = m_Doc_Tramite_Mun.CreateAsync(foto);
                    var r = proxy.GuardarImagen(modelo.img_extintor, namefile.ToString(), ".jpeg", "TRAM_MUN", TramiteNew.TRW_ID, 0);
                    LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + " SE GUARDO LA IMAGEN DEL EXTINTOR");

                }

                if (modelo.img_sticket_fecha_recarga != null && modelo.img_sticket_fecha_recarga.Length > 1)
                {
                    //foto interna local
                    var namefile = Guid.NewGuid();
                    var url = anio_vigente + "/" + mes_vigente + "/" + dia_vigente + "/" + "TRAMITE_WEB_" + TramiteNew.TRW_ID + "/" + TramiteNew.TRW_ID + "/" + namefile + ".jpeg";

                    foto.DTM_TRAMITE_WEB = TramiteNew.TRW_ID;
                    foto.DTM_NOMBRE = url;
                    foto.DTM_TIPO = 4;
                    foto.DTM_ESTADO = "A";
                    foto.DTM_FECHA_CRE = DateTime.Now;
                    foto.DTM_USU_CRE = idUsuario.ToString();
                    var result2 = m_Doc_Tramite_Mun.CreateAsync(foto);
                    var r = proxy.GuardarImagen(modelo.img_sticket_fecha_recarga, namefile.ToString(), ".jpeg", "TRAM_MUN", TramiteNew.TRW_ID, 0);
                    LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + " SE GUARDO LA IMAGEN DEL STICKER DE LA FECHA DE RECARGA");

                }

                if (modelo.img_fact_extintor_recarga != null && modelo.img_fact_extintor_recarga.Length > 1)
                {
                    //foto interna local
                    var namefile = Guid.NewGuid();
                    var url = anio_vigente + "/" + mes_vigente + "/" + dia_vigente + "/" + "TRAMITE_WEB_" + TramiteNew.TRW_ID + "/" + TramiteNew.TRW_ID + "/" + namefile + ".jpeg";

                    foto.DTM_TRAMITE_WEB = TramiteNew.TRW_ID;
                    foto.DTM_NOMBRE = url;
                    foto.DTM_TIPO = 4;
                    foto.DTM_ESTADO = "A";
                    foto.DTM_FECHA_CRE = DateTime.Now;
                    foto.DTM_USU_CRE = idUsuario.ToString();
                    var result2 = m_Doc_Tramite_Mun.CreateAsync(foto);
                    var r = proxy.GuardarImagen(modelo.img_fact_extintor_recarga, namefile.ToString(), ".jpeg", "TRAM_MUN", TramiteNew.TRW_ID, 0);
                    LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + " SE GUARDO LA IMAGEN DEL EXTINTOR CON SEÑALETICA");

                }

                #endregion

                string etb_id = RegEstablecimeinto.REST_ESTABLECIMIENTO.ToString();
                string codigo_sri = RegEstablecimeinto.REST_CODIGO_SRI;
                string actividad_sri = RegEstablecimeinto.REST_ACTIVIDAD_SRI;

                string mensaje_revisor = "";
                string num_orden = "";
                string parametroUrl = "";
                string ipc_numero_valor = "0";
                string texto_desc = "";
                if (resultadoRegistroEstablecimiento.Succeeded)
                {
                    // Actualizamos el numero de tramite
                    nuevoTra = m_TramiteotpiWeb.FindById(TramiteNew.TRW_ID);

                    List<OT_LISTADO_REV_OTPI> listadoRevision = new List<OT_LISTADO_REV_OTPI>();
                    //1 CED_VOTACION<
                    //2 PREDIO
                    //3 RUC
                    //4 CALIFICACION_ARTESANAL
                    for (int i = 1; i < 5; i++)
                    {
                        listadoRevision.Add(m_Listado_Rev_OTPI.FindById(i));
                    }
                    foreach (var data in listadoRevision)
                    {
                        OT_REVISION_TRAMITE_OTPI itemRevision = new OT_REVISION_TRAMITE_OTPI();
                        itemRevision.REV_TRAMITE_ID = TramiteNew.TRW_ID;
                        itemRevision.REV_LISTADO_REV_ID = data.LIS_ID;
                        itemRevision.REV_LISTADO_REV_VALOR = true;
                        itemRevision.REV_ESTADO = true;
                        itemRevision.REV_FEC_CREACION = DateTime.Now;
                        itemRevision.REV_ELIMINADO = false;
                        itemRevision.REV_USUARIO_CRE = UsuarioWeb;

                        m_Rev_Tram_OTPI.Create(itemRevision);
                    }
                    LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + ". CREANDO OT_REVISION_TRAMITE_OTPI");

                }
                int result_archivos = 0;
                #region GUARDAR LOS DOCUMENTOS ENVIADOS POR EL MUNICIPIO
                if (resultadoTramiteWeb.Succeeded)
                {
                    string root = ConfigurationManager.AppSettings["DocumentosOTPI"].ToString();
                    root = root + "/" + Convert.ToString(DateTime.Now.Year);
                    // Guardamos los documentos                    
                    if (modelo.f_ced_vota != null)
                    {
                        result_archivos = GuardarArchivos(nuevoTra.TRW_ID, "CED_VOTACION", modelo.f_ced_vota, root);//CEDULA y papel de votacion
                        if (result_archivos == -1)
                        {
                            resul.codigo = "110";
                            resul.mensaje = "Ocurrio un problema con el envio de la CEDULA y PAPEL DE VOTACION.";
                            return resul;
                        }
                        LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + ". GUARDANDO CEDULA Y PAPEL DE VOTACION");

                    }
                    if (modelo.f_ruc != null)
                    {
                        result_archivos = GuardarArchivos(nuevoTra.TRW_ID, "RUC", modelo.f_ruc, root);//Guarda RUC
                        if (result_archivos == -1)
                        {
                            resul.codigo = "110";
                            resul.mensaje = "Ocurrio un problema con el envio del RUC.";
                            return resul;
                        }
                        LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + ". GUARDANDO RUC");

                    }
                    if (modelo.f_calf_artesanal != null)
                    {
                        result_archivos = GuardarArchivos(nuevoTra.TRW_ID, "CALIFICACION_ARTESANAL", modelo.f_calf_artesanal, root);//Guarda cal artesanal
                        if (result_archivos == -1)
                        {
                            resul.codigo = "110";
                            resul.mensaje = "Ocurrio un problema con el envio de la CALIFICACION ARTESANAL.";
                            return resul;
                        }
                        LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + ". GUARDANDO CALIFICACION ARTESANAL");

                    }
                    if (modelo.f_predio != null)
                    {
                        result_archivos = GuardarArchivos(nuevoTra.TRW_ID, "PREDIO", modelo.f_predio, root);//Guarda predio
                        if (result_archivos == -1)
                        {
                            resul.codigo = "110";
                            resul.mensaje = "Ocurrio un problema con el envio del PREDIO.";
                            return resul;
                        }
                        LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + ". GUARDANDO PREDIO");

                    }
                }
                #endregion
                if (resultadoTramiteWeb.Succeeded)
                {
                    string codigoSri = "", actividad = "";
                    codigoSri = RegEstablecimeinto.REST_CODIGO_SRI;
                    actividad = string.IsNullOrEmpty(RegEstablecimeinto.REST_ACTIVIDAD_SRI) == true ? RegEstablecimeinto.REST_ACTIVIDAD_SRI : RegEstablecimeinto.REST_ACTIVIDAD_SRI;

                    Parametros server = new Parametros();
                    server = m_Parametros.FindByName("ServerWebApp2");

                    if (server != null)
                        parametroUrl = server.ValorParametro;

                    OT_INFORME_OBSERVACION informeObser = new OT_INFORME_OBSERVACION();
                    var lis_informeObser = m_InformeObservacion.FindByInformeObservacionXTipoEstado("NUEVO", "GENERADO");
                    if (lis_informeObser.Count() > 0)
                        informeObser = lis_informeObser.FirstOrDefault();

                    texto_desc = ReemplazarTextoVariable(informeObser.IOB_MENSAJE, "ETB_CODIGO_SRI", "ETB_ACTIVIDAD_SRI", "TRW_ID", "ETB_ID",
                    "RETW_MENSAJE_REVISOR", "ORC_NUMERO", "URL_BASE", "IPC_NUMERO", codigo_sri, actividad_sri, idTramiteWeb, etb_id, mensaje_revisor, num_orden, parametroUrl, ipc_numero_valor);


                    contenido_mensaje_tramiteAprobada = ReemplazarTextoVariable(informeObser.IOB_MENSAJE_MAIL, "ETB_CODIGO_SRI", "ETB_ACTIVIDAD_SRI", "TRW_ID", "ETB_ID",
                        "RETW_MENSAJE_REVISOR", "ORC_NUMERO", "URL_BASE", "IPC_NUMERO", codigo_sri, actividad_sri, idTramiteWeb, etb_id, mensaje_revisor, num_orden, parametroUrl, ipc_numero_valor);

                    asunto_mail = informeObser.IOB_ASUNTO_MAIL;
                    OT_NOTA_INSPECCION nota = new OT_NOTA_INSPECCION();
                    nota.NTI_DESCRIPCION = texto_desc;
                    nota.NTI_ESTABLECIMIENTO = 0;
                    nota.NTI_FECHA_CRE = DateTime.Now;
                    nota.NTI_FECHA_MOD = DateTime.Now;
                    nota.NTI_OBSERVACION = informeObser.IOB_ID; //RENOVACION SIN CAMBIOS APROBADA
                    nota.NTI_AUTOMATICO = true;
                    nota.NTI_USU_CRE = 82;
                    nota.NTI_ELIMINADO = false;
                    nota.NTI_SECUENCIAL = 0;
                    nota.NTI_TRAMITE = Convert.ToInt32(idTramiteWeb);
                    nota.NTI_FEC_CRE = DateTime.Now;

                    n_OtNotaInspeccion.Create(nota);
                    LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + ". CREANDO NOTA DE INSPECCION");


                    //await m_TramiteotpiWeb.
                    //SendMail(
                    //    "oscar_guaman@bomberosguayaquil.gob.ec"
                    //           //string.IsNullOrEmpty(contri.CTB_CORREO) ? "desarrollo@bomberosguayaquil.gob.ec" : contri.CTB_CORREO
                    //           , asunto_mail
                    //           , contenido_mensaje_tramiteAprobada, null);//correbomberos

                    LoggerFile.WriteLogger("TRAMITE WEB ID_TRAMITE_WEB : " + idTramiteWeb + ". ENVIANDO MAIL" + "\n\n");

                    resul.codigo = "001";
                    resul.mensaje = "La creacion del tramite para el establecimiento fue un exito";
                    resul.num_tramite = nuevoTra.TRW_NUM_TRAMITE;
                }

            }
            catch (Exception e)
            {
                if (resultadoRegistroEstablecimiento.Succeeded)
                {
                    var reg_estab = m_Establecimiento.FindRegEstablecimientoWebById(id_reg_estab);
                    reg_estab.REST_ELIMINADO = true;
                    reg_estab.REST_ACTIVO = false;
                    m_Establecimiento.UpdateRegistroEstablecimiento(reg_estab);


                }
                if (resultadoTramiteWeb.Succeeded || resultadoTramiteWeb != null)
                {
                    var tram = m_TramiteotpiWeb.FindById(Int32.Parse(idTramiteWeb));
                    tram.TRW_ELIMINADO = true;
                    m_TramiteotpiWeb.Update(tram);

                }
                resul.codigo = e.Source;
                resul.mensaje = e.Message.ToString();
                LoggerFile.WriteLogger("ERROR: SE CREO UN ERROR AL CREAR UN ESTABLECIMIENTO:'" + e.Message.ToString() + "'\n\n");

            }

            return resul;
        }

        private int GuardarArchivos(int id_tramite, string tipo_archivo, string s_archivo, string root)
        {
            m_Requisito_Tram = new M_Requisito_Tram();
            resultadoRequisitoWeb = new IdentityResult();
            OT_REQUISITO_TRAMITE_WEB doc = new OT_REQUISITO_TRAMITE_WEB();
            doc.REQ_TIPO = tipo_archivo;
            doc.REQ_TIPO_DOC = "PDF";
            doc.REQ_TRAMITEID = id_tramite;
            doc.REQ_RUTA = "-";
            doc.REQ_NOMBRE = "tmp";
            doc.REQ_ESTADO = "A";
            doc.REQ_FEC_CRE = DateTime.Now;
            doc.REQ_USU_CRE = UsuarioWeb;
            doc.REQ_ELIMINADO = false;
            doc.REQ_REVISION = true;
            resultadoRequisitoWeb = m_Requisito_Tram.Create(doc);
            var namefile = doc.REQ_ID + "_BCBG_" + doc.REQ_TIPO + ".pdf";
            OT_REQUISITO_TRAMITE_WEB nuevoIng = new OT_REQUISITO_TRAMITE_WEB();
            nuevoIng = m_Requisito_Tram.FindById(doc.REQ_ID);
            nuevoIng.REQ_NOMBRE = namefile;
            nuevoIng.REQ_RUTA = Convert.ToString(DateTime.Now.Year) + "/" + id_tramite + "/" + namefile;
            var actualizo = m_Requisito_Tram.Update(nuevoIng);
            if (!actualizo.Succeeded)
            {
                nuevoIng = m_Requisito_Tram.FindById(doc.REQ_ID);
                nuevoIng.REQ_ESTADO = "I";
                m_Requisito_Tram.Update(nuevoIng);
                return -1;
            }
            proxy.GuardarPDFGenerico(root, s_archivo, doc.REQ_ID + "_BCBG_" + doc.REQ_TIPO, ".pdf", id_tramite);
            return 0;

        }

        public string ReemplazarTextoVariable(string mensaje, string ETB_CODIGO_SRI, string ETB_ACTIVIDAD_SRI,
            string TRW_ID, string ETB_ID, string RETW_MENSAJE_REVISOR, string ORC_NUMERO, string URL_BASE, string IPC_NUMERO,
            string ETB_CODIGO_SRI_valor, string ETB_ACTIVIDAD_SRI_valor,
            string TRW_ID_valor, string ETB_ID_valor, string RETW_MENSAJE_REVISOR_valor, string num_orden, string parametro_urlBase, string ipc_numero_valor)
        {
            string mensaje1 = mensaje;
            if (!string.IsNullOrEmpty(ETB_CODIGO_SRI_valor))
                mensaje1 = mensaje1.Replace("{" + ETB_CODIGO_SRI + "}", ETB_CODIGO_SRI_valor);

            if (!string.IsNullOrEmpty(ETB_ACTIVIDAD_SRI_valor))
                mensaje1 = mensaje1.Replace("{" + ETB_ACTIVIDAD_SRI + "}", ETB_ACTIVIDAD_SRI_valor);

            if (!string.IsNullOrEmpty(TRW_ID_valor))
                mensaje1 = mensaje1.Replace("{" + TRW_ID + "}", TRW_ID_valor);

            if (!string.IsNullOrEmpty(ETB_ID_valor))
                mensaje1 = mensaje1.Replace("{" + ETB_ID + "}", ETB_ID_valor);

            if (!string.IsNullOrEmpty(RETW_MENSAJE_REVISOR_valor))
                mensaje1 = mensaje1.Replace("{" + RETW_MENSAJE_REVISOR + "}", RETW_MENSAJE_REVISOR_valor);

            if (!string.IsNullOrEmpty(num_orden))
                mensaje1 = mensaje1.Replace("{" + ORC_NUMERO + "}", num_orden);

            if (!string.IsNullOrEmpty(parametro_urlBase))
                mensaje1 = mensaje1.Replace("{" + URL_BASE + "}", parametro_urlBase);

            if (!string.IsNullOrEmpty(ipc_numero_valor))
                mensaje1 = mensaje1.Replace("{" + IPC_NUMERO + "}", ipc_numero_valor);

            return mensaje1;
        }

    }
}
