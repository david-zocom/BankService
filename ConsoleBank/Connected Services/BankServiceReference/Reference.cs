﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleBank.BankServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AccountInfo", Namespace="http://schemas.datacontract.org/2004/07/BankServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class AccountInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BalanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OwnerNameField;
        
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
        public decimal Balance {
            get {
                return this.BalanceField;
            }
            set {
                if ((this.BalanceField.Equals(value) != true)) {
                    this.BalanceField = value;
                    this.RaisePropertyChanged("Balance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OwnerName {
            get {
                return this.OwnerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.OwnerNameField, value) != true)) {
                    this.OwnerNameField = value;
                    this.RaisePropertyChanged("OwnerName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BankServiceReference.IBankService")]
    public interface IBankService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/GetBalance", ReplyAction="http://tempuri.org/IBankService/GetBalanceResponse")]
        decimal GetBalance();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/GetBalance", ReplyAction="http://tempuri.org/IBankService/GetBalanceResponse")]
        System.Threading.Tasks.Task<decimal> GetBalanceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/Deposit", ReplyAction="http://tempuri.org/IBankService/DepositResponse")]
        void Deposit(decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/Deposit", ReplyAction="http://tempuri.org/IBankService/DepositResponse")]
        System.Threading.Tasks.Task DepositAsync(decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/GetAccountInfo", ReplyAction="http://tempuri.org/IBankService/GetAccountInfoResponse")]
        ConsoleBank.BankServiceReference.AccountInfo GetAccountInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/GetAccountInfo", ReplyAction="http://tempuri.org/IBankService/GetAccountInfoResponse")]
        System.Threading.Tasks.Task<ConsoleBank.BankServiceReference.AccountInfo> GetAccountInfoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBankServiceChannel : ConsoleBank.BankServiceReference.IBankService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BankServiceClient : System.ServiceModel.ClientBase<ConsoleBank.BankServiceReference.IBankService>, ConsoleBank.BankServiceReference.IBankService {
        
        public BankServiceClient() {
        }
        
        public BankServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BankServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal GetBalance() {
            return base.Channel.GetBalance();
        }
        
        public System.Threading.Tasks.Task<decimal> GetBalanceAsync() {
            return base.Channel.GetBalanceAsync();
        }
        
        public void Deposit(decimal amount) {
            base.Channel.Deposit(amount);
        }
        
        public System.Threading.Tasks.Task DepositAsync(decimal amount) {
            return base.Channel.DepositAsync(amount);
        }
        
        public ConsoleBank.BankServiceReference.AccountInfo GetAccountInfo() {
            return base.Channel.GetAccountInfo();
        }
        
        public System.Threading.Tasks.Task<ConsoleBank.BankServiceReference.AccountInfo> GetAccountInfoAsync() {
            return base.Channel.GetAccountInfoAsync();
        }
    }
}
