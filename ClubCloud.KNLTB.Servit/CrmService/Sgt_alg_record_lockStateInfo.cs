using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class Sgt_alg_record_lockStateInfo
	{
		private string formattedvalueField;
		private Sgt_alg_record_lockState valueField;
		[XmlAttribute]
		public string formattedvalue
		{
			get
			{
				return this.formattedvalueField;
			}
			set
			{
				this.formattedvalueField = value;
			}
		}
		[XmlText]
		public Sgt_alg_record_lockState Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}
}
