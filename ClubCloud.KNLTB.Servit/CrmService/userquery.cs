using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public string columnsetxml
		{
			get
			{
				return this.columnsetxmlField;
			}
			set
			{
				this.columnsetxmlField = value;
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
		public string fetchxml
		{
			get
			{
				return this.fetchxmlField;
			}
			set
			{
				this.fetchxmlField = value;
			}
		}
		public string layoutxml
		{
			get
			{
				return this.layoutxmlField;
			}
			set
			{
				this.layoutxmlField = value;
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
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
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
		public CrmNumber querytype
		{
			get
			{
				return this.querytypeField;
			}
			set
			{
				this.querytypeField = value;
			}
		}
		public string returnedtypecode
		{
			get
			{
				return this.returnedtypecodeField;
			}
			set
			{
				this.returnedtypecodeField = value;
			}
		}
		public UserQueryStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
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
		public Key userqueryid
		{
			get
			{
				return this.userqueryidField;
			}
			set
			{
				this.userqueryidField = value;
			}
		}
	}
}
