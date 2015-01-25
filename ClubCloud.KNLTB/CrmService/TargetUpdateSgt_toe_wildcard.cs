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
	public class TargetUpdateSgt_toe_wildcard : TargetUpdate
	{
		private sgt_toe_wildcard sgt_toe_wildcardField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_wildcard Sgt_toe_wildcard
		{
			get
			{
				return this.sgt_toe_wildcardField;
			}
			set
			{
				this.sgt_toe_wildcardField = value;
				base.RaisePropertyChanged("Sgt_toe_wildcard");
			}
		}

		public TargetUpdateSgt_toe_wildcard()
		{
		}
	}
}