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
	public class TargetCreateSgt_toe_ranglijstpunten_toernooiresultaat : TargetCreate
	{
		private sgt_toe_ranglijstpunten_toernooiresultaat sgt_toe_ranglijstpunten_toernooiresultaatField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_ranglijstpunten_toernooiresultaat Sgt_toe_ranglijstpunten_toernooiresultaat
		{
			get
			{
				return this.sgt_toe_ranglijstpunten_toernooiresultaatField;
			}
			set
			{
				this.sgt_toe_ranglijstpunten_toernooiresultaatField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijstpunten_toernooiresultaat");
			}
		}

		public TargetCreateSgt_toe_ranglijstpunten_toernooiresultaat()
		{
		}
	}
}