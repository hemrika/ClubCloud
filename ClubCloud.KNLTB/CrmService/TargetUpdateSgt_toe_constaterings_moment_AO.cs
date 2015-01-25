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
	public class TargetUpdateSgt_toe_constaterings_moment_AO : TargetUpdate
	{
		private sgt_toe_constaterings_moment_ao sgt_toe_constaterings_moment_AOField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_constaterings_moment_ao Sgt_toe_constaterings_moment_AO
		{
			get
			{
				return this.sgt_toe_constaterings_moment_AOField;
			}
			set
			{
				this.sgt_toe_constaterings_moment_AOField = value;
				base.RaisePropertyChanged("Sgt_toe_constaterings_moment_AO");
			}
		}

		public TargetUpdateSgt_toe_constaterings_moment_AO()
		{
		}
	}
}