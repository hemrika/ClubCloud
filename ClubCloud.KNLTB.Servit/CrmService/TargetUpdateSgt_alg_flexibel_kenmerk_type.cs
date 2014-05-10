using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_flexibel_kenmerk_type : TargetUpdate
	{
		private sgt_alg_flexibel_kenmerk_type sgt_alg_flexibel_kenmerk_typeField;
		public sgt_alg_flexibel_kenmerk_type Sgt_alg_flexibel_kenmerk_type
		{
			get
			{
				return this.sgt_alg_flexibel_kenmerk_typeField;
			}
			set
			{
				this.sgt_alg_flexibel_kenmerk_typeField = value;
			}
		}
	}
}
