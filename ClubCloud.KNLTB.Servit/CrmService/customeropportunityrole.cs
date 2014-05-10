using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class customeropportunityrole : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Customer customeridField;
		private Key customeropportunityroleidField;
		private string descriptionField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup opportunityidField;
		private Lookup opportunityroleidField;
		private CrmNumber opportunitystatecodeField;
		private CrmNumber opportunitystatuscodeField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
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
		public Key customeropportunityroleid
		{
			get
			{
				return this.customeropportunityroleidField;
			}
			set
			{
				this.customeropportunityroleidField = value;
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
		public Lookup opportunityroleid
		{
			get
			{
				return this.opportunityroleidField;
			}
			set
			{
				this.opportunityroleidField = value;
			}
		}
		public CrmNumber opportunitystatecode
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
		public CrmNumber opportunitystatuscode
		{
			get
			{
				return this.opportunitystatuscodeField;
			}
			set
			{
				this.opportunitystatuscodeField = value;
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
	}
}
