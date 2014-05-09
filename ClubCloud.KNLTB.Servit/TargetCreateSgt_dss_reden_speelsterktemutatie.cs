using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_dss_reden_speelsterktemutatie : TargetCreate
	{
		private sgt_dss_reden_speelsterktemutatie sgt_dss_reden_speelsterktemutatieField;
		[XmlElement(Order = 0)]
		public sgt_dss_reden_speelsterktemutatie Sgt_dss_reden_speelsterktemutatie
		{
			get
			{
				return this.sgt_dss_reden_speelsterktemutatieField;
			}
			set
			{
				this.sgt_dss_reden_speelsterktemutatieField = value;
				base.RaisePropertyChanged("Sgt_dss_reden_speelsterktemutatie");
			}
		}
	}
}
