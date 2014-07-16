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
	public class TargetCreateSgt_toe_pb_mutatie_toernooiuitslag_set : TargetCreate
	{
		private sgt_toe_pb_mutatie_toernooiuitslag_set sgt_toe_pb_mutatie_toernooiuitslag_setField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_pb_mutatie_toernooiuitslag_set Sgt_toe_pb_mutatie_toernooiuitslag_set
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_setField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_setField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooiuitslag_set");
			}
		}

		public TargetCreateSgt_toe_pb_mutatie_toernooiuitslag_set()
		{
		}
	}
}