﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppFromConsoleHost_Consumer.ServiceStoreReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/Store.ProductsRepo")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SupplierIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> UnitsField;
        
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
        public System.Nullable<int> Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SupplierID {
            get {
                return this.SupplierIDField;
            }
            set {
                if ((this.SupplierIDField.Equals(value) != true)) {
                    this.SupplierIDField = value;
                    this.RaisePropertyChanged("SupplierID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Units {
            get {
                return this.UnitsField;
            }
            set {
                if ((this.UnitsField.Equals(value) != true)) {
                    this.UnitsField = value;
                    this.RaisePropertyChanged("Units");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceStoreReference.IProductsService")]
    public interface IProductsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/GetProducts", ReplyAction="http://tempuri.org/IProductsService/GetProductsResponse")]
        WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product[] GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/GetProducts", ReplyAction="http://tempuri.org/IProductsService/GetProductsResponse")]
        System.Threading.Tasks.Task<WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product[]> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/GetProduct", ReplyAction="http://tempuri.org/IProductsService/GetProductResponse")]
        WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product GetProduct(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/GetProduct", ReplyAction="http://tempuri.org/IProductsService/GetProductResponse")]
        System.Threading.Tasks.Task<WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product> GetProductAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/DeleteProduct", ReplyAction="http://tempuri.org/IProductsService/DeleteProductResponse")]
        bool DeleteProduct(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/DeleteProduct", ReplyAction="http://tempuri.org/IProductsService/DeleteProductResponse")]
        System.Threading.Tasks.Task<bool> DeleteProductAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/AddProduct", ReplyAction="http://tempuri.org/IProductsService/AddProductResponse")]
        bool AddProduct(WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/AddProduct", ReplyAction="http://tempuri.org/IProductsService/AddProductResponse")]
        System.Threading.Tasks.Task<bool> AddProductAsync(WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/EditProduct", ReplyAction="http://tempuri.org/IProductsService/EditProductResponse")]
        bool EditProduct(WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/EditProduct", ReplyAction="http://tempuri.org/IProductsService/EditProductResponse")]
        System.Threading.Tasks.Task<bool> EditProductAsync(WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product product);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductsServiceChannel : WebAppFromConsoleHost_Consumer.ServiceStoreReference.IProductsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsServiceClient : System.ServiceModel.ClientBase<WebAppFromConsoleHost_Consumer.ServiceStoreReference.IProductsService>, WebAppFromConsoleHost_Consumer.ServiceStoreReference.IProductsService {
        
        public ProductsServiceClient() {
        }
        
        public ProductsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product[] GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product[]> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product GetProduct(int id) {
            return base.Channel.GetProduct(id);
        }
        
        public System.Threading.Tasks.Task<WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product> GetProductAsync(int id) {
            return base.Channel.GetProductAsync(id);
        }
        
        public bool DeleteProduct(int id) {
            return base.Channel.DeleteProduct(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteProductAsync(int id) {
            return base.Channel.DeleteProductAsync(id);
        }
        
        public bool AddProduct(WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product product) {
            return base.Channel.AddProduct(product);
        }
        
        public System.Threading.Tasks.Task<bool> AddProductAsync(WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product product) {
            return base.Channel.AddProductAsync(product);
        }
        
        public bool EditProduct(WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product product) {
            return base.Channel.EditProduct(product);
        }
        
        public System.Threading.Tasks.Task<bool> EditProductAsync(WebAppFromConsoleHost_Consumer.ServiceStoreReference.Product product) {
            return base.Channel.EditProductAsync(product);
        }
    }
}
