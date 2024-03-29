// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
// This source code was auto-generated by Web Services Description Language Utility
//Mono Framework v4.0.30319.17020
//


/// <remarks/>
[System.Web.Services.WebServiceBinding(Name="servicePort", Namespace="http://webservice/")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ServiceService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback multOperationCompleted;
    
    private System.Threading.SendOrPostCallback subOperationCompleted;
    
    private System.Threading.SendOrPostCallback addOperationCompleted;
    
    private System.Threading.SendOrPostCallback divOperationCompleted;
    
    public ServiceService() {
        this.Url = "http://localhost:8080/JavaWebService-war/ServiceService";
    }
    
    public event multCompletedEventHandler multCompleted;
    
    public event subCompletedEventHandler subCompleted;
    
    public event addCompletedEventHandler addCompleted;
    
    public event divCompletedEventHandler divCompleted;
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice/", ResponseNamespace="http://webservice/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public double mult([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] double a, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] double b) {
        object[] results = this.Invoke("mult", new object[] {
                    a,
                    b});
        return ((double)(results[0]));
    }
    
    public System.IAsyncResult Beginmult(double a, double b, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("mult", new object[] {
                    a,
                    b}, callback, asyncState);
    }
    
    public double Endmult(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((double)(results[0]));
    }
    
    public void multAsync(double a, double b) {
        this.multAsync(a, b, null);
    }
    
    public void multAsync(double a, double b, object userState) {
        if ((this.multOperationCompleted == null)) {
            this.multOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmultCompleted);
        }
        this.InvokeAsync("mult", new object[] {
                    a,
                    b}, this.multOperationCompleted, userState);
    }
    
    private void OnmultCompleted(object arg) {
        if ((this.multCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.multCompleted(this, new multCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice/", ResponseNamespace="http://webservice/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public double sub([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] double a, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] double b) {
        object[] results = this.Invoke("sub", new object[] {
                    a,
                    b});
        return ((double)(results[0]));
    }
    
    public System.IAsyncResult Beginsub(double a, double b, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("sub", new object[] {
                    a,
                    b}, callback, asyncState);
    }
    
    public double Endsub(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((double)(results[0]));
    }
    
    public void subAsync(double a, double b) {
        this.subAsync(a, b, null);
    }
    
    public void subAsync(double a, double b, object userState) {
        if ((this.subOperationCompleted == null)) {
            this.subOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsubCompleted);
        }
        this.InvokeAsync("sub", new object[] {
                    a,
                    b}, this.subOperationCompleted, userState);
    }
    
    private void OnsubCompleted(object arg) {
        if ((this.subCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.subCompleted(this, new subCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice/", ResponseNamespace="http://webservice/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public double add([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] double a, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] double b) {
        object[] results = this.Invoke("add", new object[] {
                    a,
                    b});
        return ((double)(results[0]));
    }
    
    public System.IAsyncResult Beginadd(double a, double b, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("add", new object[] {
                    a,
                    b}, callback, asyncState);
    }
    
    public double Endadd(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((double)(results[0]));
    }
    
    public void addAsync(double a, double b) {
        this.addAsync(a, b, null);
    }
    
    public void addAsync(double a, double b, object userState) {
        if ((this.addOperationCompleted == null)) {
            this.addOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddCompleted);
        }
        this.InvokeAsync("add", new object[] {
                    a,
                    b}, this.addOperationCompleted, userState);
    }
    
    private void OnaddCompleted(object arg) {
        if ((this.addCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.addCompleted(this, new addCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice/", ResponseNamespace="http://webservice/", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public double div([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] double a, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] double b) {
        object[] results = this.Invoke("div", new object[] {
                    a,
                    b});
        return ((double)(results[0]));
    }
    
    public System.IAsyncResult Begindiv(double a, double b, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("div", new object[] {
                    a,
                    b}, callback, asyncState);
    }
    
    public double Enddiv(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((double)(results[0]));
    }
    
    public void divAsync(double a, double b) {
        this.divAsync(a, b, null);
    }
    
    public void divAsync(double a, double b, object userState) {
        if ((this.divOperationCompleted == null)) {
            this.divOperationCompleted = new System.Threading.SendOrPostCallback(this.OndivCompleted);
        }
        this.InvokeAsync("div", new object[] {
                    a,
                    b}, this.divOperationCompleted, userState);
    }
    
    private void OndivCompleted(object arg) {
        if ((this.divCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.divCompleted(this, new divCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
}

public partial class multCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal multCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public double Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((double)(this.results[0]));
        }
    }
}

public delegate void multCompletedEventHandler(object sender, multCompletedEventArgs args);

public partial class subCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal subCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public double Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((double)(this.results[0]));
        }
    }
}

public delegate void subCompletedEventHandler(object sender, subCompletedEventArgs args);

public partial class addCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal addCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public double Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((double)(this.results[0]));
        }
    }
}

public delegate void addCompletedEventHandler(object sender, addCompletedEventArgs args);

public partial class divCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal divCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public double Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((double)(this.results[0]));
        }
    }
}

public delegate void divCompletedEventHandler(object sender, divCompletedEventArgs args);
