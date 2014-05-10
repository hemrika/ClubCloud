using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class timezonelocalizedname : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber cultureidField;
		private string daylightnameField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private string standardnameField;
		private Lookup timezonedefinitionidField;
		private Key timezonelocalizednameidField;
		private string userinterfacenameField;
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
		public CrmNumber cultureid
		{
			get
			{
				return this.cultureidField;
			}
			set
			{
				this.cultureidField = value;
			}
		}
		public string daylightname
		{
			get
			{
				return this.daylightnameField;
			}
			set
			{
				this.daylightnameField = value;
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
		public string standardname
		{
			get
			{
				return this.standardnameField;
			}
			set
			{
				this.standardnameField = value;
			}
		}
		public Lookup timezonedefinitionid
		{
			get
			{
				return this.timezonedefinitionidField;
			}
			set
			{
				this.timezonedefinitionidField = value;
			}
		}
		public Key timezonelocalizednameid
		{
			get
			{
				return this.timezonelocalizednameidField;
			}
			set
			{
				this.timezonelocalizednameidField = value;
			}
		}
		public string userinterfacename
		{
			get
			{
				return this.userinterfacenameField;
			}
			set
			{
				this.userinterfacenameField = value;
			}
		}
	}
}
