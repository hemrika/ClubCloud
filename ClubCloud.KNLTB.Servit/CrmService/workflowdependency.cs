using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		public workflowdependency()
		{
		}
	}
}