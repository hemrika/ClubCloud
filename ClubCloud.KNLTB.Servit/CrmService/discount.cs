using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class discount : BusinessEntity
	{
		private CrmMoney amountField;
		private CrmMoney amount_baseField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Key discountidField;
		private Lookup discounttypeidField;
		private CrmDecimal exchangerateField;
		private CrmDecimal highquantityField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean isamounttypeField;
		private CrmDecimal lowquantityField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private UniqueIdentifier organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmDecimal percentageField;
		private Status statuscodeField;
		private Lookup transactioncurrencyidField;
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
		public Key discountid
		{
			get
			{
				return this.discountidField;
			}
			set
			{
				this.discountidField = value;
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
		public CrmDecimal highquantity
		{
			get
			{
				return this.highquantityField;
			}
			set
			{
				this.highquantityField = value;
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
		public CrmBoolean isamounttype
		{
			get
			{
				return this.isamounttypeField;
			}
			set
			{
				this.isamounttypeField = value;
			}
		}
		public CrmDecimal lowquantity
		{
			get
			{
				return this.lowquantityField;
			}
			set
			{
				this.lowquantityField = value;
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
	}
}
