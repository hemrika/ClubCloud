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
	public class TargetCreateSgt_alg_virtueelteam : TargetCreate
	{
		private sgt_alg_virtueelteam sgt_alg_virtueelteamField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_virtueelteam Sgt_alg_virtueelteam
		{
			get
			{
				return this.sgt_alg_virtueelteamField;
			}
			set
			{
				this.sgt_alg_virtueelteamField = value;
				base.RaisePropertyChanged("Sgt_alg_virtueelteam");
			}
		}

		public TargetCreateSgt_alg_virtueelteam()
		{
		}
	}
}