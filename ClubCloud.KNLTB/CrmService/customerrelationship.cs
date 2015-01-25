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
	public class customerrelationship : BusinessEntity
	{
		private Lookup converserelationshipidField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private Customer customeridField;

		private Key customerrelationshipidField;

		private string customerroledescriptionField;

		private Lookup customerroleidField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Customer partneridField;

		private string partnerroledescriptionField;

		private Lookup partnerroleidField;

		[XmlElement] //[XmlElement(Order=0)]
		public Lookup converserelationshipid
		{
			get
			{
				return this.converserelationshipidField;
			}
			set
			{
				this.converserelationshipidField = value;
				base.RaisePropertyChanged("converserelationshipid");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
		public Customer customerid
		{
			get
			{
				return this.customeridField;
			}
			set
			{
				this.customeridField = value;
				base.RaisePropertyChanged("customerid");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public Key customerrelationshipid
		{
			get
			{
				return this.customerrelationshipidField;
			}
			set
			{
				this.customerrelationshipidField = value;
				base.RaisePropertyChanged("customerrelationshipid");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public string customerroledescription
		{
			get
			{
				return this.customerroledescriptionField;
			}
			set
			{
				this.customerroledescriptionField = value;
				base.RaisePropertyChanged("customerroledescription");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public Lookup customerroleid
		{
			get
			{
				return this.customerroleidField;
			}
			set
			{
				this.customerroleidField = value;
				base.RaisePropertyChanged("customerroleid");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
				base.RaisePropertyChanged("ownerid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup owningbusinessunit
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

		[XmlElement] //[XmlElement(Order=13)]
		public Customer partnerid
		{
			get
			{
				return this.partneridField;
			}
			set
			{
				this.partneridField = value;
				base.RaisePropertyChanged("partnerid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string partnerroledescription
		{
			get
			{
				return this.partnerroledescriptionField;
			}
			set
			{
				this.partnerroledescriptionField = value;
				base.RaisePropertyChanged("partnerroledescription");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup partnerroleid
		{
			get
			{
				return this.partnerroleidField;
			}
			set
			{
				this.partnerroleidField = value;
				base.RaisePropertyChanged("partnerroleid");
			}
		}

		public customerrelationship()
		{
		}
	}
}