using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_thuis_thuis_schema : TargetUpdate
	{
		private sgt_com_thuis_thuis_schema sgt_com_thuis_thuis_schemaField;
		[XmlElement(Order = 0)]
		public sgt_com_thuis_thuis_schema Sgt_com_thuis_thuis_schema
		{
			get
			{
				return this.sgt_com_thuis_thuis_schemaField;
			}
			set
			{
				this.sgt_com_thuis_thuis_schemaField = value;
				base.RaisePropertyChanged("Sgt_com_thuis_thuis_schema");
			}
		}
	}
}
