//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by the XsdToClasses tool.
//     Tool Version:    1.2.23.0
//     Runtime Version: 4.0.30319.17929
//     Generated on:    05/06/2014 11:23:41 AM
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
// Workaround for bug http://lab.msdn.microsoft.com/productfeedback/viewfeedback.aspx?feedbackid=d457a36e-0ce8-4368-9a27-92762860d8e1
#pragma warning disable 1591
namespace eHealth.DHPO.Schema.eRxAuthFileDetails {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Files : System.ComponentModel.INotifyPropertyChanged {
        
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        /// <summary />
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        /// <summary />
        private FilesFileCollection itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("File", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FilesFileCollection Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class FilesFile : System.ComponentModel.INotifyPropertyChanged {
        
        /// <summary />
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        /// <summary />
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        /// <summary />
        private string fileIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FileID {
            get {
                return this.fileIDField;
            }
            set {
                this.fileIDField = value;
                this.RaisePropertyChanged("FileID");
            }
        }
        
        /// <summary />
        private string fileNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
                this.RaisePropertyChanged("FileName");
            }
        }
        
        /// <summary />
        private string senderIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SenderID {
            get {
                return this.senderIDField;
            }
            set {
                this.senderIDField = value;
                this.RaisePropertyChanged("SenderID");
            }
        }
        
        /// <summary />
        private string receiverIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReceiverID {
            get {
                return this.receiverIDField;
            }
            set {
                this.receiverIDField = value;
                this.RaisePropertyChanged("ReceiverID");
            }
        }
        
        /// <summary />
        private string transactionDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransactionDate {
            get {
                return this.transactionDateField;
            }
            set {
                this.transactionDateField = value;
                this.RaisePropertyChanged("TransactionDate");
            }
        }
        
        /// <summary />
        private string recordCountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RecordCount {
            get {
                return this.recordCountField;
            }
            set {
                this.recordCountField = value;
                this.RaisePropertyChanged("RecordCount");
            }
        }
        
        /// <summary />
        private string isDownloadedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsDownloaded {
            get {
                return this.isDownloadedField;
            }
            set {
                this.isDownloadedField = value;
                this.RaisePropertyChanged("IsDownloaded");
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace=null)]
    public partial class FilesFileCollection : System.Collections.Generic.List<FilesFile> {
    }
}
#pragma warning restore 1591