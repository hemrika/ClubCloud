using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
		public Key customeropportunityroleid
		{
			get
			{
				return this.customeropportunityroleidField;
			}
			set
			{
				this.customeropportunityroleidField = value;
				base.RaisePropertyChanged("customeropportunityroleid");
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
		public Lookup opportunityroleid
		{
			get
			{
				return this.opportunityroleidField;
			}
			set
			{
				this.opportunityroleidField = value;
				base.RaisePropertyChanged("opportunityroleid");
			}
		}
		[XmlElement(Order = 10)]
		public CrmNumber opportunitystatecode
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
		[XmlElement(Order = 11)]
		public CrmNumber opportunitystatuscode
		{
			get
			{
				return this.opportunitystatuscodeField;
			}
			set
			{
				this.opportunitystatuscodeField = value;
				base.RaisePropertyChanged("opportunitystatuscode");
			}
		}
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
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
	}
}
