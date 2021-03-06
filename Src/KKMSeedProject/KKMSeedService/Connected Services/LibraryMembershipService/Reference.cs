﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KKM.Repository.Provider.LibraryMembershipService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LibraryMembershipService.IRivetMembershipService")]
    public interface IRivetMembershipService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRivetMembershipService/AddUserToRole", ReplyAction="http://tempuri.org/IRivetMembershipService/AddUserToRoleResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SharepointRequestBase))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Message[]))]
        KKM.Repository.Provider.LibraryMembershipService.ResponseBase AddUserToRole(KKM.Repository.Provider.LibraryMembershipService.AddUserToRoleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRivetMembershipService/AddUserToRole", ReplyAction="http://tempuri.org/IRivetMembershipService/AddUserToRoleResponse")]
        System.Threading.Tasks.Task<KKM.Repository.Provider.LibraryMembershipService.ResponseBase> AddUserToRoleAsync(KKM.Repository.Provider.LibraryMembershipService.AddUserToRoleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRivetMembershipService/RemoveUserFromSite", ReplyAction="http://tempuri.org/IRivetMembershipService/RemoveUserFromSiteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SharepointRequestBase))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Message[]))]
        KKM.Repository.Provider.LibraryMembershipService.ResponseBase RemoveUserFromSite(KKM.Repository.Provider.LibraryMembershipService.RemoveUserFromSiteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRivetMembershipService/RemoveUserFromSite", ReplyAction="http://tempuri.org/IRivetMembershipService/RemoveUserFromSiteResponse")]
        System.Threading.Tasks.Task<KKM.Repository.Provider.LibraryMembershipService.ResponseBase> RemoveUserFromSiteAsync(KKM.Repository.Provider.LibraryMembershipService.RemoveUserFromSiteRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1099.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class AddUserToRoleRequest : SharepointRequestBase {
        
        private string userNameField;
        
        private string roleNameField;
        
        private string userEmailField;
        
        private string userNotesField;
        
        private bool addUserToAdminGroupField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string RoleName {
            get {
                return this.roleNameField;
            }
            set {
                this.roleNameField = value;
                this.RaisePropertyChanged("RoleName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string UserEmail {
            get {
                return this.userEmailField;
            }
            set {
                this.userEmailField = value;
                this.RaisePropertyChanged("UserEmail");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string UserNotes {
            get {
                return this.userNotesField;
            }
            set {
                this.userNotesField = value;
                this.RaisePropertyChanged("UserNotes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool AddUserToAdminGroup {
            get {
                return this.addUserToAdminGroupField;
            }
            set {
                this.addUserToAdminGroupField = value;
                this.RaisePropertyChanged("AddUserToAdminGroup");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RemoveUserFromSiteRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AddUserToRoleRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1099.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class SharepointRequestBase : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string callerUsernameField;
        
        private string callerPasswordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string CallerUsername {
            get {
                return this.callerUsernameField;
            }
            set {
                this.callerUsernameField = value;
                this.RaisePropertyChanged("CallerUsername");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string CallerPassword {
            get {
                return this.callerPasswordField;
            }
            set {
                this.callerPasswordField = value;
                this.RaisePropertyChanged("CallerPassword");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1099.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Message : object, System.ComponentModel.INotifyPropertyChanged {
        
        private MessageType typeField;
        
        private string descriptionField;
        
        private object tagField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public MessageType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("Type");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public object Tag {
            get {
                return this.tagField;
            }
            set {
                this.tagField = value;
                this.RaisePropertyChanged("Tag");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1099.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum MessageType {
        
        /// <remarks/>
        Info,
        
        /// <remarks/>
        Warning,
        
        /// <remarks/>
        Error,
        
        /// <remarks/>
        Timing,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1099.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ResponseHeader : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool statusField;
        
        private int errorCodeField;
        
        private Message[] messagesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int ErrorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
                this.RaisePropertyChanged("ErrorCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public Message[] Messages {
            get {
                return this.messagesField;
            }
            set {
                this.messagesField = value;
                this.RaisePropertyChanged("Messages");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1099.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ResponseBase : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ResponseHeader headerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ResponseHeader Header {
            get {
                return this.headerField;
            }
            set {
                this.headerField = value;
                this.RaisePropertyChanged("Header");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1099.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class RemoveUserFromSiteRequest : SharepointRequestBase {
        
        private string userNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRivetMembershipServiceChannel : KKM.Repository.Provider.LibraryMembershipService.IRivetMembershipService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RivetMembershipServiceClient : System.ServiceModel.ClientBase<KKM.Repository.Provider.LibraryMembershipService.IRivetMembershipService>, KKM.Repository.Provider.LibraryMembershipService.IRivetMembershipService {
        
        public RivetMembershipServiceClient() {
        }
        
        public RivetMembershipServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RivetMembershipServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RivetMembershipServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RivetMembershipServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public KKM.Repository.Provider.LibraryMembershipService.ResponseBase AddUserToRole(KKM.Repository.Provider.LibraryMembershipService.AddUserToRoleRequest request) {
            return base.Channel.AddUserToRole(request);
        }
        
        public System.Threading.Tasks.Task<KKM.Repository.Provider.LibraryMembershipService.ResponseBase> AddUserToRoleAsync(KKM.Repository.Provider.LibraryMembershipService.AddUserToRoleRequest request) {
            return base.Channel.AddUserToRoleAsync(request);
        }
        
        public KKM.Repository.Provider.LibraryMembershipService.ResponseBase RemoveUserFromSite(KKM.Repository.Provider.LibraryMembershipService.RemoveUserFromSiteRequest request) {
            return base.Channel.RemoveUserFromSite(request);
        }
        
        public System.Threading.Tasks.Task<KKM.Repository.Provider.LibraryMembershipService.ResponseBase> RemoveUserFromSiteAsync(KKM.Repository.Provider.LibraryMembershipService.RemoveUserFromSiteRequest request) {
            return base.Channel.RemoveUserFromSiteAsync(request);
        }
    }
}
