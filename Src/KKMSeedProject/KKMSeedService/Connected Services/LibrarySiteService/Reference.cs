﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KKM.Repository.Provider.LibrarySiteService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LibrarySiteService.IRivetSiteService")]
    public interface IRivetSiteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRivetSiteService/CreateNewSite", ReplyAction="http://tempuri.org/IRivetSiteService/CreateNewSiteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SharepointRequestBase))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Message[]))]
        KKM.Repository.Provider.LibrarySiteService.ResponseBase CreateNewSite(KKM.Repository.Provider.LibrarySiteService.CreateSiteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRivetSiteService/CreateNewSite", ReplyAction="http://tempuri.org/IRivetSiteService/CreateNewSiteResponse")]
        System.Threading.Tasks.Task<KKM.Repository.Provider.LibrarySiteService.ResponseBase> CreateNewSiteAsync(KKM.Repository.Provider.LibrarySiteService.CreateSiteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRivetSiteService/CreateNewSiteCollection", ReplyAction="http://tempuri.org/IRivetSiteService/CreateNewSiteCollectionResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SharepointRequestBase))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Message[]))]
        KKM.Repository.Provider.LibrarySiteService.ResponseBase CreateNewSiteCollection(KKM.Repository.Provider.LibrarySiteService.CreateSiteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRivetSiteService/CreateNewSiteCollection", ReplyAction="http://tempuri.org/IRivetSiteService/CreateNewSiteCollectionResponse")]
        System.Threading.Tasks.Task<KKM.Repository.Provider.LibrarySiteService.ResponseBase> CreateNewSiteCollectionAsync(KKM.Repository.Provider.LibrarySiteService.CreateSiteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRivetSiteService/AddSecondarySiteCollectionAdmin", ReplyAction="http://tempuri.org/IRivetSiteService/AddSecondarySiteCollectionAdminResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SharepointRequestBase))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Message[]))]
        KKM.Repository.Provider.LibrarySiteService.ResponseBase AddSecondarySiteCollectionAdmin(KKM.Repository.Provider.LibrarySiteService.SiteCollectionAdminRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRivetSiteService/AddSecondarySiteCollectionAdmin", ReplyAction="http://tempuri.org/IRivetSiteService/AddSecondarySiteCollectionAdminResponse")]
        System.Threading.Tasks.Task<KKM.Repository.Provider.LibrarySiteService.ResponseBase> AddSecondarySiteCollectionAdminAsync(KKM.Repository.Provider.LibrarySiteService.SiteCollectionAdminRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRivetSiteService/GetAllSites", ReplyAction="http://tempuri.org/IRivetSiteService/GetAllSitesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SharepointRequestBase))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Message[]))]
        KKM.Repository.Provider.LibrarySiteService.SharepointSitesResponse GetAllSites(KKM.Repository.Provider.LibrarySiteService.SharepointBlankRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRivetSiteService/GetAllSites", ReplyAction="http://tempuri.org/IRivetSiteService/GetAllSitesResponse")]
        System.Threading.Tasks.Task<KKM.Repository.Provider.LibrarySiteService.SharepointSitesResponse> GetAllSitesAsync(KKM.Repository.Provider.LibrarySiteService.SharepointBlankRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRivetSiteService/GetSite", ReplyAction="http://tempuri.org/IRivetSiteService/GetSiteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SharepointRequestBase))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Message[]))]
        KKM.Repository.Provider.LibrarySiteService.SharepointSiteResponse GetSite(KKM.Repository.Provider.LibrarySiteService.SharepointSiteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRivetSiteService/GetSite", ReplyAction="http://tempuri.org/IRivetSiteService/GetSiteResponse")]
        System.Threading.Tasks.Task<KKM.Repository.Provider.LibrarySiteService.SharepointSiteResponse> GetSiteAsync(KKM.Repository.Provider.LibrarySiteService.SharepointSiteRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1099.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateSiteRequest : SharepointRequestBase {
        
        private string templateNameField;
        
        private string newSiteNameUrlField;
        
        private string titleField;
        
        private string descriptionField;
        
        private uint localeIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string TemplateName {
            get {
                return this.templateNameField;
            }
            set {
                this.templateNameField = value;
                this.RaisePropertyChanged("TemplateName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string NewSiteNameUrl {
            get {
                return this.newSiteNameUrlField;
            }
            set {
                this.newSiteNameUrlField = value;
                this.RaisePropertyChanged("NewSiteNameUrl");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
                this.RaisePropertyChanged("Title");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public uint LocaleId {
            get {
                return this.localeIdField;
            }
            set {
                this.localeIdField = value;
                this.RaisePropertyChanged("LocaleId");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SharepointSiteRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SharepointBlankRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SiteCollectionAdminRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateSiteRequest))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SharepointSiteResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SharepointSitesResponse))]
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
    public partial class SharepointSiteResponse : ResponseBase {
        
        private string siteNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SiteName {
            get {
                return this.siteNameField;
            }
            set {
                this.siteNameField = value;
                this.RaisePropertyChanged("SiteName");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1099.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SharepointSitesResponse : ResponseBase {
        
        private string[] siteNamesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public string[] SiteNames {
            get {
                return this.siteNamesField;
            }
            set {
                this.siteNamesField = value;
                this.RaisePropertyChanged("SiteNames");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1099.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SharepointSiteRequest : SharepointRequestBase {
        
        private string siteNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SiteName {
            get {
                return this.siteNameField;
            }
            set {
                this.siteNameField = value;
                this.RaisePropertyChanged("SiteName");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1099.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SharepointBlankRequest : SharepointRequestBase {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1099.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SiteCollectionAdminRequest : SharepointRequestBase {
        
        private string siteCollectionUrlField;
        
        private string adminUserLoginField;
        
        private string adminUsernameField;
        
        private string adminEmailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SiteCollectionUrl {
            get {
                return this.siteCollectionUrlField;
            }
            set {
                this.siteCollectionUrlField = value;
                this.RaisePropertyChanged("SiteCollectionUrl");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string AdminUserLogin {
            get {
                return this.adminUserLoginField;
            }
            set {
                this.adminUserLoginField = value;
                this.RaisePropertyChanged("AdminUserLogin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string AdminUsername {
            get {
                return this.adminUsernameField;
            }
            set {
                this.adminUsernameField = value;
                this.RaisePropertyChanged("AdminUsername");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string AdminEmail {
            get {
                return this.adminEmailField;
            }
            set {
                this.adminEmailField = value;
                this.RaisePropertyChanged("AdminEmail");
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRivetSiteServiceChannel : KKM.Repository.Provider.LibrarySiteService.IRivetSiteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RivetSiteServiceClient : System.ServiceModel.ClientBase<KKM.Repository.Provider.LibrarySiteService.IRivetSiteService>, KKM.Repository.Provider.LibrarySiteService.IRivetSiteService {
        
        public RivetSiteServiceClient() {
        }
        
        public RivetSiteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RivetSiteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RivetSiteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RivetSiteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public KKM.Repository.Provider.LibrarySiteService.ResponseBase CreateNewSite(KKM.Repository.Provider.LibrarySiteService.CreateSiteRequest request) {
            return base.Channel.CreateNewSite(request);
        }
        
        public System.Threading.Tasks.Task<KKM.Repository.Provider.LibrarySiteService.ResponseBase> CreateNewSiteAsync(KKM.Repository.Provider.LibrarySiteService.CreateSiteRequest request) {
            return base.Channel.CreateNewSiteAsync(request);
        }
        
        public KKM.Repository.Provider.LibrarySiteService.ResponseBase CreateNewSiteCollection(KKM.Repository.Provider.LibrarySiteService.CreateSiteRequest request) {
            return base.Channel.CreateNewSiteCollection(request);
        }
        
        public System.Threading.Tasks.Task<KKM.Repository.Provider.LibrarySiteService.ResponseBase> CreateNewSiteCollectionAsync(KKM.Repository.Provider.LibrarySiteService.CreateSiteRequest request) {
            return base.Channel.CreateNewSiteCollectionAsync(request);
        }
        
        public KKM.Repository.Provider.LibrarySiteService.ResponseBase AddSecondarySiteCollectionAdmin(KKM.Repository.Provider.LibrarySiteService.SiteCollectionAdminRequest request) {
            return base.Channel.AddSecondarySiteCollectionAdmin(request);
        }
        
        public System.Threading.Tasks.Task<KKM.Repository.Provider.LibrarySiteService.ResponseBase> AddSecondarySiteCollectionAdminAsync(KKM.Repository.Provider.LibrarySiteService.SiteCollectionAdminRequest request) {
            return base.Channel.AddSecondarySiteCollectionAdminAsync(request);
        }
        
        public KKM.Repository.Provider.LibrarySiteService.SharepointSitesResponse GetAllSites(KKM.Repository.Provider.LibrarySiteService.SharepointBlankRequest request) {
            return base.Channel.GetAllSites(request);
        }
        
        public System.Threading.Tasks.Task<KKM.Repository.Provider.LibrarySiteService.SharepointSitesResponse> GetAllSitesAsync(KKM.Repository.Provider.LibrarySiteService.SharepointBlankRequest request) {
            return base.Channel.GetAllSitesAsync(request);
        }
        
        public KKM.Repository.Provider.LibrarySiteService.SharepointSiteResponse GetSite(KKM.Repository.Provider.LibrarySiteService.SharepointSiteRequest request) {
            return base.Channel.GetSite(request);
        }
        
        public System.Threading.Tasks.Task<KKM.Repository.Provider.LibrarySiteService.SharepointSiteResponse> GetSiteAsync(KKM.Repository.Provider.LibrarySiteService.SharepointSiteRequest request) {
            return base.Channel.GetSiteAsync(request);
        }
    }
}
