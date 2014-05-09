using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 0)]
		public string configuration
		{
			get
			{
				return this.configurationField;
			}
			set
			{
				this.configurationField = value;
				base.RaisePropertyChanged("configuration");
			}
		}
		[XmlElement(Order = 1)]
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
				base.RaisePropertyChanged("createdby");
			}
		}
		[XmlElement(Order = 2)]
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
				base.RaisePropertyChanged("createdon");
			}
		}
		[XmlElement(Order = 3)]
		public CrmNumber customizationlevel
		{
			get
			{
				return this.customizationlevelField;
			}
			set
			{
				this.customizationlevelField = value;
				base.RaisePropertyChanged("customizationlevel");
			}
		}
		[XmlElement(Order = 4)]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				base.RaisePropertyChanged("description");
			}
		}
		[XmlElement(Order = 5)]
		public string filteringattributes
		{
			get
			{
				return this.filteringattributesField;
			}
			set
			{
				this.filteringattributesField = value;
				base.RaisePropertyChanged("filteringattributes");
			}
		}
		[XmlElement(Order = 6)]
		public Lookup impersonatinguserid
		{
			get
			{
				return this.impersonatinguseridField;
			}
			set
			{
				this.impersonatinguseridField = value;
				base.RaisePropertyChanged("impersonatinguserid");
			}
		}
		[XmlElement(Order = 7)]
		public Picklist invocationsource
		{
			get
			{
				return this.invocationsourceField;
			}
			set
			{
				this.invocationsourceField = value;
				base.RaisePropertyChanged("invocationsource");
			}
		}
		[XmlElement(Order = 8)]
		public Picklist mode
		{
			get
			{
				return this.modeField;
			}
			set
			{
				this.modeField = value;
				base.RaisePropertyChanged("mode");
			}
		}
		[XmlElement(Order = 9)]
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
				base.RaisePropertyChanged("modifiedby");
			}
		}
		[XmlElement(Order = 10)]
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
				base.RaisePropertyChanged("modifiedon");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup plugintypeid
		{
			get
			{
				return this.plugintypeidField;
			}
			set
			{
				this.plugintypeidField = value;
				base.RaisePropertyChanged("plugintypeid");
			}
		}
		[XmlElement(Order = 13)]
		public CrmNumber rank
		{
			get
			{
				return this.rankField;
			}
			set
			{
				this.rankField = value;
				base.RaisePropertyChanged("rank");
			}
		}
		[XmlElement(Order = 14)]
		public Lookup sdkmessagefilterid
		{
			get
			{
				return this.sdkmessagefilteridField;
			}
			set
			{
				this.sdkmessagefilteridField = value;
				base.RaisePropertyChanged("sdkmessagefilterid");
			}
		}
		[XmlElement(Order = 15)]
		public Lookup sdkmessageid
		{
			get
			{
				return this.sdkmessageidField;
			}
			set
			{
				this.sdkmessageidField = value;
				base.RaisePropertyChanged("sdkmessageid");
			}
		}
		[XmlElement(Order = 16)]
		public Key sdkmessageprocessingstepid
		{
			get
			{
				return this.sdkmessageprocessingstepidField;
			}
			set
			{
				this.sdkmessageprocessingstepidField = value;
				base.RaisePropertyChanged("sdkmessageprocessingstepid");
			}
		}
		[XmlElement(Order = 17)]
		public UniqueIdentifier sdkmessageprocessingstepidunique
		{
			get
			{
				return this.sdkmessageprocessingstepiduniqueField;
			}
			set
			{
				this.sdkmessageprocessingstepiduniqueField = value;
				base.RaisePropertyChanged("sdkmessageprocessingstepidunique");
			}
		}
		[XmlElement(Order = 18)]
		public Lookup sdkmessageprocessingstepsecureconfigid
		{
			get
			{
				return this.sdkmessageprocessingstepsecureconfigidField;
			}
			set
			{
				this.sdkmessageprocessingstepsecureconfigidField = value;
				base.RaisePropertyChanged("sdkmessageprocessingstepsecureconfigid");
			}
		}
		[XmlElement(Order = 19)]
		public Picklist stage
		{
			get
			{
				return this.stageField;
			}
			set
			{
				this.stageField = value;
				base.RaisePropertyChanged("stage");
			}
		}
		[XmlElement(Order = 20)]
		public SdkMessageProcessingStepStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}
		[XmlElement(Order = 21)]
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
				base.RaisePropertyChanged("statuscode");
			}
		}
		[XmlElement(Order = 22)]
		public Picklist supporteddeployment
		{
			get
			{
				return this.supporteddeploymentField;
			}
			set
			{
				this.supporteddeploymentField = value;
				base.RaisePropertyChanged("supporteddeployment");
			}
		}
	}
}
