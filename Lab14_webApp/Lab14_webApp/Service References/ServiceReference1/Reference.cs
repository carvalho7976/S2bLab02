﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab14_webApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JogoFutebol", Namespace="http://schemas.datacontract.org/2004/07/Lab14_classLibrary")]
    [System.SerializableAttribute()]
    public partial class JogoFutebol : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string casaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short golCasaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short golVisitanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string visitanteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string casa {
            get {
                return this.casaField;
            }
            set {
                if ((object.ReferenceEquals(this.casaField, value) != true)) {
                    this.casaField = value;
                    this.RaisePropertyChanged("casa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short golCasa {
            get {
                return this.golCasaField;
            }
            set {
                if ((this.golCasaField.Equals(value) != true)) {
                    this.golCasaField = value;
                    this.RaisePropertyChanged("golCasa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short golVisitante {
            get {
                return this.golVisitanteField;
            }
            set {
                if ((this.golVisitanteField.Equals(value) != true)) {
                    this.golVisitanteField = value;
                    this.RaisePropertyChanged("golVisitante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string visitante {
            get {
                return this.visitanteField;
            }
            set {
                if ((object.ReferenceEquals(this.visitanteField, value) != true)) {
                    this.visitanteField = value;
                    this.RaisePropertyChanged("visitante");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SimpleMethod", ReplyAction="http://tempuri.org/IService1/SimpleMethodResponse")]
        string SimpleMethod(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SimpleMethod", ReplyAction="http://tempuri.org/IService1/SimpleMethodResponse")]
        System.Threading.Tasks.Task<string> SimpleMethodAsync(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ComplexMethod", ReplyAction="http://tempuri.org/IService1/ComplexMethodResponse")]
        Lab14_webApp.ServiceReference1.JogoFutebol[] ComplexMethod();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ComplexMethod", ReplyAction="http://tempuri.org/IService1/ComplexMethodResponse")]
        System.Threading.Tasks.Task<Lab14_webApp.ServiceReference1.JogoFutebol[]> ComplexMethodAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Lab14_webApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Lab14_webApp.ServiceReference1.IService1>, Lab14_webApp.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SimpleMethod(string s) {
            return base.Channel.SimpleMethod(s);
        }
        
        public System.Threading.Tasks.Task<string> SimpleMethodAsync(string s) {
            return base.Channel.SimpleMethodAsync(s);
        }
        
        public Lab14_webApp.ServiceReference1.JogoFutebol[] ComplexMethod() {
            return base.Channel.ComplexMethod();
        }
        
        public System.Threading.Tasks.Task<Lab14_webApp.ServiceReference1.JogoFutebol[]> ComplexMethodAsync() {
            return base.Channel.ComplexMethodAsync();
        }
    }
}