using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_ploegsamenstelling : TargetCreate
	{
		private sgt_com_ploegsamenstelling sgt_com_ploegsamenstellingField;
		public sgt_com_ploegsamenstelling Sgt_com_ploegsamenstelling
		{
			get
			{
				return this.sgt_com_ploegsamenstellingField;
			}
			set
			{
				this.sgt_com_ploegsamenstellingField = value;
			}
		}
	}
}
