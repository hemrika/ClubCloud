using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SdkMessageProcessingStepRegistration
	{
		private string messageNameField;
		private string primaryEntityNameField;
		private string secondaryEntityNameField;
		private string descriptionField;
		private int stageField;
		private int modeField;
		private Guid impersonatingUserIdField;
		private int supportedDeploymentField;
		private string filteringAttributesField;
		private string pluginTypeFriendlyNameField;
		private string pluginTypeNameField;
		private string customConfigurationField;
		private int invocationSourceField;
		private SdkMessageProcessingStepImageRegistration[] imagesField;
		public string MessageName
		{
			get
			{
				return this.messageNameField;
			}
			set
			{
				this.messageNameField = value;
			}
		}
		public string PrimaryEntityName
		{
			get
			{
				return this.primaryEntityNameField;
			}
			set
			{
				this.primaryEntityNameField = value;
			}
		}
		public string SecondaryEntityName
		{
			get
			{
				return this.secondaryEntityNameField;
			}
			set
			{
				this.secondaryEntityNameField = value;
			}
		}
		public string Description
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
		public int Stage
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
		public int Mode
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
		public Guid ImpersonatingUserId
		{
			get
			{
				return this.impersonatingUserIdField;
			}
			set
			{
				this.impersonatingUserIdField = value;
			}
		}
		public int SupportedDeployment
		{
			get
			{
				return this.supportedDeploymentField;
			}
			set
			{
				this.supportedDeploymentField = value;
			}
		}
		public string FilteringAttributes
		{
			get
			{
				return this.filteringAttributesField;
			}
			set
			{
				this.filteringAttributesField = value;
			}
		}
		public string PluginTypeFriendlyName
		{
			get
			{
				return this.pluginTypeFriendlyNameField;
			}
			set
			{
				this.pluginTypeFriendlyNameField = value;
			}
		}
		public string PluginTypeName
		{
			get
			{
				return this.pluginTypeNameField;
			}
			set
			{
				this.pluginTypeNameField = value;
			}
		}
		public string CustomConfiguration
		{
			get
			{
				return this.customConfigurationField;
			}
			set
			{
				this.customConfigurationField = value;
			}
		}
		public int InvocationSource
		{
			get
			{
				return this.invocationSourceField;
			}
			set
			{
				this.invocationSourceField = value;
			}
		}
		public SdkMessageProcessingStepImageRegistration[] Images
		{
			get
			{
				return this.imagesField;
			}
			set
			{
				this.imagesField = value;
			}
		}
	}
}
