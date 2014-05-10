using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public CrmMoney amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		public CrmMoney amount_base
		{
			get
			{
				return this.amount_baseField;
			}
			set
			{
				this.amount_baseField = value;
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
		public Lookup discounttypeid
		{
			get
			{
				return this.discounttypeidField;
			}
			set
			{
				this.discounttypeidField = value;
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
		public UniqueIdentifier organizationid
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
		public CrmDecimal percentage
		{
			get
			{
				return this.percentageField;
			}
			set
			{
				this.percentageField = value;
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
		public Picklist pricingmethodcode
		{
			get
			{
				return this.pricingmethodcodeField;
			}
			set
			{
				this.pricingmethodcodeField = value;
			}
		}
		public Lookup productid
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
		public Key productpricelevelid
		{
			get
			{
				return this.productpricelevelidField;
			}
			set
			{
				this.productpricelevelidField = value;
			}
		}
		public Picklist quantitysellingcode
		{
			get
			{
				return this.quantitysellingcodeField;
			}
			set
			{
				this.quantitysellingcodeField = value;
			}
		}
		public CrmMoney roundingoptionamount
		{
			get
			{
				return this.roundingoptionamountField;
			}
			set
			{
				this.roundingoptionamountField = value;
			}
		}
		public CrmMoney roundingoptionamount_base
		{
			get
			{
				return this.roundingoptionamount_baseField;
			}
			set
			{
				this.roundingoptionamount_baseField = value;
			}
		}
		public Picklist roundingoptioncode
		{
			get
			{
				return this.roundingoptioncodeField;
			}
			set
			{
				this.roundingoptioncodeField = value;
			}
		}
		public Picklist roundingpolicycode
		{
			get
			{
				return this.roundingpolicycodeField;
			}
			set
			{
				this.roundingpolicycodeField = value;
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
		public Lookup uomid
		{
			get
			{
				return this.uomidField;
			}
			set
			{
				this.uomidField = value;
			}
		}
		public Lookup uomscheduleid
		{
			get
			{
				return this.uomscheduleidField;
			}
			set
			{
				this.uomscheduleidField = value;
			}
		}
	}
}
