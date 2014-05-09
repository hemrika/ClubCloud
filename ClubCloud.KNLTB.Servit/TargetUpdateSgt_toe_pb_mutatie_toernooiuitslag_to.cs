using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_pb_mutatie_toernooiuitslag_to : TargetUpdate
	{
		private sgt_toe_pb_mutatie_toernooiuitslag_to sgt_toe_pb_mutatie_toernooiuitslag_toField;
		[XmlElement(Order = 0)]
		public sgt_toe_pb_mutatie_toernooiuitslag_to Sgt_toe_pb_mutatie_toernooiuitslag_to
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_toField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_toField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooiuitslag_to");
			}
		}
	}
}
