// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.0.0.285
//    <NameSpace>ClubCloud.Zimbra.Replication</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net45</CodeBaseTag><InitializeFields>All</InitializeFields><GenerateUnusedComplexTypes>False</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>False</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>True</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><AutomaticProperties>False</AutomaticProperties><PropNameSpecified>Default</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>False</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>False</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>False</CleanupCode><EnableXmlSerialization>False</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><GenerateShouldSerialize>False</GenerateShouldSerialize><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings></CustomUsings>
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace ClubCloud.Zimbra.Replication
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.Serialization;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("BecomeMasterRequest", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "becomeMasterRequest", Namespace = "urn:zimbraRepl")]
    public partial class becomeMasterRequest : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("BecomeMasterResponse", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "becomeMasterResponse", Namespace = "urn:zimbraRepl")]
    public partial class becomeMasterResponse : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("BringDownServiceIPRequest", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "bringDownServiceIPRequest", Namespace = "urn:zimbraRepl")]
    public partial class bringDownServiceIPRequest : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("BringDownServiceIPResponse", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "bringDownServiceIPResponse", Namespace = "urn:zimbraRepl")]
    public partial class bringDownServiceIPResponse : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("BringUpServiceIPRequest", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "bringUpServiceIPRequest", Namespace = "urn:zimbraRepl")]
    public partial class bringUpServiceIPRequest : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("BringUpServiceIPResponse", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "bringUpServiceIPResponse", Namespace = "urn:zimbraRepl")]
    public partial class bringUpServiceIPResponse : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("ReplicationStatusRequest", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "replicationStatusRequest", Namespace = "urn:zimbraRepl")]
    public partial class replicationStatusRequest : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("ReplicationStatusResponse", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "replicationStatusResponse", Namespace = "urn:zimbraRepl")]
    public partial class replicationStatusResponse : System.ComponentModel.INotifyPropertyChanged
    {

        private replicationMasterStatus _masterStatus;

        private replicationSlaveStatus _slaveStatus;

        private bool _replicationEnabled;

        private string _currentRole;

        private string _originalRole;

        public replicationStatusResponse()
        {
            this._slaveStatus = new replicationSlaveStatus();
            this._masterStatus = new replicationMasterStatus();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public replicationMasterStatus masterStatus
        {
            get
            {
                return this._masterStatus;
            }
            set
            {
                if (((this._masterStatus == null)
                            || (_masterStatus.Equals(value) != true)))
                {
                    this._masterStatus = value;
                    this.OnPropertyChanged("masterStatus");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public replicationSlaveStatus slaveStatus
        {
            get
            {
                return this._slaveStatus;
            }
            set
            {
                if (((this._slaveStatus == null)
                            || (_slaveStatus.Equals(value) != true)))
                {
                    this._slaveStatus = value;
                    this.OnPropertyChanged("slaveStatus");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool replicationEnabled
        {
            get
            {
                return this._replicationEnabled;
            }
            set
            {
                if ((_replicationEnabled.Equals(value) != true))
                {
                    this._replicationEnabled = value;
                    this.OnPropertyChanged("replicationEnabled");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string currentRole
        {
            get
            {
                return this._currentRole;
            }
            set
            {
                if (((this._currentRole == null)
                            || (_currentRole.Equals(value) != true)))
                {
                    this._currentRole = value;
                    this.OnPropertyChanged("currentRole");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string originalRole
        {
            get
            {
                return this._originalRole;
            }
            set
            {
                if (((this._originalRole == null)
                            || (_originalRole.Equals(value) != true)))
                {
                    this._originalRole = value;
                    this.OnPropertyChanged("originalRole");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "replicationMasterStatus", Namespace = "urn:zimbraRepl")]
    public partial class replicationMasterStatus : System.ComponentModel.INotifyPropertyChanged
    {

        private replicationMasterCatchupStatus _catchupStatus;

        private string _masterOperatingMode;

        public replicationMasterStatus()
        {
            this._catchupStatus = new replicationMasterCatchupStatus();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public replicationMasterCatchupStatus catchupStatus
        {
            get
            {
                return this._catchupStatus;
            }
            set
            {
                if (((this._catchupStatus == null)
                            || (_catchupStatus.Equals(value) != true)))
                {
                    this._catchupStatus = value;
                    this.OnPropertyChanged("catchupStatus");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string masterOperatingMode
        {
            get
            {
                return this._masterOperatingMode;
            }
            set
            {
                if (((this._masterOperatingMode == null)
                            || (_masterOperatingMode.Equals(value) != true)))
                {
                    this._masterOperatingMode = value;
                    this.OnPropertyChanged("masterOperatingMode");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "replicationMasterCatchupStatus", Namespace = "urn:zimbraRepl")]
    public partial class replicationMasterCatchupStatus : System.ComponentModel.INotifyPropertyChanged
    {

        private int _remainingFiles;

        private long _remainingBytes;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int remainingFiles
        {
            get
            {
                return this._remainingFiles;
            }
            set
            {
                if ((_remainingFiles.Equals(value) != true))
                {
                    this._remainingFiles = value;
                    this.OnPropertyChanged("remainingFiles");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long remainingBytes
        {
            get
            {
                return this._remainingBytes;
            }
            set
            {
                if ((_remainingBytes.Equals(value) != true))
                {
                    this._remainingBytes = value;
                    this.OnPropertyChanged("remainingBytes");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "replicationSlaveStatus", Namespace = "urn:zimbraRepl")]
    public partial class replicationSlaveStatus : System.ComponentModel.INotifyPropertyChanged
    {

        private replicationSlaveCatchupStatus _catchupStatus;

        public replicationSlaveStatus()
        {
            this._catchupStatus = new replicationSlaveCatchupStatus();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public replicationSlaveCatchupStatus catchupStatus
        {
            get
            {
                return this._catchupStatus;
            }
            set
            {
                if (((this._catchupStatus == null)
                            || (_catchupStatus.Equals(value) != true)))
                {
                    this._catchupStatus = value;
                    this.OnPropertyChanged("catchupStatus");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "replicationSlaveCatchupStatus", Namespace = "urn:zimbraRepl")]
    public partial class replicationSlaveCatchupStatus : System.ComponentModel.INotifyPropertyChanged
    {

        private int _remainingOps;

        private int _remainingFiles;

        private long _remainingBytes;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int remainingOps
        {
            get
            {
                return this._remainingOps;
            }
            set
            {
                if ((_remainingOps.Equals(value) != true))
                {
                    this._remainingOps = value;
                    this.OnPropertyChanged("remainingOps");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int remainingFiles
        {
            get
            {
                return this._remainingFiles;
            }
            set
            {
                if ((_remainingFiles.Equals(value) != true))
                {
                    this._remainingFiles = value;
                    this.OnPropertyChanged("remainingFiles");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long remainingBytes
        {
            get
            {
                return this._remainingBytes;
            }
            set
            {
                if ((_remainingBytes.Equals(value) != true))
                {
                    this._remainingBytes = value;
                    this.OnPropertyChanged("remainingBytes");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("StartCatchupRequest", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "startCatchupRequest", Namespace = "urn:zimbraRepl")]
    public partial class startCatchupRequest : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("StartCatchupResponse", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "startCatchupResponse", Namespace = "urn:zimbraRepl")]
    public partial class startCatchupResponse : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("StartFailoverClientRequest", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "startFailoverClientRequest", Namespace = "urn:zimbraRepl")]
    public partial class startFailoverClientRequest : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("StartFailoverClientResponse", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "startFailoverClientResponse", Namespace = "urn:zimbraRepl")]
    public partial class startFailoverClientResponse : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("StartFailoverDaemonRequest", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "startFailoverDaemonRequest", Namespace = "urn:zimbraRepl")]
    public partial class startFailoverDaemonRequest : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("StartFailoverDaemonResponse", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "startFailoverDaemonResponse", Namespace = "urn:zimbraRepl")]
    public partial class startFailoverDaemonResponse : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("StopFailoverClientRequest", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "stopFailoverClientRequest", Namespace = "urn:zimbraRepl")]
    public partial class stopFailoverClientRequest : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("StopFailoverClientResponse", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "stopFailoverClientResponse", Namespace = "urn:zimbraRepl")]
    public partial class stopFailoverClientResponse : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("StopFailoverDaemonRequest", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "stopFailoverDaemonRequest", Namespace = "urn:zimbraRepl")]
    public partial class stopFailoverDaemonRequest : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraRepl")]
    [System.Xml.Serialization.XmlRootAttribute("StopFailoverDaemonResponse", Namespace = "urn:zimbraRepl", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "stopFailoverDaemonResponse", Namespace = "urn:zimbraRepl")]
    public partial class stopFailoverDaemonResponse : System.ComponentModel.INotifyPropertyChanged
    {

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
#pragma warning restore
