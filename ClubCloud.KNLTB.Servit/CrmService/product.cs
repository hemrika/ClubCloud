using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class product : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmMoney currentcostField;
		private CrmMoney currentcost_baseField;
		private Lookup defaultuomidField;
		private Lookup defaultuomscheduleidField;
		private string descriptionField;
		private CrmDecimal exchangerateField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean iskitField;
		private CrmBoolean isstockitemField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmMoney priceField;
		private CrmMoney price_baseField;
		private Lookup pricelevelidField;
		private Key productidField;
		private string productnumberField;
		private Picklist producttypecodeField;
		private string producturlField;
		private CrmNumber quantitydecimalField;
		private CrmDecimal quantityonhandField;
		private Lookup sgt_btw_codeidField;
		private Lookup sgt_grootboekcodeidField;
		private string sizeField;
		private CrmMoney standardcostField;
		private CrmMoney standardcost_baseField;
		private ProductStateInfo statecodeField;
		private Status statuscodeField;
		private CrmDecimal stockvolumeField;
		private CrmDecimal stockweightField;
		private Lookup subjectidField;
		private string suppliernameField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private CrmNumber utcconversiontimezonecodeField;
		private string vendornameField;
		private string vendorpartnumberField;
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
		public CrmMoney currentcost
		{
			get
			{
				return this.currentcostField;
			}
			set
			{
				this.currentcostField = value;
			}
		}
		public CrmMoney currentcost_base
		{
			get
			{
				return this.currentcost_baseField;
			}
			set
			{
				this.currentcost_baseField = value;
			}
		}
		public Lookup defaultuomid
		{
			get
			{
				return this.defaultuomidField;
			}
			set
			{
				this.defaultuomidField = value;
			}
		}
		public Lookup defaultuomscheduleid
		{
			get
			{
				return this.defaultuomscheduleidField;
			}
			set
			{
				this.defaultuomscheduleidField = value;
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
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
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
		public CrmBoolean iskit
		{
			get
			{
				return this.iskitField;
			}
			set
			{
				this.iskitField = value;
			}
		}
		public CrmBoolean isstockitem
		{
			get
			{
				return this.isstockitemField;
			}
			set
			{
				this.isstockitemField = value;
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
		public CrmMoney price
		{
			get
			{
				return this.priceField;
			}
			set
			{
				this.priceField = value;
			}
		}
		public CrmMoney price_base
		{
			get
			{
				return this.price_baseField;
			}
			set
			{
				this.price_baseField = value;
			}
		}
		public Lookup pricelevelid
		{
			get
			{
				return this.pricelevelidField;
			}
			set
			{
				this.pricelevelidField = value;
			}
		}
		public Key productid
		{
			get
			{
				return this.productidField;
			}
			set
			{
				this.productidField = value;
			}
		}
		public string productnumber
		{
			get
			{
				return this.productnumberField;
			}
			set
			{
				this.productnumberField = value;
			}
		}
		public Picklist producttypecode
		{
			get
			{
				return this.producttypecodeField;
			}
			set
			{
				this.producttypecodeField = value;
			}
		}
		public string producturl
		{
			get
			{
				return this.producturlField;
			}
			set
			{
				this.producturlField = value;
			}
		}
		public CrmNumber quantitydecimal
		{
			get
			{
				return this.quantitydecimalField;
			}
			set
			{
				this.quantitydecimalField = value;
			}
		}
		public CrmDecimal quantityonhand
		{
			get
			{
				return this.quantityonhandField;
			}
			set
			{
				this.quantityonhandField = value;
			}
		}
		public Lookup sgt_btw_codeid
		{
			get
			{
				return this.sgt_btw_codeidField;
			}
			set
			{
				this.sgt_btw_codeidField = value;
			}
		}
		public Lookup sgt_grootboekcodeid
		{
			get
			{
				return this.sgt_grootboekcodeidField;
			}
			set
			{
				this.sgt_grootboekcodeidField = value;
			}
		}
		public string size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				this.sizeField = value;
			}
		}
		public CrmMoney standardcost
		{
			get
			{
				return this.standardcostField;
			}
			set
			{
				this.standardcostField = value;
			}
		}
		public CrmMoney standardcost_base
		{
			get
			{
				return this.standardcost_baseField;
			}
			set
			{
				this.standardcost_baseField = value;
			}
		}
		public ProductStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
			}
		}
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
			}
		}
		public CrmDecimal stockvolume
		{
			get
			{
				return this.stockvolumeField;
			}
			set
			{
				this.stockvolumeField = value;
			}
		}
		public CrmDecimal stockweight
		{
			get
			{
				return this.stockweightField;
			}
			set
			{
				this.stockweightField = value;
			}
		}
		public Lookup subjectid
		{
			get
			{
				return this.subjectidField;
			}
			set
			{
				this.subjectidField = value;
			}
		}
		public string suppliername
		{
			get
			{
				return this.suppliernameField;
			}
			set
			{
				this.suppliernameField = value;
			}
		}
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
			}
		}
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
			}
		}
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
			}
		}
		public string vendorname
		{
			get
			{
				return this.vendornameField;
			}
			set
			{
				this.vendornameField = value;
			}
		}
		public string vendorpartnumber
		{
			get
			{
				return this.vendorpartnumberField;
			}
			set
			{
				this.vendorpartnumberField = value;
			}
		}
	}
}
