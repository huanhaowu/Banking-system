﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Caja.wsIntegracion {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://intec.edu.do/", ConfigurationName="wsIntegracion.wsIntegracionSoap")]
    public interface wsIntegracionSoap {
        
        // CODEGEN: Generating message contract since element name Usuario_nombre from namespace http://intec.edu.do/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://intec.edu.do/ValidarUsuario", ReplyAction="*")]
        Caja.wsIntegracion.ValidarUsuarioResponse ValidarUsuario(Caja.wsIntegracion.ValidarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://intec.edu.do/ValidarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<Caja.wsIntegracion.ValidarUsuarioResponse> ValidarUsuarioAsync(Caja.wsIntegracion.ValidarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://intec.edu.do/GetMontoNumeroCuenta", ReplyAction="*")]
        decimal GetMontoNumeroCuenta(int numero_cuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://intec.edu.do/GetMontoNumeroCuenta", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> GetMontoNumeroCuentaAsync(int numero_cuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://intec.edu.do/InsertTransaccion", ReplyAction="*")]
        bool InsertTransaccion(int Tipo_transaccion_ID, int Cuenta_ID, int Cuenta_Destino_ID, int Transaccion_Monto, int Estado_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://intec.edu.do/InsertTransaccion", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> InsertTransaccionAsync(int Tipo_transaccion_ID, int Cuenta_ID, int Cuenta_Destino_ID, int Transaccion_Monto, int Estado_ID);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidarUsuario", Namespace="http://intec.edu.do/", Order=0)]
        public Caja.wsIntegracion.ValidarUsuarioRequestBody Body;
        
        public ValidarUsuarioRequest() {
        }
        
        public ValidarUsuarioRequest(Caja.wsIntegracion.ValidarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://intec.edu.do/")]
    public partial class ValidarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Usuario_nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Usuario_clave;
        
        public ValidarUsuarioRequestBody() {
        }
        
        public ValidarUsuarioRequestBody(string Usuario_nombre, string Usuario_clave) {
            this.Usuario_nombre = Usuario_nombre;
            this.Usuario_clave = Usuario_clave;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidarUsuarioResponse", Namespace="http://intec.edu.do/", Order=0)]
        public Caja.wsIntegracion.ValidarUsuarioResponseBody Body;
        
        public ValidarUsuarioResponse() {
        }
        
        public ValidarUsuarioResponse(Caja.wsIntegracion.ValidarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://intec.edu.do/")]
    public partial class ValidarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ValidarUsuarioResult;
        
        public ValidarUsuarioResponseBody() {
        }
        
        public ValidarUsuarioResponseBody(bool ValidarUsuarioResult) {
            this.ValidarUsuarioResult = ValidarUsuarioResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsIntegracionSoapChannel : Caja.wsIntegracion.wsIntegracionSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsIntegracionSoapClient : System.ServiceModel.ClientBase<Caja.wsIntegracion.wsIntegracionSoap>, Caja.wsIntegracion.wsIntegracionSoap {
        
        public wsIntegracionSoapClient() {
        }
        
        public wsIntegracionSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsIntegracionSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsIntegracionSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsIntegracionSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Caja.wsIntegracion.ValidarUsuarioResponse Caja.wsIntegracion.wsIntegracionSoap.ValidarUsuario(Caja.wsIntegracion.ValidarUsuarioRequest request) {
            return base.Channel.ValidarUsuario(request);
        }
        
        public bool ValidarUsuario(string Usuario_nombre, string Usuario_clave) {
            Caja.wsIntegracion.ValidarUsuarioRequest inValue = new Caja.wsIntegracion.ValidarUsuarioRequest();
            inValue.Body = new Caja.wsIntegracion.ValidarUsuarioRequestBody();
            inValue.Body.Usuario_nombre = Usuario_nombre;
            inValue.Body.Usuario_clave = Usuario_clave;
            Caja.wsIntegracion.ValidarUsuarioResponse retVal = ((Caja.wsIntegracion.wsIntegracionSoap)(this)).ValidarUsuario(inValue);
            return retVal.Body.ValidarUsuarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Caja.wsIntegracion.ValidarUsuarioResponse> Caja.wsIntegracion.wsIntegracionSoap.ValidarUsuarioAsync(Caja.wsIntegracion.ValidarUsuarioRequest request) {
            return base.Channel.ValidarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<Caja.wsIntegracion.ValidarUsuarioResponse> ValidarUsuarioAsync(string Usuario_nombre, string Usuario_clave) {
            Caja.wsIntegracion.ValidarUsuarioRequest inValue = new Caja.wsIntegracion.ValidarUsuarioRequest();
            inValue.Body = new Caja.wsIntegracion.ValidarUsuarioRequestBody();
            inValue.Body.Usuario_nombre = Usuario_nombre;
            inValue.Body.Usuario_clave = Usuario_clave;
            return ((Caja.wsIntegracion.wsIntegracionSoap)(this)).ValidarUsuarioAsync(inValue);
        }
        
        public decimal GetMontoNumeroCuenta(int numero_cuenta) {
            return base.Channel.GetMontoNumeroCuenta(numero_cuenta);
        }
        
        public System.Threading.Tasks.Task<decimal> GetMontoNumeroCuentaAsync(int numero_cuenta) {
            return base.Channel.GetMontoNumeroCuentaAsync(numero_cuenta);
        }
        
        public bool InsertTransaccion(int Tipo_transaccion_ID, int Cuenta_ID, int Cuenta_Destino_ID, int Transaccion_Monto, int Estado_ID) {
            return base.Channel.InsertTransaccion(Tipo_transaccion_ID, Cuenta_ID, Cuenta_Destino_ID, Transaccion_Monto, Estado_ID);
        }
        
        public System.Threading.Tasks.Task<bool> InsertTransaccionAsync(int Tipo_transaccion_ID, int Cuenta_ID, int Cuenta_Destino_ID, int Transaccion_Monto, int Estado_ID) {
            return base.Channel.InsertTransaccionAsync(Tipo_transaccion_ID, Cuenta_ID, Cuenta_Destino_ID, Transaccion_Monto, Estado_ID);
        }
    }
}
