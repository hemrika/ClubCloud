using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_bo_opleidingsgroep : TargetCreate
	{
		private sgt_bo_opleidingsgroep sgt_bo_opleidingsgroepField;
		[XmlElement(Order = 0)]
		public sgt_bo_opleidingsgroep Sgt_bo_opleidingsgroep
		{
			get
			{
				return this.sgt_bo_opleidingsgroepField;
			}
			set
			{
				this.sgt_bo_opleidingsgroepField = value;
				base.RaisePropertyChanged("Sgt_bo_opleidingsgroep");
			}
		}
	}
}
