using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class opportunityproduct : BusinessEntity
	{
		private CrmMoney baseamountField;
		private CrmMoney baseamount_baseField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmDecimal exchangerateField;
		private CrmMoney extendedamountField;
		private CrmMoney extendedamount_baseField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean ispriceoverriddenField;
		private CrmBoolean isproductoverriddenField;
		private CrmMoney manualdiscountamountField;
		private CrmMoney manualdiscountamount_baseField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup opportunityidField;
		private Key opportunityproductidField;
		private Picklist opportunitystatecodeField;
		private CrmDateTime overriddencreatedonField;
		private UniqueIdentifier owningbusinessunitField;
		private UniqueIdentifier owninguserField;
		private CrmMoney priceperunitField;
		private CrmMoney priceperunit_baseField;
		private Picklist pricingerrorcodeField;
		private string productdescriptionField;
		private Lookup productidField;
		private CrmDecimal quantityField;
		private CrmMoney taxField;
		private CrmMoney tax_baseField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private Lookup uomidField;
		private CrmNumber utcconversiontimezonecodeField;
		private CrmMoney volumediscountamountField;
		private CrmMoney volumediscountamount_baseField;
		[XmlElement(Order = 0)]
		public CrmMoney baseamount
		{
			get
			{
				return this.baseamountField;
			}
			set
			{
				this.baseamountField = value;
				base.RaisePropertyChanged("baseamount");
			}
		}
		[XmlElement(Order = 1)]
		public CrmMoney baseamount_base
		{
			get
			{
				return this.baseamount_baseField;
			}
			set
			{
				this.baseamount_baseField = value;
				base.RaisePropertyChanged("baseamount_base");
			}
		}
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
		public CrmMoney extendedamount
		{
			get
			{
				return this.extendedamountField;
			}
			set
			{
				this.extendedamountField = value;
				base.RaisePropertyChanged("extendedamount");
			}
		}
		[XmlElement(Order = 7)]
		public CrmMoney extendedamount_base
		{
			get
			{
				return this.extendedamount_baseField;
			}
			set
			{
				this.extendedamount_baseField = value;
				base.RaisePropertyChanged("extendedamount_base");
			}
		}
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
		public CrmBoolean ispriceoverridden
		{
			get
			{
				return this.ispriceoverriddenField;
			}
			set
			{
				this.ispriceoverriddenField = value;
				base.RaisePropertyChanged("ispriceoverridden");
			}
		}
		[XmlElement(Order = 10)]
		public CrmBoolean isproductoverridden
		{
			get
			{
				return this.isproductoverriddenField;
			}
			set
			{
				this.isproductoverriddenField = value;
				base.RaisePropertyChanged("isproductoverridden");
			}
		}
		[XmlElement(Order = 11)]
		public CrmMoney manualdiscountamount
		{
			get
			{
				return this.manualdiscountamountField;
			}
			set
			{
				this.manualdiscountamountField = value;
				base.RaisePropertyChanged("manualdiscountamount");
			}
		}
		[XmlElement(Order = 12)]
		public CrmMoney manualdiscountamount_base
		{
			get
			{
				return this.manualdiscountamount_baseField;
			}
			set
			{
				this.manualdiscountamount_baseField = value;
				base.RaisePropertyChanged("manualdiscountamount_base");
			}
		}
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
		public Lookup opportunityid
		{
			get
			{
				return this.opportunityidField;
			}
			set
			{
				this.opportunityidField = value;
				base.RaisePropertyChanged("opportunityid");
			}
		}
		[XmlElement(Order = 16)]
		public Key opportunityproductid
		{
			get
			{
				return this.opportunityproductidField;
			}
			set
			{
				this.opportunityproductidField = value;
				base.RaisePropertyChanged("opportunityproductid");
			}
		}
		[XmlElement(Order = 17)]
		public Picklist opportunitystatecode
		{
			get
			{
				return this.opportunitystatecodeField;
			}
			set
			{
				this.opportunitystatecodeField = value;
				base.RaisePropertyChanged("opportunitystatecode");
			}
		}
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
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
		[XmlElement(Order = 21)]
		public CrmMoney priceperunit
		{
			get
			{
				return this.priceperunitField;
			}
			set
			{
				this.priceperunitField = value;
				base.RaisePropertyChanged("priceperunit");
			}
		}
		[XmlElement(Order = 22)]
		public CrmMoney priceperunit_base
		{
			get
			{
				return this.priceperunit_baseField;
			}
			set
			{
				this.priceperunit_baseField = value;
				base.RaisePropertyChanged("priceperunit_base");
			}
		}
		[XmlElement(Order = 23)]
		public Picklist pricingerrorcode
		{
			get
			{
				return this.pricingerrorcodeField;
			}
			set
			{
				this.pricingerrorcodeField = value;
				base.RaisePropertyChanged("pricingerrorcode");
			}
		}
		[XmlElement(Order = 24)]
		public string productdescription
		{
			get
			{
				return this.productdescriptionField;
			}
			set
			{
				this.productdescriptionField = value;
				base.RaisePropertyChanged("productdescription");
			}
		}
		[XmlElement(Order = 25)]
		public Lookup productid
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
		[XmlElement(Order = 26)]
		public CrmDecimal quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
				base.RaisePropertyChanged("quantity");
			}
		}
		[XmlElement(Order = 27)]
		public CrmMoney tax
		{
			get
			{
				return this.taxField;
			}
			set
			{
				this.taxField = value;
				base.RaisePropertyChanged("tax");
			}
		}
		[XmlElement(Order = 28)]
		public CrmMoney tax_base
		{
			get
			{
				return this.tax_baseField;
			}
			set
			{
				this.tax_baseField = value;
				base.RaisePropertyChanged("tax_base");
			}
		}
		[XmlElement(Order = 29)]
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
		[XmlElement(Order = 30)]
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
		[XmlElement(Order = 31)]
		public Lookup uomid
		{
			get
			{
				return this.uomidField;
			}
			set
			{
				this.uomidField = value;
				base.RaisePropertyChanged("uomid");
			}
		}
		[XmlElement(Order = 32)]
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
		[XmlElement(Order = 33)]
		public CrmMoney volumediscountamount
		{
			get
			{
				return this.volumediscountamountField;
			}
			set
			{
				this.volumediscountamountField = value;
				base.RaisePropertyChanged("volumediscountamount");
			}
		}
		[XmlElement(Order = 34)]
		public CrmMoney volumediscountamount_base
		{
			get
			{
				return this.volumediscountamount_baseField;
			}
			set
			{
				this.volumediscountamount_baseField = value;
				base.RaisePropertyChanged("volumediscountamount_base");
			}
		}
	}
}
