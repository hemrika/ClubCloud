using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_top_groepsevenement : TargetUpdate
	{
		private sgt_top_groepsevenement sgt_top_groepsevenementField;
		[XmlElement(Order = 0)]
		public sgt_top_groepsevenement Sgt_top_groepsevenement
		{
			get
			{
				return this.sgt_top_groepsevenementField;
			}
			set
			{
				this.sgt_top_groepsevenementField = value;
				base.RaisePropertyChanged("Sgt_top_groepsevenement");
			}
		}
	}
}
