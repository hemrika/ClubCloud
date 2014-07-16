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
	public class duplicaterulecondition : BusinessEntity
	{
		private string baseattributenameField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private Key duplicateruleconditionidField;

		private string matchingattributenameField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Picklist operatorcodeField;

		private CrmNumber operatorparamField;

		private UniqueIdentifier owningbusinessunitField;

		private UniqueIdentifier owninguserField;

		private Lookup regardingobjectidField;

		[XmlElement] //[XmlElement(Order=0)]
		public string baseattributename
		{
			get
			{
				return this.baseattributenameField;
			}
			set
			{
				this.baseattributenameField = value;
				base.RaisePropertyChanged("baseattributename");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
		public Key duplicateruleconditionid
		{
			get
			{
				return this.duplicateruleconditionidField;
			}
			set
			{
				this.duplicateruleconditionidField = value;
				base.RaisePropertyChanged("duplicateruleconditionid");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public string matchingattributename
		{
			get
			{
				return this.matchingattributenameField;
			}
			set
			{
				this.matchingattributenameField = value;
				base.RaisePropertyChanged("matchingattributename");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
		public Picklist operatorcode
		{
			get
			{
				return this.operatorcodeField;
			}
			set
			{
				this.operatorcodeField = value;
				base.RaisePropertyChanged("operatorcode");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public CrmNumber operatorparam
		{
			get
			{
				return this.operatorparamField;
			}
			set
			{
				this.operatorparamField = value;
				base.RaisePropertyChanged("operatorparam");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup regardingobjectid
		{
			get
			{
				return this.regardingobjectidField;
			}
			set
			{
				this.regardingobjectidField = value;
				base.RaisePropertyChanged("regardingobjectid");
			}
		}

		public duplicaterulecondition()
		{
		}
	}
}