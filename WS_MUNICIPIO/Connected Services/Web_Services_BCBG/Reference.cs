﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS_MUNICIPIO.Web_Services_BCBG {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Web_Services_BCBG.WebServiceEmptySoap")]
    public interface WebServiceEmptySoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenTalentoHumano", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarImagenTalentoHumano(string image, string imagename, string ext, int idrecurso_humano);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenTalentoHumano", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarImagenTalentoHumanoAsync(string image, string imagename, string ext, int idrecurso_humano);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenPublicaciones", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarImagenPublicaciones(string image, string imagename, string ext, int idPublicacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenPublicaciones", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarImagenPublicacionesAsync(string image, string imagename, string ext, int idPublicacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenEmergencias", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarImagenEmergencias(string image, string imagename, string ext, string idEmergencia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenEmergencias", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarImagenEmergenciasAsync(string image, string imagename, string ext, string idEmergencia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenInspecciones", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarImagenInspecciones(string image, string imagename, string ext);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenInspecciones", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarImagenInspeccionesAsync(string image, string imagename, string ext);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenFichaVoluntario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarImagenFichaVoluntario(string image, string imagename, string ext, string CurseName, int idVoluntario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenFichaVoluntario", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarImagenFichaVoluntarioAsync(string image, string imagename, string ext, string CurseName, int idVoluntario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarPDFGenerico", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarPDFGenerico(string pathPrincipal, string image, string docname, string ext, int key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarPDFGenerico", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarPDFGenericoAsync(string pathPrincipal, string image, string docname, string ext, int key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarArchivosDIP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarArchivosDIP(string pathPrincipal, string file_name, string contenido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarArchivosDIP", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarArchivosDIPAsync(string pathPrincipal, string file_name, string contenido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarPDFProcedimientos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarPDFProcedimientos(string image, string imagename, string ext, int idProcedimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarPDFProcedimientos", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarPDFProcedimientosAsync(string image, string imagename, string ext, int idProcedimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarFileTemp", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarFileTemp(string image, string imagename, string ext, int key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarFileTemp", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarFileTempAsync(string image, string imagename, string ext, int key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenProcedimientos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarImagenProcedimientos(string image, string imagename, string ext, int idProcedimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenProcedimientos", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarImagenProcedimientosAsync(string image, string imagename, string ext, int idProcedimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenFormulariosFSO", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarImagenFormulariosFSO(string image, string imagename, string ext, int idFormulario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenFormulariosFSO", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarImagenFormulariosFSOAsync(string image, string imagename, string ext, int idFormulario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenFormulariosArch", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarImagenFormulariosArch(string image, string imagename, string ext, int idFormulario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenFormulariosArch", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarImagenFormulariosArchAsync(string image, string imagename, string ext, int idFormulario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagen", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarImagen(string image, string imagename, string ext, string TipoDoc, int idEstablecimiento, int IdDeclaracion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagen", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarImagenAsync(string image, string imagename, string ext, string TipoDoc, int idEstablecimiento, int IdDeclaracion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarPDFEstablecimientos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarPDFEstablecimientos(string image, string imagename, string dir_anio, string dir_mes, string dir_dia, string ext, string TipoDoc, int idEstablecimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarPDFEstablecimientos", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarPDFEstablecimientosAsync(string image, string imagename, string dir_anio, string dir_mes, string dir_dia, string ext, string TipoDoc, int idEstablecimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenXModificacion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GuardarImagenXModificacion(string image, string imagename, string dir_anio, string dir_mes, string dir_dia, string ext, string TipoDoc, int idEstablecimiento, int IdDeclaracion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GuardarImagenXModificacion", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GuardarImagenXModificacionAsync(string image, string imagename, string dir_anio, string dir_mes, string dir_dia, string ext, string TipoDoc, int idEstablecimiento, int IdDeclaracion);
        
        // CODEGEN: El parámetro 'DownloadFileResult' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DownloadFile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WS_MUNICIPIO.Web_Services_BCBG.DownloadFileResponse DownloadFile(WS_MUNICIPIO.Web_Services_BCBG.DownloadFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DownloadFile", ReplyAction="*")]
        System.Threading.Tasks.Task<WS_MUNICIPIO.Web_Services_BCBG.DownloadFileResponse> DownloadFileAsync(WS_MUNICIPIO.Web_Services_BCBG.DownloadFileRequest request);
        
        // CODEGEN: El parámetro 'DownloadFileGenericoResult' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DownloadFileGenerico", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WS_MUNICIPIO.Web_Services_BCBG.DownloadFileGenericoResponse DownloadFileGenerico(WS_MUNICIPIO.Web_Services_BCBG.DownloadFileGenericoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DownloadFileGenerico", ReplyAction="*")]
        System.Threading.Tasks.Task<WS_MUNICIPIO.Web_Services_BCBG.DownloadFileGenericoResponse> DownloadFileGenericoAsync(WS_MUNICIPIO.Web_Services_BCBG.DownloadFileGenericoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetUserNameXIdPrevencion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetUserNameXIdPrevencion(int idusuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetUserNameXIdPrevencion", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetUserNameXIdPrevencionAsync(int idusuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIdUsuarioPrevencion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] GetIdUsuarioPrevencion(string cedula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIdUsuarioPrevencion", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> GetIdUsuarioPrevencionAsync(string cedula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizaEstadoOrdenCompra", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool ActualizaEstadoOrdenCompra(int num_orden, string new_estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizaEstadoOrdenCompra", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ActualizaEstadoOrdenCompraAsync(int num_orden, string new_estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsPerfilVoluntario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool ConsPerfilVoluntario(string cedula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsPerfilVoluntario", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ConsPerfilVoluntarioAsync(string cedula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GenerarDirectorio", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool GenerarDirectorio(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GenerarDirectorio", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> GenerarDirectorioAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CopiarContenidoDirectorio", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool CopiarContenidoDirectorio(string sourceFile, string destFile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CopiarContenidoDirectorio", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> CopiarContenidoDirectorioAsync(string sourceFile, string destFile);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DownloadFile", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DownloadFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string FName;
        
        public DownloadFileRequest() {
        }
        
        public DownloadFileRequest(string FName) {
            this.FName = FName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DownloadFileResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DownloadFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] DownloadFileResult;
        
        public DownloadFileResponse() {
        }
        
        public DownloadFileResponse(byte[] DownloadFileResult) {
            this.DownloadFileResult = DownloadFileResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DownloadFileGenerico", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DownloadFileGenericoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string FName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string NameApp;
        
        public DownloadFileGenericoRequest() {
        }
        
        public DownloadFileGenericoRequest(string FName, string NameApp) {
            this.FName = FName;
            this.NameApp = NameApp;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DownloadFileGenericoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DownloadFileGenericoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] DownloadFileGenericoResult;
        
        public DownloadFileGenericoResponse() {
        }
        
        public DownloadFileGenericoResponse(byte[] DownloadFileGenericoResult) {
            this.DownloadFileGenericoResult = DownloadFileGenericoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceEmptySoapChannel : WS_MUNICIPIO.Web_Services_BCBG.WebServiceEmptySoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceEmptySoapClient : System.ServiceModel.ClientBase<WS_MUNICIPIO.Web_Services_BCBG.WebServiceEmptySoap>, WS_MUNICIPIO.Web_Services_BCBG.WebServiceEmptySoap {
        
        public WebServiceEmptySoapClient() {
        }
        
        public WebServiceEmptySoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceEmptySoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceEmptySoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceEmptySoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public string GuardarImagenTalentoHumano(string image, string imagename, string ext, int idrecurso_humano) {
            return base.Channel.GuardarImagenTalentoHumano(image, imagename, ext, idrecurso_humano);
        }
        
        public System.Threading.Tasks.Task<string> GuardarImagenTalentoHumanoAsync(string image, string imagename, string ext, int idrecurso_humano) {
            return base.Channel.GuardarImagenTalentoHumanoAsync(image, imagename, ext, idrecurso_humano);
        }
        
        public string GuardarImagenPublicaciones(string image, string imagename, string ext, int idPublicacion) {
            return base.Channel.GuardarImagenPublicaciones(image, imagename, ext, idPublicacion);
        }
        
        public System.Threading.Tasks.Task<string> GuardarImagenPublicacionesAsync(string image, string imagename, string ext, int idPublicacion) {
            return base.Channel.GuardarImagenPublicacionesAsync(image, imagename, ext, idPublicacion);
        }
        
        public string GuardarImagenEmergencias(string image, string imagename, string ext, string idEmergencia) {
            return base.Channel.GuardarImagenEmergencias(image, imagename, ext, idEmergencia);
        }
        
        public System.Threading.Tasks.Task<string> GuardarImagenEmergenciasAsync(string image, string imagename, string ext, string idEmergencia) {
            return base.Channel.GuardarImagenEmergenciasAsync(image, imagename, ext, idEmergencia);
        }
        
        public string GuardarImagenInspecciones(string image, string imagename, string ext) {
            return base.Channel.GuardarImagenInspecciones(image, imagename, ext);
        }
        
        public System.Threading.Tasks.Task<string> GuardarImagenInspeccionesAsync(string image, string imagename, string ext) {
            return base.Channel.GuardarImagenInspeccionesAsync(image, imagename, ext);
        }
        
        public string GuardarImagenFichaVoluntario(string image, string imagename, string ext, string CurseName, int idVoluntario) {
            return base.Channel.GuardarImagenFichaVoluntario(image, imagename, ext, CurseName, idVoluntario);
        }
        
        public System.Threading.Tasks.Task<string> GuardarImagenFichaVoluntarioAsync(string image, string imagename, string ext, string CurseName, int idVoluntario) {
            return base.Channel.GuardarImagenFichaVoluntarioAsync(image, imagename, ext, CurseName, idVoluntario);
        }
        
        public string GuardarPDFGenerico(string pathPrincipal, string image, string docname, string ext, int key) {
            return base.Channel.GuardarPDFGenerico(pathPrincipal, image, docname, ext, key);
        }
        
        public System.Threading.Tasks.Task<string> GuardarPDFGenericoAsync(string pathPrincipal, string image, string docname, string ext, int key) {
            return base.Channel.GuardarPDFGenericoAsync(pathPrincipal, image, docname, ext, key);
        }
        
        public string GuardarArchivosDIP(string pathPrincipal, string file_name, string contenido) {
            return base.Channel.GuardarArchivosDIP(pathPrincipal, file_name, contenido);
        }
        
        public System.Threading.Tasks.Task<string> GuardarArchivosDIPAsync(string pathPrincipal, string file_name, string contenido) {
            return base.Channel.GuardarArchivosDIPAsync(pathPrincipal, file_name, contenido);
        }
        
        public string GuardarPDFProcedimientos(string image, string imagename, string ext, int idProcedimiento) {
            return base.Channel.GuardarPDFProcedimientos(image, imagename, ext, idProcedimiento);
        }
        
        public System.Threading.Tasks.Task<string> GuardarPDFProcedimientosAsync(string image, string imagename, string ext, int idProcedimiento) {
            return base.Channel.GuardarPDFProcedimientosAsync(image, imagename, ext, idProcedimiento);
        }
        
        public string GuardarFileTemp(string image, string imagename, string ext, int key) {
            return base.Channel.GuardarFileTemp(image, imagename, ext, key);
        }
        
        public System.Threading.Tasks.Task<string> GuardarFileTempAsync(string image, string imagename, string ext, int key) {
            return base.Channel.GuardarFileTempAsync(image, imagename, ext, key);
        }
        
        public string GuardarImagenProcedimientos(string image, string imagename, string ext, int idProcedimiento) {
            return base.Channel.GuardarImagenProcedimientos(image, imagename, ext, idProcedimiento);
        }
        
        public System.Threading.Tasks.Task<string> GuardarImagenProcedimientosAsync(string image, string imagename, string ext, int idProcedimiento) {
            return base.Channel.GuardarImagenProcedimientosAsync(image, imagename, ext, idProcedimiento);
        }
        
        public string GuardarImagenFormulariosFSO(string image, string imagename, string ext, int idFormulario) {
            return base.Channel.GuardarImagenFormulariosFSO(image, imagename, ext, idFormulario);
        }
        
        public System.Threading.Tasks.Task<string> GuardarImagenFormulariosFSOAsync(string image, string imagename, string ext, int idFormulario) {
            return base.Channel.GuardarImagenFormulariosFSOAsync(image, imagename, ext, idFormulario);
        }
        
        public string GuardarImagenFormulariosArch(string image, string imagename, string ext, int idFormulario) {
            return base.Channel.GuardarImagenFormulariosArch(image, imagename, ext, idFormulario);
        }
        
        public System.Threading.Tasks.Task<string> GuardarImagenFormulariosArchAsync(string image, string imagename, string ext, int idFormulario) {
            return base.Channel.GuardarImagenFormulariosArchAsync(image, imagename, ext, idFormulario);
        }
        
        public string GuardarImagen(string image, string imagename, string ext, string TipoDoc, int idEstablecimiento, int IdDeclaracion) {
            return base.Channel.GuardarImagen(image, imagename, ext, TipoDoc, idEstablecimiento, IdDeclaracion);
        }
        
        public System.Threading.Tasks.Task<string> GuardarImagenAsync(string image, string imagename, string ext, string TipoDoc, int idEstablecimiento, int IdDeclaracion) {
            return base.Channel.GuardarImagenAsync(image, imagename, ext, TipoDoc, idEstablecimiento, IdDeclaracion);
        }
        
        public string GuardarPDFEstablecimientos(string image, string imagename, string dir_anio, string dir_mes, string dir_dia, string ext, string TipoDoc, int idEstablecimiento) {
            return base.Channel.GuardarPDFEstablecimientos(image, imagename, dir_anio, dir_mes, dir_dia, ext, TipoDoc, idEstablecimiento);
        }
        
        public System.Threading.Tasks.Task<string> GuardarPDFEstablecimientosAsync(string image, string imagename, string dir_anio, string dir_mes, string dir_dia, string ext, string TipoDoc, int idEstablecimiento) {
            return base.Channel.GuardarPDFEstablecimientosAsync(image, imagename, dir_anio, dir_mes, dir_dia, ext, TipoDoc, idEstablecimiento);
        }
        
        public string GuardarImagenXModificacion(string image, string imagename, string dir_anio, string dir_mes, string dir_dia, string ext, string TipoDoc, int idEstablecimiento, int IdDeclaracion) {
            return base.Channel.GuardarImagenXModificacion(image, imagename, dir_anio, dir_mes, dir_dia, ext, TipoDoc, idEstablecimiento, IdDeclaracion);
        }
        
        public System.Threading.Tasks.Task<string> GuardarImagenXModificacionAsync(string image, string imagename, string dir_anio, string dir_mes, string dir_dia, string ext, string TipoDoc, int idEstablecimiento, int IdDeclaracion) {
            return base.Channel.GuardarImagenXModificacionAsync(image, imagename, dir_anio, dir_mes, dir_dia, ext, TipoDoc, idEstablecimiento, IdDeclaracion);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WS_MUNICIPIO.Web_Services_BCBG.DownloadFileResponse WS_MUNICIPIO.Web_Services_BCBG.WebServiceEmptySoap.DownloadFile(WS_MUNICIPIO.Web_Services_BCBG.DownloadFileRequest request) {
            return base.Channel.DownloadFile(request);
        }
        
        public byte[] DownloadFile(string FName) {
            WS_MUNICIPIO.Web_Services_BCBG.DownloadFileRequest inValue = new WS_MUNICIPIO.Web_Services_BCBG.DownloadFileRequest();
            inValue.FName = FName;
            WS_MUNICIPIO.Web_Services_BCBG.DownloadFileResponse retVal = ((WS_MUNICIPIO.Web_Services_BCBG.WebServiceEmptySoap)(this)).DownloadFile(inValue);
            return retVal.DownloadFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WS_MUNICIPIO.Web_Services_BCBG.DownloadFileResponse> WS_MUNICIPIO.Web_Services_BCBG.WebServiceEmptySoap.DownloadFileAsync(WS_MUNICIPIO.Web_Services_BCBG.DownloadFileRequest request) {
            return base.Channel.DownloadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<WS_MUNICIPIO.Web_Services_BCBG.DownloadFileResponse> DownloadFileAsync(string FName) {
            WS_MUNICIPIO.Web_Services_BCBG.DownloadFileRequest inValue = new WS_MUNICIPIO.Web_Services_BCBG.DownloadFileRequest();
            inValue.FName = FName;
            return ((WS_MUNICIPIO.Web_Services_BCBG.WebServiceEmptySoap)(this)).DownloadFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WS_MUNICIPIO.Web_Services_BCBG.DownloadFileGenericoResponse WS_MUNICIPIO.Web_Services_BCBG.WebServiceEmptySoap.DownloadFileGenerico(WS_MUNICIPIO.Web_Services_BCBG.DownloadFileGenericoRequest request) {
            return base.Channel.DownloadFileGenerico(request);
        }
        
        public byte[] DownloadFileGenerico(string FName, string NameApp) {
            WS_MUNICIPIO.Web_Services_BCBG.DownloadFileGenericoRequest inValue = new WS_MUNICIPIO.Web_Services_BCBG.DownloadFileGenericoRequest();
            inValue.FName = FName;
            inValue.NameApp = NameApp;
            WS_MUNICIPIO.Web_Services_BCBG.DownloadFileGenericoResponse retVal = ((WS_MUNICIPIO.Web_Services_BCBG.WebServiceEmptySoap)(this)).DownloadFileGenerico(inValue);
            return retVal.DownloadFileGenericoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WS_MUNICIPIO.Web_Services_BCBG.DownloadFileGenericoResponse> WS_MUNICIPIO.Web_Services_BCBG.WebServiceEmptySoap.DownloadFileGenericoAsync(WS_MUNICIPIO.Web_Services_BCBG.DownloadFileGenericoRequest request) {
            return base.Channel.DownloadFileGenericoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WS_MUNICIPIO.Web_Services_BCBG.DownloadFileGenericoResponse> DownloadFileGenericoAsync(string FName, string NameApp) {
            WS_MUNICIPIO.Web_Services_BCBG.DownloadFileGenericoRequest inValue = new WS_MUNICIPIO.Web_Services_BCBG.DownloadFileGenericoRequest();
            inValue.FName = FName;
            inValue.NameApp = NameApp;
            return ((WS_MUNICIPIO.Web_Services_BCBG.WebServiceEmptySoap)(this)).DownloadFileGenericoAsync(inValue);
        }
        
        public string GetUserNameXIdPrevencion(int idusuario) {
            return base.Channel.GetUserNameXIdPrevencion(idusuario);
        }
        
        public System.Threading.Tasks.Task<string> GetUserNameXIdPrevencionAsync(int idusuario) {
            return base.Channel.GetUserNameXIdPrevencionAsync(idusuario);
        }
        
        public string[] GetIdUsuarioPrevencion(string cedula) {
            return base.Channel.GetIdUsuarioPrevencion(cedula);
        }
        
        public System.Threading.Tasks.Task<string[]> GetIdUsuarioPrevencionAsync(string cedula) {
            return base.Channel.GetIdUsuarioPrevencionAsync(cedula);
        }
        
        public bool ActualizaEstadoOrdenCompra(int num_orden, string new_estado) {
            return base.Channel.ActualizaEstadoOrdenCompra(num_orden, new_estado);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizaEstadoOrdenCompraAsync(int num_orden, string new_estado) {
            return base.Channel.ActualizaEstadoOrdenCompraAsync(num_orden, new_estado);
        }
        
        public bool ConsPerfilVoluntario(string cedula) {
            return base.Channel.ConsPerfilVoluntario(cedula);
        }
        
        public System.Threading.Tasks.Task<bool> ConsPerfilVoluntarioAsync(string cedula) {
            return base.Channel.ConsPerfilVoluntarioAsync(cedula);
        }
        
        public bool GenerarDirectorio(string path) {
            return base.Channel.GenerarDirectorio(path);
        }
        
        public System.Threading.Tasks.Task<bool> GenerarDirectorioAsync(string path) {
            return base.Channel.GenerarDirectorioAsync(path);
        }
        
        public bool CopiarContenidoDirectorio(string sourceFile, string destFile) {
            return base.Channel.CopiarContenidoDirectorio(sourceFile, destFile);
        }
        
        public System.Threading.Tasks.Task<bool> CopiarContenidoDirectorioAsync(string sourceFile, string destFile) {
            return base.Channel.CopiarContenidoDirectorioAsync(sourceFile, destFile);
        }
    }
}
