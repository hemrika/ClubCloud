using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_bo_voorkeur_testdag : TargetCreate
	{
		private sgt_bo_voorkeur_testdag sgt_bo_voorkeur_testdagField;
		public sgt_bo_voorkeur_testdag Sgt_bo_voorkeur_testdag
		{
			get
			{
				return this.sgt_bo_voorkeur_testdagField;
			}
			set
			{
				this.sgt_bo_voorkeur_testdagField = value;
			}
		}
	}
}
