﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.18444 版自动生成。
// 
#pragma warning disable 1591

namespace Exception.Service.Audit {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AuditServcieSoap", Namespace="http://www.jn.com/ESB/Audit")]
    public partial class AuditServcie : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddAuditBusinessOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExceptionPigeonholeOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExceptionResendOperationCompleted;
        
        private System.Threading.SendOrPostCallback AuditBusinessSearchOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAuditBusinessByOIDOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AuditServcie() {
            this.Url = global::Exception.Service.Properties.Settings.Default.Exception_Service_Audit_AuditServcie;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event AddAuditBusinessCompletedEventHandler AddAuditBusinessCompleted;
        
        /// <remarks/>
        public event ExceptionPigeonholeCompletedEventHandler ExceptionPigeonholeCompleted;
        
        /// <remarks/>
        public event ExceptionResendCompletedEventHandler ExceptionResendCompleted;
        
        /// <remarks/>
        public event AuditBusinessSearchCompletedEventHandler AuditBusinessSearchCompleted;
        
        /// <remarks/>
        public event GetAuditBusinessByOIDCompletedEventHandler GetAuditBusinessByOIDCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.jn.com/ESB/Audit/AddAuditBusiness", RequestNamespace="http://www.jn.com/ESB/Audit", ResponseNamespace="http://www.jn.com/ESB/Audit", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddAuditBusiness(string hostName, string messageBody, string messageID, string methodName, string reqBeginTime, string serviceName, int status, string callBeginTime, string callEndTime) {
            this.Invoke("AddAuditBusiness", new object[] {
                        hostName,
                        messageBody,
                        messageID,
                        methodName,
                        reqBeginTime,
                        serviceName,
                        status,
                        callBeginTime,
                        callEndTime});
        }
        
        /// <remarks/>
        public void AddAuditBusinessAsync(string hostName, string messageBody, string messageID, string methodName, string reqBeginTime, string serviceName, int status, string callBeginTime, string callEndTime) {
            this.AddAuditBusinessAsync(hostName, messageBody, messageID, methodName, reqBeginTime, serviceName, status, callBeginTime, callEndTime, null);
        }
        
        /// <remarks/>
        public void AddAuditBusinessAsync(string hostName, string messageBody, string messageID, string methodName, string reqBeginTime, string serviceName, int status, string callBeginTime, string callEndTime, object userState) {
            if ((this.AddAuditBusinessOperationCompleted == null)) {
                this.AddAuditBusinessOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddAuditBusinessOperationCompleted);
            }
            this.InvokeAsync("AddAuditBusiness", new object[] {
                        hostName,
                        messageBody,
                        messageID,
                        methodName,
                        reqBeginTime,
                        serviceName,
                        status,
                        callBeginTime,
                        callEndTime}, this.AddAuditBusinessOperationCompleted, userState);
        }
        
        private void OnAddAuditBusinessOperationCompleted(object arg) {
            if ((this.AddAuditBusinessCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddAuditBusinessCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.jn.com/ESB/Audit/ExceptionPigeonhole", RequestNamespace="http://www.jn.com/ESB/Audit", ResponseNamespace="http://www.jn.com/ESB/Audit", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ExceptionPigeonhole(System.Guid messageID) {
            this.Invoke("ExceptionPigeonhole", new object[] {
                        messageID});
        }
        
        /// <remarks/>
        public void ExceptionPigeonholeAsync(System.Guid messageID) {
            this.ExceptionPigeonholeAsync(messageID, null);
        }
        
        /// <remarks/>
        public void ExceptionPigeonholeAsync(System.Guid messageID, object userState) {
            if ((this.ExceptionPigeonholeOperationCompleted == null)) {
                this.ExceptionPigeonholeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExceptionPigeonholeOperationCompleted);
            }
            this.InvokeAsync("ExceptionPigeonhole", new object[] {
                        messageID}, this.ExceptionPigeonholeOperationCompleted, userState);
        }
        
        private void OnExceptionPigeonholeOperationCompleted(object arg) {
            if ((this.ExceptionPigeonholeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExceptionPigeonholeCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.jn.com/ESB/Audit/ExceptionResend", RequestNamespace="http://www.jn.com/ESB/Audit", ResponseNamespace="http://www.jn.com/ESB/Audit", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ExceptionResend(System.Guid messageID) {
            this.Invoke("ExceptionResend", new object[] {
                        messageID});
        }
        
        /// <remarks/>
        public void ExceptionResendAsync(System.Guid messageID) {
            this.ExceptionResendAsync(messageID, null);
        }
        
        /// <remarks/>
        public void ExceptionResendAsync(System.Guid messageID, object userState) {
            if ((this.ExceptionResendOperationCompleted == null)) {
                this.ExceptionResendOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExceptionResendOperationCompleted);
            }
            this.InvokeAsync("ExceptionResend", new object[] {
                        messageID}, this.ExceptionResendOperationCompleted, userState);
        }
        
        private void OnExceptionResendOperationCompleted(object arg) {
            if ((this.ExceptionResendCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExceptionResendCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.jn.com/ESB/Audit/AuditBusinessSearch", RequestNamespace="http://www.jn.com/ESB/Audit", ResponseNamespace="http://www.jn.com/ESB/Audit", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public AuditBusiness[] AuditBusinessSearch(AuditBusinessSearchCondition condition) {
            object[] results = this.Invoke("AuditBusinessSearch", new object[] {
                        condition});
            return ((AuditBusiness[])(results[0]));
        }
        
        /// <remarks/>
        public void AuditBusinessSearchAsync(AuditBusinessSearchCondition condition) {
            this.AuditBusinessSearchAsync(condition, null);
        }
        
        /// <remarks/>
        public void AuditBusinessSearchAsync(AuditBusinessSearchCondition condition, object userState) {
            if ((this.AuditBusinessSearchOperationCompleted == null)) {
                this.AuditBusinessSearchOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAuditBusinessSearchOperationCompleted);
            }
            this.InvokeAsync("AuditBusinessSearch", new object[] {
                        condition}, this.AuditBusinessSearchOperationCompleted, userState);
        }
        
        private void OnAuditBusinessSearchOperationCompleted(object arg) {
            if ((this.AuditBusinessSearchCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AuditBusinessSearchCompleted(this, new AuditBusinessSearchCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.jn.com/ESB/Audit/GetAuditBusinessByOID", RequestNamespace="http://www.jn.com/ESB/Audit", ResponseNamespace="http://www.jn.com/ESB/Audit", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public AuditBusiness GetAuditBusinessByOID(System.Guid oid) {
            object[] results = this.Invoke("GetAuditBusinessByOID", new object[] {
                        oid});
            return ((AuditBusiness)(results[0]));
        }
        
        /// <remarks/>
        public void GetAuditBusinessByOIDAsync(System.Guid oid) {
            this.GetAuditBusinessByOIDAsync(oid, null);
        }
        
        /// <remarks/>
        public void GetAuditBusinessByOIDAsync(System.Guid oid, object userState) {
            if ((this.GetAuditBusinessByOIDOperationCompleted == null)) {
                this.GetAuditBusinessByOIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAuditBusinessByOIDOperationCompleted);
            }
            this.InvokeAsync("GetAuditBusinessByOID", new object[] {
                        oid}, this.GetAuditBusinessByOIDOperationCompleted, userState);
        }
        
        private void OnGetAuditBusinessByOIDOperationCompleted(object arg) {
            if ((this.GetAuditBusinessByOIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAuditBusinessByOIDCompleted(this, new GetAuditBusinessByOIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.jn.com/ESB/Audit")]
    public partial class AuditBusinessSearchCondition {
        
        private AuditBusinessStatus statusField;
        
        private System.Guid businessIDField;
        
        private System.Guid serviceIDField;
        
        private DateScopeEnum dateScopeField;
        
        private System.DateTime dateScopeBeginField;
        
        private System.DateTime dateScopeEndField;
        
        /// <remarks/>
        public AuditBusinessStatus Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public System.Guid BusinessID {
            get {
                return this.businessIDField;
            }
            set {
                this.businessIDField = value;
            }
        }
        
        /// <remarks/>
        public System.Guid ServiceID {
            get {
                return this.serviceIDField;
            }
            set {
                this.serviceIDField = value;
            }
        }
        
        /// <remarks/>
        public DateScopeEnum DateScope {
            get {
                return this.dateScopeField;
            }
            set {
                this.dateScopeField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime DateScopeBegin {
            get {
                return this.dateScopeBeginField;
            }
            set {
                this.dateScopeBeginField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime DateScopeEnd {
            get {
                return this.dateScopeEndField;
            }
            set {
                this.dateScopeEndField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.jn.com/ESB/Audit")]
    public enum AuditBusinessStatus {
        
        /// <remarks/>
        Success,
        
        /// <remarks/>
        Exception,
        
        /// <remarks/>
        ExceptionReSend,
        
        /// <remarks/>
        ExceptionPigeonhole,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.jn.com/ESB/Audit")]
    public enum DateScopeEnum {
        
        /// <remarks/>
        OneDay,
        
        /// <remarks/>
        OneWeek,
        
        /// <remarks/>
        OneMonth,
        
        /// <remarks/>
        OneYear,
        
        /// <remarks/>
        All,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.jn.com/ESB/Audit")]
    public partial class AuditBusiness {
        
        private string oIDField;
        
        private string hostNameField;
        
        private string serviceNameField;
        
        private string methodNameField;
        
        private string reqBeginTimeField;
        
        private string reqEndTimeField;
        
        private int statusField;
        
        private string messageIDField;
        
        private string messageBodyField;
        
        private string callBeginTimeField;
        
        private string callEndTimeField;
        
        private string serviceIDField;
        
        private string businessIDField;
        
        private string businessNameField;
        
        private string bindingAddressField;
        
        private string returnMessageBodyField;
        
        /// <remarks/>
        public string OID {
            get {
                return this.oIDField;
            }
            set {
                this.oIDField = value;
            }
        }
        
        /// <remarks/>
        public string HostName {
            get {
                return this.hostNameField;
            }
            set {
                this.hostNameField = value;
            }
        }
        
        /// <remarks/>
        public string ServiceName {
            get {
                return this.serviceNameField;
            }
            set {
                this.serviceNameField = value;
            }
        }
        
        /// <remarks/>
        public string MethodName {
            get {
                return this.methodNameField;
            }
            set {
                this.methodNameField = value;
            }
        }
        
        /// <remarks/>
        public string ReqBeginTime {
            get {
                return this.reqBeginTimeField;
            }
            set {
                this.reqBeginTimeField = value;
            }
        }
        
        /// <remarks/>
        public string ReqEndTime {
            get {
                return this.reqEndTimeField;
            }
            set {
                this.reqEndTimeField = value;
            }
        }
        
        /// <remarks/>
        public int Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string MessageID {
            get {
                return this.messageIDField;
            }
            set {
                this.messageIDField = value;
            }
        }
        
        /// <remarks/>
        public string MessageBody {
            get {
                return this.messageBodyField;
            }
            set {
                this.messageBodyField = value;
            }
        }
        
        /// <remarks/>
        public string CallBeginTime {
            get {
                return this.callBeginTimeField;
            }
            set {
                this.callBeginTimeField = value;
            }
        }
        
        /// <remarks/>
        public string CallEndTime {
            get {
                return this.callEndTimeField;
            }
            set {
                this.callEndTimeField = value;
            }
        }
        
        /// <remarks/>
        public string ServiceID {
            get {
                return this.serviceIDField;
            }
            set {
                this.serviceIDField = value;
            }
        }
        
        /// <remarks/>
        public string BusinessID {
            get {
                return this.businessIDField;
            }
            set {
                this.businessIDField = value;
            }
        }
        
        /// <remarks/>
        public string BusinessName {
            get {
                return this.businessNameField;
            }
            set {
                this.businessNameField = value;
            }
        }
        
        /// <remarks/>
        public string BindingAddress {
            get {
                return this.bindingAddressField;
            }
            set {
                this.bindingAddressField = value;
            }
        }
        
        /// <remarks/>
        public string ReturnMessageBody {
            get {
                return this.returnMessageBodyField;
            }
            set {
                this.returnMessageBodyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void AddAuditBusinessCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ExceptionPigeonholeCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void ExceptionResendCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void AuditBusinessSearchCompletedEventHandler(object sender, AuditBusinessSearchCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuditBusinessSearchCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AuditBusinessSearchCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public AuditBusiness[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AuditBusiness[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetAuditBusinessByOIDCompletedEventHandler(object sender, GetAuditBusinessByOIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAuditBusinessByOIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAuditBusinessByOIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public AuditBusiness Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AuditBusiness)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591