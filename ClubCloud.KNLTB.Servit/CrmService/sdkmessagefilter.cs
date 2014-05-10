using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sdkmessagefilter : BusinessEntity
	{
		private CrmNumber availabilityField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber customizationlevelField;
		private CrmBoolean iscustomprocessingstepallowedField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private EntityNameReference primaryobjecttypecodeField;
		private Key sdkmessagefilteridField;
		private UniqueIdentifier sdkmessagefilteriduniqueField;
		private Lookup sdkmessageidField;
		private EntityNameReference secondaryobjecttypecodeField;
		public CrmNumber availability
		{
			get
			{
				return this.availabilityField;
			}
			set
			{
				this.availabilityField = value;
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
		public CrmNumber customizationlevel
		{
			get
			{
				return this.customizationlevelField;
			}
			set
			{
				this.customizationlevelField = value;
			}
		}
		public CrmBoolean iscustomprocessingstepallowed
		{
			get
			{
				return this.iscustomprocessingstepallowedField;
			}
			set
			{
				this.iscustomprocessingstepallowedField = value;
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
		public Key sdkmessagefilterid
		{
			get
			{
				return this.sdkmessagefilteridField;
			}
			set
			{
				this.sdkmessagefilteridField = value;
			}
		}
		public UniqueIdentifier sdkmessagefilteridunique
		{
			get
			{
				return this.sdkmessagefilteriduniqueField;
			}
			set
			{
				this.sdkmessagefilteriduniqueField = value;
			}
		}
		public Lookup sdkmessageid
		{
			get
			{
				return this.sdkmessageidField;
			}
			set
			{
				this.sdkmessageidField = value;
			}
		}
		public EntityNameReference secondaryobjecttypecode
		{
			get
			{
				return this.secondaryobjecttypecodeField;
			}
			set
			{
				this.secondaryobjecttypecodeField = value;
			}
		}
	}
}
