using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_speelschema_standaard : TargetCreate
	{
		private sgt_com_speelschema_standaard sgt_com_speelschema_standaardField;
		public sgt_com_speelschema_standaard Sgt_com_speelschema_standaard
		{
			get
			{
				return this.sgt_com_speelschema_standaardField;
			}
			set
			{
				this.sgt_com_speelschema_standaardField = value;
			}
		}
	}
}