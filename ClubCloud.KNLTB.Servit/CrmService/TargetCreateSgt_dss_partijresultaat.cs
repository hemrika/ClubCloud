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
	public class TargetCreateSgt_dss_partijresultaat : TargetCreate
	{
		private sgt_dss_partijresultaat sgt_dss_partijresultaatField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_dss_partijresultaat Sgt_dss_partijresultaat
		{
			get
			{
				return this.sgt_dss_partijresultaatField;
			}
			set
			{
				this.sgt_dss_partijresultaatField = value;
				base.RaisePropertyChanged("Sgt_dss_partijresultaat");
			}
		}

		public TargetCreateSgt_dss_partijresultaat()
		{
		}
	}
}