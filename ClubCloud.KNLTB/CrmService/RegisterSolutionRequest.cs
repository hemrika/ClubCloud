using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class RegisterSolutionRequest : Request
	{
		private BusinessEntity pluginAssemblyField;

		private SdkMessageProcessingStepRegistration[] stepsField;

		[XmlElement] //[XmlElement(Order=0)]
		public BusinessEntity PluginAssembly
		{
			get
			{
				return this.pluginAssemblyField;
			}
			set
			{
				this.pluginAssemblyField = value;
				base.RaisePropertyChanged("PluginAssembly");
			}
		}

		[XmlArray] //[XmlArray(Order=1)]
		public SdkMessageProcessingStepRegistration[] Steps
		{
			get
			{
				return this.stepsField;
			}
			set
			{
				this.stepsField = value;
				base.RaisePropertyChanged("Steps");
			}
		}

		public RegisterSolutionRequest()
		{
		}
	}
}