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

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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
		public Key discountid
		{
			get
			{
				return this.discountidField;
			}
			set
			{
				this.discountidField = value;
				base.RaisePropertyChanged("discountid");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
		public CrmDecimal highquantity
		{
			get
			{
				return this.highquantityField;
			}
			set
			{
				this.highquantityField = value;
				base.RaisePropertyChanged("highquantity");
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
		public CrmBoolean isamounttype
		{
			get
			{
				return this.isamounttypeField;
			}
			set
			{
				this.isamounttypeField = value;
				base.RaisePropertyChanged("isamounttype");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmDecimal lowquantity
		{
			get
			{
				return this.lowquantityField;
			}
			set
			{
				this.lowquantityField = value;
				base.RaisePropertyChanged("lowquantity");
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		public discount()
		{
		}
	}
}