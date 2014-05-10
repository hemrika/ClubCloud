using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class attributemap : BusinessEntity
	{
		private Key attributemapidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Lookup entitymapidField;
		private CrmBoolean issystemField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private Lookup parentattributemapidField;
		private string sourceattributenameField;
		private string targetattributenameField;
		public Key attributemapid
		{
			get
			{
				return this.attributemapidField;
			}
			set
			{
				this.attributemapidField = value;
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
		public Lookup entitymapid
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
		public CrmBoolean issystem
		{
			get
			{
				return this.issystemField;
			}
			set
			{
				this.issystemField = value;
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
		public Lookup parentattributemapid
		{
			get
			{
				return this.parentattributemapidField;
			}
			set
			{
				this.parentattributemapidField = value;
			}
		}
		public string sourceattributename
		{
			get
			{
				return this.sourceattributenameField;
			}
			set
			{
				this.sourceattributenameField = value;
			}
		}
		public string targetattributename
		{
			get
			{
				return this.targetattributenameField;
			}
			set
			{
				this.targetattributenameField = value;
			}
		}
	}
}
