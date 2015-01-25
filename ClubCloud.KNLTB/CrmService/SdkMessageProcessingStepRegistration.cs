using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class SdkMessageProcessingStepRegistration : INotifyPropertyChanged
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

		[XmlElement] //[XmlElement(Order=11)]
		public string CustomConfiguration
		{
			get
			{
				return this.customConfigurationField;
			}
			set
			{
				this.customConfigurationField = value;
				this.RaisePropertyChanged("CustomConfiguration");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public string FilteringAttributes
		{
			get
			{
				return this.filteringAttributesField;
			}
			set
			{
				this.filteringAttributesField = value;
				this.RaisePropertyChanged("FilteringAttributes");
			}
		}

		[XmlArray] //[XmlArray(Order=13)]
		public SdkMessageProcessingStepImageRegistration[] Images
		{
			get
			{
				return this.imagesField;
			}
			set
			{
				this.imagesField = value;
				this.RaisePropertyChanged("Images");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public Guid ImpersonatingUserId
		{
			get
			{
				return this.impersonatingUserIdField;
			}
			set
			{
				this.impersonatingUserIdField = value;
				this.RaisePropertyChanged("ImpersonatingUserId");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public int InvocationSource
		{
			get
			{
				return this.invocationSourceField;
			}
			set
			{
				this.invocationSourceField = value;
				this.RaisePropertyChanged("InvocationSource");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public string MessageName
		{
			get
			{
				return this.messageNameField;
			}
			set
			{
				this.messageNameField = value;
				this.RaisePropertyChanged("MessageName");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public int Mode
		{
			get
			{
				return this.modeField;
			}
			set
			{
				this.modeField = value;
				this.RaisePropertyChanged("Mode");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string PluginTypeFriendlyName
		{
			get
			{
				return this.pluginTypeFriendlyNameField;
			}
			set
			{
				this.pluginTypeFriendlyNameField = value;
				this.RaisePropertyChanged("PluginTypeFriendlyName");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string PluginTypeName
		{
			get
			{
				return this.pluginTypeNameField;
			}
			set
			{
				this.pluginTypeNameField = value;
				this.RaisePropertyChanged("PluginTypeName");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string PrimaryEntityName
		{
			get
			{
				return this.primaryEntityNameField;
			}
			set
			{
				this.primaryEntityNameField = value;
				this.RaisePropertyChanged("PrimaryEntityName");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string SecondaryEntityName
		{
			get
			{
				return this.secondaryEntityNameField;
			}
			set
			{
				this.secondaryEntityNameField = value;
				this.RaisePropertyChanged("SecondaryEntityName");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public int Stage
		{
			get
			{
				return this.stageField;
			}
			set
			{
				this.stageField = value;
				this.RaisePropertyChanged("Stage");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public int SupportedDeployment
		{
			get
			{
				return this.supportedDeploymentField;
			}
			set
			{
				this.supportedDeploymentField = value;
				this.RaisePropertyChanged("SupportedDeployment");
			}
		}

		public SdkMessageProcessingStepRegistration()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}