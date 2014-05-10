using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public string abbreviation
		{
			get
			{
				return this.abbreviationField;
			}
			set
			{
				this.abbreviationField = value;
			}
		}
		public Picklist allotmenttypecode
		{
			get
			{
				return this.allotmenttypecodeField;
			}
			set
			{
				this.allotmenttypecodeField = value;
			}
		}
		public Picklist billingfrequencycode
		{
			get
			{
				return this.billingfrequencycodeField;
			}
			set
			{
				this.billingfrequencycodeField = value;
			}
		}
		public Picklist contractservicelevelcode
		{
			get
			{
				return this.contractservicelevelcodeField;
			}
			set
			{
				this.contractservicelevelcodeField = value;
			}
		}
		public Key contracttemplateid
		{
			get
			{
				return this.contracttemplateidField;
			}
			set
			{
				this.contracttemplateidField = value;
			}
		}
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
			}
		}
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
			}
		}
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		public string effectivitycalendar
		{
			get
			{
				return this.effectivitycalendarField;
			}
			set
			{
				this.effectivitycalendarField = value;
			}
		}
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
			}
		}
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
			}
		}
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
			}
		}
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
			}
		}
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
			}
		}
		public CrmBoolean usediscountaspercentage
		{
			get
			{
				return this.usediscountaspercentageField;
			}
			set
			{
				this.usediscountaspercentageField = value;
			}
		}
	}
}
