using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sdkmessageprocessingstep : BusinessEntity
	{
		private string configurationField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber customizationlevelField;
		private string descriptionField;
		private string filteringattributesField;
		private Lookup impersonatinguseridField;
		private Picklist invocationsourceField;
		private Picklist modeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private Lookup plugintypeidField;
		private CrmNumber rankField;
		private Lookup sdkmessagefilteridField;
		private Lookup sdkmessageidField;
		private Key sdkmessageprocessingstepidField;
		private UniqueIdentifier sdkmessageprocessingstepiduniqueField;
		private Lookup sdkmessageprocessingstepsecureconfigidField;
		private Picklist stageField;
		private SdkMessageProcessingStepStateInfo statecodeField;
		private Status statuscodeField;
		private Picklist supporteddeploymentField;
		public string configuration
		{
			get
			{
				return this.configurationField;
			}
			set
			{
				this.configurationField = value;
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
		public string filteringattributes
		{
			get
			{
				return this.filteringattributesField;
			}
			set
			{
				this.filteringattributesField = value;
			}
		}
		public Lookup impersonatinguserid
		{
			get
			{
				return this.impersonatinguseridField;
			}
			set
			{
				this.impersonatinguseridField = value;
			}
		}
		public Picklist invocationsource
		{
			get
			{
				return this.invocationsourceField;
			}
			set
			{
				this.invocationsourceField = value;
			}
		}
		public Picklist mode
		{
			get
			{
				return this.modeField;
			}
			set
			{
				this.modeField = value;
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
		public Lookup plugintypeid
		{
			get
			{
				return this.plugintypeidField;
			}
			set
			{
				this.plugintypeidField = value;
			}
		}
		public CrmNumber rank
		{
			get
			{
				return this.rankField;
			}
			set
			{
				this.rankField = value;
			}
		}
		public Lookup sdkmessagefilterid
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
		public Key sdkmessageprocessingstepid
		{
			get
			{
				return this.sdkmessageprocessingstepidField;
			}
			set
			{
				this.sdkmessageprocessingstepidField = value;
			}
		}
		public UniqueIdentifier sdkmessageprocessingstepidunique
		{
			get
			{
				return this.sdkmessageprocessingstepiduniqueField;
			}
			set
			{
				this.sdkmessageprocessingstepiduniqueField = value;
			}
		}
		public Lookup sdkmessageprocessingstepsecureconfigid
		{
			get
			{
				return this.sdkmessageprocessingstepsecureconfigidField;
			}
			set
			{
				this.sdkmessageprocessingstepsecureconfigidField = value;
			}
		}
		public Picklist stage
		{
			get
			{
				return this.stageField;
			}
			set
			{
				this.stageField = value;
			}
		}
		public SdkMessageProcessingStepStateInfo statecode
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
		public Picklist supporteddeployment
		{
			get
			{
				return this.supporteddeploymentField;
			}
			set
			{
				this.supporteddeploymentField = value;
			}
		}
	}
}
