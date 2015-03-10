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
	public class TargetCreateSgt_toe_afwezigheid_bondsgedelegeerde : TargetCreate
	{
		private sgt_toe_afwezigheid_bondsgedelegeerde sgt_toe_afwezigheid_bondsgedelegeerdeField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_afwezigheid_bondsgedelegeerde Sgt_toe_afwezigheid_bondsgedelegeerde
		{
			get
			{
				return this.sgt_toe_afwezigheid_bondsgedelegeerdeField;
			}
			set
			{
				this.sgt_toe_afwezigheid_bondsgedelegeerdeField = value;
				base.RaisePropertyChanged("Sgt_toe_afwezigheid_bondsgedelegeerde");
			}
		}

		public TargetCreateSgt_toe_afwezigheid_bondsgedelegeerde()
		{
		}
	}
}