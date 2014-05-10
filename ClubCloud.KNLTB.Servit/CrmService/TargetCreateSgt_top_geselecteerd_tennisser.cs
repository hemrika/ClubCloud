using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_top_geselecteerd_tennisser : TargetCreate
	{
		private sgt_top_geselecteerd_tennisser sgt_top_geselecteerd_tennisserField;
		public sgt_top_geselecteerd_tennisser Sgt_top_geselecteerd_tennisser
		{
			get
			{
				return this.sgt_top_geselecteerd_tennisserField;
			}
			set
			{
				this.sgt_top_geselecteerd_tennisserField = value;
			}
		}
	}
}
