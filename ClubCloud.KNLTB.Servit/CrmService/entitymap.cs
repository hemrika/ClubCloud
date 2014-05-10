using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class entitymap : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Key entitymapidField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private string sourceentitynameField;
		private string targetentitynameField;
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
		public Key entitymapid
		{
			get
			{
				return this.entitymapidField;
			}
			set
			{
				this.entitymapidField = value;
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
		public string sourceentityname
		{
			get
			{
				return this.sourceentitynameField;
			}
			set
			{
				this.sourceentitynameField = value;
			}
		}
		public string targetentityname
		{
			get
			{
				return this.targetentitynameField;
			}
			set
			{
				this.targetentitynameField = value;
			}
		}
	}
}
