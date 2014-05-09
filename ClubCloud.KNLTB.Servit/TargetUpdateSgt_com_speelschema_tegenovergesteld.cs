using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_speelschema_tegenovergesteld : TargetUpdate
	{
		private sgt_com_speelschema_tegenovergesteld sgt_com_speelschema_tegenovergesteldField;
		[XmlElement(Order = 0)]
		public sgt_com_speelschema_tegenovergesteld Sgt_com_speelschema_tegenovergesteld
		{
			get
			{
				return this.sgt_com_speelschema_tegenovergesteldField;
			}
			set
			{
				this.sgt_com_speelschema_tegenovergesteldField = value;
				base.RaisePropertyChanged("Sgt_com_speelschema_tegenovergesteld");
			}
		}
	}
}
