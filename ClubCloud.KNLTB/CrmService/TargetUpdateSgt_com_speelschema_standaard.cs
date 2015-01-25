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
	public class TargetUpdateSgt_com_speelschema_standaard : TargetUpdate
	{
		private sgt_com_speelschema_standaard sgt_com_speelschema_standaardField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_speelschema_standaard Sgt_com_speelschema_standaard
		{
			get
			{
				return this.sgt_com_speelschema_standaardField;
			}
			set
			{
				this.sgt_com_speelschema_standaardField = value;
				base.RaisePropertyChanged("Sgt_com_speelschema_standaard");
			}
		}

		public TargetUpdateSgt_com_speelschema_standaard()
		{
		}
	}
}