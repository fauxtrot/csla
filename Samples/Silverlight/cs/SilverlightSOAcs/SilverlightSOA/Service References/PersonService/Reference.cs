﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace SilverlightSOA.PersonService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonData", Namespace="http://schemas.datacontract.org/2004/07/SilverlightSOAWeb")]
    public partial class PersonData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string FirstNameField;
        
        private int IdField;
        
        private string LastNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonService.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IPersonService/GetPerson", ReplyAction="http://tempuri.org/IPersonService/GetPersonResponse")]
        System.IAsyncResult BeginGetPerson(int id, System.AsyncCallback callback, object asyncState);
        
        SilverlightSOA.PersonService.PersonData EndGetPerson(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IPersonService/AddPerson", ReplyAction="http://tempuri.org/IPersonService/AddPersonResponse")]
        System.IAsyncResult BeginAddPerson(SilverlightSOA.PersonService.PersonData obj, System.AsyncCallback callback, object asyncState);
        
        SilverlightSOA.PersonService.PersonData EndAddPerson(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IPersonService/UpdatePerson", ReplyAction="http://tempuri.org/IPersonService/UpdatePersonResponse")]
        System.IAsyncResult BeginUpdatePerson(SilverlightSOA.PersonService.PersonData obj, System.AsyncCallback callback, object asyncState);
        
        SilverlightSOA.PersonService.PersonData EndUpdatePerson(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IPersonService/DeletePerson", ReplyAction="http://tempuri.org/IPersonService/DeletePersonResponse")]
        System.IAsyncResult BeginDeletePerson(int id, System.AsyncCallback callback, object asyncState);
        
        void EndDeletePerson(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : SilverlightSOA.PersonService.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetPersonCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetPersonCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public SilverlightSOA.PersonService.PersonData Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((SilverlightSOA.PersonService.PersonData)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddPersonCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public AddPersonCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public SilverlightSOA.PersonService.PersonData Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((SilverlightSOA.PersonService.PersonData)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UpdatePersonCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public UpdatePersonCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public SilverlightSOA.PersonService.PersonData Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((SilverlightSOA.PersonService.PersonData)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<SilverlightSOA.PersonService.IPersonService>, SilverlightSOA.PersonService.IPersonService {
        
        private BeginOperationDelegate onBeginGetPersonDelegate;
        
        private EndOperationDelegate onEndGetPersonDelegate;
        
        private System.Threading.SendOrPostCallback onGetPersonCompletedDelegate;
        
        private BeginOperationDelegate onBeginAddPersonDelegate;
        
        private EndOperationDelegate onEndAddPersonDelegate;
        
        private System.Threading.SendOrPostCallback onAddPersonCompletedDelegate;
        
        private BeginOperationDelegate onBeginUpdatePersonDelegate;
        
        private EndOperationDelegate onEndUpdatePersonDelegate;
        
        private System.Threading.SendOrPostCallback onUpdatePersonCompletedDelegate;
        
        private BeginOperationDelegate onBeginDeletePersonDelegate;
        
        private EndOperationDelegate onEndDeletePersonDelegate;
        
        private System.Threading.SendOrPostCallback onDeletePersonCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetPersonCompletedEventArgs> GetPersonCompleted;
        
        public event System.EventHandler<AddPersonCompletedEventArgs> AddPersonCompleted;
        
        public event System.EventHandler<UpdatePersonCompletedEventArgs> UpdatePersonCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> DeletePersonCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightSOA.PersonService.IPersonService.BeginGetPerson(int id, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetPerson(id, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SilverlightSOA.PersonService.PersonData SilverlightSOA.PersonService.IPersonService.EndGetPerson(System.IAsyncResult result) {
            return base.Channel.EndGetPerson(result);
        }
        
        private System.IAsyncResult OnBeginGetPerson(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int id = ((int)(inValues[0]));
            return ((SilverlightSOA.PersonService.IPersonService)(this)).BeginGetPerson(id, callback, asyncState);
        }
        
        private object[] OnEndGetPerson(System.IAsyncResult result) {
            SilverlightSOA.PersonService.PersonData retVal = ((SilverlightSOA.PersonService.IPersonService)(this)).EndGetPerson(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetPersonCompleted(object state) {
            if ((this.GetPersonCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetPersonCompleted(this, new GetPersonCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetPersonAsync(int id) {
            this.GetPersonAsync(id, null);
        }
        
        public void GetPersonAsync(int id, object userState) {
            if ((this.onBeginGetPersonDelegate == null)) {
                this.onBeginGetPersonDelegate = new BeginOperationDelegate(this.OnBeginGetPerson);
            }
            if ((this.onEndGetPersonDelegate == null)) {
                this.onEndGetPersonDelegate = new EndOperationDelegate(this.OnEndGetPerson);
            }
            if ((this.onGetPersonCompletedDelegate == null)) {
                this.onGetPersonCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetPersonCompleted);
            }
            base.InvokeAsync(this.onBeginGetPersonDelegate, new object[] {
                        id}, this.onEndGetPersonDelegate, this.onGetPersonCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightSOA.PersonService.IPersonService.BeginAddPerson(SilverlightSOA.PersonService.PersonData obj, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAddPerson(obj, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SilverlightSOA.PersonService.PersonData SilverlightSOA.PersonService.IPersonService.EndAddPerson(System.IAsyncResult result) {
            return base.Channel.EndAddPerson(result);
        }
        
        private System.IAsyncResult OnBeginAddPerson(object[] inValues, System.AsyncCallback callback, object asyncState) {
            SilverlightSOA.PersonService.PersonData obj = ((SilverlightSOA.PersonService.PersonData)(inValues[0]));
            return ((SilverlightSOA.PersonService.IPersonService)(this)).BeginAddPerson(obj, callback, asyncState);
        }
        
        private object[] OnEndAddPerson(System.IAsyncResult result) {
            SilverlightSOA.PersonService.PersonData retVal = ((SilverlightSOA.PersonService.IPersonService)(this)).EndAddPerson(result);
            return new object[] {
                    retVal};
        }
        
        private void OnAddPersonCompleted(object state) {
            if ((this.AddPersonCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.AddPersonCompleted(this, new AddPersonCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void AddPersonAsync(SilverlightSOA.PersonService.PersonData obj) {
            this.AddPersonAsync(obj, null);
        }
        
        public void AddPersonAsync(SilverlightSOA.PersonService.PersonData obj, object userState) {
            if ((this.onBeginAddPersonDelegate == null)) {
                this.onBeginAddPersonDelegate = new BeginOperationDelegate(this.OnBeginAddPerson);
            }
            if ((this.onEndAddPersonDelegate == null)) {
                this.onEndAddPersonDelegate = new EndOperationDelegate(this.OnEndAddPerson);
            }
            if ((this.onAddPersonCompletedDelegate == null)) {
                this.onAddPersonCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAddPersonCompleted);
            }
            base.InvokeAsync(this.onBeginAddPersonDelegate, new object[] {
                        obj}, this.onEndAddPersonDelegate, this.onAddPersonCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightSOA.PersonService.IPersonService.BeginUpdatePerson(SilverlightSOA.PersonService.PersonData obj, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpdatePerson(obj, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SilverlightSOA.PersonService.PersonData SilverlightSOA.PersonService.IPersonService.EndUpdatePerson(System.IAsyncResult result) {
            return base.Channel.EndUpdatePerson(result);
        }
        
        private System.IAsyncResult OnBeginUpdatePerson(object[] inValues, System.AsyncCallback callback, object asyncState) {
            SilverlightSOA.PersonService.PersonData obj = ((SilverlightSOA.PersonService.PersonData)(inValues[0]));
            return ((SilverlightSOA.PersonService.IPersonService)(this)).BeginUpdatePerson(obj, callback, asyncState);
        }
        
        private object[] OnEndUpdatePerson(System.IAsyncResult result) {
            SilverlightSOA.PersonService.PersonData retVal = ((SilverlightSOA.PersonService.IPersonService)(this)).EndUpdatePerson(result);
            return new object[] {
                    retVal};
        }
        
        private void OnUpdatePersonCompleted(object state) {
            if ((this.UpdatePersonCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UpdatePersonCompleted(this, new UpdatePersonCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UpdatePersonAsync(SilverlightSOA.PersonService.PersonData obj) {
            this.UpdatePersonAsync(obj, null);
        }
        
        public void UpdatePersonAsync(SilverlightSOA.PersonService.PersonData obj, object userState) {
            if ((this.onBeginUpdatePersonDelegate == null)) {
                this.onBeginUpdatePersonDelegate = new BeginOperationDelegate(this.OnBeginUpdatePerson);
            }
            if ((this.onEndUpdatePersonDelegate == null)) {
                this.onEndUpdatePersonDelegate = new EndOperationDelegate(this.OnEndUpdatePerson);
            }
            if ((this.onUpdatePersonCompletedDelegate == null)) {
                this.onUpdatePersonCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUpdatePersonCompleted);
            }
            base.InvokeAsync(this.onBeginUpdatePersonDelegate, new object[] {
                        obj}, this.onEndUpdatePersonDelegate, this.onUpdatePersonCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightSOA.PersonService.IPersonService.BeginDeletePerson(int id, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDeletePerson(id, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void SilverlightSOA.PersonService.IPersonService.EndDeletePerson(System.IAsyncResult result) {
            base.Channel.EndDeletePerson(result);
        }
        
        private System.IAsyncResult OnBeginDeletePerson(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int id = ((int)(inValues[0]));
            return ((SilverlightSOA.PersonService.IPersonService)(this)).BeginDeletePerson(id, callback, asyncState);
        }
        
        private object[] OnEndDeletePerson(System.IAsyncResult result) {
            ((SilverlightSOA.PersonService.IPersonService)(this)).EndDeletePerson(result);
            return null;
        }
        
        private void OnDeletePersonCompleted(object state) {
            if ((this.DeletePersonCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DeletePersonCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DeletePersonAsync(int id) {
            this.DeletePersonAsync(id, null);
        }
        
        public void DeletePersonAsync(int id, object userState) {
            if ((this.onBeginDeletePersonDelegate == null)) {
                this.onBeginDeletePersonDelegate = new BeginOperationDelegate(this.OnBeginDeletePerson);
            }
            if ((this.onEndDeletePersonDelegate == null)) {
                this.onEndDeletePersonDelegate = new EndOperationDelegate(this.OnEndDeletePerson);
            }
            if ((this.onDeletePersonCompletedDelegate == null)) {
                this.onDeletePersonCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDeletePersonCompleted);
            }
            base.InvokeAsync(this.onBeginDeletePersonDelegate, new object[] {
                        id}, this.onEndDeletePersonDelegate, this.onDeletePersonCompletedDelegate, userState);
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
        
        protected override SilverlightSOA.PersonService.IPersonService CreateChannel() {
            return new PersonServiceClientChannel(this);
        }
        
        private class PersonServiceClientChannel : ChannelBase<SilverlightSOA.PersonService.IPersonService>, SilverlightSOA.PersonService.IPersonService {
            
            public PersonServiceClientChannel(System.ServiceModel.ClientBase<SilverlightSOA.PersonService.IPersonService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetPerson(int id, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = id;
                System.IAsyncResult _result = base.BeginInvoke("GetPerson", _args, callback, asyncState);
                return _result;
            }
            
            public SilverlightSOA.PersonService.PersonData EndGetPerson(System.IAsyncResult result) {
                object[] _args = new object[0];
                SilverlightSOA.PersonService.PersonData _result = ((SilverlightSOA.PersonService.PersonData)(base.EndInvoke("GetPerson", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginAddPerson(SilverlightSOA.PersonService.PersonData obj, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = obj;
                System.IAsyncResult _result = base.BeginInvoke("AddPerson", _args, callback, asyncState);
                return _result;
            }
            
            public SilverlightSOA.PersonService.PersonData EndAddPerson(System.IAsyncResult result) {
                object[] _args = new object[0];
                SilverlightSOA.PersonService.PersonData _result = ((SilverlightSOA.PersonService.PersonData)(base.EndInvoke("AddPerson", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginUpdatePerson(SilverlightSOA.PersonService.PersonData obj, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = obj;
                System.IAsyncResult _result = base.BeginInvoke("UpdatePerson", _args, callback, asyncState);
                return _result;
            }
            
            public SilverlightSOA.PersonService.PersonData EndUpdatePerson(System.IAsyncResult result) {
                object[] _args = new object[0];
                SilverlightSOA.PersonService.PersonData _result = ((SilverlightSOA.PersonService.PersonData)(base.EndInvoke("UpdatePerson", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginDeletePerson(int id, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = id;
                System.IAsyncResult _result = base.BeginInvoke("DeletePerson", _args, callback, asyncState);
                return _result;
            }
            
            public void EndDeletePerson(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("DeletePerson", _args, result);
            }
        }
    }
}
