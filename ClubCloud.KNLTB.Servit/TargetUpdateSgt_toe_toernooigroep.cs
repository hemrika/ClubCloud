using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_toernooigroep : TargetUpdate
	{
		private sgt_toe_toernooigroep sgt_toe_toernooigroepField;
		[XmlElement(Order = 0)]
		public sgt_toe_toernooigroep Sgt_toe_toernooigroep
		{
			get
			{
				return this.sgt_toe_toernooigroepField;
			}
			set
			{
				this.sgt_toe_toernooigroepField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooigroep");
			}
		}
	}
}
