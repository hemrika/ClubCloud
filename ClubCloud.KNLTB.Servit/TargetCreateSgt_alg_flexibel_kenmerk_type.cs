using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_flexibel_kenmerk_type : TargetCreate
	{
		private sgt_alg_flexibel_kenmerk_type sgt_alg_flexibel_kenmerk_typeField;
		[XmlElement(Order = 0)]
		public sgt_alg_flexibel_kenmerk_type Sgt_alg_flexibel_kenmerk_type
		{
			get
			{
				return this.sgt_alg_flexibel_kenmerk_typeField;
			}
			set
			{
				this.sgt_alg_flexibel_kenmerk_typeField = value;
				base.RaisePropertyChanged("Sgt_alg_flexibel_kenmerk_type");
			}
		}
	}
}
