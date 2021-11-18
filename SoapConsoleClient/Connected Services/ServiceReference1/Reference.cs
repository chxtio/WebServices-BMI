﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapConsoleClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="results", Namespace="http://schemas.datacontract.org/2004/07/SoapWebService")]
    [System.SerializableAttribute()]
    public partial class results : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int digitsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int lower_case_lettersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int upper_case_lettersField;
        
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
        public int digits {
            get {
                return this.digitsField;
            }
            set {
                if ((this.digitsField.Equals(value) != true)) {
                    this.digitsField = value;
                    this.RaisePropertyChanged("digits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int lower_case_letters {
            get {
                return this.lower_case_lettersField;
            }
            set {
                if ((this.lower_case_lettersField.Equals(value) != true)) {
                    this.lower_case_lettersField = value;
                    this.RaisePropertyChanged("lower_case_letters");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int upper_case_letters {
            get {
                return this.upper_case_lettersField;
            }
            set {
                if ((this.upper_case_lettersField.Equals(value) != true)) {
                    this.upper_case_lettersField = value;
                    this.RaisePropertyChanged("upper_case_letters");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/piValue", ReplyAction="http://tempuri.org/IService1/piValueResponse")]
        double piValue();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/piValue", ReplyAction="http://tempuri.org/IService1/piValueResponse")]
        System.Threading.Tasks.Task<double> piValueAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/absValue", ReplyAction="http://tempuri.org/IService1/absValueResponse")]
        int absValue(int x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/absValue", ReplyAction="http://tempuri.org/IService1/absValueResponse")]
        System.Threading.Tasks.Task<int> absValueAsync(int x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/add2", ReplyAction="http://tempuri.org/IService1/add2Response")]
        int add2(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/add2", ReplyAction="http://tempuri.org/IService1/add2Response")]
        System.Threading.Tasks.Task<int> add2Async(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/computeStat", ReplyAction="http://tempuri.org/IService1/computeStatResponse")]
        SoapConsoleClient.ServiceReference1.results computeStat(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/computeStat", ReplyAction="http://tempuri.org/IService1/computeStatResponse")]
        System.Threading.Tasks.Task<SoapConsoleClient.ServiceReference1.results> computeStatAsync(string str);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : SoapConsoleClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<SoapConsoleClient.ServiceReference1.IService1>, SoapConsoleClient.ServiceReference1.IService1 {
        
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
        
        public double piValue() {
            return base.Channel.piValue();
        }
        
        public System.Threading.Tasks.Task<double> piValueAsync() {
            return base.Channel.piValueAsync();
        }
        
        public int absValue(int x) {
            return base.Channel.absValue(x);
        }
        
        public System.Threading.Tasks.Task<int> absValueAsync(int x) {
            return base.Channel.absValueAsync(x);
        }
        
        public int add2(int x, int y) {
            return base.Channel.add2(x, y);
        }
        
        public System.Threading.Tasks.Task<int> add2Async(int x, int y) {
            return base.Channel.add2Async(x, y);
        }
        
        public SoapConsoleClient.ServiceReference1.results computeStat(string str) {
            return base.Channel.computeStat(str);
        }
        
        public System.Threading.Tasks.Task<SoapConsoleClient.ServiceReference1.results> computeStatAsync(string str) {
            return base.Channel.computeStatAsync(str);
        }
    }
}
