using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_pb_mutatie_toernooidefinitie : TargetUpdate
	{
		private sgt_toe_pb_mutatie_toernooidefinitie sgt_toe_pb_mutatie_toernooidefinitieField;
		[XmlElement(Order = 0)]
		public sgt_toe_pb_mutatie_toernooidefinitie Sgt_toe_pb_mutatie_toernooidefinitie
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooidefinitieField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooidefinitieField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooidefinitie");
			}
		}
	}
}
