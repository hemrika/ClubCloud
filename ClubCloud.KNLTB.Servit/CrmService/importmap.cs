using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class importmap : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private Key importmapidField;
		private Picklist importmaptypeField;
		private CrmBoolean isvalidforimportField;
		private CrmBoolean iswizardcreatedField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sourceField;
		private string sourceuseridentifierforsourcecrmuserlinkField;
		private string sourceuseridentifierforsourcedatasourceuserlinkField;
		private ImportMapStateInfo statecodeField;
		private Status statuscodeField;
		private Picklist targetentityField;
		private string targetuseridentifierforsourcecrmuserlinkField;
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
		public Key importmapid
		{
			get
			{
				return this.importmapidField;
			}
			set
			{
				this.importmapidField = value;
			}
		}
		public Picklist importmaptype
		{
			get
			{
				return this.importmaptypeField;
			}
			set
			{
				this.importmaptypeField = value;
			}
		}
		public CrmBoolean isvalidforimport
		{
			get
			{
				return this.isvalidforimportField;
			}
			set
			{
				this.isvalidforimportField = value;
			}
		}
		public CrmBoolean iswizardcreated
		{
			get
			{
				return this.iswizardcreatedField;
			}
			set
			{
				this.iswizardcreatedField = value;
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
		public string source
		{
			get
			{
				return this.sourceField;
			}
			set
			{
				this.sourceField = value;
			}
		}
		public string sourceuseridentifierforsourcecrmuserlink
		{
			get
			{
				return this.sourceuseridentifierforsourcecrmuserlinkField;
			}
			set
			{
				this.sourceuseridentifierforsourcecrmuserlinkField = value;
			}
		}
		public string sourceuseridentifierforsourcedatasourceuserlink
		{
			get
			{
				return this.sourceuseridentifierforsourcedatasourceuserlinkField;
			}
			set
			{
				this.sourceuseridentifierforsourcedatasourceuserlinkField = value;
			}
		}
		public ImportMapStateInfo statecode
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
		public Picklist targetentity
		{
			get
			{
				return this.targetentityField;
			}
			set
			{
				this.targetentityField = value;
			}
		}
		public string targetuseridentifierforsourcecrmuserlink
		{
			get
			{
				return this.targetuseridentifierforsourcecrmuserlinkField;
			}
			set
			{
				this.targetuseridentifierforsourcecrmuserlinkField = value;
			}
		}
	}
}
