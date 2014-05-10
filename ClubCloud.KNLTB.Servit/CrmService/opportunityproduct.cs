using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public CrmMoney baseamount
		{
			get
			{
				return this.baseamountField;
			}
			set
			{
				this.baseamountField = value;
			}
		}
		public CrmMoney baseamount_base
		{
			get
			{
				return this.baseamount_baseField;
			}
			set
			{
				this.baseamount_baseField = value;
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
		public CrmMoney extendedamount
		{
			get
			{
				return this.extendedamountField;
			}
			set
			{
				this.extendedamountField = value;
			}
		}
		public CrmMoney extendedamount_base
		{
			get
			{
				return this.extendedamount_baseField;
			}
			set
			{
				this.extendedamount_baseField = value;
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
		public CrmBoolean ispriceoverridden
		{
			get
			{
				return this.ispriceoverriddenField;
			}
			set
			{
				this.ispriceoverriddenField = value;
			}
		}
		public CrmBoolean isproductoverridden
		{
			get
			{
				return this.isproductoverriddenField;
			}
			set
			{
				this.isproductoverriddenField = value;
			}
		}
		public CrmMoney manualdiscountamount
		{
			get
			{
				return this.manualdiscountamountField;
			}
			set
			{
				this.manualdiscountamountField = value;
			}
		}
		public CrmMoney manualdiscountamount_base
		{
			get
			{
				return this.manualdiscountamount_baseField;
			}
			set
			{
				this.manualdiscountamount_baseField = value;
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
		public Lookup opportunityid
		{
			get
			{
				return this.opportunityidField;
			}
			set
			{
				this.opportunityidField = value;
			}
		}
		public Key opportunityproductid
		{
			get
			{
				return this.opportunityproductidField;
			}
			set
			{
				this.opportunityproductidField = value;
			}
		}
		public Picklist opportunitystatecode
		{
			get
			{
				return this.opportunitystatecodeField;
			}
			set
			{
				this.opportunitystatecodeField = value;
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
		public UniqueIdentifier owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
			}
		}
		public UniqueIdentifier owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
			}
		}
		public CrmMoney priceperunit
		{
			get
			{
				return this.priceperunitField;
			}
			set
			{
				this.priceperunitField = value;
			}
		}
		public CrmMoney priceperunit_base
		{
			get
			{
				return this.priceperunit_baseField;
			}
			set
			{
				this.priceperunit_baseField = value;
			}
		}
		public Picklist pricingerrorcode
		{
			get
			{
				return this.pricingerrorcodeField;
			}
			set
			{
				this.pricingerrorcodeField = value;
			}
		}
		public string productdescription
		{
			get
			{
				return this.productdescriptionField;
			}
			set
			{
				this.productdescriptionField = value;
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
		public CrmDecimal quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}
		public CrmMoney tax
		{
			get
			{
				return this.taxField;
			}
			set
			{
				this.taxField = value;
			}
		}
		public CrmMoney tax_base
		{
			get
			{
				return this.tax_baseField;
			}
			set
			{
				this.tax_baseField = value;
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
		public CrmMoney volumediscountamount
		{
			get
			{
				return this.volumediscountamountField;
			}
			set
			{
				this.volumediscountamountField = value;
			}
		}
		public CrmMoney volumediscountamount_base
		{
			get
			{
				return this.volumediscountamount_baseField;
			}
			set
			{
				this.volumediscountamount_baseField = value;
			}
		}
	}
}
