using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_periodiek_proces : TargetCreate
	{
		private sgt_alg_periodiek_proces sgt_alg_periodiek_procesField;
		[XmlElement(Order = 0)]
		public sgt_alg_periodiek_proces Sgt_alg_periodiek_proces
		{
			get
			{
				return this.sgt_alg_periodiek_procesField;
			}
			set
			{
				this.sgt_alg_periodiek_procesField = value;
				base.RaisePropertyChanged("Sgt_alg_periodiek_proces");
			}
		}
	}
}
