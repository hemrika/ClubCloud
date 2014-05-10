using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class calendar : BusinessEntity
	{
		private Lookup businessunitidField;
		private Key calendaridField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmBoolean issharedField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Lookup organizationidField;
		private UniqueIdentifier primaryuseridField;
		private calendarrule[] calendarrulesField;
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
		public Key calendarid
		{
			get
			{
				return this.calendaridField;
			}
			set
			{
				this.calendaridField = value;
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
		public CrmBoolean isshared
		{
			get
			{
				return this.issharedField;
			}
			set
			{
				this.issharedField = value;
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
		public Lookup organizationid
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
		public UniqueIdentifier primaryuserid
		{
			get
			{
				return this.primaryuseridField;
			}
			set
			{
				this.primaryuseridField = value;
			}
		}
		[XmlArrayItem(IsNullable = false)]
		public calendarrule[] calendarrules
		{
			get
			{
				return this.calendarrulesField;
			}
			set
			{
				this.calendarrulesField = value;
			}
		}
	}
}
