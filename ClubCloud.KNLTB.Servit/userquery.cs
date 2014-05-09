using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class userquery : BusinessEntity
	{
		private string columnsetxmlField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private string fetchxmlField;
		private string layoutxmlField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber querytypeField;
		private string returnedtypecodeField;
		private UserQueryStateInfo statecodeField;
		private Status statuscodeField;
		private Key userqueryidField;
		[XmlElement(Order = 0)]
		public string columnsetxml
		{
			get
			{
				return this.columnsetxmlField;
			}
			set
			{
				this.columnsetxmlField = value;
				base.RaisePropertyChanged("columnsetxml");
			}
		}
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
		public string fetchxml
		{
			get
			{
				return this.fetchxmlField;
			}
			set
			{
				this.fetchxmlField = value;
				base.RaisePropertyChanged("fetchxml");
			}
		}
		[XmlElement(Order = 5)]
		public string layoutxml
		{
			get
			{
				return this.layoutxmlField;
			}
			set
			{
				this.layoutxmlField = value;
				base.RaisePropertyChanged("layoutxml");
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
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				base.RaisePropertyChanged("name");
			}
		}
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
		public CrmNumber querytype
		{
			get
			{
				return this.querytypeField;
			}
			set
			{
				this.querytypeField = value;
				base.RaisePropertyChanged("querytype");
			}
		}
		[XmlElement(Order = 12)]
		public string returnedtypecode
		{
			get
			{
				return this.returnedtypecodeField;
			}
			set
			{
				this.returnedtypecodeField = value;
				base.RaisePropertyChanged("returnedtypecode");
			}
		}
		[XmlElement(Order = 13)]
		public UserQueryStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
		public Key userqueryid
		{
			get
			{
				return this.userqueryidField;
			}
			set
			{
				this.userqueryidField = value;
				base.RaisePropertyChanged("userqueryid");
			}
		}
	}
}
