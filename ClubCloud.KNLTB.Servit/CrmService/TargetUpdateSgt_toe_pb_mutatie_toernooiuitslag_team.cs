using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_pb_mutatie_toernooiuitslag_team : TargetUpdate
	{
		private sgt_toe_pb_mutatie_toernooiuitslag_team sgt_toe_pb_mutatie_toernooiuitslag_teamField;
		public sgt_toe_pb_mutatie_toernooiuitslag_team Sgt_toe_pb_mutatie_toernooiuitslag_team
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_teamField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_teamField = value;
			}
		}
	}
}
