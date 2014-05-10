using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public Lookup converserelationshipid
		{
			get
			{
				return this.converserelationshipidField;
			}
			set
			{
				this.converserelationshipidField = value;
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
		public Customer customerid
		{
			get
			{
				return this.customeridField;
			}
			set
			{
				this.customeridField = value;
			}
		}
		public Key customerrelationshipid
		{
			get
			{
				return this.customerrelationshipidField;
			}
			set
			{
				this.customerrelationshipidField = value;
			}
		}
		public string customerroledescription
		{
			get
			{
				return this.customerroledescriptionField;
			}
			set
			{
				this.customerroledescriptionField = value;
			}
		}
		public Lookup customerroleid
		{
			get
			{
				return this.customerroleidField;
			}
			set
			{
				this.customerroleidField = value;
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
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
			}
		}
		public Lookup owningbusinessunit
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
		public Customer partnerid
		{
			get
			{
				return this.partneridField;
			}
			set
			{
				this.partneridField = value;
			}
		}
		public string partnerroledescription
		{
			get
			{
				return this.partnerroledescriptionField;
			}
			set
			{
				this.partnerroledescriptionField = value;
			}
		}
		public Lookup partnerroleid
		{
			get
			{
				return this.partnerroleidField;
			}
			set
			{
				this.partnerroleidField = value;
			}
		}
	}
}
