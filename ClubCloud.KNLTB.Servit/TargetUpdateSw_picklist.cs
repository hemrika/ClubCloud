using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSw_picklist : TargetUpdate
	{
		private sw_picklist sw_picklistField;
		[XmlElement(Order = 0)]
		public sw_picklist Sw_picklist
		{
			get
			{
				return this.sw_picklistField;
			}
			set
			{
				this.sw_picklistField = value;
				base.RaisePropertyChanged("Sw_picklist");
			}
		}
	}
}
