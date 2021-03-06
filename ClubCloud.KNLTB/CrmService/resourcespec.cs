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
	public class resourcespec : BusinessEntity
	{
		private Lookup businessunitidField;

		private string constraintsField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private string descriptionField;

		private CrmFloat effortrequiredField;

		private UniqueIdentifier groupobjectidField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private string nameField;

		private string objectiveexpressionField;

		private EntityNameReference objecttypecodeField;

		private Lookup organizationidField;

		private CrmNumber requiredcountField;

		private Key resourcespecidField;

		private CrmBoolean samesiteField;

		[XmlElement] //[XmlElement(Order=0)]
		public Lookup businessunitid
		{
			get
			{
				return this.businessunitidField;
			}
			set
			{
				this.businessunitidField = value;
				base.RaisePropertyChanged("businessunitid");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string constraints
		{
			get
			{
				return this.constraintsField;
			}
			set
			{
				this.constraintsField = value;
				base.RaisePropertyChanged("constraints");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				base.RaisePropertyChanged("description");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public CrmFloat effortrequired
		{
			get
			{
				return this.effortrequiredField;
			}
			set
			{
				this.effortrequiredField = value;
				base.RaisePropertyChanged("effortrequired");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public UniqueIdentifier groupobjectid
		{
			get
			{
				return this.groupobjectidField;
			}
			set
			{
				this.groupobjectidField = value;
				base.RaisePropertyChanged("groupobjectid");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				base.RaisePropertyChanged("name");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string objectiveexpression
		{
			get
			{
				return this.objectiveexpressionField;
			}
			set
			{
				this.objectiveexpressionField = value;
				base.RaisePropertyChanged("objectiveexpression");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public EntityNameReference objecttypecode
		{
			get
			{
				return this.objecttypecodeField;
			}
			set
			{
				this.objecttypecodeField = value;
				base.RaisePropertyChanged("objecttypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmNumber requiredcount
		{
			get
			{
				return this.requiredcountField;
			}
			set
			{
				this.requiredcountField = value;
				base.RaisePropertyChanged("requiredcount");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Key resourcespecid
		{
			get
			{
				return this.resourcespecidField;
			}
			set
			{
				this.resourcespecidField = value;
				base.RaisePropertyChanged("resourcespecid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmBoolean samesite
		{
			get
			{
				return this.samesiteField;
			}
			set
			{
				this.samesiteField = value;
				base.RaisePropertyChanged("samesite");
			}
		}

		public resourcespec()
		{
		}
	}
}