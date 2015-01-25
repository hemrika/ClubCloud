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
		public CrmMoney currentcost
		{
			get
			{
				return this.currentcostField;
			}
			set
			{
				this.currentcostField = value;
				base.RaisePropertyChanged("currentcost");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public CrmMoney currentcost_base
		{
			get
			{
				return this.currentcost_baseField;
			}
			set
			{
				this.currentcost_baseField = value;
				base.RaisePropertyChanged("currentcost_base");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public Lookup defaultuomid
		{
			get
			{
				return this.defaultuomidField;
			}
			set
			{
				this.defaultuomidField = value;
				base.RaisePropertyChanged("defaultuomid");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public Lookup defaultuomscheduleid
		{
			get
			{
				return this.defaultuomscheduleidField;
			}
			set
			{
				this.defaultuomscheduleidField = value;
				base.RaisePropertyChanged("defaultuomscheduleid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
				base.RaisePropertyChanged("exchangerate");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public CrmBoolean iskit
		{
			get
			{
				return this.iskitField;
			}
			set
			{
				this.iskitField = value;
				base.RaisePropertyChanged("iskit");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmBoolean isstockitem
		{
			get
			{
				return this.isstockitemField;
			}
			set
			{
				this.isstockitemField = value;
				base.RaisePropertyChanged("isstockitem");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
		public CrmMoney price
		{
			get
			{
				return this.priceField;
			}
			set
			{
				this.priceField = value;
				base.RaisePropertyChanged("price");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmMoney price_base
		{
			get
			{
				return this.price_baseField;
			}
			set
			{
				this.price_baseField = value;
				base.RaisePropertyChanged("price_base");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Lookup pricelevelid
		{
			get
			{
				return this.pricelevelidField;
			}
			set
			{
				this.pricelevelidField = value;
				base.RaisePropertyChanged("pricelevelid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Key productid
		{
			get
			{
				return this.productidField;
			}
			set
			{
				this.productidField = value;
				base.RaisePropertyChanged("productid");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string productnumber
		{
			get
			{
				return this.productnumberField;
			}
			set
			{
				this.productnumberField = value;
				base.RaisePropertyChanged("productnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Picklist producttypecode
		{
			get
			{
				return this.producttypecodeField;
			}
			set
			{
				this.producttypecodeField = value;
				base.RaisePropertyChanged("producttypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public string producturl
		{
			get
			{
				return this.producturlField;
			}
			set
			{
				this.producturlField = value;
				base.RaisePropertyChanged("producturl");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public CrmNumber quantitydecimal
		{
			get
			{
				return this.quantitydecimalField;
			}
			set
			{
				this.quantitydecimalField = value;
				base.RaisePropertyChanged("quantitydecimal");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public CrmDecimal quantityonhand
		{
			get
			{
				return this.quantityonhandField;
			}
			set
			{
				this.quantityonhandField = value;
				base.RaisePropertyChanged("quantityonhand");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public Lookup sgt_btw_codeid
		{
			get
			{
				return this.sgt_btw_codeidField;
			}
			set
			{
				this.sgt_btw_codeidField = value;
				base.RaisePropertyChanged("sgt_btw_codeid");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public Lookup sgt_grootboekcodeid
		{
			get
			{
				return this.sgt_grootboekcodeidField;
			}
			set
			{
				this.sgt_grootboekcodeidField = value;
				base.RaisePropertyChanged("sgt_grootboekcodeid");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public string size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				this.sizeField = value;
				base.RaisePropertyChanged("size");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public CrmMoney standardcost
		{
			get
			{
				return this.standardcostField;
			}
			set
			{
				this.standardcostField = value;
				base.RaisePropertyChanged("standardcost");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public CrmMoney standardcost_base
		{
			get
			{
				return this.standardcost_baseField;
			}
			set
			{
				this.standardcost_baseField = value;
				base.RaisePropertyChanged("standardcost_base");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public ProductStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
				base.RaisePropertyChanged("statuscode");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public CrmDecimal stockvolume
		{
			get
			{
				return this.stockvolumeField;
			}
			set
			{
				this.stockvolumeField = value;
				base.RaisePropertyChanged("stockvolume");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public CrmDecimal stockweight
		{
			get
			{
				return this.stockweightField;
			}
			set
			{
				this.stockweightField = value;
				base.RaisePropertyChanged("stockweight");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public Lookup subjectid
		{
			get
			{
				return this.subjectidField;
			}
			set
			{
				this.subjectidField = value;
				base.RaisePropertyChanged("subjectid");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public string suppliername
		{
			get
			{
				return this.suppliernameField;
			}
			set
			{
				this.suppliernameField = value;
				base.RaisePropertyChanged("suppliername");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
				base.RaisePropertyChanged("timezoneruleversionnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
				base.RaisePropertyChanged("transactioncurrencyid");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
				base.RaisePropertyChanged("utcconversiontimezonecode");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public string vendorname
		{
			get
			{
				return this.vendornameField;
			}
			set
			{
				this.vendornameField = value;
				base.RaisePropertyChanged("vendorname");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public string vendorpartnumber
		{
			get
			{
				return this.vendorpartnumberField;
			}
			set
			{
				this.vendorpartnumberField = value;
				base.RaisePropertyChanged("vendorpartnumber");
			}
		}

		public product()
		{
		}
	}
}