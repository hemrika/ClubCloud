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
	public class TargetCreateSgt_toe_baansoort_toernooi : TargetCreate
	{
		private sgt_toe_baansoort_toernooi sgt_toe_baansoort_toernooiField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_baansoort_toernooi Sgt_toe_baansoort_toernooi
		{
			get
			{
				return this.sgt_toe_baansoort_toernooiField;
			}
			set
			{
				this.sgt_toe_baansoort_toernooiField = value;
				base.RaisePropertyChanged("Sgt_toe_baansoort_toernooi");
			}
		}

		public TargetCreateSgt_toe_baansoort_toernooi()
		{
		}
	}
}