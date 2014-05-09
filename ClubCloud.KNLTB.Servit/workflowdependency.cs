using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class workflowdependency : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string customentitynameField;
		private string dependentattributenameField;
		private string dependententitynameField;
		private string entityattributesField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private UniqueIdentifier owningbusinessunitField;
		private UniqueIdentifier owninguserField;
		private string parameternameField;
		private string parametertypeField;
		private string relatedattributenameField;
		private string relatedentitynameField;
		private Lookup sdkmessageidField;
		private Picklist typeField;
		private Key workflowdependencyidField;
		private Lookup workflowidField;
		[XmlElement(Order = 0)]
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
				base.RaisePropertyChanged("createdby");
			}
		}
		[XmlElement(Order = 1)]
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
				base.RaisePropertyChanged("createdon");
			}
		}
		[XmlElement(Order = 2)]
		public string customentityname
		{
			get
			{
				return this.customentitynameField;
			}
			set
			{
				this.customentitynameField = value;
				base.RaisePropertyChanged("customentityname");
			}
		}
		[XmlElement(Order = 3)]
		public string dependentattributename
		{
			get
			{
				return this.dependentattributenameField;
			}
			set
			{
				this.dependentattributenameField = value;
				base.RaisePropertyChanged("dependentattributename");
			}
		}
		[XmlElement(Order = 4)]
		public string dependententityname
		{
			get
			{
				return this.dependententitynameField;
			}
			set
			{
				this.dependententitynameField = value;
				base.RaisePropertyChanged("dependententityname");
			}
		}
		[XmlElement(Order = 5)]
		public string entityattributes
		{
			get
			{
				return this.entityattributesField;
			}
			set
			{
				this.entityattributesField = value;
				base.RaisePropertyChanged("entityattributes");
			}
		}
		[XmlElement(Order = 6)]
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
				base.RaisePropertyChanged("modifiedby");
			}
		}
		[XmlElement(Order = 7)]
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
				base.RaisePropertyChanged("modifiedon");
			}
		}
		[XmlElement(Order = 8)]
		public UniqueIdentifier owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
				base.RaisePropertyChanged("owningbusinessunit");
			}
		}
		[XmlElement(Order = 9)]
		public UniqueIdentifier owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
				base.RaisePropertyChanged("owninguser");
			}
		}
		[XmlElement(Order = 10)]
		public string parametername
		{
			get
			{
				return this.parameternameField;
			}
			set
			{
				this.parameternameField = value;
				base.RaisePropertyChanged("parametername");
			}
		}
		[XmlElement(Order = 11)]
		public string parametertype
		{
			get
			{
				return this.parametertypeField;
			}
			set
			{
				this.parametertypeField = value;
				base.RaisePropertyChanged("parametertype");
			}
		}
		[XmlElement(Order = 12)]
		public string relatedattributename
		{
			get
			{
				return this.relatedattributenameField;
			}
			set
			{
				this.relatedattributenameField = value;
				base.RaisePropertyChanged("relatedattributename");
			}
		}
		[XmlElement(Order = 13)]
		public string relatedentityname
		{
			get
			{
				return this.relatedentitynameField;
			}
			set
			{
				this.relatedentitynameField = value;
				base.RaisePropertyChanged("relatedentityname");
			}
		}
		[XmlElement(Order = 14)]
		public Lookup sdkmessageid
		{
			get
			{
				return this.sdkmessageidField;
			}
			set
			{
				this.sdkmessageidField = value;
				base.RaisePropertyChanged("sdkmessageid");
			}
		}
		[XmlElement(Order = 15)]
		public Picklist type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				base.RaisePropertyChanged("type");
			}
		}
		[XmlElement(Order = 16)]
		public Key workflowdependencyid
		{
			get
			{
				return this.workflowdependencyidField;
			}
			set
			{
				this.workflowdependencyidField = value;
				base.RaisePropertyChanged("workflowdependencyid");
			}
		}
		[XmlElement(Order = 17)]
		public Lookup workflowid
		{
			get
			{
				return this.workflowidField;
			}
			set
			{
				this.workflowidField = value;
				base.RaisePropertyChanged("workflowid");
			}
		}
	}
}
