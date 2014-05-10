using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class resourcegroup : BusinessEntity
	{
		private Lookup businessunitidField;
		private Picklist grouptypecodeField;
		private string nameField;
		private EntityNameReference objecttypecodeField;
		private Lookup organizationidField;
		private Key resourcegroupidField;
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
		public Picklist grouptypecode
		{
			get
			{
				return this.grouptypecodeField;
			}
			set
			{
				this.grouptypecodeField = value;
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
		public EntityNameReference objecttypecode
		{
			get
			{
				return this.objecttypecodeField;
			}
			set
			{
				this.objecttypecodeField = value;
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
		public Key resourcegroupid
		{
			get
			{
				return this.resourcegroupidField;
			}
			set
			{
				this.resourcegroupidField = value;
			}
		}
	}
}
