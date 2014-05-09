using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_partij_uitslag : TargetUpdate
	{
		private sgt_com_partij_uitslag sgt_com_partij_uitslagField;
		[XmlElement(Order = 0)]
		public sgt_com_partij_uitslag Sgt_com_partij_uitslag
		{
			get
			{
				return this.sgt_com_partij_uitslagField;
			}
			set
			{
				this.sgt_com_partij_uitslagField = value;
				base.RaisePropertyChanged("Sgt_com_partij_uitslag");
			}
		}
	}
}
