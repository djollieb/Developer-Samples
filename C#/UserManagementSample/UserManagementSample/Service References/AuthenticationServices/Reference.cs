﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserManagementSample.AuthenticationServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceOperationResultOfboolean", Namespace="http://schemas.datacontract.org/2004/07/Checkbox.Wcf.Services.Proxies")]
    [System.SerializableAttribute()]
    public partial class ServiceOperationResultOfboolean : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CallSuccessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FailureExceptionTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FailureMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ResultDataField;
        
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
        public bool CallSuccess {
            get {
                return this.CallSuccessField;
            }
            set {
                if ((this.CallSuccessField.Equals(value) != true)) {
                    this.CallSuccessField = value;
                    this.RaisePropertyChanged("CallSuccess");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FailureExceptionType {
            get {
                return this.FailureExceptionTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.FailureExceptionTypeField, value) != true)) {
                    this.FailureExceptionTypeField = value;
                    this.RaisePropertyChanged("FailureExceptionType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FailureMessage {
            get {
                return this.FailureMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FailureMessageField, value) != true)) {
                    this.FailureMessageField = value;
                    this.RaisePropertyChanged("FailureMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ResultData {
            get {
                return this.ResultDataField;
            }
            set {
                if ((this.ResultDataField.Equals(value) != true)) {
                    this.ResultDataField = value;
                    this.RaisePropertyChanged("ResultData");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceOperationResultOfstring", Namespace="http://schemas.datacontract.org/2004/07/Checkbox.Wcf.Services.Proxies")]
    [System.SerializableAttribute()]
    public partial class ServiceOperationResultOfstring : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CallSuccessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FailureExceptionTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FailureMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResultDataField;
        
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
        public bool CallSuccess {
            get {
                return this.CallSuccessField;
            }
            set {
                if ((this.CallSuccessField.Equals(value) != true)) {
                    this.CallSuccessField = value;
                    this.RaisePropertyChanged("CallSuccess");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FailureExceptionType {
            get {
                return this.FailureExceptionTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.FailureExceptionTypeField, value) != true)) {
                    this.FailureExceptionTypeField = value;
                    this.RaisePropertyChanged("FailureExceptionType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FailureMessage {
            get {
                return this.FailureMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FailureMessageField, value) != true)) {
                    this.FailureMessageField = value;
                    this.RaisePropertyChanged("FailureMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResultData {
            get {
                return this.ResultDataField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultDataField, value) != true)) {
                    this.ResultDataField = value;
                    this.RaisePropertyChanged("ResultData");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceOperationResultOfanyType", Namespace="http://schemas.datacontract.org/2004/07/Checkbox.Wcf.Services.Proxies")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(UserManagementSample.AuthenticationServices.ServiceOperationResultOfboolean))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(UserManagementSample.AuthenticationServices.ServiceOperationResultOfstring))]
    public partial class ServiceOperationResultOfanyType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CallSuccessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FailureExceptionTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FailureMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ResultDataField;
        
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
        public bool CallSuccess {
            get {
                return this.CallSuccessField;
            }
            set {
                if ((this.CallSuccessField.Equals(value) != true)) {
                    this.CallSuccessField = value;
                    this.RaisePropertyChanged("CallSuccess");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FailureExceptionType {
            get {
                return this.FailureExceptionTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.FailureExceptionTypeField, value) != true)) {
                    this.FailureExceptionTypeField = value;
                    this.RaisePropertyChanged("FailureExceptionType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FailureMessage {
            get {
                return this.FailureMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FailureMessageField, value) != true)) {
                    this.FailureMessageField = value;
                    this.RaisePropertyChanged("FailureMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object ResultData {
            get {
                return this.ResultDataField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultDataField, value) != true)) {
                    this.ResultDataField = value;
                    this.RaisePropertyChanged("ResultData");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthenticationServices.IAuthenticationService")]
    public interface IAuthenticationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/IsLoggedIn", ReplyAction="http://tempuri.org/IAuthenticationService/IsLoggedInResponse")]
        UserManagementSample.AuthenticationServices.ServiceOperationResultOfboolean IsLoggedIn();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/IsLoggedIn", ReplyAction="http://tempuri.org/IAuthenticationService/IsLoggedInResponse")]
        System.Threading.Tasks.Task<UserManagementSample.AuthenticationServices.ServiceOperationResultOfboolean> IsLoggedInAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/Login", ReplyAction="http://tempuri.org/IAuthenticationService/LoginResponse")]
        UserManagementSample.AuthenticationServices.ServiceOperationResultOfstring Login(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/Login", ReplyAction="http://tempuri.org/IAuthenticationService/LoginResponse")]
        System.Threading.Tasks.Task<UserManagementSample.AuthenticationServices.ServiceOperationResultOfstring> LoginAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/Logout", ReplyAction="http://tempuri.org/IAuthenticationService/LogoutResponse")]
        UserManagementSample.AuthenticationServices.ServiceOperationResultOfanyType Logout();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/Logout", ReplyAction="http://tempuri.org/IAuthenticationService/LogoutResponse")]
        System.Threading.Tasks.Task<UserManagementSample.AuthenticationServices.ServiceOperationResultOfanyType> LogoutAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/ValidateUser", ReplyAction="http://tempuri.org/IAuthenticationService/ValidateUserResponse")]
        UserManagementSample.AuthenticationServices.ServiceOperationResultOfboolean ValidateUser(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/ValidateUser", ReplyAction="http://tempuri.org/IAuthenticationService/ValidateUserResponse")]
        System.Threading.Tasks.Task<UserManagementSample.AuthenticationServices.ServiceOperationResultOfboolean> ValidateUserAsync(string userName, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthenticationServiceChannel : UserManagementSample.AuthenticationServices.IAuthenticationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthenticationServiceClient : System.ServiceModel.ClientBase<UserManagementSample.AuthenticationServices.IAuthenticationService>, UserManagementSample.AuthenticationServices.IAuthenticationService {
        
        public AuthenticationServiceClient() {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public UserManagementSample.AuthenticationServices.ServiceOperationResultOfboolean IsLoggedIn() {
            return base.Channel.IsLoggedIn();
        }
        
        public System.Threading.Tasks.Task<UserManagementSample.AuthenticationServices.ServiceOperationResultOfboolean> IsLoggedInAsync() {
            return base.Channel.IsLoggedInAsync();
        }
        
        public UserManagementSample.AuthenticationServices.ServiceOperationResultOfstring Login(string userName, string password) {
            return base.Channel.Login(userName, password);
        }
        
        public System.Threading.Tasks.Task<UserManagementSample.AuthenticationServices.ServiceOperationResultOfstring> LoginAsync(string userName, string password) {
            return base.Channel.LoginAsync(userName, password);
        }
        
        public UserManagementSample.AuthenticationServices.ServiceOperationResultOfanyType Logout() {
            return base.Channel.Logout();
        }
        
        public System.Threading.Tasks.Task<UserManagementSample.AuthenticationServices.ServiceOperationResultOfanyType> LogoutAsync() {
            return base.Channel.LogoutAsync();
        }
        
        public UserManagementSample.AuthenticationServices.ServiceOperationResultOfboolean ValidateUser(string userName, string password) {
            return base.Channel.ValidateUser(userName, password);
        }
        
        public System.Threading.Tasks.Task<UserManagementSample.AuthenticationServices.ServiceOperationResultOfboolean> ValidateUserAsync(string userName, string password) {
            return base.Channel.ValidateUserAsync(userName, password);
        }
    }
}
