using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_pb_mutatie_toernooiuitslag_ronde : TargetCreate
	{
		private sgt_toe_pb_mutatie_toernooiuitslag_ronde sgt_toe_pb_mutatie_toernooiuitslag_rondeField;
		[XmlElement(Order = 0)]
		public sgt_toe_pb_mutatie_toernooiuitslag_ronde Sgt_toe_pb_mutatie_toernooiuitslag_ronde
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_rondeField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_rondeField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooiuitslag_ronde");
			}
		}
	}
}
