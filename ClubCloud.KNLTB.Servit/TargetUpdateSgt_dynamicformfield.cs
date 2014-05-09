using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_dynamicformfield : TargetUpdate
	{
		private sgt_dynamicformfield sgt_dynamicformfieldField;
		[XmlElement(Order = 0)]
		public sgt_dynamicformfield Sgt_dynamicformfield
		{
			get
			{
				return this.sgt_dynamicformfieldField;
			}
			set
			{
				this.sgt_dynamicformfieldField = value;
				base.RaisePropertyChanged("Sgt_dynamicformfield");
			}
		}
	}
}
