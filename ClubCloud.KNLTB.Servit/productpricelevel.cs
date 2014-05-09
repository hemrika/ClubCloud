using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class productpricelevel : BusinessEntity
	{
		private CrmMoney amountField;
		private CrmMoney amount_baseField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Lookup discounttypeidField;
		private CrmDecimal exchangerateField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private UniqueIdentifier organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmDecimal percentageField;
		private Lookup pricelevelidField;
		private Picklist pricingmethodcodeField;
		private Lookup productidField;
		private Key productpricelevelidField;
		private Picklist quantitysellingcodeField;
		private CrmMoney roundingoptionamountField;
		private CrmMoney roundingoptionamount_baseField;
		private Picklist roundingoptioncodeField;
		private Picklist roundingpolicycodeField;
		private Lookup transactioncurrencyidField;
		private Lookup uomidField;
		private Lookup uomscheduleidField;
		[XmlElement(Order = 0)]
		public CrmMoney amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				base.RaisePropertyChanged("amount");
			}
		}
		[XmlElement(Order = 1)]
		public CrmMoney amount_base
		{
			get
			{
				return this.amount_baseField;
			}
			set
			{
				this.amount_baseField = value;
				base.RaisePropertyChanged("amount_base");
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
		public Lookup discounttypeid
		{
			get
			{
				return this.discounttypeidField;
			}
			set
			{
				this.discounttypeidField = value;
				base.RaisePropertyChanged("discounttypeid");
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
		public UniqueIdentifier organizationid
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
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
		public CrmDecimal percentage
		{
			get
			{
				return this.percentageField;
			}
			set
			{
				this.percentageField = value;
				base.RaisePropertyChanged("percentage");
			}
		}
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
		public Picklist pricingmethodcode
		{
			get
			{
				return this.pricingmethodcodeField;
			}
			set
			{
				this.pricingmethodcodeField = value;
				base.RaisePropertyChanged("pricingmethodcode");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
		public Key productpricelevelid
		{
			get
			{
				return this.productpricelevelidField;
			}
			set
			{
				this.productpricelevelidField = value;
				base.RaisePropertyChanged("productpricelevelid");
			}
		}
		[XmlElement(Order = 16)]
		public Picklist quantitysellingcode
		{
			get
			{
				return this.quantitysellingcodeField;
			}
			set
			{
				this.quantitysellingcodeField = value;
				base.RaisePropertyChanged("quantitysellingcode");
			}
		}
		[XmlElement(Order = 17)]
		public CrmMoney roundingoptionamount
		{
			get
			{
				return this.roundingoptionamountField;
			}
			set
			{
				this.roundingoptionamountField = value;
				base.RaisePropertyChanged("roundingoptionamount");
			}
		}
		[XmlElement(Order = 18)]
		public CrmMoney roundingoptionamount_base
		{
			get
			{
				return this.roundingoptionamount_baseField;
			}
			set
			{
				this.roundingoptionamount_baseField = value;
				base.RaisePropertyChanged("roundingoptionamount_base");
			}
		}
		[XmlElement(Order = 19)]
		public Picklist roundingoptioncode
		{
			get
			{
				return this.roundingoptioncodeField;
			}
			set
			{
				this.roundingoptioncodeField = value;
				base.RaisePropertyChanged("roundingoptioncode");
			}
		}
		[XmlElement(Order = 20)]
		public Picklist roundingpolicycode
		{
			get
			{
				return this.roundingpolicycodeField;
			}
			set
			{
				this.roundingpolicycodeField = value;
				base.RaisePropertyChanged("roundingpolicycode");
			}
		}
		[XmlElement(Order = 21)]
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
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
		public Lookup uomscheduleid
		{
			get
			{
				return this.uomscheduleidField;
			}
			set
			{
				this.uomscheduleidField = value;
				base.RaisePropertyChanged("uomscheduleid");
			}
		}
	}
}
