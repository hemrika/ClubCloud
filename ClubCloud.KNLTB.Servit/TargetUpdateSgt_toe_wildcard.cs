using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_wildcard : TargetUpdate
	{
		private sgt_toe_wildcard sgt_toe_wildcardField;
		[XmlElement(Order = 0)]
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
	}
}
