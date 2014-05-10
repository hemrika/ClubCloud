using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_bo_tennisleraar_geeft_les_bij : TargetCreate
	{
		private sgt_bo_tennisleraar_geeft_les_bij sgt_bo_tennisleraar_geeft_les_bijField;
		public sgt_bo_tennisleraar_geeft_les_bij Sgt_bo_tennisleraar_geeft_les_bij
		{
			get
			{
				return this.sgt_bo_tennisleraar_geeft_les_bijField;
			}
			set
			{
				this.sgt_bo_tennisleraar_geeft_les_bijField = value;
			}
		}
	}
}
