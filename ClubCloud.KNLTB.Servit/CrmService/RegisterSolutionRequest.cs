using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RegisterSolutionRequest : Request
	{
		private BusinessEntity pluginAssemblyField;
		private SdkMessageProcessingStepRegistration[] stepsField;
		public BusinessEntity PluginAssembly
		{
			get
			{
				return this.pluginAssemblyField;
			}
			set
			{
				this.pluginAssemblyField = value;
			}
		}
		public SdkMessageProcessingStepRegistration[] Steps
		{
			get
			{
				return this.stepsField;
			}
			set
			{
				this.stepsField = value;
			}
		}
	}
}
