﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Этот исходный код был создан с помощью xsd, версия=4.8.3928.0.
// 
namespace RegistrySchemas.DTO.L_reg {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PERS_LIST {
        
        private PERS_LISTZGLV zGLVField;
        
        private PERS_LISTPERS[] pERSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PERS_LISTZGLV ZGLV {
            get {
                return this.zGLVField;
            }
            set {
                this.zGLVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PERS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PERS_LISTPERS[] PERS {
            get {
                return this.pERSField;
            }
            set {
                this.pERSField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PERS_LISTZGLV {
        
        private string vERSIONField;
        
        private System.DateTime dATAField;
        
        private string fILENAMEField;
        
        private string fILENAME1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string VERSION {
            get {
                return this.vERSIONField;
            }
            set {
                this.vERSIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DATA {
            get {
                return this.dATAField;
            }
            set {
                this.dATAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string FILENAME {
            get {
                return this.fILENAMEField;
            }
            set {
                this.fILENAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string FILENAME1 {
            get {
                return this.fILENAME1Field;
            }
            set {
                this.fILENAME1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PERS_LISTPERS {
        
        private string iD_PACField;
        
        private string fAMField;
        
        private string imField;
        
        private string otField;
        
        private long wField;
        
        private System.DateTime drField;
        
        private long[] dOSTField;
        
        private string tELField;
        
        private string fAM_PField;
        
        private string iM_PField;
        
        private string oT_PField;
        
        private long w_PField;
        
        private bool w_PFieldSpecified;
        
        private System.DateTime dR_PField;
        
        private bool dR_PFieldSpecified;
        
        private long[] dOST_PField;
        
        private string mrField;
        
        private string dOCTYPEField;
        
        private string dOCSERField;
        
        private string dOCNUMField;
        
        private System.DateTime dOCDATEField;
        
        private bool dOCDATEFieldSpecified;
        
        private string dOCORGField;
        
        private string sNILSField;
        
        private string oKATOGField;
        
        private string oKATOPField;
        
        private string cOMENTPField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string ID_PAC {
            get {
                return this.iD_PACField;
            }
            set {
                this.iD_PACField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string FAM {
            get {
                return this.fAMField;
            }
            set {
                this.fAMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string IM {
            get {
                return this.imField;
            }
            set {
                this.imField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string OT {
            get {
                return this.otField;
            }
            set {
                this.otField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long W {
            get {
                return this.wField;
            }
            set {
                this.wField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DR {
            get {
                return this.drField;
            }
            set {
                this.drField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DOST", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long[] DOST {
            get {
                return this.dOSTField;
            }
            set {
                this.dOSTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string TEL {
            get {
                return this.tELField;
            }
            set {
                this.tELField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string FAM_P {
            get {
                return this.fAM_PField;
            }
            set {
                this.fAM_PField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string IM_P {
            get {
                return this.iM_PField;
            }
            set {
                this.iM_PField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string OT_P {
            get {
                return this.oT_PField;
            }
            set {
                this.oT_PField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long W_P {
            get {
                return this.w_PField;
            }
            set {
                this.w_PField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool W_PSpecified {
            get {
                return this.w_PFieldSpecified;
            }
            set {
                this.w_PFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DR_P {
            get {
                return this.dR_PField;
            }
            set {
                this.dR_PField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DR_PSpecified {
            get {
                return this.dR_PFieldSpecified;
            }
            set {
                this.dR_PFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DOST_P", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long[] DOST_P {
            get {
                return this.dOST_PField;
            }
            set {
                this.dOST_PField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string MR {
            get {
                return this.mrField;
            }
            set {
                this.mrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string DOCTYPE {
            get {
                return this.dOCTYPEField;
            }
            set {
                this.dOCTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string DOCSER {
            get {
                return this.dOCSERField;
            }
            set {
                this.dOCSERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string DOCNUM {
            get {
                return this.dOCNUMField;
            }
            set {
                this.dOCNUMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
        public System.DateTime DOCDATE {
            get {
                return this.dOCDATEField;
            }
            set {
                this.dOCDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DOCDATESpecified {
            get {
                return this.dOCDATEFieldSpecified;
            }
            set {
                this.dOCDATEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string DOCORG {
            get {
                return this.dOCORGField;
            }
            set {
                this.dOCORGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string SNILS {
            get {
                return this.sNILSField;
            }
            set {
                this.sNILSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string OKATOG {
            get {
                return this.oKATOGField;
            }
            set {
                this.oKATOGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string OKATOP {
            get {
                return this.oKATOPField;
            }
            set {
                this.oKATOPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string COMENTP {
            get {
                return this.cOMENTPField;
            }
            set {
                this.cOMENTPField = value;
            }
        }
    }
}