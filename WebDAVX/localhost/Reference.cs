﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3705.0
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.0.3705.0.
// 
namespace WebDAVWSConsumer.localhost {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebDAVRequestSoap", Namespace="http://tempuri.org/")]
    public class WebDAVRequest : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public WebDAVRequest() {
            this.Url = "http://localhost/WebDAVTest/WebDAVSearch.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Search", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Search(string strWorkspaceURL, string strSearchKeyword) {
            object[] results = this.Invoke("Search", new object[] {
                        strWorkspaceURL,
                        strSearchKeyword});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSearch(string strWorkspaceURL, string strSearchKeyword, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Search", new object[] {
                        strWorkspaceURL,
                        strSearchKeyword}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndSearch(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
    }
}