using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_spelersmemo : TargetUpdate
	{
		private sgt_toe_spelersmemo sgt_toe_spelersmemoField;
		public sgt_toe_spelersmemo Sgt_toe_spelersmemo
		{
			get
			{
				return this.sgt_toe_spelersmemoField;
			}
			set
			{
				this.sgt_toe_spelersmemoField = value;
			}
		}
	}
}
