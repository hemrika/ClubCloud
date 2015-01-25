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
	public class contracttemplate : BusinessEntity
	{
		private string abbreviationField;

		private Picklist allotmenttypecodeField;

		private Picklist billingfrequencycodeField;

		private Picklist contractservicelevelcodeField;

		private Key contracttemplateidField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private string descriptionField;

		private string effectivitycalendarField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private string nameField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private CrmBoolean usediscountaspercentageField;

		[XmlElement] //[XmlElement(Order=0)]
		public string abbreviation
		{
			get
			{
				return this.abbreviationField;
			}
			set
			{
				this.abbreviationField = value;
				base.RaisePropertyChanged("abbreviation");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Picklist allotmenttypecode
		{
			get
			{
				return this.allotmenttypecodeField;
			}
			set
			{
				this.allotmenttypecodeField = value;
				base.RaisePropertyChanged("allotmenttypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public Picklist billingfrequencycode
		{
			get
			{
				return this.billingfrequencycodeField;
			}
			set
			{
				this.billingfrequencycodeField = value;
				base.RaisePropertyChanged("billingfrequencycode");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public Picklist contractservicelevelcode
		{
			get
			{
				return this.contractservicelevelcodeField;
			}
			set
			{
				this.contractservicelevelcodeField = value;
				base.RaisePropertyChanged("contractservicelevelcode");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public Key contracttemplateid
		{
			get
			{
				return this.contracttemplateidField;
			}
			set
			{
				this.contracttemplateidField = value;
				base.RaisePropertyChanged("contracttemplateid");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public string effectivitycalendar
		{
			get
			{
				return this.effectivitycalendarField;
			}
			set
			{
				this.effectivitycalendarField = value;
				base.RaisePropertyChanged("effectivitycalendar");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
				base.RaisePropertyChanged("importsequencenumber");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
				base.RaisePropertyChanged("overriddencreatedon");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmBoolean usediscountaspercentage
		{
			get
			{
				return this.usediscountaspercentageField;
			}
			set
			{
				this.usediscountaspercentageField = value;
				base.RaisePropertyChanged("usediscountaspercentage");
			}
		}

		public contracttemplate()
		{
		}
	}
}