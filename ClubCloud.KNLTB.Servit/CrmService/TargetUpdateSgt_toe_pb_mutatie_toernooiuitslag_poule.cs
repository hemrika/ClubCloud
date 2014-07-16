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
	public class TargetUpdateSgt_toe_pb_mutatie_toernooiuitslag_poule : TargetUpdate
	{
		private sgt_toe_pb_mutatie_toernooiuitslag_poule sgt_toe_pb_mutatie_toernooiuitslag_pouleField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_pb_mutatie_toernooiuitslag_poule Sgt_toe_pb_mutatie_toernooiuitslag_poule
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_pouleField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_pouleField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooiuitslag_poule");
			}
		}

		public TargetUpdateSgt_toe_pb_mutatie_toernooiuitslag_poule()
		{
		}
	}
}