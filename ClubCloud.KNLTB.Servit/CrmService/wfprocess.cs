using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class wfprocess : BusinessEntity
	{
		private Lookup businessunitidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private string entitytypeField;
		private Picklist eventtypecodeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private CrmNumber priorityField;
		private Picklist processcodeField;
		private Key processidField;
		private Picklist processtypecodeField;
		private CrmNumber processtypeversionField;
		private WFProcessStateInfo statecodeField;
		private Lookup usercontextField;
		public Lookup businessunitid
		{
			get
			{
				return this.businessunitidField;
			}
			set
			{
				this.businessunitidField = value;
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
		public string entitytype
		{
			get
			{
				return this.entitytypeField;
			}
			set
			{
				this.entitytypeField = value;
			}
		}
		public Picklist eventtypecode
		{
			get
			{
				return this.eventtypecodeField;
			}
			set
			{
				this.eventtypecodeField = value;
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
		public CrmNumber priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
			}
		}
		public Picklist processcode
		{
			get
			{
				return this.processcodeField;
			}
			set
			{
				this.processcodeField = value;
			}
		}
		public Key processid
		{
			get
			{
				return this.processidField;
			}
			set
			{
				this.processidField = value;
			}
		}
		public Picklist processtypecode
		{
			get
			{
				return this.processtypecodeField;
			}
			set
			{
				this.processtypecodeField = value;
			}
		}
		public CrmNumber processtypeversion
		{
			get
			{
				return this.processtypeversionField;
			}
			set
			{
				this.processtypeversionField = value;
			}
		}
		public WFProcessStateInfo statecode
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
		public Lookup usercontext
		{
			get
			{
				return this.usercontextField;
			}
			set
			{
				this.usercontextField = value;
			}
		}
	}
}
