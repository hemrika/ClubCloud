using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class Sgt_toe_basisschema_rondeStateInfo
	{
		private string formattedvalueField;
		private Sgt_toe_basisschema_rondeState valueField;
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
		public Sgt_toe_basisschema_rondeState Value
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
