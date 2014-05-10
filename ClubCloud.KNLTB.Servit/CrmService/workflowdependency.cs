using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class workflowdependency : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string customentitynameField;
		private string dependentattributenameField;
		private string dependententitynameField;
		private string entityattributesField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private UniqueIdentifier owningbusinessunitField;
		private UniqueIdentifier owninguserField;
		private string parameternameField;
		private string parametertypeField;
		private string relatedattributenameField;
		private string relatedentitynameField;
		private Lookup sdkmessageidField;
		private Picklist typeField;
		private Key workflowdependencyidField;
		private Lookup workflowidField;
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
		public string customentityname
		{
			get
			{
				return this.customentitynameField;
			}
			set
			{
				this.customentitynameField = value;
			}
		}
		public string dependentattributename
		{
			get
			{
				return this.dependentattributenameField;
			}
			set
			{
				this.dependentattributenameField = value;
			}
		}
		public string dependententityname
		{
			get
			{
				return this.dependententitynameField;
			}
			set
			{
				this.dependententitynameField = value;
			}
		}
		public string entityattributes
		{
			get
			{
				return this.entityattributesField;
			}
			set
			{
				this.entityattributesField = value;
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
		public UniqueIdentifier owningbusinessunit
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
		public UniqueIdentifier owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
			}
		}
		public string parametername
		{
			get
			{
				return this.parameternameField;
			}
			set
			{
				this.parameternameField = value;
			}
		}
		public string parametertype
		{
			get
			{
				return this.parametertypeField;
			}
			set
			{
				this.parametertypeField = value;
			}
		}
		public string relatedattributename
		{
			get
			{
				return this.relatedattributenameField;
			}
			set
			{
				this.relatedattributenameField = value;
			}
		}
		public string relatedentityname
		{
			get
			{
				return this.relatedentitynameField;
			}
			set
			{
				this.relatedentitynameField = value;
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
		public Picklist type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
		public Key workflowdependencyid
		{
			get
			{
				return this.workflowdependencyidField;
			}
			set
			{
				this.workflowdependencyidField = value;
			}
		}
		public Lookup workflowid
		{
			get
			{
				return this.workflowidField;
			}
			set
			{
				this.workflowidField = value;
			}
		}
	}
}
