﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace JProject.Demo.TableSvc {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JsonResult", Namespace="http://schemas.datacontract.org/2004/07/JProject.ServicesTest.Utilities")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(JProject.Demo.TableSvc.NavigationEntity))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(JProject.Demo.TableSvc.NavigationEntity[]))]
    public partial class JsonResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMsgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsErrorField;
        
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
        public object Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMsg {
            get {
                return this.ErrorMsgField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMsgField, value) != true)) {
                    this.ErrorMsgField = value;
                    this.RaisePropertyChanged("ErrorMsg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsError {
            get {
                return this.IsErrorField;
            }
            set {
                if ((this.IsErrorField.Equals(value) != true)) {
                    this.IsErrorField = value;
                    this.RaisePropertyChanged("IsError");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NavigationEntity", Namespace="http://schemas.datacontract.org/2004/07/JProject.ServicesTest.Utilities")]
    [System.SerializableAttribute()]
    public partial class NavigationEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sex {
            get {
                return this.SexField;
            }
            set {
                if ((object.ReferenceEquals(this.SexField, value) != true)) {
                    this.SexField = value;
                    this.RaisePropertyChanged("Sex");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TableSvc.IListSvc")]
    public interface IListSvc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListSvc/TestSvc", ReplyAction="http://tempuri.org/IListSvc/TestSvcResponse")]
        string TestSvc();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListSvc/TestSvc", ReplyAction="http://tempuri.org/IListSvc/TestSvcResponse")]
        System.Threading.Tasks.Task<string> TestSvcAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListSvc/TestHasParametersMethod", ReplyAction="http://tempuri.org/IListSvc/TestHasParametersMethodResponse")]
        string TestHasParametersMethod(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListSvc/TestHasParametersMethod", ReplyAction="http://tempuri.org/IListSvc/TestHasParametersMethodResponse")]
        System.Threading.Tasks.Task<string> TestHasParametersMethodAsync(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListSvc/getJsonMsg2", ReplyAction="http://tempuri.org/IListSvc/getJsonMsg2Response")]
        JProject.Demo.TableSvc.JsonResult getJsonMsg2();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListSvc/getJsonMsg2", ReplyAction="http://tempuri.org/IListSvc/getJsonMsg2Response")]
        System.Threading.Tasks.Task<JProject.Demo.TableSvc.JsonResult> getJsonMsg2Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListSvc/getJsonMsg", ReplyAction="http://tempuri.org/IListSvc/getJsonMsgResponse")]
        JProject.Demo.TableSvc.NavigationEntity[] getJsonMsg();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListSvc/getJsonMsg", ReplyAction="http://tempuri.org/IListSvc/getJsonMsgResponse")]
        System.Threading.Tasks.Task<JProject.Demo.TableSvc.NavigationEntity[]> getJsonMsgAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IListSvcChannel : JProject.Demo.TableSvc.IListSvc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ListSvcClient : System.ServiceModel.ClientBase<JProject.Demo.TableSvc.IListSvc>, JProject.Demo.TableSvc.IListSvc {
        
        public ListSvcClient() {
        }
        
        public ListSvcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ListSvcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ListSvcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ListSvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string TestSvc() {
            return base.Channel.TestSvc();
        }
        
        public System.Threading.Tasks.Task<string> TestSvcAsync() {
            return base.Channel.TestSvcAsync();
        }
        
        public string TestHasParametersMethod(string str) {
            return base.Channel.TestHasParametersMethod(str);
        }
        
        public System.Threading.Tasks.Task<string> TestHasParametersMethodAsync(string str) {
            return base.Channel.TestHasParametersMethodAsync(str);
        }
        
        public JProject.Demo.TableSvc.JsonResult getJsonMsg2() {
            return base.Channel.getJsonMsg2();
        }
        
        public System.Threading.Tasks.Task<JProject.Demo.TableSvc.JsonResult> getJsonMsg2Async() {
            return base.Channel.getJsonMsg2Async();
        }
        
        public JProject.Demo.TableSvc.NavigationEntity[] getJsonMsg() {
            return base.Channel.getJsonMsg();
        }
        
        public System.Threading.Tasks.Task<JProject.Demo.TableSvc.NavigationEntity[]> getJsonMsgAsync() {
            return base.Channel.getJsonMsgAsync();
        }
    }
}
