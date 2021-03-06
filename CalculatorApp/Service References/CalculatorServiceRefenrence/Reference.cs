﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace CalculatorApp.CalculatorServiceRefenrence {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CalculadoraDTO", Namespace="http://schemas.datacontract.org/2004/07/ProyectoWCF.DTO")]
    public partial class CalculadoraDTO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private decimal Numero1Field;
        
        private decimal Numero2Field;
        
        private string OperacionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Numero1 {
            get {
                return this.Numero1Field;
            }
            set {
                if ((this.Numero1Field.Equals(value) != true)) {
                    this.Numero1Field = value;
                    this.RaisePropertyChanged("Numero1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Numero2 {
            get {
                return this.Numero2Field;
            }
            set {
                if ((this.Numero2Field.Equals(value) != true)) {
                    this.Numero2Field = value;
                    this.RaisePropertyChanged("Numero2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Operacion {
            get {
                return this.OperacionField;
            }
            set {
                if ((object.ReferenceEquals(this.OperacionField, value) != true)) {
                    this.OperacionField = value;
                    this.RaisePropertyChanged("Operacion");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorServiceRefenrence.ICalculadoraService")]
    public interface ICalculadoraService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ICalculadoraService/DoWork", ReplyAction="http://tempuri.org/ICalculadoraService/DoWorkResponse")]
        System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState);
        
        void EndDoWork(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ICalculadoraService/EjecutarOperacion", ReplyAction="http://tempuri.org/ICalculadoraService/EjecutarOperacionResponse")]
        System.IAsyncResult BeginEjecutarOperacion(CalculatorApp.CalculatorServiceRefenrence.CalculadoraDTO calculadoraDTO, System.AsyncCallback callback, object asyncState);
        
        decimal EndEjecutarOperacion(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculadoraServiceChannel : CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EjecutarOperacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public EjecutarOperacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public decimal Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((decimal)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculadoraServiceClient : System.ServiceModel.ClientBase<CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService>, CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService {
        
        private BeginOperationDelegate onBeginDoWorkDelegate;
        
        private EndOperationDelegate onEndDoWorkDelegate;
        
        private System.Threading.SendOrPostCallback onDoWorkCompletedDelegate;
        
        private BeginOperationDelegate onBeginEjecutarOperacionDelegate;
        
        private EndOperationDelegate onEndEjecutarOperacionDelegate;
        
        private System.Threading.SendOrPostCallback onEjecutarOperacionCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public CalculadoraServiceClient() {
        }
        
        public CalculadoraServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculadoraServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("No se puede establecer el objeto CookieContainer. Asegúrese de que el enlace cont" +
                            "iene un objeto HttpCookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> DoWorkCompleted;
        
        public event System.EventHandler<EjecutarOperacionCompletedEventArgs> EjecutarOperacionCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService.BeginDoWork(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDoWork(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService.EndDoWork(System.IAsyncResult result) {
            base.Channel.EndDoWork(result);
        }
        
        private System.IAsyncResult OnBeginDoWork(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService)(this)).BeginDoWork(callback, asyncState);
        }
        
        private object[] OnEndDoWork(System.IAsyncResult result) {
            ((CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService)(this)).EndDoWork(result);
            return null;
        }
        
        private void OnDoWorkCompleted(object state) {
            if ((this.DoWorkCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DoWorkCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DoWorkAsync() {
            this.DoWorkAsync(null);
        }
        
        public void DoWorkAsync(object userState) {
            if ((this.onBeginDoWorkDelegate == null)) {
                this.onBeginDoWorkDelegate = new BeginOperationDelegate(this.OnBeginDoWork);
            }
            if ((this.onEndDoWorkDelegate == null)) {
                this.onEndDoWorkDelegate = new EndOperationDelegate(this.OnEndDoWork);
            }
            if ((this.onDoWorkCompletedDelegate == null)) {
                this.onDoWorkCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDoWorkCompleted);
            }
            base.InvokeAsync(this.onBeginDoWorkDelegate, null, this.onEndDoWorkDelegate, this.onDoWorkCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService.BeginEjecutarOperacion(CalculatorApp.CalculatorServiceRefenrence.CalculadoraDTO calculadoraDTO, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginEjecutarOperacion(calculadoraDTO, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        decimal CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService.EndEjecutarOperacion(System.IAsyncResult result) {
            return base.Channel.EndEjecutarOperacion(result);
        }
        
        private System.IAsyncResult OnBeginEjecutarOperacion(object[] inValues, System.AsyncCallback callback, object asyncState) {
            CalculatorApp.CalculatorServiceRefenrence.CalculadoraDTO calculadoraDTO = ((CalculatorApp.CalculatorServiceRefenrence.CalculadoraDTO)(inValues[0]));
            return ((CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService)(this)).BeginEjecutarOperacion(calculadoraDTO, callback, asyncState);
        }
        
        private object[] OnEndEjecutarOperacion(System.IAsyncResult result) {
            decimal retVal = ((CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService)(this)).EndEjecutarOperacion(result);
            return new object[] {
                    retVal};
        }
        
        private void OnEjecutarOperacionCompleted(object state) {
            if ((this.EjecutarOperacionCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.EjecutarOperacionCompleted(this, new EjecutarOperacionCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void EjecutarOperacionAsync(CalculatorApp.CalculatorServiceRefenrence.CalculadoraDTO calculadoraDTO) {
            this.EjecutarOperacionAsync(calculadoraDTO, null);
        }
        
        public void EjecutarOperacionAsync(CalculatorApp.CalculatorServiceRefenrence.CalculadoraDTO calculadoraDTO, object userState) {
            if ((this.onBeginEjecutarOperacionDelegate == null)) {
                this.onBeginEjecutarOperacionDelegate = new BeginOperationDelegate(this.OnBeginEjecutarOperacion);
            }
            if ((this.onEndEjecutarOperacionDelegate == null)) {
                this.onEndEjecutarOperacionDelegate = new EndOperationDelegate(this.OnEndEjecutarOperacion);
            }
            if ((this.onEjecutarOperacionCompletedDelegate == null)) {
                this.onEjecutarOperacionCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnEjecutarOperacionCompleted);
            }
            base.InvokeAsync(this.onBeginEjecutarOperacionDelegate, new object[] {
                        calculadoraDTO}, this.onEndEjecutarOperacionDelegate, this.onEjecutarOperacionCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService CreateChannel() {
            return new CalculadoraServiceClientChannel(this);
        }
        
        private class CalculadoraServiceClientChannel : ChannelBase<CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService>, CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService {
            
            public CalculadoraServiceClientChannel(System.ServiceModel.ClientBase<CalculatorApp.CalculatorServiceRefenrence.ICalculadoraService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("DoWork", _args, callback, asyncState);
                return _result;
            }
            
            public void EndDoWork(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("DoWork", _args, result);
            }
            
            public System.IAsyncResult BeginEjecutarOperacion(CalculatorApp.CalculatorServiceRefenrence.CalculadoraDTO calculadoraDTO, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = calculadoraDTO;
                System.IAsyncResult _result = base.BeginInvoke("EjecutarOperacion", _args, callback, asyncState);
                return _result;
            }
            
            public decimal EndEjecutarOperacion(System.IAsyncResult result) {
                object[] _args = new object[0];
                decimal _result = ((decimal)(base.EndInvoke("EjecutarOperacion", _args, result)));
                return _result;
            }
        }
    }
}
