using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_ploegnaam_mutatie : TargetCreate
	{
		private sgt_com_ploegnaam_mutatie sgt_com_ploegnaam_mutatieField;
		[XmlElement(Order = 0)]
		public sgt_com_ploegnaam_mutatie Sgt_com_ploegnaam_mutatie
		{
			get
			{
				return this.sgt_com_ploegnaam_mutatieField;
			}
			set
			{
				this.sgt_com_ploegnaam_mutatieField = value;
				base.RaisePropertyChanged("Sgt_com_ploegnaam_mutatie");
			}
		}
	}
}
