﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34209
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestProject2.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JediWS", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.EntitiesWS")]
    [System.SerializableAttribute()]
    public partial class JediWS : UnitTestProject2.ServiceReference1.EntityObjectWS {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityObjectWS", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.EntitiesWS")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(UnitTestProject2.ServiceReference1.StadeWS))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(UnitTestProject2.ServiceReference1.MatchWS))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(UnitTestProject2.ServiceReference1.TournoiWS))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(UnitTestProject2.ServiceReference1.JediWS))]
    public partial class EntityObjectWS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StadeWS", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.EntitiesWS")]
    [System.SerializableAttribute()]
    public partial class StadeWS : UnitTestProject2.ServiceReference1.EntityObjectWS {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MatchWS", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.EntitiesWS")]
    [System.SerializableAttribute()]
    public partial class MatchWS : UnitTestProject2.ServiceReference1.EntityObjectWS {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TournoiWS", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.EntitiesWS")]
    [System.SerializableAttribute()]
    public partial class TournoiWS : UnitTestProject2.ServiceReference1.EntityObjectWS {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetJediList", ReplyAction="http://tempuri.org/IService1/GetJediListResponse")]
        System.Collections.Generic.List<UnitTestProject2.ServiceReference1.JediWS> GetJediList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetJediList", ReplyAction="http://tempuri.org/IService1/GetJediListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<UnitTestProject2.ServiceReference1.JediWS>> GetJediListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStadeList", ReplyAction="http://tempuri.org/IService1/GetStadeListResponse")]
        System.Collections.Generic.List<UnitTestProject2.ServiceReference1.StadeWS> GetStadeList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStadeList", ReplyAction="http://tempuri.org/IService1/GetStadeListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<UnitTestProject2.ServiceReference1.StadeWS>> GetStadeListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMatchList", ReplyAction="http://tempuri.org/IService1/GetMatchListResponse")]
        System.Collections.Generic.List<UnitTestProject2.ServiceReference1.MatchWS> GetMatchList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMatchList", ReplyAction="http://tempuri.org/IService1/GetMatchListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<UnitTestProject2.ServiceReference1.MatchWS>> GetMatchListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTournamentList", ReplyAction="http://tempuri.org/IService1/GetTournamentListResponse")]
        System.Collections.Generic.List<UnitTestProject2.ServiceReference1.TournoiWS> GetTournamentList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTournamentList", ReplyAction="http://tempuri.org/IService1/GetTournamentListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<UnitTestProject2.ServiceReference1.TournoiWS>> GetTournamentListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : UnitTestProject2.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<UnitTestProject2.ServiceReference1.IService1>, UnitTestProject2.ServiceReference1.IService1 {
        
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
        
        public System.Collections.Generic.List<UnitTestProject2.ServiceReference1.JediWS> GetJediList() {
            return base.Channel.GetJediList();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<UnitTestProject2.ServiceReference1.JediWS>> GetJediListAsync() {
            return base.Channel.GetJediListAsync();
        }
        
        public System.Collections.Generic.List<UnitTestProject2.ServiceReference1.StadeWS> GetStadeList() {
            return base.Channel.GetStadeList();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<UnitTestProject2.ServiceReference1.StadeWS>> GetStadeListAsync() {
            return base.Channel.GetStadeListAsync();
        }
        
        public System.Collections.Generic.List<UnitTestProject2.ServiceReference1.MatchWS> GetMatchList() {
            return base.Channel.GetMatchList();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<UnitTestProject2.ServiceReference1.MatchWS>> GetMatchListAsync() {
            return base.Channel.GetMatchListAsync();
        }
        
        public System.Collections.Generic.List<UnitTestProject2.ServiceReference1.TournoiWS> GetTournamentList() {
            return base.Channel.GetTournamentList();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<UnitTestProject2.ServiceReference1.TournoiWS>> GetTournamentListAsync() {
            return base.Channel.GetTournamentListAsync();
        }
    }
}
