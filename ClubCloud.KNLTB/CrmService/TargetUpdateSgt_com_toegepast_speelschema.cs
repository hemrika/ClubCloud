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
	public class TargetUpdateSgt_com_toegepast_speelschema : TargetUpdate
	{
		private sgt_com_toegepast_speelschema sgt_com_toegepast_speelschemaField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_toegepast_speelschema Sgt_com_toegepast_speelschema
		{
			get
			{
				return this.sgt_com_toegepast_speelschemaField;
			}
			set
			{
				this.sgt_com_toegepast_speelschemaField = value;
				base.RaisePropertyChanged("Sgt_com_toegepast_speelschema");
			}
		}

		public TargetUpdateSgt_com_toegepast_speelschema()
		{
		}
	}
}