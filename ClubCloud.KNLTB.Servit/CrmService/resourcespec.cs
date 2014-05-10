using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class resourcespec : BusinessEntity
	{
		private Lookup businessunitidField;
		private string constraintsField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmFloat effortrequiredField;
		private UniqueIdentifier groupobjectidField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private string objectiveexpressionField;
		private EntityNameReference objecttypecodeField;
		private Lookup organizationidField;
		private CrmNumber requiredcountField;
		private Key resourcespecidField;
		private CrmBoolean samesiteField;
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
		public string constraints
		{
			get
			{
				return this.constraintsField;
			}
			set
			{
				this.constraintsField = value;
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
		public CrmFloat effortrequired
		{
			get
			{
				return this.effortrequiredField;
			}
			set
			{
				this.effortrequiredField = value;
			}
		}
		public UniqueIdentifier groupobjectid
		{
			get
			{
				return this.groupobjectidField;
			}
			set
			{
				this.groupobjectidField = value;
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
		public string objectiveexpression
		{
			get
			{
				return this.objectiveexpressionField;
			}
			set
			{
				this.objectiveexpressionField = value;
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
		public CrmNumber requiredcount
		{
			get
			{
				return this.requiredcountField;
			}
			set
			{
				this.requiredcountField = value;
			}
		}
		public Key resourcespecid
		{
			get
			{
				return this.resourcespecidField;
			}
			set
			{
				this.resourcespecidField = value;
			}
		}
		public CrmBoolean samesite
		{
			get
			{
				return this.samesiteField;
			}
			set
			{
				this.samesiteField = value;
			}
		}
	}
}
