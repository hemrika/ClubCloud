using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class relationshiprolemap : BusinessEntity
	{
		private EntityNameReference associateobjecttypecodeField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private UniqueIdentifier organizationidField;
		private EntityNameReference primaryobjecttypecodeField;
		private Lookup relationshiproleidField;
		private Key relationshiprolemapidField;
		public EntityNameReference associateobjecttypecode
		{
			get
			{
				return this.associateobjecttypecodeField;
			}
			set
			{
				this.associateobjecttypecodeField = value;
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
		public UniqueIdentifier organizationid
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
		public EntityNameReference primaryobjecttypecode
		{
			get
			{
				return this.primaryobjecttypecodeField;
			}
			set
			{
				this.primaryobjecttypecodeField = value;
			}
		}
		public Lookup relationshiproleid
		{
			get
			{
				return this.relationshiproleidField;
			}
			set
			{
				this.relationshiproleidField = value;
			}
		}
		public Key relationshiprolemapid
		{
			get
			{
				return this.relationshiprolemapidField;
			}
			set
			{
				this.relationshiprolemapidField = value;
			}
		}
	}
}
